Console.Write("Эта программа найдет максимальное значение двух чисел. Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine(num1 + " - Это максимальное из двух чисел");
    Console.WriteLine(num2 + " - Это минимальное из двух чисел");
}
else
{
    Console.WriteLine(num2 + " - Это максимальное из двух чисел");
    Console.WriteLine(num1 + " - Это минимальное из двух чисел");
}