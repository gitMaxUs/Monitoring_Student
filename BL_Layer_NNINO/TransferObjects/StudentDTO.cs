using System;
using System.Collections.Generic;
using System.Text;

namespace BL_Layer_NNINO.TransferObjects
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public GroupDTO Group { get; set; }
    }
}
