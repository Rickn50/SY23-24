using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    internal class Program
    {
        struct Pokemon
        {
            public int Id;
            public string Name;
            public int Level;

        }
        struct student
        {
            public string Name;
            public int age;
            public int grade;
            public gender gender;
            public decimal GPA;
        }
        struct holidays
        {
            public string name;
            public day day;

        }
        enum gender {Male,Female};
        enum day {Mon,Tues,Wed,Thur,Fri,Sat,Sun}
        static void Main(string[] args)
        {
            Pokemon Pikachu = new Pokemon();
            Pikachu.Name = "Pikachu";
            Pikachu.Level = 1;
            Pikachu.Id = 1;

            student Bob=new student();
            Bob.age = 52;
            Bob.grade = 2;
            Bob.gender = gender.Male;
            Bob.GPA = 2;

            holidays MLK=new holidays();
            MLK.day = day.Mon;
            MLK.name = "MLK Day";


        }
    }
}
