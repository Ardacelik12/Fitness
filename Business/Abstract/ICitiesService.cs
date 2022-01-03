using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public  interface ICitiesService
    {
        IDataResult<List<Cities>> GetAll();
        IDataResult<Cities> getById(int id);
        IDataResult<Searchh> Searchh(string s);
    }
}
