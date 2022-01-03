using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class Search :IDto
    {
        public  string ProgrammeName { get; set; }
        public  string SupplementName { get; set; }
        public string  TrainerName { get; set; }
    }
}
