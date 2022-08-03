int workinghrs = 0;
int isparttime = 1;
int isfulltime = 2;
int wageperhr = 20;

Random random =new Random();
int result = random.Next(0, 3);
Console.WriteLine("result" + result);
if (result == isparttime)
{
    workinghrs = 8;
    Console.WriteLine("Part Workinghrs:" + workinghrs);
    Console.WriteLine(workinghrs * wageperhr);
}
else if (result == isfulltime)
{
    workinghrs = 16;
    Console.WriteLine("Full time Workinghrs:" + workinghrs);
    Console.WriteLine(workinghrs * wageperhr);
}
else
        { workinghrs = 0;
    Console.WriteLine("No Working Hrs:" + workinghrs);
    Console.WriteLine(workinghrs * wageperhr);
}


