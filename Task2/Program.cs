// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

Console.WriteLine("Введите координату X(где x ≠ 0): ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber == 0)
{
    Console.WriteLine("X не может быть равен 0");
}
Console.WriteLine("Введите координату Y(где y ≠ 0): ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (secondNumber == 0)
{
    Console.WriteLine("Y не может быть равен 0");
}

if (firstNumber > 0 && secondNumber > 0)
{
    Console.WriteLine("Данные координаты в первой плоскости");
}
if (firstNumber > 0 && secondNumber < 0)
{
    Console.WriteLine("Данные координаты в четвертой плоскости");
}
if (firstNumber < 0 && secondNumber > 0)
{
    Console.WriteLine ("Данные координаты во второй плоскости");
}
if (firstNumber <0 && secondNumber < 0)
{
    Console.WriteLine("Данные координаты в третьей плоскости");
}
