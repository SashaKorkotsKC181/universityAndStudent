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
        public Knowledge knowledge;
        public Student(string name_)
            : base(name_)
        {
            knowledge = new Knowledge(0);
        }
        
        public Student(string name_, Knowledge knowledge_)
            : base(name_)
        {
            knowledge = knowledge_;
        }

        public void SetKnowledge(Knowledge knowledge_)
        {
            knowledge = knowledge_;
        }
    }
}
