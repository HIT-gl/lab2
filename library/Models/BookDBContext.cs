using System;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace library.Models
{
    public class BookDBContext : DbContext
    {
        public DbSet<book> books { get; set; }
        public DbSet<author> authors { get; set; }
    }

}


/*namespace library.Models
{
      /* public class book
       {
           /*      public int ID { get; set; }
                 public string Title { get; set; }
                 public DateTime ReleaseDate { get; set; }
                 public string Genre { get; set; }
                 public decimal Price { get; set; }
           public string ISBN { get; set; }
           public string Title { get; set; }
           public int AuthorID { get; set; }
           public string Publisher { get; set; }
           public string PublishDate { get; set; }
           public decimal Price { get; set; }
       }
    public class BookDBContext : DbContext
    {
        public DbSet<book> books { get; set; }
    }
*/
//}
