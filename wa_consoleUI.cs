namespace WritingTracker
{
    class WT_UI
    {
        public void Start()
        {

            TrackerManager.CreateWeek();

            Console.WriteLine("Please select the number of the day of the week to modify (1 = Monday, etc.). To view the current week, type '0'.");

            int choice = int.Parse(Console.ReadLine());
            int weekday = 0;

            switch (choice)
            {
                case 0:
                    foreach (var day in TrackerManager.currentWeek)
                    {
                        Console.WriteLine($"{day.DayOfTheWeek}: {day.Entry}. Wrote: {day.DidWriting}.");
                    }
                    break;
                case 1:
                    weekday = 1;
                    Console.WriteLine();
                    Console.WriteLine("You selected Monday.");
                    break;
                case 2:
                    weekday = 2;
                    Console.WriteLine();
                    Console.WriteLine("You selected Tuesday.");
                    break;
                case 3:
                    weekday = 3;
                    Console.WriteLine();
                    Console.WriteLine("You selected Wednesday.");
                    break;
                case 4:
                    weekday = 4;
                    Console.WriteLine();
                    Console.WriteLine("You selected Thursday.");
                    break;
                case 5:
                    weekday = 5;
                    Console.WriteLine();
                    Console.WriteLine("You selected Friday.");
                    break;
                case 6:
                    weekday = 6;
                    Console.WriteLine();
                    Console.WriteLine("You selected Saturday.");
                    break;
                case 7:
                    weekday = 7;
                    Console.WriteLine();
                    Console.WriteLine("You selected Sunday.");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Please select a valid day.");
                    Start();
                    break;
            }
            
            Console.WriteLine();
            Console.WriteLine("Please write the writing journal entry:");
            string entry = Console.ReadLine();
            TrackerManager.AddEntry(choice, entry);

            Console.WriteLine();
            Console.WriteLine("Did you also write on that day? (Y/N)");
            string wrote = Console.ReadLine();
            switch (wrote)
            {
                case "Y":
                    TrackerManager.WroteToday(weekday);
                    Start();
                    break;
                case "N":
                    Start();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Please try again.");
                    Start();
                    break;
            }
        }
    }
}