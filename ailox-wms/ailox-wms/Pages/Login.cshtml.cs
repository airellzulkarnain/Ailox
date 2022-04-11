using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ailox_wms.Data;
using ailox_wms.Models;

namespace ailox_wms.Pages
{
    public class LoginModel : PageModel
    {
        private readonly AiloxContext _context;

        public LoginModel(AiloxContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User User { get; set; }
        public void OnGet()
        {
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OnPostAsync(User user)
        {
            user = await _context.Users.AsNoTracking().SingleOrDefaultAsync(s => s.username == user.username && s.password == user.password);
            if (user != null)
            {
                HttpContext.Session.SetString("_username", user.username);
                return RedirectToPage("./Index");
            }
            ViewData["ErrorMessage"] = "Password or username invalid!";
            return Page();
        }
    }
}
