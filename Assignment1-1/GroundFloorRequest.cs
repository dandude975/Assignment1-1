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
    public partial class GroundFloorRequest : Form
    {
        private readonly ElevatorController? _controller;
        public GroundFloorRequest()
        {
            InitializeComponent();
        }

        public GroundFloorRequest(ElevatorController controller) : this()
        {
            _controller = controller ?? throw new ArgumentNullException(nameof(controller));

            _controller.CurrentFloorChanged += OnCurrentFloorChanged;
            _controller.MovementStatusChanged += OnMovementChanged;

            floorGndCall.Click += (_, __) =>
            {
                _controller.LogCommand("Button pressed for floor 0", "Request", "User requested floor 0", "Location: 0"); // Calls the LogCommand method to log this command on MySQL
                _controller.RequestFloor(0); // Requests change in floor
            };

        }

        private void OnCurrentFloorChanged(int floor)
        {
            if (InvokeRequired) BeginInvoke(new Action(() => UpdateDisplay(floor)));
            else UpdateDisplay(floor);
        }

        private void OnMovementChanged(string status)
        {
            if (InvokeRequired) BeginInvoke(new Action(() => display_gfloor.Text = status));
            else display_gfloor.Text = status;
        }

        private void UpdateDisplay(int floor)
        {
            display_gfloor.Text = (floor == 0) ? "At Ground" : "At 1st";
        }

        private void floorGndCall_Click(object sender, EventArgs e)
        {

        }

        private void display_gfloor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
