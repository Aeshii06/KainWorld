using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KainWorld.Pages
{
    public class SupportUsModel : PageModel
    {
        private readonly ILogger<SupportUsModel> _logger;

        public SupportUsModel(ILogger<SupportUsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}