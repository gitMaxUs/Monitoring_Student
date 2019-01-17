using System;
using System.Collections.Generic;
using System.Text;

namespace DATA_Layer_NNINO.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Group Group { get; set; } 
    }
}
