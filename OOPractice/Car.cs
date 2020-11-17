namespace OOPractice
{
    public class Car
    {
        public string name;
        public int speed;

        public string SpeedUp()
        {
            return $"{name}: speed up {speed} km/h";
        }
    }
}