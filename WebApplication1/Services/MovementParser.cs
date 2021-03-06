﻿namespace BMS.Services
{
    using BMS.Data.DTO.MovementsDTO;
    using BMS.Services.Contracts;
    using BMS.Services.ParserUtility.UtilityContracts;
    using BMS.Services.Utility.UtilityContracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class MovementParser : IMovementParser
    {
        private readonly IFlightDataValidation _flightDataValidation;
        private readonly IParserArrivalMovementUtility _arrivalMovementUtility;
        private readonly IParserDepartureMovementUtility _departureMovementUtility;
        private readonly IFlightService _flightsService;
        private readonly IMovementService _movementService;

        public MovementParser(IFlightDataValidation flightDataValidation, 
            IParserArrivalMovementUtility arrivalMovementUtility,IParserDepartureMovementUtility departureMovementUtility,
            IFlightService flightsService,
            IMovementService movementService)
        {
            _flightDataValidation = flightDataValidation;
            _arrivalMovementUtility = arrivalMovementUtility;
            _departureMovementUtility = departureMovementUtility;
            _flightsService = flightsService;
            _movementService = movementService;
        }

        public async Task<bool> ParseArrivalMovement(string messageData)
        {
            string[] splitMessage =
                messageData.Split("\r\n", StringSplitOptions.None);

            if (_flightDataValidation.IsArrivalMovementFlightDataValid(splitMessage))
            {
                string[] flightData = _arrivalMovementUtility.GetMovementFlightData(splitMessage[1]); 
                var inboundFlightByFlightNumber = await _flightsService.GetInboundFlightByFlightNumber(flightData[0]);
                string[] arrivalMovementTimes = _arrivalMovementUtility.GetTimes(splitMessage[2]); 
                DateTime[] validMovementTime = _arrivalMovementUtility.ParseMovementTimes(arrivalMovementTimes, inboundFlightByFlightNumber);
                string supplementaryInformation = ParseSupplementaryInformation(splitMessage[3]);

                var arrivalMovementDTO = new ArrivalMovementDTO(validMovementTime, supplementaryInformation);

                await _movementService.CreateArrivalMovement(arrivalMovementDTO, inboundFlightByFlightNumber);
                return true; 
            }

            return false;
        }

        public async Task<bool> ParseDepartureMovement(string messageData)
        {
            string[] splitMessage = messageData
                .Split("\r\n", StringSplitOptions.None);

            if (_flightDataValidation.IsDepartureMovementFlightDataValid(splitMessage))
            {
                string[] flightData = _departureMovementUtility.GetMovementFlightData(splitMessage[1]);
                var outboundFlightByFlightNumber = await _flightsService.GetOutboundFlightByFlightNumber(flightData[0]);
                string supplementaryInformation = ParseSupplementaryInformation(splitMessage[splitMessage.Length - 1]);
                int totalPax = ParseTotalPax(splitMessage[3]);
                string[] times = _departureMovementUtility.GetTimes(splitMessage[2]);
                DateTime[] timesForDeparture = _departureMovementUtility.ParseMovementTimes(times, outboundFlightByFlightNumber);

                var departureMovementDTO = new DepartureMovementDTO(timesForDeparture, supplementaryInformation, totalPax);

               await _movementService.CreateDepartureMovement(departureMovementDTO,outboundFlightByFlightNumber);
               return true;
                
            }
            return false;
        }

        private string ParseSupplementaryInformation(string info)
        {
            string result = string.Empty;

            if (!info.Contains("NIL"))
            {
                string[] splitData = info
                    .Split("SI", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                return result = splitData[0];
            }

            result = "NIL";
            return result;
        }

        private int ParseTotalPax(string pax)
        {
            return int.Parse(pax.Remove(0, 3));
        }
    }
}
