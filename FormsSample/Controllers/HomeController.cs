using FormsSample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FormsSample.Controllers {
	public class HomeController: Controller {
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger) {
			_logger = logger;
		}

		public IActionResult Index() {
			return View();
		}

		public IActionResult Privacy() {
			return View();
		}

		public IActionResult Contact() {
			var model = new ContactModel();
			return View(model);
		}

		public IActionResult ContactSubmit(ContactModel model) {

			_logger.LogInformation("{name}, {mobile}, {email}", model.FullName, model.Mobile, model.Email);

			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error() {
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}