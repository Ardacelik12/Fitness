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
    public class IBlogPostManager : IBlogPostService
    {
        IBlogPostDal _IBlogPostDal;
        public IBlogPostManager(IBlogPostDal IBlogPostDal)
        {
            _IBlogPostDal  = IBlogPostDal;
        }

        public IDataResult<BlogPost> getById(int id)
        {
            return new SuccessDataResult<BlogPost>(_IBlogPostDal.get(p => p.ID == id), Messages.BlogListId);
        }

        public IDataResult<List<BlogPost>> GetAll()
        {
            return new SuccessDataResult<List<BlogPost>>(_IBlogPostDal.GetAll(), Messages.BlogList);
        }
    }
}
