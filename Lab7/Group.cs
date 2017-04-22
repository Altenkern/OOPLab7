using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab7
{
    public class Group
    {
        public List<Student> Students { get; set; }
        public string GroupName{ get; set; }
        public List<Lesson> Lessons { get; set; }
    }
}
