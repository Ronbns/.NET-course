using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class Truck : Vehicle
    {
        private bool m_transportsRefrigerated;
        private float m_CargoCapacity;
        private int m_NumberOfTires = 14;
        private float m_MaximalTirePressure = 28;
        public Truck(string i_LicenseID, string i_ModelName) : base(i_LicenseID, i_ModelName) 
        {
            for (int i = 0; i < m_NumberOfTires; i++)
            {
                m_Tires.Add(new Tire(m_MaximalTirePressure));
            }
        }
    }
}
