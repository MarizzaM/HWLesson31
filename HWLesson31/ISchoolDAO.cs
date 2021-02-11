using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson31
{
    interface ISchoolDAO
    {
        List<object> GetMapClassToStudentsDictionary();
        List<object> GetStudentsFromClass(int classId);
    }
}
