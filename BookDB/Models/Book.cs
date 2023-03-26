using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookDB.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string author { get; set; }

        public int BookPublisherId { get; set; }
        public publisher BookPublisher { get; set; }
    }

    public class publisher
    {
        public int pub_ID { get; set; }
        public string pub_name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
    
}
