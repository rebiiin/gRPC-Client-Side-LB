using Grpc.Net.Client.Balancer;
using System.Net;
using System.Xml;
using System.Xml.Serialization;

namespace GrpcClientFeedReaderFileResolver
{



    [XmlRoot(ElementName = "element")]
    public class Element
    {

        [XmlElement(ElementName = "HostName")]

        public string HostName { get; set; }

        [XmlElement(ElementName = "Port")]
        public int Port { get; set; }
    }

    [XmlRoot(ElementName = "root")]
    public class Root
    {

        [XmlElement(ElementName = "element")]
        public List<Element>? Element { get; set; }
    }





public class xmlFileResolver : Resolver
{


    private readonly Uri _uriAddress;

    private Action<ResolverResult>? _listener;


    public xmlFileResolver(Uri uriAddress)
    {
        _uriAddress = uriAddress;
    }



    public override async Task RefreshAsync(CancellationToken cancellationToken)
    {


    await Task.Run(async () =>
    {

        using (var reader = new StreamReader(_uriAddress.LocalPath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Root));

            var resultsDeserialize = (Root)serializer.Deserialize(reader);

            IReadOnlyList<DnsEndPoint> listAddresses = resultsDeserialize.Element.Select(r => new DnsEndPoint(r.HostName, r.Port)).ToList();

            _listener(ResolverResult.ForResult(listAddresses, serviceConfig: null));


        }


    });

    }


    public override void Start(Action<ResolverResult> listener)
    {
        _listener = listener;
    }
}

   public class customFileResolver : ResolverFactory
{

    public override string Name => "file";

    public override Resolver Create(ResolverOptions options)
    {
        return new xmlFileResolver(options.Address);
    }
}
}
