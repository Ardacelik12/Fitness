using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IContactInfoService
    {
        IDataResult<List<GetContactInfo>> GetAll();
        // mail yollama hallet contack us
        IResult ContactUs(ContactDto contactdto);
    }
}
