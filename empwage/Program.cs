namespace empwage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem Part 4");

            Console.WriteLine("Output to get Total wage when quired by Company Using Interface Approach :");


            EmpWageBuilderArray builder = new EmpWageBuilderArray();
            builder.addCompanyEmpWage("Dmart", 20, 2, 10);
            builder.addCompanyEmpWage("Reliance", 10, 4, 20);
            builder.computeEmpWage();

        }
    }
}