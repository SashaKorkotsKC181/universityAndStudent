using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institution
{
    public abstract class EducationPlace
    {
        string name;
        public List<Student> Students { get; private set; }
        public Knowledge MidleLevelKnowledge {get; private set; }

        public EducationPlace(string name_)
        {
            name = name_;
            MidleLevelKnowledge = new Knowledge(0);
            Students = new List<Student>();
        }

        public virtual void AddStudent(Student student_)
        {
            Students.Add(student_);
            student_.educationPlace = this; 
            MidleLevelKnowledge = new Knowledge(Students.Average(student => student.Knowledge.level));
            
        }
        
        public void AddStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                AddStudent(student);
            }
        }
        public void AddStudentsFromOtherEducPlace(EducationPlace educationPlace)
        {
            foreach (Student student in educationPlace.Students)
            {
                AddStudent(student);
            }
        }
        public string GetStudents()
        {
            string output = "";
            foreach (Student student in Students)
            {
                output += student + "\n";
            }
            return output;
        }
    }
}
