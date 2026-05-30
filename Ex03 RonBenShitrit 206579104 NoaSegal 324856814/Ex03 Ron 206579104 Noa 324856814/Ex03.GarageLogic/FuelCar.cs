using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    
    internal class FuelCar : Car
    {
        public FuelCar(string i_LicenseID, string i_ModelName) : base(i_LicenseID, i_ModelName)
        {
            m_Engine = new FuelEngine(eFuelType.Octan95, 0, 51f);
            
        }
        //public void FillFuelTank(float i_FuelToAdd)
        // {}
    }
}
