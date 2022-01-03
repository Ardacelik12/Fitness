
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Supplement :IEntity
    {
        public int ID { get; set; }
        public string SupplementName { get; set; }
        public int UnitPrice { get; set; }
        public int SupplementSize { get; set; }
        public string ImagesLink { get; set; }

    }
}
