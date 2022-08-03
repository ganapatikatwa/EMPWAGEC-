int workinghrs = 0;
const int isparttime = 1;
const int isfulltime = 2;
int wageperhr = 20;

Random random =new Random();
int result = random.Next(0, 3);
Console.WriteLine("result" + result);
switch (result)
{ case isparttime:
        workinghrs = 8;
        Console.WriteLine("Working Hrs:" + workinghrs);
        Console.WriteLine("Part Time");
        break;
    case isfulltime:
        workinghrs = 16;
        Console.WriteLine("Working Hrs:" + workinghrs);
        Console.WriteLine("Full Time");
        break;
    default:
        workinghrs = 0;
        Console.WriteLine("Working Hrs:" + workinghrs);
        Console.WriteLine("Absent");
        break;
}






