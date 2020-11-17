namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class TruckTest
    {
        [Fact]
        public void Should_show_message_with_name_and_speed_when_SpeedUp()
        {
            // given
            Truck truck = new Truck("Big Truck", 10);

            // when
            string message = truck.SpeedUp();

            // then
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }
    }
}
