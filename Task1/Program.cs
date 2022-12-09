//Задача 25: Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B.
//Нельзя использовать функцию Math.Pow
  
 //число, которое нужно возвести в степень
Console.Clear();
Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());                                     
  //степень числа
Console.Write("Введите число B (степень): ");
int n =  Convert.ToInt32(Console.ReadLine());      
    //число, возведенное в степень
int x=1;
for(int i=0; i<n; i++) 
{

x*=a;
}
Console.WriteLine($"{a} ^ {n} = {x}");
  

 
