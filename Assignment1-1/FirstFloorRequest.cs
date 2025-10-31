using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_1
{
    public partial class FirstFloorRequest : Form
    {
        private readonly ElevatorController? _controller;

        public FirstFloorRequest()
        {
            InitializeComponent();
        }

        public FirstFloorRequest(ElevatorController controller) : this()
        {
            _controller = controller ?? throw new ArgumentNullException(nameof(controller));

            _controller.CurrentFloorChanged += OnCurrentFloorChanged;
            _controller.MovementStatusChanged += OnMovementChanged;

            UpdateDisplay(_controller.CurrentFloor);

            floor1Call.Click += (_, __) =>
            {
                _controller.LogCommand("Button pressed for floor 1", "Request", "User requested floor 1", "Location: 1"); // Calls the LogCommand method to log this command on MySQL
                _controller.RequestFloor(1); // Requests change in floor
            };
        }

        private void OnCurrentFloorChanged(int floor)
        {
            if (InvokeRequired) BeginInvoke(new Action(() => UpdateDisplay(floor)));
            else UpdateDisplay(floor);
        }

        private void OnMovementChanged(string status)
        {
            if (InvokeRequired) BeginInvoke(new Action(() => Display_1floor.Text = status));
            else Display_1floor.Text = status;
        }

        private void UpdateDisplay(int floor)
        {
            Display_1floor.Text = (floor == 1) ? "At 1st" : "At Ground";
        }

        private void floor1Call_Click(object sender, EventArgs e)
        {

        }

        private void Display_1floor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
