using BL_Layer_NNINO.TransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL_Layer_NNINO.TransferObjects
{
    public class GroupDTO
    {
        public int Id { get; set; }
        public string GroupName { get; set; }

        public ICollection<StudentDTO> Students { get; set; }
    }
}
