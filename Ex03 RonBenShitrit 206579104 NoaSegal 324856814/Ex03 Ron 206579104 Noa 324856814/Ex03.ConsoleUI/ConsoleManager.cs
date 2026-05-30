using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    internal class ConsoleManager
    {
        private GarageManager m_GarageManager;

        public ConsoleManager()
        {
            m_GarageManager = new GarageManager();
        }
        public void StartMenu()
        {
            Console.WriteLine("Welcome to the Garage! Please choose an option:");
            Console.WriteLine("1. Load the system from a file");
            Console.WriteLine("2. Add a new vehicle");
            Console.WriteLine("3. Display a list of all vehicles in the garage");
            Console.WriteLine("4. Change the state of a vehicle in the garage");
            Console.WriteLine("5. Inflate tires of a vehicle to the maximum");
            Console.WriteLine("6. Refuel a fuel-based vehicle");
            Console.WriteLine("7. Recharge an electric vehicle");
            Console.WriteLine("8. Display all information of a vehicle");
    
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        
                        break;
                    case "2":
                        
                        break;
                    case "3":
                        
                        break;
                    case "4":
                        
                        break;
                    case "5":
                        
                        break;
                    case "6":
                        
                        break;
                    case "7":
                        
                        return;
                    default:
                    //throw excetion
                    break;
            }
        }

    }
