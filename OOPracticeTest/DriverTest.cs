namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class DriverTest
    {
        [Fact]
        public void Should_show_message_with_name_and_speed_when_SpeedUp_given_drive_a_car()
        {
            // given
            Driver driver = new Driver("car");

            // when
            string message = driver.SpeedUp();

            // then
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }

        [Fact]
        public void Should_show_message_with_name_and_speed_when_SpeedUp_given_drive_a_truck()
        {
            // given
            Driver driver = new Driver("truck");

            // when
            string message = driver.SpeedUp();

            // then
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }
    }
}
