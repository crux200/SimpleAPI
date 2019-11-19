using System;
using Xunit;
using SimpleWebapi.Controllers;

namespace testwebapi
{
    public class UnitTest1
    {
        ValuesController controller= new ValuesController();
        [Fact]
        public void getreturnsmyname()
        {
            var returnvalue=  controller.Get(1);
            Assert.Equal("Varghese Thomas", returnvalue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
