using DATA_Layer_NNINO.Entities;
using DATA_Layer_NNINO.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DATA_Layer_NNINO.UOW
{
    public interface IUnitOFWork
    {
        IGenericRepository<Student> StudentsUOW { get; }
        IGenericRepository<Teacher> TeacersUOW { get; }
        IGenericRepository<Group> GroupUOW { get; }
        IGenericRepository<Lesson> LessonUOW { get; }

        void Save();
    }
}
