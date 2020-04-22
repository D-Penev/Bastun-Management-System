﻿namespace BMS.Services.Contracts
{
    using BMS.Data.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAircraftCabinBaggageHoldService
    {
        Task CreateCabinAndZones(OutboundFlight flight);

        Task CreateBaggageHoldAndCompartments(OutboundFlight flight);


    }
}
