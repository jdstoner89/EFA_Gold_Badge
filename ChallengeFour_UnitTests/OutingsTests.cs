using System;
using ChallengeFour_Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace ChallengeFour_UnitTests
{
    [TestClass]
    public class OutingsTests
    {
        [TestMethod]
        public void SetEventType_SetCorrectString()
        {
            Outings outing = new Outings();
            outing.EventType = "Dinner Party";

            string expected = "Dinner Party";
            string actual = outing.EventType;

            Assert.AreEqual(expected, actual);
        }
    }
}
