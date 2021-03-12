using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewsApp.Data;


namespace NewsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IInfo _data;

        public HomeController(ILogger<HomeController> logger, IInfo data)
        {
            _logger = logger;
            _data = data;
        }

        //Get: Home/Index
        public IActionResult Index()
        {
            var info = _data.GetAll();
            return View(info);
        }

        //Get: Home/Detail/id
        public IActionResult Detail(int id)
        {
            var info = _data.GetById(id);
            if (info == null)
            {
                return NotFound();
            }
            return View(info);
        }

    }
}
