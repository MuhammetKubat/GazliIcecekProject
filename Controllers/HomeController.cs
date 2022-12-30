using BankTransactions.Models;
using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

namespace BankTransactions.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GazlicecekDbContext _dbContext;
        private readonly IWebHostEnvironment webHostEnvironment;
        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment hostEnvironment, GazlicecekDbContext _context)
        {
            _logger = logger;
            _dbContext = _context;
            webHostEnvironment = hostEnvironment;

        }
        public IActionResult GazlicecekListing()
        {
            return View(_dbContext.Gazliceceks.ToList());
        }

        public IActionResult IstatislikGrafik()
        {
             var qMarka = from r in _dbContext.Gazliceceks
            group r by r.Marka into g
            select new
            {
              Markalar = g.Key,
            };
            //Her bir Marka count
             var qCount = from r in _dbContext.Gazliceceks
            group r by r.Marka into g
            select new
            {
              MarkaCount = g.Count(),
            };
        

            ViewBag.disMarka=qMarka;
            ViewBag.disCount=qCount;
            ViewData["ToplamKayit"]=_dbContext.Gazliceceks.Count();
            return View();
        }
        public ActionResult GazlicecekProfileUpload(Gazlicecek gzdetails)
        {
            string? unigueFileName = null;
            if (gzdetails.ImageFile != null)
            {
                string ImageUploadedFolder = Path.Combine(webHostEnvironment.WebRootPath, "UploadedImages");
                unigueFileName = Guid.NewGuid().ToString() + "_" + gzdetails.ImageFile.FileName;
                string filepath = Path.Combine(ImageUploadedFolder, unigueFileName);
                using (var fileStream = new FileStream(filepath, FileMode.Create))
                {
                    gzdetails.ImageFile.CopyTo(fileStream);
                }
                gzdetails.IcecekPath = "~/wwwroot/UploadedImages";
                gzdetails.IcecekFileName = unigueFileName;
                _dbContext.Gazliceceks.Add(gzdetails);
                _dbContext.SaveChanges();
                return RedirectToAction("GazlicecekListing", "Home");
            }
            return View(gzdetails);
        }
        public IActionResult Index()
        {
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