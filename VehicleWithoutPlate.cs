namespace Practice2
{
    abstract class VehicleWithoutPlate : Vehicle
    {
        private string typeOfVehicle;

        public VehicleWithoutPlate(string typeOfVehicle) : base(typeOfVehicle)
        {
            this.typeOfVehicle = typeOfVehicle;
        }

        //Override ToString() method with class information
        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} without plate ";
        }
    }
}