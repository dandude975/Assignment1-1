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
            _controller = controller;

            floorGndCall.Click += (_, __) =>
            {
                _controller.LogCommand("Button pressed for floor 0", "Request", "User requested floor 0", "Location: 0"); // Calls the LogCommand method to log this command on MySQL
                _controller.RequestFloor(0); // Requests change in floor
            };

        }

        private void floorGndCall_Click(object sender, EventArgs e)
        {

        }
    }
}
