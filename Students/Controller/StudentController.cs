using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Controller
{
    class StudentController
    {
        List<Student> StudentDB = new List<Student>();

        public List<Student> GetAll()
        {
            return StudentDB;
        }

        public void Add(Student student)
        {
            StudentDB.Add(student);
        }
    }
}
