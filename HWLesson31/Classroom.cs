using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson31
{
    class Classroom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public int NumberOfStudent { get; set; }
        public int NumberOfVip { get; set; }
        public int AgeAvarage { get; set; }
        public string MostPopularCity { get; set; }
        public int OldesVip { get; set; }
        public int YounestVip { get; set; }

        public static bool operator ==(Classroom c1, Classroom c2)
        {
            if (c1 == null && c2 == null)
                return true;
            if (c1 == null || c2 == null)
                return false;

            return (c1.Id == c2.Id);
        }

        public static bool operator !=(Classroom c1, Classroom c2)
        {
            return !(c1 == c2);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Classroom c = obj as Classroom;
            if (c == null)
                return false;

            return this.Id == c.Id;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Code} {NumberOfStudent} {NumberOfVip} {AgeAvarage} {MostPopularCity}" +
                        $" {OldesVip} {YounestVip}";
        }
    }
}
