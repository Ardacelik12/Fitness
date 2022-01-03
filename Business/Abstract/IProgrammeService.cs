using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IProgrammeService
    {
        IDataResult<List<Programme>> GetAll();
        IDataResult<List<Programme>> getByCategoryId(int id);
        IResult ProgrammePay(Order order);
        IDataResult<List<CustomerProgrammes>> GetProgrammesByCustomerId(int id);
        IResult ProgrammeDelete(Order order);
        
    }
}
