using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp.contract
{
    public interface IObserver
    {
        public void UpdateHasMoved(int pastX, int pastY, int newX, int newY);
        public void UpdateMaterialAvailableChanged(String name);
        public void UpdateEmployeeNotAvailable(String name);
        public void UpdateEmployeeAvailable(String name);
        public void UpdateEvent(String eventName);
    }
}
