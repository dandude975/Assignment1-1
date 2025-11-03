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

        // Initialising connection with SQL table
        private readonly string _connStr =
        "Server=127.0.0.1;Port=3306;Database=elevator_logs;Uid=root;Pwd=password;";


        // This method inserts a command into the logged commands SQL database
        public void LogCommand(string command, string action, string description, string location)
        {
            using (var conn = new MySqlConnection(_connStr))
            {

                // Passing in the parameters to protect against SQL injection
                conn.Open();
                string sql = "INSERT INTO log_entries (command, action, description, location) VALUES (@c, @a, @d, @l)";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@c", command);
                    cmd.Parameters.AddWithValue("@a", action);
                    cmd.Parameters.AddWithValue("@d", description);
                    cmd.Parameters.AddWithValue("@l", location);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        // This method retrieves the SQL table and puts it into a readable format so the user can see the elevator history
        public List<string> GetLogs()
        {
            var logs = new List<string>();

            using (var conn = new MySqlConnection(_connStr))
            {
                conn.Open();
                string sql = "SELECT timestamp, command, action, description, location FROM log_entries ORDER BY timestamp DESC";
                using (var cmd = new MySqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        logs.Add($"[{reader.GetDateTime("timestamp"):HH:mm:ss}] Command: {reader.GetString("command")} | Action: {reader.GetString("action")} | Description: {reader.GetString("description")} | Location: {reader.GetString("location")}");
                    }
                }
            }

            return logs;
        }

        public event Action<int>? CurrentFloorChanged; // Called whenever the floor changes
        public event Action<string>? MovementStatusChanged; // NEW: "Moving up", "Moving down", "Idle ..."


        // Only place in that stores which floor elevator is on
        // 0 is ground floor, 1 is floor 1
        public int CurrentFloor { get; private set; } = 0;
        private bool _isMoving;

        // Only place that can request a change in floor, i.e. move the elevator

        public async Task RequestFloor(int target)
    {
        // Optional guard: only floors 0 or 1
        if (target != 0 && target != 1)
            return;

        // Busy? prevent re-entrancy
        if (_isMoving)
        {
            MovementStatusChanged?.Invoke("Busy");
            return;
        }

        // Already there
        if (target == CurrentFloor)
        {
            MovementStatusChanged?.Invoke($"Idle at {(CurrentFloor == 0 ? "Ground" : "1st")}");
            LogCommand($"Move elevator to floor {target}", "None", "Elevator already on this floor",
                       location: CurrentFloor.ToString());
            return;
        }

        // Begin movement
        _isMoving = true;
        var dir = target > CurrentFloor ? "Moving up" : "Moving down";
        MovementStatusChanged?.Invoke(dir);

        LogCommand($"Move elevator to floor {target}", "Move",
                   $"{dir} from {CurrentFloor} to {target}", location: CurrentFloor.ToString());

        await Task.Delay(5000); // simulate 3s travel

        // Arrive
        CurrentFloor = target;
        _isMoving = false;

        CurrentFloorChanged?.Invoke(CurrentFloor);
        MovementStatusChanged?.Invoke($"Idle at {(CurrentFloor == 0 ? "Ground" : "1st")}");

        LogCommand($"Arrived at floor {target}", "DoorOpen",
                   "Doors opened", location: CurrentFloor.ToString());
    }

    
    }
}
