using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Computer
    {
        private readonly string id;
        private bool? hasCellAntenna;
        private double? hardDriveStorage;
        private int ram;
        private int[] licenses;

        public Computer(string ID)
        {
            this.id = ID;
        }

        public bool? HasCellAntenna
        {
            get { return hasCellAntenna; }
            set => hasCellAntenna = value;
        }

        public double? HardDriveStorage
        {
            get { return hardDriveStorage;  }
            set
            {
                if (value >= 0)
                {
                    hardDriveStorage = value;
                }
            }
        }

        public int Ram
        {
            get
            {
                int adjustedRAM = hasCellAntenna.HasValue ? 100 : 50;

                if (licenses != null)
                {
                    adjustedRAM += licenses.Length * 10;
                }

                return ram - adjustedRAM;
            }
          
            set
            { if (value >= 1000)
                {
                    ram = value;
                } 
            }
        }

        public int[] Licenses
        {
            get { return licenses;  }
            set { licenses = value;  }
        }

        public string toString()
        {
            string computerInfo = "Computer ID: " + id  + ", cell antenna: ";
            computerInfo += (bool)hasCellAntenna ? "yes" : "no";
            computerInfo += ", hard drive: ";
            if (hardDriveStorage != null)
                computerInfo += hardDriveStorage;
            else
                computerInfo += "none";
            computerInfo += ", ram: " + ram + " number of licenses: " + licenses.Length;
            
            return computerInfo;
        }
            
    }
}
