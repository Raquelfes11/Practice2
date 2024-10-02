using System.Diagnostics.Metrics;
using Practice2;

class City  //  ADD taxi, si le queito la licencia quito taxi
{
	private PoliceStation policeStation;
	public List<Vehicle> vehicles;
	private string name;

	public City(string cityName)
	{
		name = cityName;
		vehicles = new List<Vehicle>();
	}

	public PoliceStation CreatePoliceStation(string namePoliceStation)
	{
		PoliceStation policeStation = new PoliceStation(namePoliceStation);
		this.policeStation = policeStation;
		return policeStation;
	}

	public void RegisterLicenceOfTaxi(Taxi taxi)
	{
		bool licence = taxi.GetLicence();
        if (licence)
		{
            Console.WriteLine(taxi.WriteMessage($"Has alredy a licence"));
        }
		else
		{
			taxi.SetLicence(true);
            Console.WriteLine(taxi.WriteMessage($"Has a new licence"));
			AddVehicle(taxi);
        }
	}

	public void RetireLicence(Taxi taxi)
	{
		bool licence = taxi.GetLicence();

		if (licence)
		{
			taxi.SetLicence(false);
            Console.WriteLine(taxi.WriteMessage($"Has been retired its licence"));
			RemoveVehicle(taxi);
        }
		else
		{
            Console.WriteLine(taxi.WriteMessage($"Has not alredy a licence"));
        }
	}

	public void AddVehicle(Vehicle vehicle)
	{
		vehicles.Add(vehicle);
	}

	public void RemoveVehicle(Vehicle vehicle)
	{
		vehicles.Remove(vehicle);
	}

		
}



