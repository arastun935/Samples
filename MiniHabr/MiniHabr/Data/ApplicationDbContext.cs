using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MiniHabr.Models;

namespace MiniHabr.Data
{
   public class ApplicationDbContext : IdentityDbContext<User>
   {
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
      {
         Database.EnsureCreated();
      }
   }
}
