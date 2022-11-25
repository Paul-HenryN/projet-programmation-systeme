using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp.model
{
    internal abstract class MobileKitchenElement : KitchenElement
    {
        public int x { get; set; }
        public int y { get; set; }

        public void start()
        {

        }
    }
}
