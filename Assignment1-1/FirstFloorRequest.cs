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
            _controller = controller;

            floor1Call.Click += (_, __) =>
            {
                _controller.LogCommand("Button pressed for floor 1", "Request", "User requested floor 1", "Location: 1"); // Calls the LogCommand method to log this command on MySQL
                _controller.RequestFloor(1); // Requests change in floor
            };
        }

        private void floor1Call_Click(object sender, EventArgs e)
        {

        }
    }
}
