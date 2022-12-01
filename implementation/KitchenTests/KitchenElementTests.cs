using System.Drawing;
using KitchenApp.model;


namespace KitchenTests
{
    [TestClass]
    public class KitchenElementTests
    {
        [TestMethod]
        public void GetSpriteTest()
        {
            Chef chef = new();
            Image waitingSprite = chef.GetSprite("waiting");

            Assert.IsNotNull(waitingSprite);
        }
        public void SetSpriteTest()
        {
            Chef chef = new();
            chef.SetSprite("test", Image.FromFile("C:\\Users\\hp\\OneDrive\\Bureau\\KitchenApp\\assets\\employees\\chef\\ready.png"));

            Assert.IsNotNull(chef.GetSprite("test"));
        }
    }
}