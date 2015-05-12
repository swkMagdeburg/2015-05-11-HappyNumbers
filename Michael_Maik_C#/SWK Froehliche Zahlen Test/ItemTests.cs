using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWK_Froehliche_Zahlen;

namespace SWK_Froehliche_Zahlen_Test
{
    [TestClass]
    public class ItemTests
    {


        [TestMethod]
        public void CalcSuccessor_Zero()
        {
            Item sut = new Item(0);

            Assert.AreEqual(0, sut.Successor);
        }

        [TestMethod]
        public void CalcSuccessor_1()
        {
            Item sut = new Item(1);

            Assert.AreEqual(1, sut.Successor);
        }

        [TestMethod]
        public void CalcSuccessor_1234()
        {
            Item sut = new Item(1234);
            Assert.AreEqual(30, sut.Successor);
        }

        [TestMethod]
        public void TestGetPrint()
        {
            Item sut = new Item(12);
            Assert.AreEqual("1^2 + 2^2 = 5", sut.GetPrint());
        }

        [TestMethod]
        public void TestGetPrint_TwoTimes()
        {
            Item sut = new Item(12);
            Assert.AreEqual("1^2 + 2^2 = 5", sut.GetPrint());
            Assert.AreEqual("1^2 + 2^2 = 5", sut.GetPrint());
        }

        [TestMethod]
        public void TestGetPrint_1234()
        {
            Item sut = new Item(1234);
            Assert.AreEqual("1^2 + 2^2 + 3^2 + 4^2 = 30", sut.GetPrint());
        }
    }
}
