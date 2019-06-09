using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniHabr.Data;
using MiniHabr.Models;
using MiniHabr.Services.Abstractions;

namespace MiniHabr.Controllers {
   public class HomeController : Controller {
      private readonly IPostService postService;
      private readonly ICommentService commentService;

      public HomeController(IPostService postService, ICommentService commentService) {
         this.postService = postService;
         this.commentService = commentService;
      }

      public IActionResult Index() {
         
         return View();
      }

      public IActionResult Privacy() {
         return View();
      }

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error() {
         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }
   }
}
