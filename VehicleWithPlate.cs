namespace Practice2
{
    abstract class VehicleWithPlate: Vehicle
    {
        private string typeOfVehicle;
        private string plate;

        public VehicleWithPlate(string typeOfVehicle, string plate) : base(typeOfVehicle)
        {
            this.typeOfVehicle = typeOfVehicle;
            this.plate = plate;
        }

        //Override ToString() method with class information
        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with plate {GetPlate()}";
        }

        public string GetPlate()
        {
            return plate;
        }
    }
}


