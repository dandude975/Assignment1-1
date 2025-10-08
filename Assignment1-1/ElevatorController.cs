using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_1
{

    // Purpose of this class is to unify all of the event handling so that 
    // all of the actions from 3 forms are controlled by one class
    public class ElevatorController
    {
        public event EventHandler<int>? CurrentFloorChanged; // Called whenever the floor changes

        // Only place in that stores which floor elevator is on
        // 0 is ground floor, 1 is floor 1
        public int CurrentFloor { get; private set; } = 0;

        // Only place that can request a change in floor, i.e. move the elevator
        public void RequestFloor(int target)
        {
            // If the requested floor is the same as the floor the elevator is on - do nothing
            if (target == CurrentFloor)
            {
                return;
            }

            // Update the variable containing the floor elevator is on
            CurrentFloor = target;

            // Notify all forms of change of floor, so correct floor can be displayed
            CurrentFloorChanged?.Invoke(this, CurrentFloor);

            // Later add in anitmations etc.
        }
    }
}
