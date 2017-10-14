using System;
using System.Data.Entity;

namespace library.Models
{
    public class book
    {
        /*      public int ID { get; set; }
              public string Title { get; set; }
              public DateTime ReleaseDate { get; set; }
              public string Genre { get; set; }
              public decimal Price { get; set; }*/
        public int ID { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
    //    public decimal AuthorID { get; set; }
        public string Publisher { get; set; }
        public string PublishDate { get; set; }
        public decimal Price { get; set; }
    }

    public class author
    {
        public int authorID { get; set; }
        public string Name { get; set; }
        public decimal age { get; set; }
        public string country { get; set; }

    }

}

