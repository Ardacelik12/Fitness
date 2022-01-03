using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ITrainerManager : ITrainerService
    {

        ITrainerDal _ITrainerDal;
        public ITrainerManager(ITrainerDal ITrainerDal)
        {
            _ITrainerDal = ITrainerDal;
        }
        public IDataResult<List<Trainer>> GetAll()
        {
            return new SuccessDataResult<List<Trainer>>(_ITrainerDal.GetAll(),Messages.TrainerListed);
        }

        public IDataResult<Trainer> getById(int id)
        {
            return new SuccessDataResult<Trainer>(_ITrainerDal.get(p => p.ID == id),Messages.TrainerListId);
        }

        public IDataResult<ShowTrainerInfo> getTrainerİnfo(int id)
        {
            return new SuccessDataResult<ShowTrainerInfo>(_ITrainerDal.GetTrainerİnfo(id),Messages.TrainerİnfoShow);
        }
    }
}
