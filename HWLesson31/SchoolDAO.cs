using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson31
{
    class SchoolDAO : ISchoolDAO
    {
        public List<object> GetMapClassToStudentsDictionary()
        {
            List<object> results = new List<object>();

            using (SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\User\\Desktop\\SQLite\\31.db; Version = 3;"))
            {
                con.Open();

                using (SQLiteCommand cmd = new SQLiteCommand($"SELECT *, STUDENT.NAME as NAME_OF_STUDENT, CLASS.NAME as NAME_OF_CLASS FROM STUDENT JOIN CLASS ON STUDENT.CLASS_ID == CLASS.ID", con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            var obj = new
                            {
                                Class = (string)reader["NAME_OF_CLASS"],
                                Student = (string)reader["NAME_OF_STUDENT"],

                            };
                            /*Classroom c = new Classroom
                            {
                                Id = (int)reader["ID"],
                                Name = (string)reader["NAME_OF_STUDENT"],
                                Code = (int)reader["CODE"],
                                NumberOfStudent = (int)reader["NUMBER_OF_STUDENTS"],
                                NumberOfVip = (int)reader["MUMBER_OF_VIP"],
                                AgeAvarage = (int)reader["AGE_AVERAGE"],
                                MostPopularCity = (string)reader["MOST_POPULAR_CITY"],
                                OldesVip = (int)reader["OLDEST_VIP"],
                                YounestVip = (int)reader["YOUNGEST_VIP"],
                            };

                            Student s = new Student
                            {
                                Id = (int)reader["ID"],
                                ClassId = (int)reader["CLASS_ID"],
                                Name = (string)reader["NAME_OF_CLASS"],
                                Age = (int)reader["AGE"],
                                AddressCity = (string)reader["ADDRESS_CITY"],
                                VIP = (bool)reader["VIP"],
                            };*/

                            results.Add(obj);
                        }
                    }
                }
            }
            return results;
        }

        public List<object> GetStudentsFromClass(int classId)
        {
            List<object> results = new List<object>();

            using (SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\User\\Desktop\\SQLite\\31.db; Version = 3;"))
            {
                con.Open();

                using (SQLiteCommand cmd = new SQLiteCommand($"SELECT *, STUDENT.NAME as NAME_OF_STUDENT, CLASS.NAME as NAME_OF_CLASS FROM STUDENT JOIN CLASS ON STUDENT.CLASS_ID == CLASS.ID WHERE CLASS.ID = {classId}", con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            var obj = new
                            {
                                Class = (string)reader["NAME_OF_CLASS"],
                                Student = (string)reader["NAME_OF_STUDENT"],

                            };
                            /*Classroom c = new Classroom
                            {
                                Id = (int)reader["ID"],
                                Name = (string)reader["NAME_OF_STUDENT"],
                                Code = (int)reader["CODE"],
                                NumberOfStudent = (int)reader["NUMBER_OF_STUDENTS"],
                                NumberOfVip = (int)reader["MUMBER_OF_VIP"],
                                AgeAvarage = (int)reader["AGE_AVERAGE"],
                                MostPopularCity = (string)reader["MOST_POPULAR_CITY"],
                                OldesVip = (int)reader["OLDEST_VIP"],
                                YounestVip = (int)reader["YOUNGEST_VIP"],
                            };

                            Student s = new Student
                            {
                                Id = (int)reader["ID"],
                                ClassId = (int)reader["CLASS_ID"],
                                Name = (string)reader["NAME_OF_CLASS"],
                                Age = (int)reader["AGE"],
                                AddressCity = (string)reader["ADDRESS_CITY"],
                                VIP = (bool)reader["VIP"],
                            };*/

                            results.Add(obj);
                        }
                    }
                }
            }
            return results;
        }
    }
}
