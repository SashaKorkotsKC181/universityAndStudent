using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institution
{
    public class Person
    {
        protected string name;

        public Person(string name_)
        {
            name = name_;

        }

        public override string ToString()
        {
            return name;
        }
    }
}
