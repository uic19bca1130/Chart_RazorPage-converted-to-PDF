using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Chart_RazorP.Controllers
{
	public class HomeController : Controller
	{
		// ... other methods ...

		[HttpGet("/getTableData")]
		public IActionResult GetTableData()
		{
			var tableData = new List<object>
			{
				new { ID = 1, Name = "sidhu", Phone = "123-456-7890", Email = "sidhu@example.com" },
				new { ID = 2, Name = "mooseala", Phone = "987-654-3210", Email = "mooseala@example.com" },
                // Add More Rows If You Need
            };

			return Json(tableData);
		}
	}
}
