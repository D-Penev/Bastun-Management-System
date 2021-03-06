﻿namespace BMS.Data.Models
{
    using BMS.Data.Models.BaggageHolds.AircraftBaggageHolds;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class AircraftBaggageHold
    {
        public AircraftBaggageHold()
        {
            Compartments = new List<Compartment>();
        }

        [Key]
        public int BaggageHoldId { get; set; }

        [Required]
        public int AircraftId { get; set; }

        [Required]
        public virtual Aircraft Aircraft { get; set; }

        [Required]
        public virtual ICollection<Compartment> Compartments { get; set; }

    }
}
