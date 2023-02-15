using EC2_1234567.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IO;

namespace EC2_1234567.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext appDbContext;
        private readonly IWebHostEnvironment webHostEnvironment;
        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            this.appDbContext = appDbContext;
            this.webHostEnvironment = webHostEnvironment;
        }
        

        public IActionResult AllApp()
        {
            var data = appDbContext.applicationSoftwares.ToList();
            return View(data);
        }
        public IActionResult DeleteApp(int id)
        {
            var data = appDbContext.applicationSoftwares.Where(x => x.softid == id).FirstOrDefault();
            appDbContext.applicationSoftwares.Remove(data);
            appDbContext.SaveChanges();
            return RedirectToAction("AllApp", "Home");
        }
        [HttpGet]
        public IActionResult AddApp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddApp(ApplicationSoftware applicationSoftware, IFormFile File)
        {
            applicationSoftware.Image = UploadImage(File);
            appDbContext.applicationSoftwares.Add(applicationSoftware);
            appDbContext.SaveChanges();
            return View();
        }
        public IActionResult ModifyApp(int id)
        {
            return View();
        }























        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public string UploadImage(IFormFile mediafile)
        {
            string pictureName = mediafile.FileName;
            string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "uploads");
            string fileExtension = Path.GetExtension(mediafile.FileName);
            pictureName = pictureName;
            string filePath = Path.Combine(uploadsFolder, "images", pictureName);
            using (FileStream fs = System.IO.File.Create(filePath))

            {

                mediafile.CopyTo(fs);

            }
        
            return pictureName;
        }
   
    }
}