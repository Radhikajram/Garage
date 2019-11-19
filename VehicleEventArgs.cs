using System;

namespace VehicleGarage
{
    public class VehicleEventArgs : EventArgs
    {
        public Vehicle vehicle { get; set; }
        public string Message { get; set; }
    }
}