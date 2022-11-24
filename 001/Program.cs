Console.WriteLine("input numA");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input numB");
int numB = Convert.ToInt32(Console.ReadLine());
int step = numA;

for (int i = 1; i < numB; i++)
{
    step = step * numA;
}

Console.WriteLine("число A в степени B равно = " +step);


