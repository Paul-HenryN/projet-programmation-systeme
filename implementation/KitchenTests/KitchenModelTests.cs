using KitchenApp.model;
using KitchenApp.view;
using KitchenApp.contract;

namespace KitchenTests
{
    [TestClass]
    public class KitchenModelTests
    {
        [TestMethod]
        public void SetEmployeeConfigTest()
        {
            KitchenModel model = new KitchenModel();
            model.SetEmployeeConfig(1, 2, 3, 4);

            Assert.AreEqual<int>(model.chefs.Length, 1);
            Assert.AreEqual<int>(model.partChefs.Length, 2);
            Assert.AreEqual<int>(model.clerks.Length, 3);
            Assert.AreEqual<int>(model.washers.Length, 4);
        }

        [TestMethod]
        public void SetMaterialConfigTest()
        {
            KitchenModel model = new KitchenModel();
            model.SetMaterialConfig(1, 2, 3, 4, 5);

            Assert.AreEqual<int>(model.cookingFire.quantity, 1);
            Assert.AreEqual<int>(model.oven.quantity, 2);
            Assert.AreEqual<int>(model.blender.quantity, 3);
            Assert.AreEqual<int>(model.pan.quantity, 4);
            Assert.AreEqual<int>(model.kitchenKnife.quantity, 5);
        }

        [TestMethod]
        public void AddObserverTest()
        {
            KitchenModel model = new KitchenModel();
            KitchenView view = new(model);

            model.AddObserver(view);

            Assert.AreEqual<IObserver>(model.observers[0], view);

        }
    }
}
