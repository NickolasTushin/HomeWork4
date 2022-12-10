//Задача 29: Напишите программу, которая спрашивает у пользователя кол-во элементов и спршивает сами элементы. 
//После записи элементов в массив, необходимо его вывести на экран.
//8
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[]arr = new int[n];
void FillArray(int []arr)
{
    int length = arr.Length;       // Размер массива
    int i = 0;
while (i < length)
{
 Console.WriteLine("Введите элемент массива:  ");
 arr[i] = Convert.ToInt32(Console.ReadLine()); 
 i++;
}
}
void PrintArray(int []arr)
{
int count = arr.Length;
int p = 0;
while (p < count)
{ 


Console.WriteLine( " индекс " + p + $"\tприсвоено значение [{arr[p]}] ");
p++;
}
}
FillArray(arr);
PrintArray(arr);