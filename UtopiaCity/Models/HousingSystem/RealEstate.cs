﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtopiaCity.Models.HousingSystem
{
    public class RealEstate
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        [Display(Name = "House type")]
        public EstateType Type { get; set; }
        [Required]
        [Display(Name = "House address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "House owner")]
        public string Owner { get; set; }
        public List<Resident> Residents { get; set; }
    }
    public enum EstateType
    {
        Apartment,
        PrivateHouse,
        Dormitory
    }
}
