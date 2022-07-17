Console.Write("Эта программа найдет максимальное значение из трех чисел. Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());

int max = num1;

if(num2 > max)
{
    if(num2 > num3)
    {   
        max = num2;
        Console.WriteLine(max + " - Это максимальное из трех чисел");
    }
}
if(num3 > max)
{
    max = num3;
    Console.WriteLine(max + " - Это максимальное из трех чисел");
}
else
{
    Console.WriteLine(max + " - Это максимальное из трех чисел");
}