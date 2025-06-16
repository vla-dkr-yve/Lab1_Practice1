using FluentAssertions;

namespace Geometry.Tests
{
    public class SegmentTests
    {
        [Fact]
        public void SegmentConstructorTest()
        {
            Point start = new Point();
            Point end = new Point(5,5);
            Segment segment = new Segment(start,end);

            segment.Start.Should().BeEquivalentTo(start);
            segment.End.Should().BeEquivalentTo(end);
        }

        [Fact]
        public void SegmentLengthTest()
        {
            Point start = new Point();
            Point end = new Point(3, 4);
            Segment segment = new Segment(start, end);

            var length = segment.Length;
            length.Should().Be(5);
        }
    }
}
