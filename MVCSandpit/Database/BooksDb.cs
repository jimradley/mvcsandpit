using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MVCSandpit.Data.Model;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;

namespace MVCSandpit.Data.Database
{
    public class BooksDb : DbContext 
    {
        public BooksDb() : base("DefaultConnection")
        {

            Database.Log = sql => Debug.Write(sql);
        }

        public DbSet<Book> MyProperty { get; set; }

    }
}
