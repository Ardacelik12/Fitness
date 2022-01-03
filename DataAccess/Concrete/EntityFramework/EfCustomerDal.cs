using Core.DataAccess.EntityFramework;

using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, FitnessCenterContext>, ICustomerDal
    {
        

        public ShowCustomerInfo ShowCustomerInfoByCustomerId(int id)
        {
            using (FitnessCenterContext context = new FitnessCenterContext())
            {

                var result = from p in context.Customer
                             join c in context.Cities

                             on
                             p.CityID equals c.ID

                             where p.ID == id
                             select new ShowCustomerInfo
                             {
                                 CustomerName = p.CustomerName,
                                 CustomerLastName = p.CustomerSurname,
                                 Email = p.Email,
                                 PhoneNumber=p.PhoneNumber,
                                 CityName =c.CityName
                                 
                             };

                return result.FirstOrDefault();


            }
           
                

            }



    }
}

