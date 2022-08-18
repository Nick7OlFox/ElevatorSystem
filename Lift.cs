using System;

namespace Assignment1
{
    public class Lift
    {
        private String Door, Floor, Movement;
        private Boolean CheckD, CheckF;

        public Lift()
        {
            Door = "Closed";
            Floor = "1";
            Movement = "Closed";
        }

        public void ChangeDoor()
        {
            if (Door == "Closed")
            {
                Door = "Open";
            }

            else
            {
                Door = "Closed";
            }
        }

        public void ChangeFloor()
        {
            if (Floor == "1")
            {
                Floor = "2";
            }

            else
            {
                Floor = "1";
            }
        }

        public void ChangeMovement()
        {
            if (Movement == "Stoped")
            {
                Movement = "Moving";
            }

            else
            {
                Movement = "Stoped";
            }
        }

        public Boolean CheckFloor(String currentFloor)
        {
            if (Floor == currentFloor)
            {
                CheckF = true;
            }

            else
            {
                CheckF = false;
            }

            return CheckF;
        }

        public Boolean CheckDoor()
        {
            if (Door == "Closed")
            {
                CheckD = true;
            }

            else
            {
                CheckD = false;
            }

            return CheckD;
        }
    }
}