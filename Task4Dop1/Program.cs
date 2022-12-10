//Дана последовательность из N целых чисел и число K. 
//Необходимо сдвинуть всю последовательность (сдвиг - циклический) 
//на |K| элементов вправо, если K – положительное и влево, если отрицательное.

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Введите {i} элемент массива: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите число для сдвига: ");
int k = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(k) > n) k %= n;    // Этот метод возвращает абсолютное значение числа, 
if (k > 0)                      // если число неотрицательное, то его и возвращает,
k = n - k;                      // а если отрицательное - отбрасывает знак "минус"
else if (k < 0)
    k = Math.Abs(k);

for (int i = k; i < n; i++)

Console.Write($" [ {arr[i]} ]   ");

for (int i = 0; i < k; i++)
    
Console.Write($" [ {arr[i]} ]   ");