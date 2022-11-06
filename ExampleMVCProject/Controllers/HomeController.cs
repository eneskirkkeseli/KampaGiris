using ExampleMVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json.Serialization;

namespace ExampleMVCProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // db doldur
            var users = new List<User>();
            users.Add(new User { Id = 1, UserName = "enes1", Password = "123" });
            users.Add(new User { Id = 2, UserName = "fatih", Password = "123" });


            var xxx = JsonConvert.SerializeObject(users);
            //user'ı getir
            var selectedUser = users.Where(c => c.UserName == username && c.Password == password).FirstOrDefault();

            //user kontrolü yap hatalıysa hata dön
            if (selectedUser == null)
            {
                return NotFound("Kullanıcı adı yada şifre yanlış");
            }

            // kata yoksa başarılı sayfasına yönlendir
            return View(selectedUser);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}