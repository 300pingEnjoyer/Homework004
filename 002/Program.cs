Console.WriteLine("input number");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (num > 0)
{                       
    int ed = num % 10; 
    num = num / 10;  
    sum = sum + ed;
}
Console.WriteLine("сумма числа = " +sum);