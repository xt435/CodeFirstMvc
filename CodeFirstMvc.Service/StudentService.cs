using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstMvc.Data;
using CodeFirstMvc.Model;

namespace CodeFirstMvc.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Student GetStudentByLastName(string lastName)
        {
            return _studentRepository.GetStudentByLastName(lastName);
        }

        public IEnumerable<Student> GetStudents()
        {
            return _studentRepository.GetAll();
        }
    }

    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentByLastName(string lastName);
    }
}
