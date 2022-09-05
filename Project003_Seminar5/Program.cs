// S Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] newArray = new double[20];
  for (int i = 0; i < newArray.Length; i++ )
  {
    newArray[i] = new Random().Next(1, 100);
    Console.Write(newArray[i] + " ");
  }

double maxNumber = newArray[0];
double minNumber = newArray[0];

  for (int i = 1; i < newArray.Length; i++)
  {
    if (maxNumber < newArray[i])
    {
      maxNumber = newArray[i];
    }
        if (minNumber > newArray[i])
    {
      minNumber = newArray[i];
    }
  }

  double result = maxNumber - minNumber;

  Console.WriteLine($"Разница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {result}");
