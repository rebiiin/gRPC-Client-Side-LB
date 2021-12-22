using GrpcClientFeedReaderFileResolver.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Grpc.Net.Client;
using Grpc.Core;


namespace GrpcClientFeedReaderFileResolver.Controllers
{
    public class HomeController : Controller
    {
         
        private readonly ILogger<HomeController> _logger;
        private readonly GrpcChannel _grpcChannel;
        private List<FeedViewModel>? _feedViewModel;
        public HomeController(ILogger<HomeController> logger, GrpcChannel grpcChannel)
        {
            _logger = logger;
            _grpcChannel = grpcChannel;

        }

        public async Task<IActionResult> Index()
        {

            var client = new FeedService.FeedServiceClient(_grpcChannel);

            try
            {
                var replay = client.GetFeedAsync(new Google.Protobuf.WellKnownTypes.Empty());


                var responseHeaders = await replay.ResponseHeadersAsync;

                ViewData["hostAdress"] = responseHeaders.GetValue("host");

                var responseFeed = await replay;


                _feedViewModel = new List<FeedViewModel>();

                foreach (var item in responseFeed.FeedItems)
                {


                    _feedViewModel.Add(new FeedViewModel
                    {

                        title = item.Title,
                        Summary = item.Summary,
                        publishDate = DateTime.Parse(item.PublishDate),
                        Link = item.Link

                    });
                }
            }

            catch (RpcException rpcex)
            {

                _logger.LogWarning(rpcex.StatusCode.ToString());
                _logger.LogError(rpcex.Message);
            }



            return View(_feedViewModel);
        }



         



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}