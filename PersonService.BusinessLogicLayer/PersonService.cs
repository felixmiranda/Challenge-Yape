using PersonService.DataAccessLayer;
using PersonService.DTOs;

namespace PersonService.BusinessLogicLayer
{
    public class PersonService
    {
        private readonly PersonRepository _personRepository;
        public PersonService()
        {
            _personRepository = new PersonRepository();
        }

        public PersonResponse? GetPersonByCellPhoneNumber(PersonRequest request)
        {
            return _personRepository.GetPersonByCellPhoneNumber(request.CellPhoneNumber);
        }

    }
}
