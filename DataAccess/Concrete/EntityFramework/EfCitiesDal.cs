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
    public class EfCitiesDal : EfEntityRepositoryBase<Cities, FitnessCenterContext>, ICitiesDal
    {


        public List<Search> Search()
        {

            {
                using (FitnessCenterContext context = new FitnessCenterContext())
                {

                    var result = from p in context.Supplement
                                 join c in context.Trainer

                                 on
                                 p.ID equals c.ID
                                 join d in context.Programme on
                                 p.ID equals d.ID


                                 select new Search
                                 {

                                     ProgrammeName = d.ProgrammeName,
                                     SupplementName = p.SupplementName,
                                     TrainerName = c.trainer


                                 };

                    return result.ToList();


                }
            }
        }
    }
}

