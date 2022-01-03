using Core.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class MyProgrammes :IEntity
    {
        public int Id { get; set; }
        public int ProgrammeId { get; set; }
        public int CustomerId { get; set; }
        public string ImagesLink { get; set; }
    }
}
