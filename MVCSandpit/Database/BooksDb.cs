using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MVCSandpit.Data.Model;

namespace MVCSandpit.Data.Database
{
    public class BooksDb : DbContext 
    {
        public DbSet<Book> MyProperty { get; set; }

    }
}
