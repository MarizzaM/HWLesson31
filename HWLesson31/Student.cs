using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson31
{
    class Student
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string AddressCity { get; set; }
        public bool VIP { get; set; }

        public static bool operator ==(Student s1, Student s2)
        {
            if (s1 == null && s2 == null)
                return true;
            if (s1 == null || s2 == null)
                return false;

            return (s1.Id == s2.Id);
        }

        public static bool operator !=(Student s1, Student s2)
        {
            return !(s1 == s2);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Student s = obj as Student;
            if (s == null)
                return false;

            return this.Id == s.Id;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

        public override string ToString()
        {
            return $"{Id} {ClassId} {Name} {Age} {AddressCity} {VIP}";
        }
    }
}
