using System.ComponentModel.DataAnnotations;

namespace gRPCClientK8s.Models
{
    public class FeedViewModel
    {
        public string? title { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime publishDate { get; set; }
        public string? Summary { get; set; }
        public string? Link { get; set; }
    }

    
    
}
