using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiningRoomApp.model;

namespace DiningRoomApp.controller
{
    internal class DiningRoomController
    {


        public void start()
        {
            for (int i = 0; i < 2; i++)
            {
                Thread HeadWaiterThread = new(new ThreadStart(HeadWaiterTask));
                HeadWaiterThread.Name = "Head Waiter #" + (i + 1);
                HeadWaiterThread.Start();
            }

            for(int i = 0; i < 2; i++)
            {
                Thread ButlerThread = new(new ThreadStart(ButlerTask));
                ButlerThread.Name = "Butler #" + (i + 1);
                ButlerThread.Start();
            }

            for(int i = 0; i < 2; i++)
            {
                Thread ChefThread = new(new ThreadStart(ChefTask));
                ChefThread.Name = "Chef #" + (i + 1);
                ChefThread.Start();
            }

            for(int i = 0; i < 2; i++)
            {
                Thread WaiterThread = new(new ThreadStart(WaiterTask));
                WaiterThread.Name = "Waiter #" + (i + 1);
                WaiterThread.Start();
            }

        }

        private void ButlerTask()
        {

        }

        private void HeadWaiterTask()
        {

        }

        private void ChefTask()
        {

        }

        private void WaiterTask()
        {

        }
    }
}

