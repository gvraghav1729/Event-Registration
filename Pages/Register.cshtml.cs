using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EventRegistration.Data;
using EventRegistration.Models;

namespace EventRegistration.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public RegisterModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Registration Registration { get; set; }
        public Event Event { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Event = await _context.Events.FindAsync(id);
            if (Event == null)
            {
                return NotFound();
            }
            Registration = new Registration { EventId = id };
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Event = await _context.Events.FindAsync(Registration.EventId);
                return Page();
            }

            _context.Registrations.Add(Registration);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}