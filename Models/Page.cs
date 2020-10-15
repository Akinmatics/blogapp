using System.ComponentModel.DataAnnotations;

namespace mywebsite.Models
{
    public class Page
    {
        [Key]
        public string Title { get; set; }
        public string Content { get; set; }
    }
}