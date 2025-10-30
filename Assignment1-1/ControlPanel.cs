namespace Assignment1_1
{
    public partial class ControlPanel : Form
    {
        private readonly ElevatorController? _controller;

        public ControlPanel()
        {
            InitializeComponent(); // Sets everything from the designer file
        }


        // When program.cs runs, it calls this constructor
        // It passes the single controller (ElevatorController.cs) into the constructor so that everything is
        // controlled by that.
        // this() is called to run InitializeComponent() which is required to display the form
        public ControlPanel(ElevatorController controller) : this()
        {
            // Allows this form to call methods from the controller
            _controller = controller;

            // Automatically updates the floor when its changed by EventController.cs
            _controller.CurrentFloorChanged += OnCurrentFloorChanged;

            // Chnages the actual display in accordance to floor change
            UpdateFloorDisplay(_controller.CurrentFloor);
        }

        // This runs when ElevatorController changes CurrentFloorChanged.
        // 'sender' is who raised it; 'newFloor' is the parameter (0=Ground, 1=First).
        private void OnCurrentFloorChanged(object? sender, int newFloor)
        {
            if (InvokeRequired)
            {
                // Ensures that any changes made to labels are made on the UI thread
                // This prevents glitches which can occur from changes made from the background thread
                Invoke(new Action(() => UpdateFloorDisplay(newFloor)));
            }
            
            // If we are already running on the UI thread, it is safe to call this method directly
            else UpdateFloorDisplay(newFloor);
        }


        // This method simply handles tha actual updating of the labels, after being changed to the UI thread
        private void UpdateFloorDisplay(int floor)
        {
            // If the floor parameter is 0, display ground, if not, display 1st Floor
            label1.Text = floor == 0 ? "Ground" : "1st Floor";
        }


        // These are requests to change floor, made by buttons on the control panel form.
        // When the requests are made, the event handlers in the ElevatorController.cs class are called.

        // Note that the event handlers in this class do not directly change the floor but request the
        // ElevatorController.cs to do so.
        private void FloorGndRqst_Click(object sender, EventArgs e)
        {
            _controller.LogCommand("Button pressed for floor 0", "Request", "User requested floor 0", "Location: Elevator"); // Calls the LogCommand method to log this command on MySQL
            _controller?.RequestFloor(0); // Requests change in floor
        }
        private void Floor1Rqst_Click(object sender, EventArgs e) 
        {
            _controller.LogCommand("Button pressed for floor 1", "Request", "User requested floor 1", "Location: Elevator"); // Calls the LogCommand method to log this command on MySQL
            _controller?.RequestFloor(1); // Requests change in floor
        } 
        private void LogRqst_Click(object sender, EventArgs e) 
        {
            var logs = _controller?.GetLogs();
            MessageBox.Show(string.Join(Environment.NewLine, logs), "Elevator Log");
        }
        
        
        // Auto-wired by Designer; keep them even if you don’t use them.
        private void label1_Click_1(object sender, EventArgs e)
        {
            // No action needed
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            // No action needed (you can initialise UI here later if you want)
        }

    }
}
