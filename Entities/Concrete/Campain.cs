using Core.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Campain: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public int PriceAfterDiscount { get; set; }
        public int Type { get; set; }
        public string ImagesLink { get; set; }
    }
}
