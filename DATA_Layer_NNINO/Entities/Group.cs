using System;
using System.Collections.Generic;
using System.Text;

namespace DATA_Layer_NNINO.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string GroupName { get; set; }

        public  ICollection<Student> Students { get; set; }
    }
}
