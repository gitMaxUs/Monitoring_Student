using AutoMapper;
using BL_Layer_NNINO.Interfaces;
using BL_Layer_NNINO.TransferObjects;
using DATA_Layer_NNINO.Entities;
using DATA_Layer_NNINO.UOW;
using System;
using System.Collections.Generic;

namespace BL_Layer_NNINO.Services
{
    class StudentService : IStudentService
    {
        IUnitOFWork Database;
        public StudentService(IUnitOFWork uow)
        {
            Database = uow;
        }


        public void CreateItem(StudentDTO instanceDTO)
        {
            if (instanceDTO == null)
                throw new ArgumentNullException();
            Database.StudentsUOW.Create(Mapper.Map<StudentDTO, Student>(instanceDTO));
            Database.Save();
        }

        public void DeleteItem(int? id)
        {
            var game = Database.StudentsUOW.Get(id.Value);

            Database.StudentsUOW.Delete(id);
            Database.Save();
        }

        public void EditItem(StudentDTO instanceDTO)
        {
            if (instanceDTO == null)
                throw new ArgumentNullException();
            Database.StudentsUOW.Update(Mapper.Map<StudentDTO, Student>(instanceDTO));
            Database.Save();
        }

        public StudentDTO GetItem(int? id)
        {
            if (id == null)
                throw new ArgumentNullException();

            Student student = Database.StudentsUOW.Get(id.Value);
            if (student == null)
            {
                throw new ArgumentNullException();
            }

            return (Mapper.Map<Student, StudentDTO>(student));
        }

        public IEnumerable<StudentDTO> GetItems()
        {
            IEnumerable<Student> students = Database.StudentsUOW.GetAll();
            return Mapper.Map<IEnumerable<Student>, IEnumerable<StudentDTO>>(students);
        }


        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
