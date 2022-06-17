using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Powerline;
// readme
 
namespace Powerline
{
    public class PassengerCar : Vehicle
    {
        byte _PassengerCapacity = 6;
        byte _DeteriorationPercentagePerPassenger = 6;
        byte _NumberOfPassengers = 1;

        public byte NumberOfPassengers
        {
            get { return _NumberOfPassengers; }
            set
            {
                if (value > _PassengerCapacity || value < 0)
                {
                    Console.WriteLine("Cannot set NumberOfPassenger to the value specified {0} \n " +
                        "It should be greater or equal to 0 or less than {1} \n" +
                        "Setting to just 1", value, _PassengerCapacity);
                    _NumberOfPassengers = 1;
                }
                else
                {
                    _NumberOfPassengers = value;
                }
            }
        }

        public override float DistanceLeft()
        {
            float _BaseDistanceLeft;
            _BaseDistanceLeft = base.DistanceLeft();
            return (_BaseDistanceLeft * (100 - _NumberOfPassengers * _DeteriorationPercentagePerPassenger) / 100);
        }

        public override float MinutesToFullstop()
        {
            float _MinutesToFullstop;
            _MinutesToFullstop = DistanceLeft() / _CurrentSpeed * 60;
            return _MinutesToFullstop;
        }
    }
}
