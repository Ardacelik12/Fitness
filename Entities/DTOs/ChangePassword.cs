using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ChangePassword : IDto
    {
        public string Email { get; set; }

    }
}
     
