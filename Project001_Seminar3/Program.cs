//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.WriteLine("Введите пятизначное число:");
//         string str = NewMethod();
//         int a = 0;
//         for (int i = 0; i < str.Length / 2; i++)
//         {
//             if (str.Substring(i, 1) != str.Substring(str.Length - 1 - i, 1))
//             {
//                 Console.WriteLine("Число {0} не является палиндромом", str);
//                 break;
//             }
//             else
//                 a = 1;
//         }
//         if (a == 1) Console.WriteLine("Число {0} является палиндромом", str);
//     }

//     private static string NewMethod()
//     {
//         return Console.ReadLine();
//     }
// }
//
//


Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Число {number} является палиндромом.");
  }
  else Console.WriteLine($"Число {number} не явялется палиндромом.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Введите правильное число");