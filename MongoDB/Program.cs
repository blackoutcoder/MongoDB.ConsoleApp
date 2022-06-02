using System;
using System.Collections.Generic;
using MongoDB.Driver;
namespace MongoDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoClient client = new MongoClient("mongodb+srv://blackout:karina@cluster1.b9ndq.mongodb.net/?retryWrites=true&w=majority");
            //var playlistCollections = client.GetDatabase("Playlists").GetCollection<Playlist>("Playlist");
            var playlistCollections = client.GetDatabase("Books").GetCollection<Book>("Book");
            var page = new Page(39, "Wonderland");
            var book = new Book("Alice", page);
            
            playlistCollections.InsertOne(book);

            //var filter = Builders<Playlist>.Filter.Eq("Username", "User1");
            //var results = playlistCollections.Find(filter).ToList();
            //var update = Builders<Playlist>.Update.AddToSet<string>("Items", "Gop");

           // playlistCollections.UpdateMany(filter, update);



        }
    }
}
