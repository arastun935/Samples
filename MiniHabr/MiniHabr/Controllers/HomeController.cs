using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniHabr.Data;
using MiniHabr.Models;

namespace MiniHabr.Controllers
{
   public class HomeController : Controller
   {
      private readonly UserManager<User> userManager;
      private readonly ApplicationDbContext dbContext;

      public HomeController(UserManager<User> userManager, ApplicationDbContext dbContext)
      {
         this.userManager = userManager;
         this.dbContext = dbContext;
      }

      public async Task<ActionResult> AddComment() {
         try {
            var user = await userManager.GetUserAsync(HttpContext.User);
            this.dbContext.Posts.Add(new Post() {
               Content = "Some post content",
               PostDate = DateTime.Now,
               User = user,
            });
            dbContext.SaveChanges();
            return Ok();
         } catch (Exception ex) {
            return BadRequest(ex.Message);
         }
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
