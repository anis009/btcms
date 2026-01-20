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
    public partial class Seat_Availability : Form
    {
        private readonly ErrorProvider errorProvider;

        // In-memory booking store keyed by "Bus|Route|yyyy-MM-dd" -> set of booked seat ids
        private static readonly Dictionary<string, HashSet<string>> _bookedSeats = new Dictionary<string, HashSet<string>>();

        // Persist booked records for reference
        private static readonly List<Booking> _bookings = new List<Booking>();

        // Canonical seat list
        private static readonly string[] _allSeats = {
            "A1","A2","A3","A4","A5",
            "B1","B2","B3","B4","B5",
            "C1","C2","C3","C4","C5"
        };

        public Seat_Availability()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.NeverBlink };

            // Set sensible date range
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;

            // Wire event handlers
            comboBox1.SelectedIndexChanged += Inputs_Changed;
            comboBox2.SelectedIndexChanged += Inputs_Changed;
            dateTimePicker1.ValueChanged += Inputs_Changed;
        }

        private void Seat_Availability_Load(object sender, EventArgs e)
        {
            UpdateAvailableSeats();
        }

        // When Bus / Route / Date changes, update available seats
        private void Inputs_Changed(object sender, EventArgs e)
        {
            errorProvider.Clear();
            UpdateAvailableSeats();
        }

        // Update available seats based on selection
        private void UpdateAvailableSeats()
        {
            var bus = (comboBox1.SelectedItem ?? string.Empty).ToString();
            var route = (comboBox2.SelectedItem ?? string.Empty).ToString();
            var date = dateTimePicker1.Value.Date;

            comboBox3.Items.Clear();

            if (string.IsNullOrEmpty(bus) || string.IsNullOrEmpty(route))
            {
                // No selection yet; add all seats
                comboBox3.Items.AddRange(_allSeats);
                return;
            }

            var key = BookingKey(bus, route, date);
            var booked = _bookedSeats.ContainsKey(key) ? _bookedSeats[key] : new HashSet<string>();

            foreach (var seat in _allSeats)
            {
                if (!booked.Contains(seat))
                {
                    comboBox3.Items.Add(seat);
                }
            }
        }

        // Confirm booking button
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.Clear();

                var bus = (comboBox1.SelectedItem ?? string.Empty).ToString().Trim();
                var route = (comboBox2.SelectedItem ?? string.Empty).ToString().Trim();
                var date = dateTimePicker1.Value.Date;
                var seat = (comboBox3.SelectedItem ?? string.Empty).ToString().Trim();
                var fareText = (comboBox4.SelectedItem ?? string.Empty).ToString().Trim();

                // Validate inputs
                if (string.IsNullOrEmpty(bus))
                {
                    errorProvider.SetError(comboBox1, "Please select a bus/company.");
                    comboBox1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(route))
                {
                    errorProvider.SetError(comboBox2, "Please select a route.");
                    comboBox2.Focus();
                    return;
                }

                if (date < DateTime.Today)
                {
                    errorProvider.SetError(dateTimePicker1, "Journey date cannot be in the past.");
                    dateTimePicker1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(seat))
                {
                    errorProvider.SetError(comboBox3, "Please select a seat.");
                    comboBox3.Focus();
                    return;
                }

                if (!decimal.TryParse(fareText, out var fare))
                {
                    errorProvider.SetError(comboBox4, "Please select a valid fare.");
                    comboBox4.Focus();
                    return;
                }

                var key = BookingKey(bus, route, date);

                if (!_bookedSeats.TryGetValue(key, out var booked))
                {
                    booked = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                    _bookedSeats[key] = booked;
                }

                if (booked.Contains(seat))
                {
                    errorProvider.SetError(comboBox3, "Selected seat is already booked for this bus/route/date.");
                    comboBox3.Focus();
                    return;
                }

                // Perform booking
                booked.Add(seat);
                var booking = new Booking
                {
                    BusNumber = bus,
                    Route = route,
                    JourneyDate = date,
                    SeatNumber = seat,
                    Fare = fare,
                    PassengerName = "Guest" // Can be extended to capture passenger info
                };
                _bookings.Add(booking);

                MessageBox.Show(
                    $"Booking Confirmed!\n\nBus: {bus}\nRoute: {route}\nDate: {date.ToShortDateString()}\nSeat: {seat}\nFare: {fare:C}\nBooking ID: {booking.BookingId}",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Reset form
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            errorProvider.Clear();
            UpdateAvailableSeats();
        }

        private string BookingKey(string bus, string route, DateTime date)
        {
            return $"{bus}|{route}|{date:yyyy-MM-dd}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
