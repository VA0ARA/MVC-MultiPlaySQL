using Microsoft.AspNetCore.Mvc;
using MulitiSqlDI.Data;
using MulitiSqlDI.Models;
using System.Diagnostics;

namespace MulitiSqlDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DevDB _DatabaseDev;
        //private readonly ProDB _DatabasePro;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment webHostEnvironment,DevDB d)
        {
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
            _DatabaseDev = d;
           // _DatabasePro = p;
        }

        public IActionResult Index()
        {
            Developer objd = new Developer();
            objd.Name = "barname4";
            Developer objg = new Developer();
            objg.Name = "barname5";
            if (_webHostEnvironment.IsDevelopment())
            {
            _DatabaseDev.Add(objd);
            _DatabaseDev.Add(objg);
            _DatabaseDev.SaveChanges();

            }
            Developer objp = new Developer();
            objp.Name = "Mahsol6";
            if (_webHostEnvironment.IsProduction())
            {
                _DatabaseDev.Add(objp);
                _DatabaseDev.SaveChanges();
            }
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
