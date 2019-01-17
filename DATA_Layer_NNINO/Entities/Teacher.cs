using System;
using System.Collections.Generic;
using System.Text;

namespace DATA_Layer_NNINO.Entities
{
    public  class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Lesson Lesson { get; set; }

    }
}
