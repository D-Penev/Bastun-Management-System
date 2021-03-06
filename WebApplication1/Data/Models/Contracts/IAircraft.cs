﻿namespace BMS.Data.Models.Contracts
{
    using BMS.Data.Models.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IAircraft
    {
        public int AircraftId { get; set; }

        public AircraftType Type { get; set; }

        public string AircraftRegistration { get; set; }

        public string Version { get; set; }

        public AircraftCabin Cabin { get; set; }

    }
}
