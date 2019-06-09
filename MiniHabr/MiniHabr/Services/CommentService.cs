using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using MiniHabr.Data;
using MiniHabr.Models;
using MiniHabr.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniHabr.Services {
   public class CommentService : ICommentService {
      private readonly UserManager<User> userManager;
      private readonly ApplicationDbContext dbContext;

      public CommentService(UserManager<User> userManager, ApplicationDbContext dbContext) {
         this.userManager = userManager;
         this.dbContext = dbContext;
      }


      public async Task AddComment(Comment comment, int postId, HttpContext context) {
         var user = await this.userManager.GetUserAsync(context.User);
         var post = user.Posts.FirstOrDefault(p => p.Id == postId);
         post.Comments.Add(comment);
      }

      public IEnumerable<Comment> GetComments(int postId) {
         return dbContext.Posts.Find(postId).Comments.ToList();
      }
   }
}
