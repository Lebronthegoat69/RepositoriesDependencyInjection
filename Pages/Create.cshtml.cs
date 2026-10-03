using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MicroBlog.Models;

namespace MicroBlog.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IBlogRepository _repository;

        [BindProperty]
        public Post Post { get; set; } = new();

        public CreateModel(IBlogRepository repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Post.Id = _repository.GetAll().Count() + 1;
            _repository.Add(Post);

            return RedirectToPage("./Index");
        }
    }
}