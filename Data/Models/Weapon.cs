﻿using System.ComponentModel.DataAnnotations;

namespace OpenCases.Data.Models
{
    public class Weapon
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }
    }
}
