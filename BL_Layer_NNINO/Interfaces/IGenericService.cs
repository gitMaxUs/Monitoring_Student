﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BL_Layer_NNINO.Interfaces
{
    public interface IGenericService<T>
    {
        IEnumerable<T> GetItems();
        void CreateItem(T ItemDTO);
        void EditItem(T ItemDTO);
        T GetItem(int? id);
        void DeleteItem(int? id);
    }
}
