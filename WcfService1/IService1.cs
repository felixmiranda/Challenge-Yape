﻿using PersonService.DTOs;
using System.ServiceModel;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        PersonResponse GetPersonByCellPhoneNumber(PersonRequest request);
    }
          
}
