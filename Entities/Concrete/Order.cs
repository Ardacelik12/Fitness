
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Order :IEntity
    {
        public int Id { get; set; }
        public int Customerıd { get; set; }
        public int Programmeıd { get; set; }
        public int Campainıd { get; set; }
        public int Supplementıd { get; set; }
    
    }
}
