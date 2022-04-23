using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.GroupName("Programming");
            student.GroupName("Design");
            Student student2 = new Student();
            Student student3 = new Student();
            student3.GroupName("Design");
            Console.WriteLine(student.GroupName("Design"));
            Console.WriteLine(student.GroupName("Programming"));
            Console.ReadLine();
        }
    }
}
