Console.WriteLine("Введите два числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"Наибольшее число: {a}");
}
else 
{
    Console.WriteLine($"Наибольшее число: {b}");
}