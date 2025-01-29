using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class PersonRepository
{
    // Simulamos una base de datos con una lista en memoria
    private readonly List<PersonResponse> _persons = new List<PersonResponse>
        {
            new PersonResponse
            {
                CellPhoneNumber = "123456789",
                Name = "John",
                LastName = "Doe",
                DocumentType = "ID",
                DocumentNumber = "12345678"
            },
            new PersonResponse
            {
                CellPhoneNumber = "987654321",
                Name = "Jane",
                LastName = "Smith",
                DocumentType = "Passport",
                DocumentNumber = "87654321"
            }
        };

    public PersonResponse GetPersonByCellPhoneNumber(string cellPhoneNumber)
    {
        return _persons.FirstOrDefault(p => p.CellPhoneNumber == cellPhoneNumber);
    }
}