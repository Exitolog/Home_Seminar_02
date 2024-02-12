System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 1)
{
    bool result1 = number % 7 == 0;
    bool result2 = number % 23 == 0;
    if (result1==result2)
    {
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}
}