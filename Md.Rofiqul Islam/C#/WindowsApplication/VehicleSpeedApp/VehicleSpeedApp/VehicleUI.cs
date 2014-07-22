using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleSpeedApp
{
    public partial class VehicleUI : Form
    {
        public VehicleUI()
        {
            InitializeComponent();
        }

        Vehicle aVehicle=new Vehicle();
        private void createButton_Click(object sender, EventArgs e)
        {
            aVehicle.vehicleName = vehicleTextBox.Text;
            aVehicle.regNo = regNoTextBox.Text;
            vehicleTextBox.Text = "";
            regNoTextBox.Text = "";
            string msg = aVehicle.CreateVehicle();
            MessageBox.Show(msg);

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            aVehicle.speed = Convert.ToDouble(speedTextBox.Text);
            string msg = aVehicle.Speed();
            aVehicle.numberOfSpeed= aVehicle.NumberOfSpeed();
            aVehicle.sumOfSpeed=  aVehicle.SumOfSpeed();
            MessageBox.Show(msg);
            speedTextBox.Text = "";



        }

        private void showButton_Click(object sender, EventArgs e)
        {
           
            minSpeedTextBox.Text = aVehicle.MinSpeed().ToString();
            maxSpeedTextBox.Text = aVehicle.MaxSpeed().ToString();
            averageSpeedTextBox.Text = aVehicle.AvgSpeed().ToString();

        }
    }
}
