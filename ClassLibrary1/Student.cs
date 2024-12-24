using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary1
{
    public class Student
    {
        public string Nam { get; set; }
        public int Ocenka { get; set; }
        public string Name { get; set; }


        public Student(string nam, int ocenka,string name)
        { 
            Nam = nam;
            Ocenka = ocenka;
            Name = name;
        }
        public void show()
        {
            Console.WriteLine($"Название: {Nam},Фамилия {Name}  Группа: {Ocenka}");
        }
    }
}
