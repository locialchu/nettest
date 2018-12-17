using System;
using Xunit;
using WebTest;
using WebTest.Controllers;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        [Fact]
        public void Addition()
        {
            var cal = new Calculator();
            var result = cal.Addition(1, 2);
            var home = new HomeController();
            Assert.Equal(3, result);
        }
    }
}
