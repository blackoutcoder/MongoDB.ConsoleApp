using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB
{
    internal class Playlist
    {
        public ObjectId Id { get; set; }
        public string Username { get; set; } = null;
        public List<string> Items { get; set; } = null;

        public Playlist(string username)
        {
            Username = username;
            Items = new List<string>();

        }
    }
}
