using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab7
{
    public class Teacher
    {
        public string TeacherFirstName { get; set; }
        public string TeacherSecondName { get; set; }
        public string TeacherFatherName { get; set; }
        public List<Group> Groups { get; set; }
        public List<Lesson> TeacherLessons { get; set; }
        public string TeacherRang { get; set; }
    }

}
