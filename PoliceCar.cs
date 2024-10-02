using Practice2;

class PoliceCar : Vehicle
{
    private const string typeOfVehicle = "Police Car";
    private bool isPatrolling;
    private SpeedRadar speedRadar;
    private bool isChasingACar;
    private PoliceStation policeStation; 

    public PoliceCar(string plate,PoliceStation station) : base(typeOfVehicle, plate)
    {
        isPatrolling = false;
        speedRadar = new SpeedRadar();
        policeStation = station; 
        isChasingACar = false;
    }

    public void UseRadar(Vehicle vehicle)
    {
        if (isPatrolling)
        {
            speedRadar.TriggerRadar(vehicle);
            string meassurement = speedRadar.GetLastReading();
            Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));

            if (meassurement.Contains("above legal speed"))
            {
                policeStation.ActivateAlarm(vehicle.GetPlate());
                // It starts chasing because the method ActivateAlarm make that every policeCar that is patrolling to chase the taxi
            }
        }
        else
        {
            Console.WriteLine(WriteMessage($"has no active radar."));
        }
    }

    public bool IsPatrolling()
    {
        return isPatrolling;
    }

    public void StartPatrolling()
    {
        if (!isPatrolling)
        {
            isPatrolling = true;
            Console.WriteLine(WriteMessage("started patrolling."));
        }
        else
        {
            Console.WriteLine(WriteMessage("is already patrolling."));
        }
    }

    public void EndPatrolling()
    {
        if (isPatrolling)
        {
            isPatrolling = false;
            Console.WriteLine(WriteMessage("stopped patrolling."));
        }
        else
        {
            Console.WriteLine(WriteMessage("was not patrolling."));
        }
    }

    public void PrintRadarHistory()
    {
        Console.WriteLine(WriteMessage("Report radar speed history:"));
        foreach (float speed in speedRadar.SpeedHistory)
        {
            Console.WriteLine(speed);
        }
    }

    public void StartChasing(string vehiclePlate)
    {
        if (isPatrolling && !isChasingACar)
        {
            isChasingACar = true;
            Console.WriteLine(WriteMessage($"was chasing a car with plate {vehiclePlate}"));
        }
        else if (!isPatrolling)
        {
            Console.WriteLine(WriteMessage("was not patrolling."));
        }
        else
        {
            Console.WriteLine(WriteMessage("was alredy chasing a car"));
        }
    }

    public void FinishChasing()
    {
        if (isChasingACar)
        {
            isChasingACar = false;
            Console.WriteLine(WriteMessage($"stopped chasing."));
        }
        else
        {
            Console.WriteLine(WriteMessage("was not chasing a car"));
        }
    }
}

