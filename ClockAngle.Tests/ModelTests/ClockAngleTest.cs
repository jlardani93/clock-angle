using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClockAngleProject.Models;

namespace ClockAngleProject.TestTools
{
    [TestClass]
    public class ClockAngleTest
    {
        [TestMethod]
        public void CalculateAngle_true()
        {
            Clock newClock = new Clock();
            newClock.SetHour("8");
            newClock.SetMinute("30");
            string expected = "60";
            Assert.AreEqual(expected, newClock.CalculateAngle());

            newClock.SetHour("12");
            newClock.SetMinute("40");
            expected = "120";
            Assert.AreEqual(expected, newClock.CalculateAngle());
        }
    }
}
