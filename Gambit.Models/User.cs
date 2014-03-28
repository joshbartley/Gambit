using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gambit.Models
{
    public class User
    {
        public string EMail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Points { get; set; }
        public List<Badge> Badges { get; set; }
    }
}
