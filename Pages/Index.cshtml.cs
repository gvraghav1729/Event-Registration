using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EventRegistration.Data;
using EventRegistration.Models;

namespace EventRegistration.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Event> Events { get; set; }

        public async Task OnGetAsync()
        {
            Events = _context.Events.ToList();
        }

        public async Task<IActionResult> OnGetDeleteAsync(int id)
        {
            var eventToDelete = await _context.Events.FindAsync(id);
            if (eventToDelete != null)
            {
                _context.Events.Remove(eventToDelete);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}