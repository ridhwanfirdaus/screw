using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Screw.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime DateAdded { get; set; }

        public byte NumberInStock  { get; set; }
        public byte NumberAvailable { get; set; }
    }
}