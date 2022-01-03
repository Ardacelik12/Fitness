
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Programme :IEntity
    {
        public int ID { get; set; }
        public  string ProgrammeName { get; set; }
        public int Type { get; set; }
        public  int UnıtPrice  { get; set; }
        public int TrainerID { get; set; }
        public string ImagesLink { get; set; }

    }
}
