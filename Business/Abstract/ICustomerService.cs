using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICustomerService
    {
        IResult Add(Customer customer);
        IDataResult<List<Customer>> GetAll();
       
        IDataResult<Customer> login(Customer customer);
        IResult DeleteMyAccount(Customer customer);
        IResult UpdateMyAccount(Customer customer);
        IDataResult<ShowCustomerInfo> getCustomerİnfo(int id);
        IDataResult<Customer> ChangePassword(Customer customer);
        IResult bmıcalculate(Customer customer);
        IResult calculatecalory(Customer customer);
        IResult cıkısyap(Customer customer);
    

    }
}
