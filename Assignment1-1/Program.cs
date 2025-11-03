namespace Assignment1_1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Creating a shared controller (EventController class) to govern all forms
            var controller = new ElevatorController();
            
            // Create all three forms, using the same controller
            var ControlPanel         = new ControlPanel(controller);
            var GroundFloorRequest   = new GroundFloorRequest(controller);
            var FirstFloorRequest    = new FirstFloorRequest(controller);

            
            // Making things look pretty
            GroundFloorRequest.StartPosition = FormStartPosition.Manual;
            GroundFloorRequest.Location = new Point(50, 100);

            FirstFloorRequest.StartPosition = FormStartPosition.Manual;
            FirstFloorRequest.Location = new Point(400, 100);

            ControlPanel.StartPosition = FormStartPosition.Manual;
            ControlPanel.Location = new Point(750, 100);

            // Show the other two forms
            GroundFloorRequest.Show();
            FirstFloorRequest.Show();

            // Run the main application loop on the ControlPanel
            Application.Run(ControlPanel);
        }
    }
}