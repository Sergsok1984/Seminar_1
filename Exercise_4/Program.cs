Console.WriteLine("Введите три числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine($"Максимальное число: {a}");    
}
else if (b > c)
{
    Console.WriteLine($"Максимальное число: {b}");   
}
else 
{
    Console.WriteLine($"Максимальное число: {c}"); 
}
