using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICampainService
    {
        IDataResult<List<Campain>> GetAll();
        IDataResult<List<Campain>> getByCategoryId(int id);
        IResult CampainPay(Order order);
    }
}
