using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniHabr.Models {
   public class Post {
      public int UserId { get; set; }
      public User User { get; set; }
      
   }
}
