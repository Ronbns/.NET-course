using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class FuelTruck : Truck
    {
        public FuelTruck(string i_LicenseID, string i_ModelName) : base (i_LicenseID, i_ModelName)
        {
            m_Engine = new FuelEngine(eFuelType.Soler, 0, 125f);
        }
    }
}
