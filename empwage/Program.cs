class Program
{
    
    public const int FULL_TIME = 1;
    public const int PART_TIME = 2;
    public const int EMP_RATE_PER_HR = 20;
    public const int WORKING_DAYS = 20;
    static void Main(string[] args)
    {
        
        int EmpHours = 0;
        int EmpWage = 0;
        int TotalWage = 0;

        
        Random random = new Random();

        
        for (int day = 1; day <= WORKING_DAYS; day++)
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
            TotalWage += EmpWage;
        }
        Console.WriteLine("Employee wage for " + WORKING_DAYS + "days = " + TotalWage);
        Console.Read();
    }
}






