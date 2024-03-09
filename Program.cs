// import
using ToDoList;
using Calculator;
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
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine();
                    Program.Main();
                    break;
            }
        }
    }
}