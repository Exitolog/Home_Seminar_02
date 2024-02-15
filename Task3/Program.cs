Console.WriteLine("Введите натуральное чило от 10 до 99: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >=10 && number <= 99)
{
    int firstNumber = number / 10;
    int secondNumber = number % 10;
    if (firstNumber > secondNumber)
    {
        Console.WriteLine(firstNumber);
    }
    else 
    {
        Console.WriteLine(secondNumber);
    }
}
else 
{
    Console.WriteLine("Вы ввели число не из указаного диапазона");
}