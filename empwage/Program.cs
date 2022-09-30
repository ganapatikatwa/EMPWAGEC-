namespace empwage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem Part 3");

            Console.WriteLine("Output of Total Employee wage and Save Total Wage of company as :");
            //Creating Object of the class to call in Main method
            //because method is non static

            EmpWageBuilder dmart = new EmpWageBuilder("Dmart", 20, 2, 10);
            EmpWageBuilder reliance = new EmpWageBuilder("Reliance", 10, 4, 20);
            dmart.computeEmpWage();
            Console.WriteLine(dmart.toString());

            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());


        }
    }
}