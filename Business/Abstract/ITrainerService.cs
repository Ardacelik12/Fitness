using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITrainerService
    {
        IDataResult<List<Trainer>> GetAll();
        IDataResult<Trainer> getById(int id);
        IDataResult<ShowTrainerInfo> getTrainerİnfo(int id);


    }
}
