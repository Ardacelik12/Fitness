
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class BlogPost:IEntity
    {
        public int ID { get; set; }
        public  string Title { get; set; }
        public string Content { get; set; }
        public int Created_ad { get; set; }
        public  int  Created_by { get; set; }
        public string ImagesLink { get; set; }

    }
}
