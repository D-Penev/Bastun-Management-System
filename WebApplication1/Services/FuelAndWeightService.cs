﻿namespace BMS.Services
{
    using AutoMapper;
    using BMS.Data;
    using BMS.Data.Models;
    using BMS.Models;
    using BMS.Services.Contracts;
    using BMS.GlobalData.Validation;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebApplication1.Data;

    public class FuelAndWeightService : IFuelAndWeightService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IFlightService _flightService;
        private readonly IMapper _mapper;

        public FuelAndWeightService(ApplicationDbContext dbContext, IFlightService flightService, IMapper mapper)
        {
            _dbContext = dbContext;
            _flightService = flightService;
            _mapper = mapper;
        }
        public async Task<bool> AddFuelForm(FuelFormInputModel fuelFormInputModel)
        {
            if (FuelAndWeightValidation.IsFuelFormInputDataValid(fuelFormInputModel))
            {
                return false;
            }

            var outboundFlight = await _flightService.GetOutboundFlightByFlightNumber(fuelFormInputModel.FlightNumber);

            if (outboundFlight == null)
            {
                return false;
            }

            if (outboundFlight.Aircraft != null)
            {
                var newFuelForm = _mapper.Map<FuelForm>(fuelFormInputModel);

                newFuelForm.Aircraft = outboundFlight.Aircraft;
                newFuelForm.AircraftId = outboundFlight.AircraftId;


                outboundFlight.Aircraft.FuelForm = newFuelForm;
                outboundFlight.Aircraft.FuelFormId = newFuelForm.Id;

               await _dbContext.FuelForms.AddAsync(newFuelForm);
               await _dbContext.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<bool> AddWeightForm(WeightFormInputModel weightInputModel)
        {
            if (FuelAndWeightValidation.IsWeightInputDataValid(weightInputModel))
            {
                return false;
            }

            var outboundFlight = await _flightService.GetOutboundFlightByFlightNumber(weightInputModel.FlightNumber);

            if (outboundFlight == null)
            {
                return false;
            }

            if (outboundFlight != null)
            {
                var newWeightForm = _mapper.Map<WeightForm>(weightInputModel);

                newWeightForm.Aircraft = outboundFlight.Aircraft;
                newWeightForm.AircraftId = outboundFlight.Aircraft.AircraftId;
                outboundFlight.Aircraft.WeightForm = newWeightForm;
                outboundFlight.Aircraft.WeightFormId = newWeightForm.Id;

                await _dbContext.WeightForms.AddAsync(newWeightForm);
                await _dbContext.SaveChangesAsync();

                return true;
            }

            return false;
        }
    }
}
