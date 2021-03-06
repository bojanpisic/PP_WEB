﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineMicroservice.DTOs
{
    public class InfoDto
    {
        public List<PassengerDto> Friends { get; set; }
        public List<UnregisteredDto> UnregisteredFriends { get; set; }
        [Required]
        public List<int> MySeatsIds { get; set; }
    }
}
