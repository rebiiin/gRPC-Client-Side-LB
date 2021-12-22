

namespace GrpcServiceFeedReader1.Services
{
    public class MainFeedService : FeedService.FeedServiceBase
    {
        private string feedUrl = "https://devblogs.microsoft.com/dotnet/feed/";
        private readonly ILogger<MainFeedService> _logger;
         
        public MainFeedService(ILogger<MainFeedService> logger)
        {
            _logger = logger;
        }


        public override async Task<FeedResponce> GetFeed(Empty request, ServerCallContext context)
        {

            var httpContext = context.GetHttpContext();

            await context.WriteResponseHeadersAsync(new Metadata{{ "host", $"{httpContext.Request.Scheme}://{httpContext.Request.Host}" }});



            FeedResponce listFeedResponce = new();

            using XmlReader reader = XmlReader.Create(feedUrl, new XmlReaderSettings { Async = true });

            SyndicationFeed feed = SyndicationFeed.Load(reader);

            reader.Close();

            var query = from feedItem in feed.Items.OrderByDescending(x => x.PublishDate)

                        select new FeedModel
                        {

                            Title = feedItem.Title.Text,
                            Summary = feedItem.Summary.Text,
                            Link = feedItem.Links[0].Uri.ToString(),
                            PublishDate = feedItem.PublishDate.ToString()


                        };

            listFeedResponce.FeedItems.AddRange(query.ToList());


            return await Task.FromResult(listFeedResponce);
        }

         

    }
}
