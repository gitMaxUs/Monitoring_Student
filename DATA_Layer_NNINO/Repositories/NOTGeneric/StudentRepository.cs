//using DATA_Layer_NNINO.Entities;
//using DATA_Layer_NNINO.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Text;

//namespace DATA_Layer_NNINO.Repositories
//{
//    class StudentRepository : IRepository<Student>
//    {
//        private EFContext db;

//        public StudentRepository(EFContext context)
//        {
//            this.db = context;
//        }

//        public IEnumerable<Student> GetAll()
//        {
//            return db.Students;
//        }

//        public Student Get(int id)
//        {
//            return db.Students.Find(id);
//        }

//        public void Create(Student book)
//        {
//            db.Students.Add(book);
//        }

//        public void Update(Student book)
//        {
//            db.Entry(book).State = EntityState.Modified;
//        }
        
//        public IEnumerable<Student> Find(Func<Student, Boolean> predicate)
//        {
//            return db.Students.Where(predicate).ToList();
//        }

//        public void Delete(int id)
//        {
//            Student book = db.Students.Find(id);
//            if (book != null)
//                db.Students.Remove(book);
//        }

//    }
//}

