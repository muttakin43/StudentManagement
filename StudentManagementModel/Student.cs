using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementModel
{
    public class Student 
    {
   
        public int  StudentId { get; set; }
        

        public int RollNumber { get; set; }
        public string Name { get; set; }
        
        public string Email { get; set; }
        
       

        public int Age { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

        public bool IsActive { get; set; } 



        public string Department { get; set; }
    }
}
