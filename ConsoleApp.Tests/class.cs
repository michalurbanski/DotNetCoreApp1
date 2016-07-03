using Xunit; 

namespace ConsoleApp.Tests
{
    public class First 
    {
        [Fact]
        public void Test()
        {
            Assert.Equal(4, 2+2);
        }
    }
}