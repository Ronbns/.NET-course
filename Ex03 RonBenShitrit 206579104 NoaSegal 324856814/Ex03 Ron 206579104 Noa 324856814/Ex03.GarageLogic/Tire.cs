using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Tire
    {
        private string m_ManufacturerName;
        private float m_CurrentTirePressure;
        private float m_MaximalTirePressure;

        public Tire(float i_MaximalTirePressure)
        {
            m_MaximalTirePressure = i_MaximalTirePressure;
        }
        public void InflateTirePressure(float i_PressureToAdd)
        {
            if (m_CurrentTirePressure + i_PressureToAdd <= m_MaximalTirePressure)
            {
                m_CurrentTirePressure += i_PressureToAdd;
            }
        }


    }
}
