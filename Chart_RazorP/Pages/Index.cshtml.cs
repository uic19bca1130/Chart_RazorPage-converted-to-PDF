using Chart_RazorP.Data;
using Chart_RazorP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Chart_RazorP.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppDbContext _context;

        public IndexModel(ILogger<IndexModel> logger,AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [BindProperty]
        public List<Employee> employee { get; set; } = default!;

		public void OnGet()
		{
			employee = _context.Employees.ToList();
		}
	}
}