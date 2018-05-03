using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        double NewGlbKm = 0;
        double NewLclKm = 0;
        public double FuelCapacity { get; set; }
        public double FuelUsage { get; set; }
        public double CurrentFuel { get; set; }
        private double _globalKm;
        private double _localKm;

        public void Drive(double km)
        {
            //if ((this.CurrentFuel *(10/this.FuelUsage))>= km)
                this.CurrentFuel -= km * (this.FuelUsage / 10);
                NewGlbKm += km;
                NewLclKm += km;
                this._globalKm += NewGlbKm;
                this._localKm += NewLclKm;
        }
        public void AddFuel(double AddedFuel)
        {
            this.CurrentFuel += AddedFuel;
        }
        public double  LocalKmShow()
        {
            return NewLclKm;
        }
        public void LocalKmZero()
        {
            NewLclKm = 0;
        }
       public double GlobalKmShow()
        { 
            return NewGlbKm;
        }

    }
}
