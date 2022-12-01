using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp.model
{
    internal class Washer : KitchenEmployee
    {
        public Washer()
        {
            x = 7;
            y = 4;
            SetSprite("moving-left", Image.FromFile("C:\\Users\\hp\\OneDrive\\Bureau\\KitchenApp\\assets\\employees\\washer\\moving-left.png"));
            SetSprite("moving-right", Image.FromFile("C:\\Users\\hp\\OneDrive\\Bureau\\KitchenApp\\assets\\employees\\washer\\moving-right.png"));
            currentSprite = GetSprite("moving-left");
        }
    }
}
