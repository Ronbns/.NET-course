using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class ElectricCar : Car
    {
        //m_engine
        public ElectricCar(string i_LicenseID,string i_ModelName) : base(i_LicenseID, i_ModelName)
        {
            //m_engine = electricEngine;
        }
    }
}
