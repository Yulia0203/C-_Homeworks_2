//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


System.Console.WriteLine("Введите положительное число: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int N);

if(!isNumberN)
{
    System.Console.WriteLine("Вы ввели не число!");
    return;
}

PrintCube(GetCube(N));
int[] GetCube(int n)
{
    int i = 1;
    int[] result = new int[n];
    while (i <= n)
    {
        result[i-1] = (int) Math.Pow (i, 3);
        i++;
    }
    return result;
}
void PrintCube(int [] cube)
{
    int i = 0;
    int lenght = cube.Length;
    while (i < lenght)
    {
        System.Console.WriteLine((cube[i]));
        i++;
    }
}

