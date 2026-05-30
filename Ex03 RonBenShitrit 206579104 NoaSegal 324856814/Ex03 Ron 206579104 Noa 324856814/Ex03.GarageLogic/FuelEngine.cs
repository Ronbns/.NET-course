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
    internal class FuelEngine : Engine
    {
        protected eFuelType m_FuelType;
        protected float m_CurrentLitersOfFuel;
        protected float m_MaxLitersOfFuel;

        public FuelEngine(eFuelType i_FuelType, float i_CurrentLitersOfFuel, float i_MaxLitersOfFuel)
        {
            m_FuelType = i_FuelType;
            m_CurrentLitersOfFuel = i_CurrentLitersOfFuel;
            m_MaxLitersOfFuel = i_MaxLitersOfFuel;
        }

        public void AddFuel(float i_Fuel, eFuelType i_FuelType)
        {
            if (i_FuelType == m_FuelType && i_Fuel + m_CurrentLitersOfFuel <= m_MaxLitersOfFuel)
            {
                m_CurrentLitersOfFuel += i_Fuel;
            }
            else if (i_FuelType != m_FuelType)
            {
                throw new ArgumentException("Wrong fuel type");
            }
            else
            {
                //add ValueRangeException
            }
        }
}
