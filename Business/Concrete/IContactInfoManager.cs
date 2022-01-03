using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace Business.Concrete
{
    public class IContactInfoManager : IContactInfoService
    {
        IContactInfoDal _IBlogPostDal;
        public IContactInfoManager(IContactInfoDal IBlogPostDal)
        {
            _IBlogPostDal = IBlogPostDal;
        }

        public IResult ContactUs(ContactDto contactdto)
        {
            var success = false;
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress(contactdto.name +" - " +contactdto.Email , "celikarda813@gmail.com"));
            message.To.Add(MailboxAddress.Parse("abdurrahmanresmi@gmail.com"));
            message.Subject = "password change ";
            message.Body = new TextPart("plain")
            {
                Text = @"  " + contactdto.message
            };
            SmtpClient Client = new SmtpClient();
            try
            {
                Client.Connect("smtp.gmail.com", 465, true);
                Client.Authenticate("celikarda813@gmail.com", "arda070707");
                Client.Send(message);
                success = true;
            }
            catch (Exception)
            {

                return new ErrorResult("mesaj gönderilemedi"); 
            }
            finally
            {
                Client.Disconnect(true);
                Client.Dispose();
               
            }
            if (success)
            {
                return new SuccessResult("Mesaj gönderildi");
            }
            return new ErrorResult("mesaj gönderilemedi");

        }

        public IDataResult<List<GetContactInfo>> GetAll()
        {

            return new SuccessDataResult<List<GetContactInfo>>(_IBlogPostDal.GetContactInfo());
        }

    }
}
