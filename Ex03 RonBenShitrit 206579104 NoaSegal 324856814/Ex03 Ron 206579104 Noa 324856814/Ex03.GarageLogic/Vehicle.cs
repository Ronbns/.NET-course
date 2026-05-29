using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        private string m_ModelName;
        private string m_LicenseID;
        private float m_EnergyLeftPercentage;
        protected readonly List<Tire> m_Tires = new List<Tire>();


        // todo: 1. think if list fits here or dict is better

        protected Vehicle (string i_LicenseID, string i_ModelName)
        {
            m_LicenseID = i_LicenseID;
            m_ModelName = i_ModelName;
        }
       
    }
}
