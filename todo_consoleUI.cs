namespace ToDoList
{
    // ConsoleUI class will house behaviors and events for using the console to interact with the TaskManager, and retrieve the tasks
    class ConsoleUI
    {
        public void Start()
        {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Edit Task");
            Console.WriteLine("3. Delete Task");
            Console.WriteLine("4. Complete Task");
            Console.WriteLine("5. Display All Tasks");
            Console.WriteLine("6. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please write the task description:");
                    string description = Console.ReadLine();
                    TaskManager.AddTask(description);
                    Console.WriteLine();
                    this.Start();
                    break;
                case 2:
                    Console.WriteLine("Enter the task number to edit:");
                    int editIndex = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("Enter the new task description:");
                    string editDescription = Console.ReadLine();
                    TaskManager.EditTask(editIndex, editDescription);
                    Console.WriteLine();
                    this.Start();
                    break;
                case 3:
                    Console.WriteLine("Enter the task number to delete:");
                    int deleteIndex = int.Parse(Console.ReadLine()) - 1;
                    TaskManager.DeleteTask(deleteIndex);
                    Console.WriteLine();                    
                    this.Start();
                    break;
                case 4:
                    Console.WriteLine("Enter the task number to mark as completed:");
                    int completeIndex = int.Parse(Console.ReadLine()) - 1;
                    TaskManager.CompleteTask(completeIndex);
                    Console.WriteLine();
                    this.Start();
                    break;
                case 5:
                    TaskManager.DisplayTasks();
                    Console.WriteLine();
                    this.Start();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine();
                    this.Start();
                    break;
            }
        }
    }

}