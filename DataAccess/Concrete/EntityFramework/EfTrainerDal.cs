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
    public class EfTrainerDal : EfEntityRepositoryBase<Trainer, FitnessCenterContext>, ITrainerDal
    {
         
        
        public ShowTrainerInfo GetTrainerİnfo(int ıd)
        {
            using (FitnessCenterContext context = new FitnessCenterContext())
            {

                var result = from p in context.Trainer
                             join c in context.Cities

                             on
                             p.CityID equals c.ID

                             where p.ID == ıd
                             select new ShowTrainerInfo
                             {

                                 trainer = p.trainer,
                                 trainerSurname = p.trainerSurname,
                                 PhoneNumber = p.PhoneNumber,
                                 Email = p.Email,
                                 DateOfBirth = p.DateOfBirth,
                                 TrainerAbility = p.TrainerAbility,
                                 CityName
                             = c.CityName
                             };

                return result.FirstOrDefault();
            

            }

    }
} }




