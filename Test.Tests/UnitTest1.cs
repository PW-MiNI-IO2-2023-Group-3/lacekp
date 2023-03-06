namespace Test.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result = Feature.Method("pawel");

            Assert.Equal("ok", result);
        }
    }
}