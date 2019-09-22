//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Data.Entity;

//namespace Screw.Models
//{
//    public class MyDBContext : DbContext
//    {
//        public DbSet<Customer> Customers { get; set; }
//        public DbSet<Movie> Movies { get; set; }
//    }
//}// have to add create method and other applicationdbcontext things 

using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Screw.Models
{
    public class MyDBContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
      

        public MyDBContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static MyDBContext Create()
        {
            return new MyDBContext();
        }
    }
}