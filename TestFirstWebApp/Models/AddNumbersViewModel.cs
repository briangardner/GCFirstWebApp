using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestFirstWebApp.Models
{
    public class AddNumbersViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Number1 { get; set; }
        public int Y { get; set; }
        public int Result => Number1 + Y;
    }
}