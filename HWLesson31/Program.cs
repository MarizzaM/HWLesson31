using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson31
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ISchoolDAO dao = new SchoolDAO();
            //var students = dao.GetMapClassToStudentsDictionary();
            var students = dao.GetStudentsFromClass(1);

            foreach (var s in students) {
                var studentName = ((dynamic)s).Student;
                var className = ((dynamic)s).Class;

                Console.WriteLine($"{className} {studentName}");
            }
        }
    }
}
