using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class ContactDto :IDto
    {
        public string name { get; set; }
       
        public string Email { get; set; }

        public string message { get; set; }

    }
}
