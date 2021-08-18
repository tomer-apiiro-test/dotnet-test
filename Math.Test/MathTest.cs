using Math.Api;
using Xunit;

namespace Math.Test
{
    public class MathTest
    {
        [Fact]
        public void AddTest()
        {
            var math = new SimpleMath();
            var actual = math.Add(1, 2);
            Assert.Equal(3, actual);
        }

        [Fact]
        public void SubtractTest()
        {
            var math = new SimpleMath();
            var actual = math.Subtract(2, 1);
            Assert.Equal(1, actual);
        }

        [Fact]
        public void MultiplyTest()
        {
            var math = new SimpleMath();
            var actual = math.Multiply(2, 3);
            Assert.Equal(6, actual);
        }
    }
}