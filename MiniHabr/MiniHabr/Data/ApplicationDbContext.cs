using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MiniHabr.Models;

namespace MiniHabr.Data {
   public class ApplicationDbContext : IdentityDbContext<User> {
      public DbSet<Post> Posts { get; set; }
      public DbSet<Comment> Comments { get; set; }

      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options) {
         Database.EnsureCreated();
      }
   }
}
