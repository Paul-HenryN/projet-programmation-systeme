using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiningRoomApp.model
{
    internal abstract class MobileDiningRoomElement : DiningRoomElement
    {
        public int x { get; set; }
        public int y { get; set; }

        public void start()
        {

        }
    }
    
}
