// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


System.Console.WriteLine("Введите число M: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int a);
int[] arrayNum = new int[a];
InputNumbers(a);

if (!isNumber)
{
    System.Console.WriteLine("Это не число");
    return;
}

void InputNumbers(int a)
{
for (int i = 0; i < a; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    arrayNum[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] arrayNum2)
{
  int count = 0;
  for (int i = 0; i < arrayNum2.Length; i++)
  {
    if(arrayNum2[i] > 0 ) count += 1; 
  }
  return count;
}


Console.WriteLine($"Чисел больше 0: {Comparison(arrayNum)} ");

