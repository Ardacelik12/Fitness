using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ICitiesManager : ICitiesService
    {
        ICitiesDal _ICitiesDal;
        IProgrammeService _IProgrammeService;
        ITrainerService _ITrainerService;
        ISupplementService _ISupplementService;
        
        public ICitiesManager(ICitiesDal ICitiesDal,IProgrammeService ProgrammeService,ITrainerService TrainerService,ISupplementService SupplementService)
        {
            _ICitiesDal = ICitiesDal;
            _IProgrammeService = ProgrammeService;
            _ITrainerService = TrainerService;
            _ISupplementService = SupplementService;
           
        }
        public IDataResult<List<Cities>> GetAll()
        {
            return new SuccessDataResult<List<Cities>>(_ICitiesDal.GetAll());
        }

        public IDataResult<Cities> getById(int id)
        {
            return new SuccessDataResult<Cities>(_ICitiesDal.get(p => p.ID == id));
        }

      

        public IDataResult<Searchh> Searchh(string s)
        {
            List<Programme> plist = new List<Programme>();
            List<Supplement> slist = new List<Supplement>();
            List<Trainer> tlist = new List<Trainer>();

            List<Programme> pdlist = _IProgrammeService.GetAll().Data;
            List<Supplement> sdlist = _ISupplementService.GetAll().Data;
            List<Trainer> tdlist = _ITrainerService.GetAll().Data;

            foreach (var programme in pdlist)
            {
                if (programme.ProgrammeName.Contains(s))
                {
                    plist.Add(programme);
                }
            }
            foreach (var supplement in sdlist)
            {
                if (supplement.SupplementName.Contains(s))
                {
                    slist.Add(supplement);
                }
            }
            foreach ( var trainer in tdlist)
            {
                if (trainer.trainer.Contains(s))
                {
                    tlist.Add(trainer);
                }
            }

            return new SuccessDataResult<Searchh>(new Searchh(plist,slist,tlist));

        }
    }
}
