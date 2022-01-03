using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   
    public class IOrderManager : IOrderService
    {
        IOrderDal _IOrderDal;
        public IOrderManager(IOrderDal IOrderDal)
        {
            _IOrderDal = IOrderDal;
        }
        public IResult Add(Order order)
        {
            _IOrderDal.Add(order);

            return new SuccessResult();
        }

        public IResult delete(Order order)
        {
            _IOrderDal.Delete(order);
            return new SuccessResult();
        }

        public IDataResult<List<Order>> getall()
        {
            return new SuccessDataResult<List<Order>>(_IOrderDal.GetAll());
        }
    }
}
