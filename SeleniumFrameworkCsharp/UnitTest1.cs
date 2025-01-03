using SeleniumFrameworkCsharp.DriverConfig;

namespace SeleniumFrameworkCsharp
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Driver.InitDriver();
        }
    }
}