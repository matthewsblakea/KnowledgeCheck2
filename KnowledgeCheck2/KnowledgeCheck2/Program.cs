namespace KnowledgeCheck2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PC Inventory. How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Laptop>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var pc = new Laptop();

                Console.WriteLine("What is the manufacturer?");
                pc.manufacturer = Console.ReadLine();

                Console.WriteLine("How many gigabytes of memory does the PC have?");
                pc.numberGigaBytesOfRAM = int.Parse(Console.ReadLine());

                Console.WriteLine("What processor does the device have?");
                pc.processor = Console.ReadLine();

                Console.WriteLine("What GPU does the device have? If none type 'none'.");
                pc.gpu = Console.ReadLine();

                Console.WriteLine("How big is the laptop's screen in inches?");
                pc.screenSizeInches = float.Parse(Console.ReadLine());

                Console.WriteLine("Is the laptop a 2-in-1? True or false.");
                pc.isTwoInOne = bool.Parse(Console.ReadLine());

                recordList.Add(pc);
            }

            // Print out the list of records using Console.WriteLine()
            foreach (var pc in recordList)
            {
                Console.WriteLine(pc);
            }
            }
        }
    }
