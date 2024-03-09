namespace Calculator
{
    class CalcUI
    {
        public void Start()
        {
            Console.WriteLine("Please select the operation: ");
            Console.WriteLine("1. Adding");
            Console.WriteLine("2. Subtracting");
            Console.WriteLine("3. Multiplying");
            Console.WriteLine("4. Dividing");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please specify the first operator:");
                    float add_op1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please specify the second operator:");
                    float add_op2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"Your result is: {CalcEngine.Adding(add_op1, add_op2)}");                    
                    break;
                case 2:
                    Console.WriteLine("Please specify the first operator:");
                    float sub_op1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please specify the second operator:");
                    float sub_op2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"Your result is: {CalcEngine.Subtracting(sub_op1, sub_op2)}");                    
                    break;
                case 3:
                    Console.WriteLine("Please specify the first operator:");
                    float mul_op1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please specify the second operator:");
                    float mul_op2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"Your result is: {CalcEngine.Multiplying(mul_op1, mul_op2)}");                    
                    break;
                case 4:
                    Console.WriteLine("Please specify the first operator:");
                    float div_op1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please specify the second operator:");
                    float div_op2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"Your result is: {CalcEngine.Dividing(div_op1, div_op2)}");                    
                    break;
                case 5:
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