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
        public IActionResult AllBag()
        {
            var data = appDbContext.bagStores.ToList();
            return View(data);
        }
        public IActionResult DeleteBag(int id)
        {
            var data = appDbContext.bagStores.Where(x => x.Bagid == id).FirstOrDefault();
            appDbContext.bagStores.Remove(data);
            appDbContext.SaveChanges();
            return RedirectToAction("AllBag", "Home");
        }
        [HttpGet]
        public IActionResult AddBag()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBag(BagStore bagStore, IFormFile File)
        {
           bagStore.Image = UploadImage(File);
            appDbContext.bagStores.Add(bagStore);
            appDbContext.SaveChanges();
            return View();
        }

        public IActionResult AllBook()
        {
            var data = appDbContext.bookStores.ToList();
            return View(data);
        }
        public IActionResult DeleteBook(int id)
        {
            var data = appDbContext.bookStores.Where(x => x.BookISBN == id).FirstOrDefault();
            appDbContext.bookStores.Remove(data);
            appDbContext.SaveChanges();
            return RedirectToAction("AllBook", "Home");
        }
        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(BookStore bookStore, IFormFile File)
        {
            bookStore.Image = UploadImage(File);
            appDbContext.bookStores.Add(bookStore);
            appDbContext.SaveChanges();
            return View();
        }

        public IActionResult AllLapTop()
        {
            var data = appDbContext.laptopStores.ToList();
            return View(data);
        }
        public IActionResult DeleteLapTop(int id)
        {
            var data = appDbContext.laptopStores.Where(x => x.LaptopId == id).FirstOrDefault();
            appDbContext.laptopStores.Remove(data);
            appDbContext.SaveChanges();
            return RedirectToAction("AllLapTop", "Home");
        }
        [HttpGet]
        public IActionResult AddLapTop()
        {
            return View();
        }
        public IActionResult AllPhone()
        {
            var data = appDbContext.phoneStores.ToList();
            return View(data);
        }
        public IActionResult DeletePhone(int id)
        {
            var data = appDbContext.phoneStores.Where(x => x.PhoneId == id).FirstOrDefault();
            appDbContext.phoneStores.Remove(data);
            appDbContext.SaveChanges();
            return RedirectToAction("AllPhone", "Home");
        }
        [HttpGet]
        public IActionResult AddPhone()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPhone(PhoneStore phoneStore, IFormFile File)
        {
            phoneStore.Image = UploadImage(File);
            appDbContext.phoneStores.Add(phoneStore);
            appDbContext.SaveChanges();
            return View();
        }
        public IActionResult AllVehicle()
        {
            var data = appDbContext.vehicles.ToList();
            return View(data);
        }
        public IActionResult DeleteVehicle(int id)
        {
            var data = appDbContext.vehicles.Where(x => x.Vehid == id).FirstOrDefault();
            appDbContext.vehicles.Remove(data);
            appDbContext.SaveChanges();
            return RedirectToAction("AllVehicle", "Home");
        }
        [HttpGet]
        public IActionResult AddVehicle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddVehicle(Vehicle vehicle, IFormFile File)
        {
            vehicle.Image = UploadImage(File);
            appDbContext.vehicles.Add(vehicle);
            appDbContext.SaveChanges();
            return View();
        }

        public IActionResult AllWatch()
        {
            var data = appDbContext.watchStores.ToList();
            return View(data);
        }
        public IActionResult DeleteWatch(int id)
        {
            var data = appDbContext.watchStores.Where(x => x.watchid == id).FirstOrDefault();
            appDbContext.watchStores.Remove(data);
            appDbContext.SaveChanges();
            return RedirectToAction("AllWatch", "Home");
        }
        [HttpGet]
        public IActionResult AddWatch()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddWatch(WatchStore watchStore, IFormFile File)
        {
            watchStore.Image = UploadImage(File);
            appDbContext.watchStores.Add(watchStore);
            appDbContext.SaveChanges();
            return View();
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

        public IActionResult AllShoe()
        {
            var data = appDbContext.shoeStores.ToList();
            return View(data);
        }
        public IActionResult DeleteShoe(int id)
        {
            var data = appDbContext.shoeStores.Where(x => x.Shoeid == id).FirstOrDefault();
            appDbContext.shoeStores.Remove(data);
            appDbContext.SaveChanges();
            return RedirectToAction("AllShoe", "Home");
        }
        [HttpGet]
        public IActionResult AddShoe()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddShoe(ShoeStore shoeStore, IFormFile File)
        {
            shoeStore.Image = UploadImage(File);
            appDbContext.shoeStores.Add(shoeStore);
            appDbContext.SaveChanges();
            return View();
        }

















        [HttpPost]
        public IActionResult AddLapTop(LaptopStore laptopStore, IFormFile File)
        {
            laptopStore.Image = UploadImage(File);
            appDbContext.laptopStores.Add(laptopStore);
            appDbContext.SaveChanges();
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
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}