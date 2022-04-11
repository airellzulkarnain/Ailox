using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ailox_wms.Data;
using ailox_wms.Models;

namespace ailox_wms.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AiloxContext _context;

        public IndexModel(ILogger<IndexModel> logger, AiloxContext context)
        {
            _logger = logger;
            _context = context;
        }
        public User User { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            string username = HttpContext.Session.GetString("_username");
            if (username == null)
            {
                return RedirectToPage("./Login");
            }
            User = await _context.Users.AsNoTracking().SingleAsync(s => s.username == username);
            return Page();
        }
    }
}