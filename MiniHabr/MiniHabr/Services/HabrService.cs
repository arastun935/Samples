using MiniHabr.Data;
using MiniHabr.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniHabr.Services {
   public class HabrService : IService {
      private readonly ApplicationDbContext dbContext;

      public HabrService(ApplicationDbContext dbContext) {
         this.dbContext = dbContext;
      }


   }
}
