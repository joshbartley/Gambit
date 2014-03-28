using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gambit.Models
{

    public enum Condtion
    {
        Exists = 0,
        GreaterThan = 1,
        Equal = 2, 
        LessThan = 3,
        Count = 4
    }

    public class Rule
    {
        public Rule()
        {
            this.ActivityIds = new List<string>();
        }

        public Condtion Condition { get; set; }
        public List<string> ActivityIds { get; set; }
    }
}
