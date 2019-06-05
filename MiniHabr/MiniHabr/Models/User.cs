using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniHabr.Models {
   public class User : IdentityUser {
      public virtual List<Post> Posts { get; set; }
      public virtual List<Comment> Comments { get; set; }
   }
}
