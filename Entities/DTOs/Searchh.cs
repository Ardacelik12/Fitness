using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class Searchh:IDto
    {
        public Searchh(List<Programme> plist, List<Supplement> slist, List<Trainer> tlist)
        {
            this.plist = plist;
            this.slist = slist;
            this.tlist = tlist;
        }
        public List<Programme>  plist{ get; set; }
        public List<Supplement> slist { get; set; }
        public List<Trainer> tlist { get; set; }


    }
}
