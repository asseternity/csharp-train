// import
using ToDoList;
using Calculator;
using WritingTracker;
// --- TO DO LIST CONSOLE APP ---
namespace ToDoList
{
// class Program that will put it all together
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please select the application:");
            Console.WriteLine("1: To Do List");
            Console.WriteLine("2: Calculator");
            Console.WriteLine("3: Writing Tracker");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ConsoleUI consoleUI = new ConsoleUI();
                    consoleUI.Start();
                    break;
                case 2:
                    CalcUI calcUI = new CalcUI();
                    calcUI.Start();
                    break;
                case 3:
                    WT_UI wt_UI = new WT_UI();
                    wt_UI.Start();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine();
                    Program.Main();
                    break;
            }
        }
    }
}