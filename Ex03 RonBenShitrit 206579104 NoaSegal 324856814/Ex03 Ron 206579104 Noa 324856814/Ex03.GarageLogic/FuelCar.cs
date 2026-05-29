using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    enum eFuelType
    {
        Octan98,
        Octan96,
        Octan95,
        Soler
    }
    internal class FuelCar : Car
    {
        //all marked in // should be in the engine / carSystem class - else it create code duplication
        //private eFuelType m_FuelType;
        //private float m_CurrentFuelAmountLiters;
        //private float m_MaxFuelAmountLiters;
        //m_engine

        public FuelCar(string i_LicenseID, string i_ModelName) : base(i_LicenseID, i_ModelName)
        {
            //m_engine = FuelEngine;
        }
        //public void FillFuelTank(float i_FuelToAdd)
        // {}
    }
}
