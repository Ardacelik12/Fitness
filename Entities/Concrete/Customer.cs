using Core.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer :IEntity
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string  Email { get; set; }
        public string PhoneNumber { get; set; }
       
        public string Height { get; set; }
        public string Weight { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; } 
        public  int CityID { get; set; }
        public int DateOfBirth { get; set; }
        public string BodyMassİndex { get; set; }
        public int Age { get; set; }
        public int Login { get; set; }

    }
}
