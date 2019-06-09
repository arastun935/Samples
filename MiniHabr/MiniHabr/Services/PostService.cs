using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using MiniHabr.Data;
using MiniHabr.Helpers;
using MiniHabr.Models;
using MiniHabr.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniHabr.Services {
   public class PostService : IPostService {
      private readonly UserManager<User> userManager;
      private readonly ApplicationDbContext dbContext;

      public PostService(UserManager<User> userManager, ApplicationDbContext dbContext) {
         this.userManager = userManager;
         this.dbContext = dbContext;
      }

      public async Task AddPost(Post post, HttpContext context) {
            var user = await this.userManager.GetUserAsync(context.User);
            user.Posts.Add(post);
      }

      public Post GetPostById(int id) {
         return dbContext.Posts.Find(id);
      }

      public IEnumerable<Post> GetPosts(int page) {
         // Make senses
         return dbContext.Posts.ToList();
      }

      public IEnumerable<Post> GetPostsByUserId(int userId) {
         return dbContext.Users.Find(userId).Posts.ToList();
      }
   }
}
