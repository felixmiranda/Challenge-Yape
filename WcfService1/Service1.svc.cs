using PersonService.DTOs;

namespace WcfService1
{

    public class Service1 : IService1
    {
        private readonly PersonService.BusinessLogicLayer.PersonService _personService;
        public Service1()
        {
            _personService = new PersonService.BusinessLogicLayer.PersonService();
        }
        public PersonResponse GetPersonByCellPhoneNumber(PersonRequest request)
        {
            return _personService.GetPersonByCellPhoneNumber(request);
        }
    }
}
