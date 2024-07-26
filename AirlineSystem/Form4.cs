using System.Linq;
using System.Windows.Forms;
using System;

namespace AirlineSystem
{
    public partial class Form4 : Form
    {
        masterEntities masterEntities;

        public Form4()
        {
            InitializeComponent();
            masterEntities = new masterEntities();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FLIGHT flight = new FLIGHT
                {
                    AIRCRAFTID = nametxt.Text,
                    SOURCE = sourcetxt.Text,
                    DESTINATION = desttxt.Text,
                    DEPARTUREDATE = DateTime.Parse(deptxt.Text),
                    ARRIVALDATE = DateTime.Parse(arrtxt.Text),
                    FARE = decimal.Parse(faretxt.Text)
                };

                masterEntities.FLIGHTs.Add(flight);
                masterEntities.SaveChanges();
                MessageBox.Show("Flight added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string aircraftId = nametxt.Text;
                FLIGHT flight = masterEntities.FLIGHTs.SingleOrDefault(f => f.AIRCRAFTID == aircraftId);

                if (flight != null)
                {
                    flight.SOURCE = sourcetxt.Text;
                    flight.DESTINATION = desttxt.Text;
                    flight.DEPARTUREDATE = deptxt.Text;
                    flight.ARRIVALDATE = arrtxt.Text;
                    flight.FARE = (faretxt.Text).;

                    masterEntities.SaveChanges();
                    MessageBox.Show("Flight updated successfully!");
                }
                else
                {
                    MessageBox.Show("Flight not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string aircraftId = nametxt.Text;
                FLIGHT flight = masterEntities.FLIGHTs.SingleOrDefault(f => f.AIRCRAFTID == aircraftId);

                if (flight != null)
                {
                    masterEntities.FLIGHTs.Remove(flight);
                    masterEntities.SaveChanges();
                    MessageBox.Show("Flight deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Flight not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}