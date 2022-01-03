
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Trainer :IEntity
    {
        public int ID { get; set; }
        public string trainer { get; set; }
        public string trainerSurname { get; set; }
        public string PhoneNumber { get; set; }
        public int DateOfBirth { get; set; }
        public string Email { get; set; }
        public  string TrainerAbility { get; set; }
        public int CityID { get; set; }
        public string ImagesLink { get; set; }
    }

}
