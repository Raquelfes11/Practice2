namespace Practice2
{
    class Taxi : VehicleWithPlate
    {
        private static string typeOfVehicle = "Taxi";
        private bool isCarryingPassengers;
        private bool hasLicence;

        public Taxi(string plate) : base(typeOfVehicle, plate)
        {
            isCarryingPassengers = false;
            SetSpeed(45.0f);
        }

        public void SetLicence(bool licence)
        {
            hasLicence = licence;
        }

        public bool GetLicence()
        {
            return hasLicence;
        }

        public void StartRide()
        {
            if (!isCarryingPassengers && hasLicence)
            {
                isCarryingPassengers = true;
                SetSpeed(100.0f);
                Console.WriteLine(WriteMessage("starts a ride."));
            }
            else if (!hasLicence)
            {
                Console.WriteLine(WriteMessage("Has not a licence"));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already in a ride."));
            }
        }

        public void StopRide()
        {
            if (isCarryingPassengers && hasLicence)
            {
                isCarryingPassengers = false;
                SetSpeed(45.0f);
                Console.WriteLine(WriteMessage("finishes ride."));
            }
            else if (!hasLicence)
            {
                Console.WriteLine(WriteMessage("Has not a licence"));
            }
            else
            {
                Console.WriteLine(WriteMessage("is not on a ride."));
            }
        }
    }
}

