﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static forestApi.Models.Trail;

namespace forestApi.Models.Dtos
{
    public class TrailDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Distance { get; set; }

        public DifficultyType Difficulty { get; set; }
        [Required]
        public int NationalParkId { get; set; }

        public NationalParkDto NationalPark { get; set; }
        [Required]
        public double Elevation { get; set; }
    }
}
