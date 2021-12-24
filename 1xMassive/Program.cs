//Задание 3

Massives1x mass = new Massives1x(10/*длина массива*/, 2/*шаг*/, 1/*начало*/, 2/*Multi*/);

mass.GetMassive();
mass.PrintMassive();
int sum = mass.Sum();

Console.WriteLine($"{sum} == сумма");

int[] NewArray  = mass.Inverse();

for (int i = 0; i < NewArray.Length; i++)
{
    Console.Write($"{NewArray[i]} \t");
}

Console.WriteLine();
int[] NewArray2 = mass.Multi();

Console.Write("Числа умноженные на MULL ___ ");
for (int i = 0;i < NewArray2.Length; i++)
{
    Console.Write($"{NewArray2[i]} \t" );
}
Console.WriteLine();
int Max = mass.MaxCount();
Console.WriteLine($"Число элементов = {Max}");