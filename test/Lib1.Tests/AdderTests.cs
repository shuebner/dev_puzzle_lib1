namespace Lib1.Tests
{
    public class AdderTests
    {
        [Fact]
        public void Test1()
        {
            var adder = new Adder();
            int result = adder.Add(1, 2);
            Assert.Equal(3, result);
        }
    }
}