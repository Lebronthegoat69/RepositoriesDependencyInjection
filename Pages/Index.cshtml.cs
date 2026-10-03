using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MicroBlog.Models;

namespace MicroBlog.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IBlogRepository _repository;

        public List<Post> Posts { get; set; } = new();

        public IndexModel(IBlogRepository repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
            Posts = _repository.GetAll().ToList();
        }
    }
}