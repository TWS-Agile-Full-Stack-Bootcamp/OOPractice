namespace OOPractice
{
    public class Driver
    {
        private readonly string vehicleType;

        public Driver(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        public string SpeedUp()
        {
            if ("car".Equals(vehicleType))
            {
                return new Car("Cool Car", 30).SpeedUp();
            }
            else if ("truck".Equals(vehicleType))
            {
                return new Truck("Big Truck", 10).SpeedUp();
            }

            throw new System.NotImplementedException();
        }
    }
}