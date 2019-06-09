using Microsoft.AspNetCore.Http;
using MiniHabr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniHabr.Services.Abstractions {
   public interface ICommentService {
      IEnumerable<Comment> GetComments(int postId);
      Task AddComment(Comment comment, int postId, HttpContext context);
   }
}
