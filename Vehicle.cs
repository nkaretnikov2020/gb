using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerline
{
    public abstract class Vehicle
    {
        protected byte _AverageFuelConsumptionPer100;          //per 100km
        protected byte _FuelTankCapacity, _CurrentSpeed;
        protected byte _FuelLeftPercentage;

        public Vehicle()
        {
            _AverageFuelConsumptionPer100 = 1;  // default value
            _FuelTankCapacity = 1;              // default value
        }

        public Vehicle( byte AverageFuelConsumptionPer100, byte FuelTankCapacity, 
                        byte CurrentSpeed, byte FuelLeftPercentage)
        {
            _AverageFuelConsumptionPer100 = AverageFuelConsumptionPer100;
            _FuelTankCapacity = FuelTankCapacity;
            _CurrentSpeed = CurrentSpeed;
            _FuelLeftPercentage = FuelLeftPercentage;
        }

        public byte AverageFuelConsumptionPer100
        {
            get { return _AverageFuelConsumptionPer100; }
            set { _AverageFuelConsumptionPer100 = value; }
        }
        public byte FuelTankCapacity
        {
            get { return _FuelTankCapacity; }
            set { _FuelTankCapacity = value; }
        }
        public byte CurrentSpeed
        {
            get { return _CurrentSpeed; }
            set { _CurrentSpeed = value; }
        }
        public byte FuelLeftPercentage
        {
            get { return _FuelLeftPercentage; }
            set { _FuelLeftPercentage = value; }
        }

        virtual public float DistanceLeft()
        {
            float _DistanceLeft;
            _DistanceLeft = _FuelTankCapacity * _FuelLeftPercentage / _AverageFuelConsumptionPer100;
            return _DistanceLeft;
        }

        virtual public float MinutesToFullstop()
        {
            float _MinutesToFullstop;
            _MinutesToFullstop = DistanceLeft() / _CurrentSpeed* 60;
            return _MinutesToFullstop;
        }

}

}
