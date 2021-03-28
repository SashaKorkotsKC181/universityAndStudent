using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institution
{
    public class Internship : EducationPlace
    {
        public Internship(string name_) : base(name_)
        {
             
        }

        public override void AddStudent(Student student)
        {
            if (student.educationPlace.MidleLevelKnowledge < student.Knowledge)
            {
                base.AddStudent(student);
            }
        }

    }
}
