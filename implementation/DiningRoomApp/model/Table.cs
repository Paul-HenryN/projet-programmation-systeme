using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiningRoomApp.model
{
    internal abstract class Table : DiningRoomMaterial
    {
        public int PlaceNum { get; set; }
        
        public void start()
        {

        }
    }
    
}
