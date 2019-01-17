//using DATA_Layer_NNINO.Entities;
//using DATA_Layer_NNINO.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DATA_Layer_NNINO.Repositories
//{
//    public class EFUnitOfWork : IUnitOfWork
//    {
//        private EFContext db;
//        private StudentRepository studentRepository;
//        // private TeacherRepository teacherRepository;

//        public EFUnitOfWork(string connectionString)
//        {
//            db = new EFContext(connectionString);
//        }
//        public IRepository<Student> Students
//        {
//            get
//            {
//                if (studentRepository == null)
//                    studentRepository = new StudentRepository(db);
//                return studentRepository;
//            }
//        }

//        public IRepository<Teacher> Teachers => throw new NotImplementedException();

//        public IRepository<Group> Groups => throw new NotImplementedException();

//        public IRepository<Lesson> Lessons => throw new NotImplementedException();

//        //public IRepository<Teacher> Teachers
//        //{
//        //    get
//        //    {
//        //        if (teacherRepository == null)
//        //            teacherRepository = new TeacherRepository(db);
//        //        return teacherRepository;
//        //    }
//        //}

//        public void Save()
//        {
//            db.SaveChanges();
//        }



//        private bool disposed = false;

//        public virtual void Dispose(bool disposing)
//        {
//            if (!this.disposed)
//            {
//                if (disposing)
//                {
//                    db.Dispose();
//                }
//                this.disposed = true;
//            }
//        }

//        public void Dispose()
//        {
//            Dispose(true);
//            GC.SuppressFinalize(this);
//        }
//    }
//}