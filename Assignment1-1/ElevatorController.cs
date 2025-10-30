using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Assignment1_1
{

    // Purpose of this class is to unify all of the event handling so that 
    // all of the actions from 3 forms are controlled by one class
    public class ElevatorController
    {

        private readonly string _connStr =
        "Server=127.0.0.1;Port=3306;Database=elevator_logs;Uid=root;Pwd=password;";


        // This method inserts a command into the logged commands SQL database
        public void LogCommand(string command, string action, string description)
        {
            using (var conn = new MySqlConnection(_connStr))
            {

                // Passing in the parameters to protect against SQL injection
                conn.Open();
                string sql = "INSERT INTO log_entries (command, action, description) VALUES (@c, @a, @d)";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@c", command);
                    cmd.Parameters.AddWithValue("@a", action);
                    cmd.Parameters.AddWithValue("@d", description);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<string> GetLogs()
        {
            var logs = new List<string>();

            using (var conn = new MySqlConnection(_connStr))
            {
                conn.Open();
                string sql = "SELECT timestamp, command, action, description FROM log_entries ORDER BY timestamp DESC";
                using (var cmd = new MySqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        logs.Add($"[{reader.GetDateTime("timestamp"):HH:mm:ss}] Command: {reader.GetString("command")} | Action: {reader.GetString("action")} | Description: {reader.GetString("description")}");
                    }
                }
            }

            return logs;
        }

        public event EventHandler<int>? CurrentFloorChanged; // Called whenever the floor changes

        // Only place in that stores which floor elevator is on
        // 0 is ground floor, 1 is floor 1
        public int CurrentFloor { get; private set; } = 0;

        // Only place that can request a change in floor, i.e. move the elevator
        public void RequestFloor(int target)
        {
            // If the requested floor is the same as the current one — no movement
            if (target == CurrentFloor)
            {
                LogCommand($"Move elevator to floor {target}", "None", "Elevator already on this floor");
                return;
            }

            // Log the request to move
            LogCommand($"Move elevator to floor {target}", "Move", $"Moving from {CurrentFloor} to {target}");

            // Update floor variable
            CurrentFloor = target;

            // Notify all forms that the floor has changed
            CurrentFloorChanged?.Invoke(this, CurrentFloor);

            // Log arrival
            LogCommand($"Arrived at floor {target}", "DoorOpen", "Reached target floor and doors opened");
        }

    }
}
