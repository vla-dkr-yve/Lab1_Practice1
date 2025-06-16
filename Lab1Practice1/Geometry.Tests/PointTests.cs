using FluentAssertions;

namespace Geometry.Tests
{
    public class PointTests
    {
        [Fact]
        public void FirstConstructorTests()
        {
            Point point = new Point();

            point.X.Should().Be(0);
            point.Y.Should().Be(0);
        }

        [Fact]
        public void SecondConstructorTests()
        {
            Point point = new Point(1);

            point.X.Should().Be(1);
            point.Y.Should().Be(1);
        }

        [Fact]
        public void ThirdConstructorTests()
        {
            Point point = new Point(1,2);

            point.X.Should().Be(1);
            point.Y.Should().Be(2);
        }

        [Fact]
        public void PointMoveMethodTest()
        {
            Point point = new Point();

            point.Move(1, 2);
            point.X.Should().Be(1);
            point.Y.Should().Be(2);
        }

        [Fact]
        public void PointDistanceMethodTest()
        {
            Point point = new Point(3,4);

            var res = point.Distance();
            res.Should().Be(5);
        }
    }
}
