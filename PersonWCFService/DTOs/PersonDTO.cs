using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



public class PersonResponse
{
    public string CellPhoneNumber { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string DocumentType { get; set; }
    public string DocumentNumber { get; set; }
}

public class PersonRequest
{
    public string CellPhoneNumber { get; set; }
}


