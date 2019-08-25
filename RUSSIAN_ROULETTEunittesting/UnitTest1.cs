using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RUSSIAN_ROULETTEunittesting
{
    [TestClass]
    public class UnitTest1
    {
        logic unitTestobj = new logic();
        [TestMethod]
        public void GetRandomPosition()
        {
            var act = unitTestobj.GetRandomPosition(1);
            Assert.AreEqual(expected: 4, act);
        }
    }
}
