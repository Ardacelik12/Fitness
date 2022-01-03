using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ISupplementManager : ISupplementService
    {

        ISupplementDal _ISupplementDal;
        IOrderService _orderService;
        ICustomerDal _customerdal;
        public ISupplementManager(ISupplementDal ISupplementDal, IOrderService IOrderService, ICustomerDal cs2)
        {
            
            _ISupplementDal = ISupplementDal;
            _orderService = IOrderService;
            _customerdal = cs2;
        }
        public IDataResult<List<Supplement>> GetAll()
        {
            return new SuccessDataResult<List<Supplement>>(_ISupplementDal.GetAll(), Messages.SupplementListed);
        }

        public IResult SupplementPay(Order order)
        {
            Customer cs = _customerdal.get(p => p.ID == order.Customerıd);
            if (cs.Login == 1)
            {
                order.Campainıd = 0;
                order.Programmeıd = 0;
                _orderService.Add(order);

                return new SuccessResult(Messages.SupplementBought);
            }
            return new SuccessResult("satın alabilmek için giriş yapmanız gerekiyor");
        }
    }
}
