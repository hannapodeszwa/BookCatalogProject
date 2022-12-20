using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5.Data
{
    public class Lab5Context : IdentityDbContext<IdentityUser>
    {
        public Lab5Context (DbContextOptions<Lab5Context> options)
            : base(options)
        {
        }

        public DbSet<Lab5.Models.Book> Book { get; set; } = default!;
        public DbSet<Lab5.Models.User> User { get; set; } = default!;
    }
}
