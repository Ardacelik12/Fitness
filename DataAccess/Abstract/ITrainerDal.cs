using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ITrainerDal :IEntityRepository<Trainer>
    {
        // Trainer ShowTrainerİnfo(Expression<Func<Trainer, bool>> filter);
       ShowTrainerInfo GetTrainerİnfo(int ıd);
    }
}
