﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Screw.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime Birthdate { get; set; }
    }
}