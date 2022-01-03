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
    public class EfProgrammeDal : EfEntityRepositoryBase<Programme, FitnessCenterContext>, IProgrammeDal
    {
        public List<CustomerProgrammes> GetProgrammesByCustomerId(int id)
        {
            using (FitnessCenterContext context = new FitnessCenterContext())
            {

                var result = from p in context.Order
                             join c in context.Customer

                             on
                             p.Customerıd equals c.ID
                             join d in context.Programme on
                             p.Programmeıd equals d.ID

                             where c.ID == id
                             select new CustomerProgrammes
                             {
                                 Price = d.UnıtPrice,
                                 CustomerName = c.CustomerName,
                                 CustomerSurname = c.CustomerSurname,
                                 ProgrammeName = d.ProgrammeName,
                                 ImagesLink = d.ImagesLink
                                 

                             };

                return result.ToList();


            }
        }
    }
}

      
    
