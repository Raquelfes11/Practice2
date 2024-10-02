namespace Practice2
{
    class PoliceStation
    {
        private bool alertIsActivated;
        private string name;
        public List<PoliceCar> policeCars { get; private set; }  

        public PoliceStation(string namePoliceStation)
        {
            policeCars = new List<PoliceCar>();
            alertIsActivated = false;
            name = namePoliceStation;
        }

        public PoliceCar RegisterPoliceCar(string plate)
		{
			PoliceCar policeCar = new PoliceCar(plate,this); 
            policeCars.Add(policeCar);
            Console.WriteLine(policeCar.WriteMessage("Created"));

            Console.WriteLine(policeCar.WriteMessage($"registered at Police Station {name}"));

            return policeCar;
		}

        public void ActivateAlarm(string plateVehicleInfractor) 
        {
            string message = Message();

            if (!alertIsActivated)
            {
                alertIsActivated = true;
                Console.WriteLine($"{message} is activated.");

                foreach (PoliceCar policeCar in policeCars)
                {
                    if (policeCar.IsPatrolling())
                    {
                        policeCar.StartChasing(plateVehicleInfractor);
                    }
                }
            }
            else
            {
                Console.WriteLine($"{message} is already activated.");
            }
            
        }

        public void DeactivateAlarm()
        {
            string message = Message();

            if (alertIsActivated)
            {
                alertIsActivated = false;
                Console.WriteLine($"{message} is deactivated.");

                foreach (PoliceCar policeCar in policeCars)
                {
                    if (policeCar.IsPatrolling())
                    {
                        policeCar.FinishChasing();
                    }
                }
            }
            else
            {
                Console.WriteLine($"{message} is alredy deactivated.");
            }
        }

        public string Message()
        {
            return $"The alarm of the Police Station {name}: ";
        }

    }
}

