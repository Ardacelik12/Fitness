using Business.Abstract;
using Business.Constants;
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
    public class ICustomerManager : ICustomerService
    {

        ICustomerDal _customerdal;
        public ICustomerManager(ICustomerDal ICustomerDal)
        {
            _customerdal = ICustomerDal;
        }
        public IResult Add(Customer customer)
        {
            if(customer.Email != null && customer.Password != null)
            {
                customer.Login = 0;
                _customerdal.Add(customer);

                return new SuccessResult("kayıt başarılı");
            }
            return new ErrorResult("basarısız kayıt");
           
        }

        public IResult DeleteMyAccount(Customer customer)
        {
            _customerdal.Delete(customer);
            return new SuccessResult("hesabınız silindi");
        }
        public IResult UpdateMyAccount(Customer customer)
        {
            customer.Login = 1;
            _customerdal.Update(customer);
            return new SuccessResult("hesabınız güncellendi");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerdal.GetAll());
        }

      
        public IDataResult<Customer> login(Customer customer)
        {
            Customer toCheck = null;
            List<Customer> cs = _customerdal.GetAll();
            
            foreach(var c in cs)
            {
             
                if (c.Email.Equals(customer.Email))
                {
                    toCheck = c;
                    break;
                }
            }
            if(toCheck != null)
            if (toCheck.Password.Equals(customer.Password))
            {
                    toCheck.Login = 1;
                    _customerdal.Update(toCheck);
                    return new SuccessDataResult<Customer>(toCheck,"giris onaylandı");
            }
            toCheck.Login = 0;
            return new ErrorDataResult<Customer>("giris basarısız");
        }

        public IDataResult<ShowCustomerInfo> getCustomerİnfo(int id)
        {
            return new SuccessDataResult<ShowCustomerInfo>(_customerdal.ShowCustomerInfoByCustomerId(id), Messages.customerinfoshowed);
        }

        public IDataResult<Customer> ChangePassword(Customer customer)
        {
           
            var result = _customerdal.get(p => p.Email == customer.Email);
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Tester", "celikarda813@gmail.com"));
            message.To.Add(MailboxAddress.Parse(customer.Email));
            Random rastgele = new Random();   
            int sayi = rastgele.Next(1000, 10000);
            result.Password = sayi.ToString();
            _customerdal.Update(result);
            message.Subject = "password change ";
            message.Body = new TextPart("plain")
            {
                Text = @"yeni sifreniz : " + result.Password
            };
            SmtpClient Client = new SmtpClient();
            try
            {
                Client.Connect("smtp.gmail.com", 465, true);
                Client.Authenticate("celikarda813@gmail.com", "arda070707");
                Client.Send(message);
            }
            catch (Exception )
            {

                throw;
            }finally
            {
                Client.Disconnect(true);
                Client.Dispose();
            }
            return new SuccessDataResult<Customer>(result.Password);
            
        }

        public IResult bmıcalculate(Customer customer)
        {
            List<Customer> cs = _customerdal.GetAll();
            foreach (var item in cs)
            {
                if(item.Weight.Equals(customer.Weight) && item.Height.Equals(customer.Height))
                {
                    double weight = Convert.ToDouble(customer.Weight);
                    double height = Convert.ToDouble(customer.Height);
                    double vki = (weight /Math.Pow(height,2))*10000;
                    
                    item.BodyMassİndex = Convert.ToString(vki);
                    _customerdal.Update(item);
                    if (Convert.ToDouble(item.BodyMassİndex) < 30)
                    {
                        return new SuccessResult("normal kilodasasınız :" + item.BodyMassİndex );
                    }
                    return new SuccessResult("kilolusunuz :" + item.BodyMassİndex );
                   
                }
                
            }
            return new ErrorResult("yalnış boy ve kilo bilgileri girdiniz");
        }

        public IResult calculatecalory(Customer customer)
        {
            List<Customer> cs = _customerdal.GetAll();
            foreach (var item in cs)
            {
                if (item.Weight.Equals(customer.Weight) && item.Height.Equals(customer.Height) && item.Age.Equals(customer.Age))
                {

                    var calory = 66 + (13.75 * Convert.ToDouble(customer.Weight)) + (5 * Convert.ToDouble(customer.Height)) - (6.8 * customer.Age);
                    return new SuccessResult("günlük kalori ihtiyacınız : " + calory);
                }

            }
            return new ErrorResult("bilgilerinizi yalnış girdiniz");
        }

        public IResult cıkısyap(Customer customer)
        {
          
            List<Customer> customer2 = _customerdal.GetAll();
            foreach (var c in customer2)
            {

                if (c.Email.Equals(customer.Email))
                {

                    c.Login = 0;
                    _customerdal.Update(c);
                    return new SuccessResult("cıkıs yapıldı");
                }
            }
            return new ErrorResult("yalnıs bir eposta adresi girdiniz");


        }
    }
}
