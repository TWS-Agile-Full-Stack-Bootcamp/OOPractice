namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class CarTest
    {
        [Fact]
        public void Should_show_message_with_name_and_speed_when_SpeedUp()
        {
            // given
            Car car = new Car("Cool Car", new ElectricEngine());

            // when
            string message = car.SpeedUp();

            // then
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }
    }
}
