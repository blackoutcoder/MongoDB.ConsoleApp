using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
    internal class BookRepositoty
    {
        public List<Book> Books { get; set; }
        public BookRepositoty()
        {
            Books = new List<Book>();
        }

        public void CreateBook()
        {
            Page page = new Page(11, "Content");
            Book book = new Book("Alice", page);
        }
    }
}
