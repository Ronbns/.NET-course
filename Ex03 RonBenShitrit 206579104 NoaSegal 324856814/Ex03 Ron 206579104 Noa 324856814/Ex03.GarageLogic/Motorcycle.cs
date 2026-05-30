using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    enum eMotorcycleLicenseType
    {
        A,
        A2,
        B1,
        AB
    }
    public abstract class Motorcycle : Vehicle
    {
        private eMotorcycleLicenseType m_LicenseType;
        private int m_EngineVolume;
        
        public Motorcycle(string i_LicenseID, string i_ModelName) : base(i_LicenseID, i_ModelName)
        {
            m_NumberOfTires = 2;
            m_MaximalTirePressure = 30;
            for (int i = 0; i < m_NumberOfTires; i++)
            {
                m_Tires.Add(new Tire(m_MaximalTirePressure));
            }
        }
    }
}
