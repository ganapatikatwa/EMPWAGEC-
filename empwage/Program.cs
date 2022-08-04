class Program
{
    public const int FULL_TIME = 1;
    public const int PART_TIME = 2;
    public const int EMP_RATE_PER_HR = 20;
    public const int MAX_WORKING_DAYS = 20;
    public const int MAX_WORKING_HRS = 100;
    static void Main(string[] args)
    {
        int EmpHours = 0;
        int EmpWage = 0;
        int TotalWage = 0;
        int WrorkingDays = 1;
        int WorkingHrs = 0;

        Random random = new Random();
        while (WrorkingDays <= MAX_WORKING_DAYS && WorkingHrs <= MAX_WORKING_HRS)
        {
            int EmpInput = random.Next(0, 3);
            
            switch (EmpInput)
            {
                case FULL_TIME:
                    EmpHours = 8;
                    break;
                case PART_TIME:
                    EmpHours = 4;
                    break;
                default:
                    EmpHours = 0;
                    break;
            }
            
            EmpWage = EMP_RATE_PER_HR * EmpHours;
            WorkingHrs += EmpHours;
            TotalWage += EmpWage;
            if (EmpInput != 0)
            {
                WrorkingDays++;
            }
        }
        Console.WriteLine("WorkingHrs = " + WorkingHrs + " Working days =" + WrorkingDays);
        Console.WriteLine("Employee wage for " + MAX_WORKING_DAYS + "days = " + TotalWage);
        Console.Read();
    }
}