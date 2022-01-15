using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using addition;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int num1 = 5;
            int num2 = 6;
            int expected = 11;
            int actual = 0;
            //act
            addition obj = new addition();
            actual = obj.add(num1, num2);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
