using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;


namespace MongoDB
{
    internal class Book
    {
        public ObjectId Id { get; set; }
        public string BookName { get; set; }
        public List<Page> Page { get; set; }

        public Book(string bookName, List<Page> page)
        {
            BookName = bookName;
            Page = page;
        }
    }
}
