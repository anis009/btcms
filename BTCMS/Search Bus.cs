using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCMS
{
    public partial class Search_Bus : Form
    {
        private readonly ErrorProvider errorProvider;
        private readonly List<Bus> _buses;
        
        public Search_Bus()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.NeverBlink };
            dateTimePicker2.MinDate = DateTime.Today;
            
            // sample data for demo — replace with DB/API calls as needed
            _buses = new List<Bus>
            {
                new Bus("R001", "B-101", "Green Line", new TimeSpan(08, 00, 0), new TimeSpan(12, 30, 0), 800m),
                new Bus("R001", "B-102", "Ena", new TimeSpan(20, 30, 0), new TimeSpan(01, 30, 0), 750m),
                new Bus("R002", "B-201", "Shohag", new TimeSpan(09, 00, 0), new TimeSpan(13, 00, 0), 500m)
            };
        }

        private void Search_Bus_Load(object sender, EventArgs e)
        {
            // Set default date to today
            dateTimePicker2.Value = DateTime.Today;
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.Clear();
                
                string routeID = txtRouteID.Text.Trim();
                DateTime journeyDate = dateTimePicker2.Value.Date;
                
                // Validate Route ID
                if (string.IsNullOrEmpty(routeID))
                {
                    errorProvider.SetError(txtRouteID, "Please enter a Route ID.");
                    txtRouteID.Focus();
                    return;
                }
                
                // Filter buses by route ID
                var filteredBuses = _buses.Where(b => b.RouteId.Equals(routeID, StringComparison.OrdinalIgnoreCase)).ToList();
                
                // Clear existing rows
                dataGridView2.Rows.Clear();
                
                if (filteredBuses.Count == 0)
                {
                    MessageBox.Show($"No buses found for Route ID: {routeID}", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                // Populate DataGridView
                foreach (var bus in filteredBuses)
                {
                    dataGridView2.Rows.Add(
                        bus.BusNumber,
                        bus.CompanyName,
                        bus.DepartureTime.ToString(@"hh\:mm"),
                        bus.ArrivalTime.ToString(@"hh\:mm"),
                        bus.Fare.ToString("C")
                    );
                }
                
                MessageBox.Show($"Found {filteredBuses.Count} bus(es) for Route {routeID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtRouteID, string.Empty);
        }

        private void lblSEARCHBUS_Click(object sender, EventArgs e)
        {

        }
    }
}
