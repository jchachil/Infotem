//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TUIBackEnd.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flight
    {
        public int Id { get; set; }
        public int DepartureAirportId { get; set; }
        public int DestinationAirportId { get; set; }
        public double FlightDistance { get; set; }
        public double AirCratfFuelComsumpDistance { get; set; }
        public double FlightTime { get; set; }
        public double TakeOffEffort { get; set; }
        public double FuelNeeded { get; set; }
    
        public virtual Airport Airport { get; set; }
        public virtual Airport Airport1 { get; set; }
    }
}
