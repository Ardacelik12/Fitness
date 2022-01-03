using Core.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ContactInfo :IEntity
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public int CityId { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
    }
}
