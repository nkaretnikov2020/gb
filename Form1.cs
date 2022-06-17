using System;
using System.Collections.Generic;
using Powerline;

namespace Powerline
{
    public partial class PowerlinePilot : Form
    {
        public PowerlinePilot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PassengerCar MyPS = new()
            {
                CurrentSpeed = (byte)numCurrentSpeed.Value,
                FuelTankCapacity = (byte)numFuelTankCapacity.Value,
                FuelLeftPercentage = (byte)numFuelLeftPercentage.Value,
                AverageFuelConsumptionPer100 = (byte)numAverageFuelConsumptionPer100.Value,
                NumberOfPassengers = (byte)numNumberOfPassengers.Value
            };

            lblDistanceLeft.Text = MyPS.DistanceLeft().ToString("0");
            lblMinutesToFullstop.Text = MyPS.MinutesToFullstop().ToString("0");
            //Console.WriteLine("Passenger car will go another: {0} km.", MyPS.DistanceLeft());
            //Console.WriteLine("Passenger car will go for another: {0} min.", MyPS.MinutesToFullstop());
//            Console.WriteLine("Truck will go another: {0} km.", MyT.DistanceLeft());
 //           Console.WriteLine("Truck will go for another: {0} min.", MyT.MinutesToFullstop());
        }

        private void lblDistanceLeft_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAverageFuelConsumptionPer100_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // comment
            Truck MyT = new()
            {
                CurrentSpeed = (byte)numTCurrentSpeed.Value,
                FuelTankCapacity = (byte)numTFuelTankCapacity.Value,
                FuelLeftPercentage = (byte)numTFuelLeftPercentage.Value,
                AverageFuelConsumptionPer100 = (byte)numTAverageFuelConsumptionPer100.Value,
                CurrentLoad = (int)numTCurrentLoad.Value
            };
            lblTDistanceLeft.Text = MyT.DistanceLeft().ToString("0");
            lblTMinutesToFullstop.Text = MyT.MinutesToFullstop().ToString("0");
        }
    }
}