using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GunTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            FireGunGame.MyClass GClass = new FireGunGame.MyClass();
            
            int result = GClass.FireLogic();

            Assert.IsTrue(result < 5);
        }
        [TestMethod]
        public void TestMethod2()
        {
            FireGunGame.MyClass GClass = new FireGunGame.MyClass();
            
            int result = GClass.FireAwayLogic();

            Assert.IsTrue(result > 0);

        }
    }
}
