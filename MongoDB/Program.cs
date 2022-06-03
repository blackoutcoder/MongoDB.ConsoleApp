using System;
using System.Collections.Generic;
using MongoDB.Driver;
namespace MongoDB
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            StartUp startUp = new StartUp();
            startUp.PrintChoise();
            //var filter = Builders<Playlist>.Filter.Eq("Username", "User1");
            //var results = playlistCollections.Find(filter).ToList();
            //var update = Builders<Playlist>.Update.AddToSet<string>("Items", "Gop");

           // playlistCollections.UpdateMany(filter, update);
        }
    }
}
