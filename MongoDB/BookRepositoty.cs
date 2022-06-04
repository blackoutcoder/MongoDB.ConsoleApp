using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace MongoDB
{
    internal class BookRepositoty
    {
        public List<Book> Books { get; set; }
        public List<Page> Pages { get; set; }
        public BookRepositoty()
        {
            Books = new List<Book>();
        }

        public void CreateBook()
        {
            MongoClient client = new MongoClient("mongodb+srv://blackout:karina@cluster1.b9ndq.mongodb.net/?retryWrites=true&w=majority");
            var playlistCollections = client.GetDatabase("Books").GetCollection<Book>("Bookshelf");
            Console.WriteLine("Enter book name and press ENTER...");
            var bookName = Console.ReadLine();
            Console.WriteLine("Enter number of pages and press ENTER...");
            var numberOfPages = Console.ReadLine();
            GeneratePages(Convert.ToInt32(numberOfPages));
            Books.Add(new Book(bookName, GeneratePages(Convert.ToInt32(numberOfPages))));
            var book = Books.Where(x => x.BookName == bookName).First();
            playlistCollections.InsertOne(book);
            
        }

        public List<Page> GeneratePages(int numberOfPages)
        {
            List<Page> pages = new List<Page>();

            for (int i = 1; i < numberOfPages; i++)
            {
                pages.Add(new Page(i, $"This is the {i} page of the book."));  
            }
            return pages;
        }

        public void DeleteBook()
        {
            MongoClient client = new MongoClient("mongodb+srv://blackout:karina@cluster1.b9ndq.mongodb.net/?retryWrites=true&w=majority");
            Console.WriteLine("Enter book name to delete and press ENTER...");
            var bookName = Console.ReadLine();
            var filter = Builders<Book>.Filter.Eq("BookName", bookName);
            var playlistCollections = client.GetDatabase("Books").GetCollection<Book>("Bookshelf");
            playlistCollections.DeleteOne(filter);
        }

        public void FindBook()
        {
            MongoClient client = new MongoClient("mongodb+srv://blackout:karina@cluster1.b9ndq.mongodb.net/?retryWrites=true&w=majority");
            Console.WriteLine("Enter book name to find and press ENTER...");
            var bookName = Console.ReadLine();
            var filter = Builders<Book>.Filter.Eq("BookName", bookName);
            var playlistCollections = client.GetDatabase("Books").GetCollection<Book>("Bookshelf");
            var results = playlistCollections.Find(filter);
            Console.WriteLine(Convert.ToString(results));
        }

        public void EditBookName()
        {
            MongoClient client = new MongoClient("mongodb+srv://blackout:karina@cluster1.b9ndq.mongodb.net/?retryWrites=true&w=majority");
            Console.WriteLine("Enter book name to add a new page and press ENTER...");
            var bookName = Console.ReadLine();
            Console.WriteLine("Enter a new 'name' for a book and press ENTER...");
            var newName = Console.ReadLine();
            var filter = Builders<Book>.Filter.Eq("BookName", bookName);
            var update = Builders<Book>.Update.Rename(bookName, newName);
            var playlistCollections = client.GetDatabase("Books").GetCollection<Book>("Bookshelf");
            var results = playlistCollections.UpdateMany(filter, update);
            Console.WriteLine(results);
        }
    }
}
