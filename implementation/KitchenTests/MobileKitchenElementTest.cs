using KitchenApp.model;

namespace KitchenTests
{
    [TestClass]
    public class MobileKitchenElementTest
    {
        [TestMethod]
        public void MoveLeftTest()
        {
            Chef chef = new Chef();
            int pastX = chef.x;
            chef.MoveLeft();

            Assert.AreEqual<int>(chef.x, pastX - MobileKitchenElement.speed);
        }

        [TestMethod]
        public void MoveRightTest()
        {
            Chef chef = new Chef();
            int pastX = chef.x;
            chef.MoveRight();

            Assert.AreEqual<int>(chef.x, pastX + MobileKitchenElement.speed);
        }

        [TestMethod]
        public void MoveUpTest()
        {
            Chef chef = new Chef();
            int pastY = chef.y;
            chef.MoveUp();

            Assert.AreEqual<int>(chef.y, pastY - MobileKitchenElement.speed);
        }

        [TestMethod]
        public void MoveDownTest()
        {
            Chef chef = new Chef();
            int pastY = chef.y;
            chef.MoveDown();

            Assert.AreEqual<int>(chef.y, pastY + MobileKitchenElement.speed);
        }
    }
}
