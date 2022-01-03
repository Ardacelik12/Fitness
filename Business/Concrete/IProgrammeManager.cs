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
    public class IProgrammeManager : IProgrammeService
    {
        IProgrammeDal _IProgrammeDal;
        IOrderService _orderService;
        ICustomerService _customerService;
        ICustomerDal _customerdal;
        public IProgrammeManager(IProgrammeDal IProgrammeDal, IOrderService IOrderService,ICustomerService cs,ICustomerDal cs2)
        {
            _IProgrammeDal = IProgrammeDal;
            _orderService = IOrderService;
            _customerService = cs;
            _customerdal = cs2;
        }
        public IResult ProgrammePay(Order order)
        {
            Customer cs = _customerdal.get(p => p.ID == order.Customerıd);
            List<Order> item = _orderService.getall().Data;
            foreach (var c in item)
            {
                if (order.Customerıd == c.Customerıd && order.Programmeıd == c.Programmeıd)
                {
                    return new ErrorResult("kullanıcı bu programı almıs");

                } }
            if (cs.Login == 1)
            {
                order.Campainıd = 0;
                order.Supplementıd = 0;
                _orderService.Add(order);
                return new SuccessResult(Messages.ProgrammeBought);
            }
            return new SuccessResult("satın alabilmek için giriş yapmanız gerekiyor");
        }

        public IDataResult<List<Programme>> GetAll()
        {
           
            return new SuccessDataResult<List<Programme>>(_IProgrammeDal.GetAll());
        }

        public IDataResult<List<Programme>> getByCategoryId(int id)
        {
            if (id > 4 )
            {

                return new ErrorDataResult<List<Programme>>(Messages.ProgrammeError);
            }
            return new SuccessDataResult<List<Programme>>(_IProgrammeDal.GetAll(p => p.Type == id));
        }

        public IDataResult<List<CustomerProgrammes>> GetProgrammesByCustomerId(int id)
        {
           
      return new SuccessDataResult<List<CustomerProgrammes>>(_IProgrammeDal.GetProgrammesByCustomerId(id),Messages.CustomerProgrammes);
        }

        public IResult ProgrammeDelete(Order order)
        {
            List<Order> item = _orderService.getall().Data;
            foreach (var c in item)
            {
                if(order.Customerıd==c.Customerıd && order.Programmeıd == c.Programmeıd)
                {
                    _orderService.delete(c);
                    return new SuccessResult(Messages.ProgrammeCancelled);
                }

            }
            return new ErrorResult();
        
        }

        
    }
    }

