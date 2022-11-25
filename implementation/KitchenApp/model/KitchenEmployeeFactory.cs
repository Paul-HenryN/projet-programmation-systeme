using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp.model
{
    internal class KitchenEmployeeFactory
    {
        private static Chef CHEF = new Chef();
        private static PartChef PART_CHEF = new PartChef();
        private static KitchenClerk KITCHEN_CLERK  = new KitchenClerk();
        private static Washer WASHER = new Washer();
    }
}
