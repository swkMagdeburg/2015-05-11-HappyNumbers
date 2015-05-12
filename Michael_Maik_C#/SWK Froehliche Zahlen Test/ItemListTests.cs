using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWK_Froehliche_Zahlen;

namespace SWK_Froehliche_Zahlen_Test
{
    [TestClass]
    public class ItemListTests
    {
        [TestMethod]
        public void TesteItemList()
        {
            var sut = new ItemList(1);
            Assert.AreEqual("1 -> 1^2 = 1", sut.GetPrint());
        }

        [TestMethod]
        public void TesteItemList_19()
        {
            var sut = new ItemList(19);
            Assert.AreEqual("19 -> 1^2 + 9^2 = 82 -> 8^2 + 2^2 = 68 -> 6^2 + 8^2 = 100 -> 1^2 + 0^2 + 0^2 = 1", sut.GetPrint());
        }
    }
}
