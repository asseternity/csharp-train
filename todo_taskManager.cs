namespace ToDoList
{
    // TaskManager class will house behaviors for adding, editing and deleting tasks, assigning priorities (default priority 0)
        class TaskManager
        {
            public static List<Task> currentTasks = new List<Task>();
            public static void AddTask(string description) 
            {
                currentTasks.Add(new Task { Description = description, IsCompleted = false, Priority = 0});
            }
            public static void EditTask(int index, string newDescription) 
            {
                currentTasks[index].Description = newDescription;
            }
            public static void DeleteTask(int index)
            {
                currentTasks.RemoveAt(index);
            }
            public static void CompleteTask(int index)
            {
                currentTasks[index].IsCompleted = true;
            }
            public static void DisplayTasks()
            {
                for (int i = 0; i < currentTasks.Count; i++) {
                    Console.WriteLine($"{i+1}) {currentTasks[i].Description}. Completed: {(currentTasks[i].IsCompleted ? "[X]" : "[_]")}.");
                }
            }
    }
}