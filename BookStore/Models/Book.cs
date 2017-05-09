using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string PublishDate { get; set; }
    }
}
