using KitchenApp.model;

namespace KitchenTests
{
    [TestClass]
    public class KitchenMaterialFactoryTests
    {
        [TestMethod]
        public void CreateCookingFireTest()
        {
            KitchenMaterial cookingFire = KitchenMaterialFactory.CreateCookingFire();
            Assert.AreEqual<String>(cookingFire.name, "cooking fire");
        }

        [TestMethod]
        public void CreatePanTest()
        {
            KitchenMaterial pan = KitchenMaterialFactory.CreatePan();
            Assert.AreEqual<String>(pan.name, "pan");
        }

        [TestMethod]
        public void CreateOvenTest()
        {
            KitchenMaterial oven = KitchenMaterialFactory.CreateOven();
            Assert.AreEqual<String>(oven.name, "oven");
        }

        [TestMethod]
        public void CreateBlenderTest()
        {
            KitchenMaterial blender = KitchenMaterialFactory.CreateBlender();
            Assert.AreEqual<String>(blender.name, "blender");
        }

        [TestMethod]
        public void CreateKitchenKnifeTest()
        {
            KitchenMaterial kitchenKnife = KitchenMaterialFactory.CreateKitchenKnife();
            Assert.AreEqual<String>(kitchenKnife.name, "kitchen knife");
        }
    }
}
