using Microsoft.AspNetCore.Http;
using MiniHabr.Helpers;
using MiniHabr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniHabr.Services.Abstractions {
   public interface IPostService {
      Post GetPostById(int id);
      IEnumerable<Post> GetPosts(int page);
      IEnumerable<Post> GetPostsByUserId(int UserId);
      Task AddPost(Post post, HttpContext context);
   }
}
