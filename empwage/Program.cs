int workinghrs = 0;
int fulltime= 1;
int wageperhr = 20;
Random random =new Random();
int result = random.Next(0, 2);
{
if(result==1)
{
  workinghrs = 8;
Console.WriteLine("Employee is working Full day=8", workinghrs);
Console.WriteLine("Wage per hr=20",wageperhr);
int fulldaywage = workinghrs * wageperhr;
Console.WriteLine(workinghrs * wageperhr );
}
  else
  {
  Console.WriteLine("Employee is absent");
  }
}

