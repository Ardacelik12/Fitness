using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class GetContactInfo :IDto
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public string CityName { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
    }
}
