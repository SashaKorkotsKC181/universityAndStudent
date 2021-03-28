using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institution
{
    public struct Knowledge
    {
        public decimal level;
        public Knowledge(decimal level_)
        {
            level = level_;
            //TODO: Implementation is needed
        }
        public static bool operator <(Knowledge a, Knowledge b)
        {
            return a.level < b.level;
        }
        public static bool operator >(Knowledge a, Knowledge b)
        {
            return a.level > b.level;
        }
        public override string ToString()
        {
            return level.ToString();
        }
    }
}
