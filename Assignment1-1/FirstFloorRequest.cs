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

            floor1Call.Click += (_, __) => _controller!.RequestFloor(1);
        }

        private void floor1Call_Click(object sender, EventArgs e)
        {

        }
    }
}
