Console.Write("Эта программа выведет четное число или нет. Введите число: ");
int num1 = int.Parse(Console.ReadLine());

if(num1 % 2 == 0)
{
    Console.WriteLine(num1 + " - Это четное число.");
}
else
{
    Console.WriteLine(num1 +" - Это нечетное число.");
}