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
    public class EfContactInfoDal : EfEntityRepositoryBase<ContactInfo, FitnessCenterContext>, IContactInfoDal
    {
        public List<GetContactInfo> GetContactInfo()
        {


            using (FitnessCenterContext context = new FitnessCenterContext())
            {

                var result = from p in context.Contactİnfo
                             join c in context.Cities

                             on
                             p.CityId equals c.ID
                             select new GetContactInfo { Id = p.Id, Adress = p.Adress, Mail = p.Mail, PhoneNumber = p.PhoneNumber, CityName = c.CityName };
                return result.ToList();








            }
        }
    }
}
    

