namespace OOPractice
{
    public class Truck
    {
        private string name;
        private int speed;

        public Truck(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public string SpeedUp()
        {
            return $"{name}: speed up {speed} km/h";
        }
    }
}