Console.WriteLine("WelCome to Employee Wage Computation");
int present = 1;
Random random = new Random();
int status = random.Next(0, 2);
Console.WriteLine("status=" + status);
if (status == present)
{
    Console.WriteLine("Employee is Present");
}
else
{
    Console.WriteLine("Employee is Absent");
}