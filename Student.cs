using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Student
    {
        private int _id;
        public static int Id { get; set; }  
        public string Fullname { get; set; }    
        public string Subject { get; set; }  
        public Student()
        {
            _id = 1000;
            _id++;
            Id = _id;
        }
        public string GroupName(string Subject)
        {
          if(Subject == "Programming")
            {
                return  "PR"+ Id;
            }
          else if (Subject == "Design")
            {
                return  "DE"+ Id;
            }
            return "bele bir qrup tapilmaqdi";
        }
    } 
}
