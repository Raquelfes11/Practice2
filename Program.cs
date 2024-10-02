using Practice2;
namespace Practice2
{
    internal class Program
    {

        static void Main()
        {

            City city = new City("Toledo");
            PoliceStation policeStation = city.CreatePoliceStation("1");


            Taxi taxi1 = new Taxi("0001 AAA");
            Console.WriteLine(taxi1.WriteMessage("Created"));
            city.RegisterLicenceOfTaxi(taxi1);

            Taxi taxi2 = new Taxi("0002 BBB");
            Console.WriteLine(taxi2.WriteMessage("Created"));
            city.RegisterLicenceOfTaxi(taxi2);

            PoliceCar policeCar1 = policeStation.RegisterPoliceCar("0001 CNP");
            PoliceCar policeCar2 = policeStation.RegisterPoliceCar("0002 CNP");

            policeCar1.StartPatrolling(); 
            policeCar1.UseRadar(taxi1);

            taxi2.StartRide();
            policeCar2.UseRadar(taxi2);
            policeCar2.StartPatrolling();
            policeCar2.UseRadar(taxi2);
            taxi2.StopRide();
            policeStation.DeactivateAlarm();
            city.RetireLicence(taxi2);
            policeCar2.EndPatrolling();


            taxi1.StartRide();
            taxi1.StartRide();
            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1);
            taxi1.StopRide();
            taxi1.StopRide();
            policeStation.DeactivateAlarm();
            city.RetireLicence(taxi1);
            policeCar1.EndPatrolling();

            policeCar1.PrintRadarHistory();
            policeCar2.PrintRadarHistory();

        }
    }
}




