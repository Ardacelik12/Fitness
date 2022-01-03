using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class BMI :IDto
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public double vki { get; set; }
    }
}
