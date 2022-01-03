using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CustomerProgrammes :IDto
    {
        
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string ProgrammeName { get; set; }
        public string ImagesLink { get; set; }
        public int  Price { get; set; }
    }
}
