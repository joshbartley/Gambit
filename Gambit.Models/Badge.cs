using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gambit.Models
{
    public class Badge
    {
        public Badge()
        {
            this.Rules = new List<Rule>();
        }

        public List<Rule> Rules { get; set; }
    }
}
