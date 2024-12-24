using System.Collections.Generic;
using System.Text.RegularExpressions;
using static ClassLibrary1.Group;

namespace ClassLibrary1
{
    public class Group
    {

      public  int Name { get; set; }
      public string College { get; set; }
        public List<Student> Students { get; set; }


        public Group (int name, string college)
        {
            Name = name;
            College = college;
            Students = new List <Student> ();
        
        }
        public void addStudent(Student  student)
        {
            Students.Add (student);
        }
        public void show()
        {
            Console.WriteLine($"Название: {Name}, Колледж: {College}");
        }


        public void ShowAll()
        {
            foreach (var student in Students)
            {
                student.show();
      
            }        
        }
    }
}
