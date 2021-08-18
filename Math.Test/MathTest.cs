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
    }
}
