using CodeFirstMvc.Data;
using CodeFirstMvc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstMvc.Service
{
    public class PersonService : IPersonService
    {

        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public void AddPeople(People people)
        {
            _personRepository.Add(people);
        }

        public IEnumerable<People> GetAllPeople()
        {
            //throw new NotImplementedException();
            return _personRepository.GetAll();
        }
    }
    public interface IPersonService
    {
        IEnumerable<People> GetAllPeople();

        //People GetPeopleById(int id)
        //{
        //    return _personRepository.GetById(id);
        //}
    }
}
