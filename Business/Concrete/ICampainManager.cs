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
    public class ICampainManager : ICampainService
    {
        ICampainDal _ICampainDal;
        IOrderService _orderService;
        ICustomerService _cs;
        ICustomerDal _customerdal;
        public ICampainManager(ICampainDal ICampainDal,IOrderService IOrderService,ICustomerService cs,ICustomerDal cs2)
        {
            _ICampainDal = ICampainDal;
            _orderService = IOrderService;
            _cs = cs;
            _customerdal = cs2;
        }
       
        public IResult CampainPay(Order order)
        {
            
           Customer cs = _customerdal.get(p => p.ID == order.Customerıd);
            if (cs.Login==1)
            {
                order.Supplementıd = 0;
                order.Programmeıd = 0;
                _orderService.Add(order);

                return new SuccessResult(Messages.CampainBought);
            }
            return new SuccessResult("satın alabilmek için giriş yapmanız gerekiyor");
           
        }

        public IDataResult<List<Campain>> GetAll()
        {
            return new SuccessDataResult<List<Campain>>(_ICampainDal.GetAll(), Messages.Campainlisted);
        }

        public IDataResult<List<Campain>> getByCategoryId(int type)
        {
            if(type >2)
            {

                return new ErrorDataResult<List<Campain>>(Messages.Campainerror);
            }
            return new SuccessDataResult<List<Campain>>(_ICampainDal.GetAll(p => p.Type == type));
        }
    }
}
