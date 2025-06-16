using FluentAssertions;

namespace Geometry.Tests
{
    public class PolygonalChainTests
    {
        [Fact]
        public void PoligonalChainToStringTest()
        {
            Point start = new Point(1, 1);
            Point end = new Point(3, 3);
            Point midPoint = new Point(2, 2);
            PolygonalChain polygonalChain = new PolygonalChain(start, end);

            polygonalChain.AddMidpoint(midPoint);

            var res = polygonalChain.ToString();
            res.Should().Be("(1,1),(2,2),(3,3)");
        }

        [Fact]
        public void PoligonalChainMoveTest()
        {
            Point start = new Point(1, 1);
            Point end = new Point(3, 3);
            Point midPoint = new Point(2, 2);
            PolygonalChain polygonalChain = new PolygonalChain(start, end);

            polygonalChain.AddMidpoint(midPoint);

            polygonalChain.Move(1, 1);

            var res = polygonalChain.ToString();
            res.Should().Be("(2,2),(3,3),(4,4)");
        }
    }
}
