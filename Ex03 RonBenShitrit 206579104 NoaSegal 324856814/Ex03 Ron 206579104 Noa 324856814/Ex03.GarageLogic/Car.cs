using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    enum eCarColor
    {
        Red,
        Yellow,
        Black,
        Silver
    };
    
    public abstract class Car : Vehicle
    {
        private eCarColor m_CarColor;
        private int m_NumberOfDoors;

        public Car(string i_LicenseID, string i_ModelName) : base (i_LicenseID, i_ModelName)
        {
            m_NumberOfTires = 5;
            m_MaximalTirePressure = 31;
            for (int i = 0; i < m_NumberOfTires; i++)
            {
                m_Tires.Add(new Tire(m_MaximalTirePressure));
            }
        }
    }
}
