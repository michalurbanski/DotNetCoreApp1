using Xunit; 
using ConsoleApplication;  

namespace ConsoleApp.Tests
{
    public class First 
    {
        [Fact]
        public void Test()
        {
            Program program = new Program();
            var result = program.ReturnConstantValue();  

            Assert.Equal(6, result);
        }
    }
}