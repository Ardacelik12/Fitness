using Core.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Cities: IEntity
    {
        public int ID { get; set; }
        public  string CityName { get; set; }

    }
}
