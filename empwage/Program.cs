namespace empwage
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem Part 3");
            Console.WriteLine("Output of Total Employee wage for a Month  :");
            EmloyeeWage emp = new EmloyeeWage();
            emp.ComputeEmpWage();

        }
    }
}