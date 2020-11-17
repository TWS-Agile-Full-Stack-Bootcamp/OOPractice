namespace OOPractice
{
    public class Car : Vehicle
    {
        public Car(string name, ElectricEngine engine) : base(name, engine.SpeedUp())
        {
        }
    }
}