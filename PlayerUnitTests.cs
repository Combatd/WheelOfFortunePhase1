using Microsoft.VisualStudio.TestTools.UnitTesting;
using WheelOfFortuneV2;

namespace WheelOfFortuneV2_test
{
    [TestClass]
    public class PlayerUnitTests
    {
        [TestMethod]
        public void playerNamePropertyIsSet()
        {
            string testName = "Miko";
            Player mikoPlayer = new Player("Miko");

            StringAssert.Contains(testName, mikoPlayer.name);
        }
    }
}
