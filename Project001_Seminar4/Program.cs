// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


  System.Console.WriteLine("Введите число A: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int n);

  System.Console.WriteLine("Введите число B: ");
bool isNumber2 = int.TryParse(Console.ReadLine(), out int m);

if (!isNumber || !isNumber2)
{
    System.Console.WriteLine("Это не число");
    return;
}
int GetDegreeNumber (int number1, int number2)
{
    if (number1 < 1)
    {
        return 0;
    }
    int result = 1;
    for (int i = 1; i <= number2; i++)
    {
        result = result * number1;
    }
    return result;
}

  int degree = GetDegreeNumber(n, m);
  Console.WriteLine("Ответ: " + degree);

