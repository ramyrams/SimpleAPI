using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        ValuesController c = new ValuesController();

        [Fact]
        public void GetReturnsMyName()
        {
               var returnvalue = c.Get(1);
                Assert.Equal("Rams", returnvalue.Value);
        }



        [Fact]
        public void Test1()
        {

        }
    }
}
