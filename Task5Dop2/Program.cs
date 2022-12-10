
Console.Write("Введите четное число больше двух: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 2 || n % 2 !=0)
{
    Console.WriteLine("Введите правильное число; ");
    n = Convert.ToInt32(Console.ReadLine());
}
int[]arr = new int[n];
n = arr.Length;
int i = 0;
int sum = n;
void FillArray(int []arr)
{
    int length = arr.Length;      
    int i = 0;
while (i < length)
{
    for (i = 0; i <= length; i ++) 
{
    arr[i] += i;
    Console.Write($"  [ {i} ]  ");
}
}
}
for ( i = 0; i < n; i++ )
{
    for (int y = 1; y < n; y++)
{
        sum = arr[i] + arr[y];
        if (sum == arr.Length)
        {
          Console.Write($"  [ {sum} ]  ");
        }
        {
        Console.Write($"  [ {sum} ]  ");
        }
}
}
FillArray(arr);
