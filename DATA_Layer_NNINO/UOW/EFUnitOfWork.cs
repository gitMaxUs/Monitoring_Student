﻿using System;
using System.Collections.Generic;
using System.Text;
using DATA_Layer_NNINO.Entities;
using DATA_Layer_NNINO.Repositories; 

namespace DATA_Layer_NNINO.UOW
{
    public class EFUnitOfWork : IUnitOFWork
    {
        private EFContext DB_Context;

        private EFGenericRepository<Student> StudentRepository;
        private EFGenericRepository<Teacher> TeacherRepository;
        private EFGenericRepository<Group> GroupRepository;
        private EFGenericRepository<Lesson> LessonRepository;

        public EFUnitOfWork(EFContext Context_nnino)
        {
            DB_Context = Context_nnino;
        }


        public IGenericRepository<Student> StudentsUOW
        {
            get
            {
                if (StudentRepository == null)
                    StudentRepository = new EFGenericRepository<Student>(DB_Context);
                return StudentRepository;
            }
        }
        public IGenericRepository<Teacher> TeacersUOW
        {
            get
            {
                if (TeacherRepository == null)
                    TeacherRepository = new EFGenericRepository<Teacher>(DB_Context);
                return TeacherRepository;
            }
        }
        public IGenericRepository<Group> GroupUOW
        {
            get
            {
                if (GroupRepository == null)
                    GroupRepository = new EFGenericRepository<Group>(DB_Context);
                return GroupRepository;
            }
        }
        public IGenericRepository<Lesson> LessonUOW
        {
            get
            {
                if (LessonRepository == null)
                    LessonRepository = new EFGenericRepository<Lesson>(DB_Context);
                return LessonRepository;
            }
        }

        public void Save()
        {
            DB_Context.SaveChanges();
        }
    }
}
