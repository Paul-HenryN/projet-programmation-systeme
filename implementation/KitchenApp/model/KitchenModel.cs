using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp.model
{
    internal class KitchenModel
    {
        public Kitchen kitchen { get; set; }
        private KitchenEmployee[][] employees;


        public KitchenEmployee GetEmployee(int x, int y)
        {
            return new Chef();
        }

        public void SetEmployee(int x, int y, KitchenEmployee employee)
        {

        }
    }
}
