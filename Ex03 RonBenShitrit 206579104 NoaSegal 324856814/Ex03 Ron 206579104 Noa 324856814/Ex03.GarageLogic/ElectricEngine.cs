using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class ElectricEngine : Engine
    {
        private float m_TimeLeftInBattery;
        private float m_MaxBatteryTime;

        public ElectricEngine(float i_TimeLeftInBattery,float i_MaxBatteryTime)
        {
            m_TimeLeftInBattery = i_TimeLeftInBattery;
            m_MaxBatteryTime = i_MaxBatteryTime;
        }
        public void AddTimeInBattery(float i_TimeToAdd)
        {
            if(i_TimeToAdd + m_TimeLeftInBattery <= m_MaxBatteryTime)
            {
                m_TimeLeftInBattery += i_TimeToAdd;
            }
        }
    }
}
