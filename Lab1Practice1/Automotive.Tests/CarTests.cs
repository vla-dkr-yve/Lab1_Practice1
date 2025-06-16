using FluentAssertions;

namespace Automotive.Tests
{
    public class CarTests
    {
        [Fact]
        public void CarConstructorExceptionsTest()
        {
            Action NoBrand = () => new Car("",1,1);
            Action NegativeCapacity = () => new Car("Brand", -1, 1);
            Action NegativeFuelConsumption = () => new Car("Brand", 1, -1);


            NoBrand.Should().Throw<ArgumentException>();
            NegativeCapacity.Should().Throw<ArgumentOutOfRangeException>();
            NegativeFuelConsumption.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void CarFuelConsumptionTest()
        {
            Car car = new Car("Toyota", 200, 50);

            car.Refuel(100);

            car.CurrentFuelLevel.Should().Be(100);
        }

        [Fact]
        public void CarFuelConsumptionExceptionTest()
        {
            Car car = new Car("Toyota", 200, 50);

            Action act = () => car.Refuel(-1);

            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void CarDriveTest()
        {
            Car car = new Car("Toyota", 200, 50);
            car.Refuel(50);
            car.Drive(100);

            car.TripOdometer.Should().Be(100);
            car.CurrentFuelLevel.Should().Be(0);
        }

        [Fact]
        public void CarDriveExceptionTest()
        {
            Car car = new Car("Toyota", 200, 50);
            car.Refuel(50);
            Action act = () => car.Drive(-1);

            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void CarOdometerResetTest()
        {
            Car car = new Car("Toyota", 200, 50);
            car.Refuel(50);
            car.Drive(100);

            car.ResetTripOdometer();
            car.TripOdometer.Should().Be(0);
        }
    }
}
