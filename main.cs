using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class main
    {
        static int CloudStorage = 500;
        static int NetworkSpeed = 1000;

        static Computer prototype = new Computer("Prototype");
        static Computer userPrototypeComputer = new Computer("user prototype");
        static Computer[] computers;

        public static void Main()
        {
            prototype.HardDriveStorage = 2.2;
            prototype.HasCellAntenna = false;
            prototype.Ram = 230000;
            int[] pl = { 1, 2, 3, 4, 5, 6, 6 };
            prototype.Licenses = pl;

            Console.WriteLine("Enter the amount of computers to record: ");
            _ = Console.ReadLine();
            int computerNum;
            bool validNum = GetIntFromUser(out computerNum, 5, 20, 10);
            computers = new Computer[computerNum];

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add a computer");
                Console.WriteLine("2. Specify the Prototype computer");
                Console.WriteLine("3. Remove the Prototype computer");
                Console.WriteLine("4. Upgrade Cloud Storage");
                Console.WriteLine("5. Downgrade Cloud Storage");
                Console.WriteLine("6. Upgrade Network Speed");
                Console.WriteLine("7. Downgrade Network Speed");
                Console.WriteLine("8. Get summary of a specific computer by array index");
                Console.WriteLine("9. Get summary of statistics on all computers entered");
                Console.WriteLine("10. Get summary of statistics on specific computers by array indices");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                int choice;
                if (!GetIntFromUser(out choice, 0, 10, -1))
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddComputer();
                        break;
                    case 2:
                        SpecifyPrototypeComputer();
                        break;
                    case 3:
                        RemovePrototypeComputer();
                        break;
                    case 4:
                        UpgradeCloudStorage();
                        break;
                    case 5:
                        DowngradeCloudStorage();
                        break;
                    case 6:
                        UpgradeNetworkSpeed();
                        break;
                    case 7:
                        DowngradeNetworkSpeed();
                        break;
                    case 8:
                        GetComputerSummary();
                        break;
                    case 9:
                        GetStatisticsSummary();
                        break;
                    case 10:
                        GetSpecificComputersSummary();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }


        }
        static void AddComputer()
        {

            Console.Write("Enter computer index to add (0 to max-1): ");
            int index;
            if (!GetIntFromUser(out index, 0, computers.Length - 1, -1))
            {
                Console.WriteLine("Invalid index. Please try again.");
                return;
            }

            computers[index] = new Computer($"Computer{index}");

            Console.Write($"Enter values for Computer{index} (HasCellularAntenna, HardDriveCapacity, RAM, SoftwareLicenses): ");
            string[] values = Console.ReadLine().Split(',');

            computers[index].HasCellAntenna = bool.Parse(values[0].Trim());
            computers[index].HardDriveStorage = int.Parse(values[1].Trim());
            computers[index].Ram = int.Parse(values[2].Trim());
            string[] licenseValues = values[3].Trim().Split(',');
            computers[index].Licenses = new int[licenseValues.Length];
            for (int i = 0; i < licenseValues.Length; i++)
            {
                computers[index].Licenses[i] = int.Parse(licenseValues[i]);
            }
        }


        static void SpecifyPrototypeComputer()
        {
            Console.Write("Enter values for Prototype computer (HasCellularAntenna, HardDriveCapacity, RAM, SoftwareLicenses): ");
            string[] values = Console.ReadLine().Split(',');

           

            userPrototypeComputer.HasCellAntenna = bool.Parse(values[0].Trim());
            userPrototypeComputer.HardDriveStorage = int.Parse(values[1].Trim());
            userPrototypeComputer.Ram = int.Parse(values[2].Trim());
            string[] licenseValues = values[3].Trim().Split(',');
            userPrototypeComputer.Licenses = new int[licenseValues.Length];
            for (int i = 0; i < licenseValues.Length; i++)
            {
                userPrototypeComputer.Licenses[i] = int.Parse(licenseValues[i]);
            }
        }

        static void RemovePrototypeComputer()
        {
            userPrototypeComputer = null;
            Console.WriteLine("User Prototype computer removed.");
        }

        static void UpgradeCloudStorage()
        {
            int upgradeLimit = 1600;
            bool canUpgrade = DoubleIntNotPastMax(ref CloudStorage, upgradeLimit, false);
            if (canUpgrade)
                Console.WriteLine("Cloud Storage upgraded to " + CloudStorage);
            else
                Console.WriteLine("Error - cannot exceed Cloud Storage limit.");
        }

        static void DowngradeCloudStorage()
        {
            int downgradeLimit = 500;
            bool canDowngrade = HalveValueNotPastMin(ref CloudStorage, downgradeLimit, true);
            if (canDowngrade)
                Console.WriteLine("Cloud storage downgraded to " + CloudStorage);
            else
                Console.WriteLine("Cannot downgrade Cloud Storage below " + CloudStorage);
        }

        static void UpgradeNetworkSpeed()
        {
            int upgradeLimit = 250000;
            bool canUpgrade = DoubleIntNotPastMax(ref NetworkSpeed, upgradeLimit, true);
            if (canUpgrade)
                Console.WriteLine("Network Speed upgraded to " + NetworkSpeed);
            else
                Console.WriteLine("Cannot upgrade Network Speed past " + upgradeLimit);
        }
        static void DowngradeNetworkSpeed()
        {
            int downgradeLimit = 10000;
            bool canDowngrade = HalveValueNotPastMin(ref NetworkSpeed, downgradeLimit, false);
            if (canDowngrade)
                Console.WriteLine("Network Speed downgraded to " + NetworkSpeed);
            else
                Console.WriteLine("Error - cannot go below Network Speed minimum.");

        }

        static void GetComputerSummary()
        {
            Console.WriteLine("Enter an index in the computer array to view a summary of that computer: ");
            int index;
            if (!GetIntFromUser(out index, 0, computers.Length - 1, -1))
            {
                Console.WriteLine("Invalid index. Please try again.");
                return;
            }

            Console.WriteLine(computers[index] ?? prototype);
            Console.WriteLine($"Cloud Storage: {CloudStorage}, Network Speed: {NetworkSpeed}");

        }






        static void GetStatisticsSummary()
        {
            int totalRAM = 0;
            int cellularAntennaCount = 0;
            double totalHardDriveCapacity = 0;
            int totalSoftwareLicenses = 0;
            int[] totalProgramLicenses = new int[5];

            int validComputersCount = 0;

            foreach (var computer in computers)
            {
                if (computer != null)
                {
                    totalRAM += computer.Ram;

                    if (computer.HasCellAntenna.HasValue)
                    {
                        cellularAntennaCount++;
                    }

                    if (computer.HardDriveStorage.HasValue)
                    {
                        totalHardDriveCapacity += computer.HardDriveStorage.Value;
                    }

                    if (computer.Licenses != null)
                    {
                        totalSoftwareLicenses += computer.Licenses.Length;

                        for (int i = 0; i < computer.Licenses.Length; i++)
                        {
                            totalProgramLicenses[i] += computer.Licenses[i];
                        }
                    }

                    validComputersCount++;
                }
                else if (userPrototypeComputer != null)
                {
                    totalRAM += userPrototypeComputer.Ram;

                    if (userPrototypeComputer.HasCellAntenna.HasValue)
                    {
                        cellularAntennaCount++;
                    }

                    if (userPrototypeComputer.HardDriveStorage.HasValue)
                    {
                        totalHardDriveCapacity += userPrototypeComputer.HardDriveStorage.Value;
                    }

                    if (userPrototypeComputer.Licenses != null)
                    {
                        totalSoftwareLicenses += userPrototypeComputer.Licenses.Length;

                        for (int i = 0; i < userPrototypeComputer.Licenses.Length; i++)
                        {
                            totalProgramLicenses[i] += userPrototypeComputer.Licenses[i];
                        }
                    }

                    validComputersCount++;
                }
            }

            if (validComputersCount > 0)
            {
                double averageRAM = totalRAM / (double)validComputersCount;
                double percentCellularAntenna = (cellularAntennaCount / (double)validComputersCount) * 100;
                double averageHardDriveCapacity = totalHardDriveCapacity / validComputersCount;
                double averageTotalSoftwareLicenses = totalSoftwareLicenses / (double)validComputersCount;

                Console.WriteLine($"Average RAM: {averageRAM}");
                Console.WriteLine($"Percent of computers with cellular antenna: {percentCellularAntenna}%");
                Console.WriteLine($"Average Hard Drive Capacity: {averageHardDriveCapacity}");
                Console.WriteLine($"Average Total Software Licenses: {averageTotalSoftwareLicenses}");

                for (int i = 0; i < totalProgramLicenses.Length; i++)
                {
                    double averageProgramLicenses = totalProgramLicenses[i] / (double)validComputersCount;
                    Console.WriteLine($"Average Licenses for Program {i + 1}: {averageProgramLicenses}");
                }

                Console.WriteLine($"Cloud Storage: {CloudStorage}, Network Speed: {NetworkSpeed}");
            }
            else
            {
                Console.WriteLine("No valid computers to calculate statistics.");
            }
        }

        static void GetSpecificComputersSummary()
        {
            Console.Write("Enter start index for summary: ");
            int startIndex;
            if (!GetIntFromUser(out startIndex, 0, computers.Length - 1, -1))
            {
                Console.WriteLine("Invalid start index. Please try again.");
                return;
            }

            Console.Write("Enter end index for summary: ");
            int endIndex;
            if (!GetIntFromUser(out endIndex, startIndex, computers.Length - 1, -1))
            {
                Console.WriteLine("Invalid end index. Please try again.");
                return;
            }

            int totalRAM = 0;
            int cellularAntennaCount = 0;
            double totalHardDriveCapacity = 0;
            int totalSoftwareLicenses = 0;
            int[] totalProgramLicenses = new int[5];

            int validComputersCount = 0;

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (i >= 0 && i < computers.Length && computers[i] != null)
                {
                    totalRAM += computers[i].Ram;

                    if (computers[i].HasCellAntenna.HasValue)
                    {
                        cellularAntennaCount++;
                    }

                    if (computers[i].HardDriveStorage.HasValue)
                    {
                        totalHardDriveCapacity += computers[i].HardDriveStorage.Value;
                    }

                    if (computers[i].Licenses != null)
                    {
                        totalSoftwareLicenses += computers[i].Licenses.Length;

                        for (int j = 0; j < computers[i].Licenses.Length; j++)
                        {
                            totalProgramLicenses[j] += computers[i].Licenses[j];
                        }
                    }

                    validComputersCount++;
                }
                else if (userPrototypeComputer != null)
                {
                    totalRAM += userPrototypeComputer.Ram;

                    if (userPrototypeComputer.HasCellAntenna.HasValue)
                    {
                        cellularAntennaCount++;
                    }

                    if (userPrototypeComputer.HardDriveStorage.HasValue)
                    {
                        totalHardDriveCapacity += userPrototypeComputer.HardDriveStorage.Value;
                    }

                    if (userPrototypeComputer.Licenses != null)
                    {
                        totalSoftwareLicenses += userPrototypeComputer.Licenses.Length;

                        for (int j = 0; j < userPrototypeComputer.Licenses.Length; j++)
                        {
                            totalProgramLicenses[j] += userPrototypeComputer.Licenses[j];
                        }
                    }

                    validComputersCount++;
                }
            }

            if (validComputersCount > 0)
            {
                double averageRAM = totalRAM / (double)validComputersCount;
                double percentCellularAntenna = (cellularAntennaCount / (double)validComputersCount) * 100;
                double averageHardDriveCapacity = totalHardDriveCapacity / validComputersCount;
                double averageTotalSoftwareLicenses = totalSoftwareLicenses / (double)validComputersCount;

                Console.WriteLine($"Average RAM: {averageRAM}");
                Console.WriteLine($"Percent of computers with cellular antenna: {percentCellularAntenna}%");
                Console.WriteLine($"Average Hard Drive Capacity: {averageHardDriveCapacity}");
                Console.WriteLine($"Average Total Software Licenses: {averageTotalSoftwareLicenses}");

                for (int i = 0; i < totalProgramLicenses.Length; i++)
                {
                    double averageProgramLicenses = totalProgramLicenses[i] / (double)validComputersCount;
                    Console.WriteLine($"Average Licenses for Program {i + 1}: {averageProgramLicenses}");
                }

                Console.WriteLine($"Cloud Storage: {CloudStorage}, Network Speed: {NetworkSpeed}");
            }
            else
            {
                Console.WriteLine("No valid computers to calculate statistics.");
            }
        }

        static bool GetIntFromUser(out int number, int min, int max, int defaultVal)
        {
            Console.Write($"Enter a number between {min} and {max} (Otherwise, value will revert to {defaultVal}). ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                number = defaultVal;
                return false;
            }

            if (int.TryParse(input, out number) && number >= min && number <= max)
            {

                return true;
            }

            number = defaultVal;
            return false;
        }

        static bool DoubleIntNotPastMax(ref int number, int max, bool setToMax)
        {
            if (number * 2 <= max)
            {
                number *= 2;
                return true;
            }
            else
            {
                if (setToMax)
                {
                    number = max;
                    return false;
                }
                else
                {
                    return false;
                }
            }
        }

        static bool HalveValueNotPastMin(ref int number, int min, bool setToMin)
        {
            if (number / 2 >= min)
            {
                number /= 2;
                return true;
            }
            else
            {
                if (setToMin)
                {
                    number = min;
                    return false;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}