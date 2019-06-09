using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniHabr.Models {
   public class Comment {
      public int Id { get; set; }

      public int UserId { get; set; }
      public virtual User User { get; set; }

      public int PostId { get; set; }
      public virtual Post Post { get; set; }

      [DataType(DataType.DateTime)]
      public DateTime PostDate { get; set; }
      [DataType(DataType.Text)]
      public string Content { get; set; }
   }
}
