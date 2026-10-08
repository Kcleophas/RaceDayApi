using Xunit;

namespace RaceDay.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(2, 1 + 1);
        }

        [Fact]
        public void Test3()
        {
            Assert.NotNull("RaceDay");
        }

        [Fact]
        public void Test4()
        {
            Assert.Contains("Race", "RaceDay");
        }

        [Fact]
        public void Test5()
        {
            Assert.False(false);
        }
    }
}