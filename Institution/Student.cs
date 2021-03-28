using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institution
{
    public class Student : Person
    {
        public EducationPlace educationPlace;
        public Knowledge Knowledge { get; private set; }
        public Student(string name_)
            : base(name_)
        {
            Knowledge = new Knowledge(0);
        }
        
        public Student(string name_, Knowledge knowledge_)
            : base(name_)
        {
            Knowledge = new Knowledge(knowledge_.level);
        }

        public void SetKnowledge(Knowledge knowledge_)
        {
            Knowledge = new Knowledge(knowledge_.level);
        }
    }
}
