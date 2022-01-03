using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IOrderService
    {
        IResult Add(Order order);
        IResult delete(Order order);
        IDataResult<List<Order>> getall();
    }
}
