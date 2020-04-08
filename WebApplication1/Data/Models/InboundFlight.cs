﻿namespace BMS.Data.Models
{
    using BMS.Data.Models.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class InboundFlight
    {
        public int FlightId { get; set; }

        public string FlightNumber { get; set; }

        public ArrivalMovement ArrivalMovement { get; set; }

        public DateTime STA { get; set; }

        public string Origin { get; set; }

        public virtual ICollection<Message> InboundMessages { get; set; }
    }
}