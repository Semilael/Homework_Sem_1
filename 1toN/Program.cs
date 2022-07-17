Console.Write("Эта программа выведет ряд четных чисел до введенного числа. Введите число: ");
int N = int.Parse(Console.ReadLine());
int CountN = 1;

while(CountN < N)
{
    if(CountN % 2 == 0)
    {
        Console.WriteLine(CountN);
    }
    CountN++;    
}
