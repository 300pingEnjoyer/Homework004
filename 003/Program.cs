int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray;
}
void ShowArray (int[] array)
{
    Console.Write("Получившийся массив -> ");
   for (int i = 0; i < array.Length; i++)
   {
    Console.Write(array[i]+ " ");
   } 
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a,min,max);
ShowArray(myArray);
