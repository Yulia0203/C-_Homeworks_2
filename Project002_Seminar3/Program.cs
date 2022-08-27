// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



System.Console.Write("Введите координату x первой точки A: ");
bool isNumberX_1 = int.TryParse(Console.ReadLine(), out int x1);

System.Console.Write("Введите координату y первой точки A: ");
bool isNumberY_1 = int.TryParse(Console.ReadLine(), out int y1);

System.Console.Write("Введите координату z первой точки A: ");
bool isNumberZ_1 = int.TryParse(Console.ReadLine(), out int z1);

System.Console.Write("Введите координату x второй точки B: ");
bool isNumberX_2 = int.TryParse(Console.ReadLine(), out int x2);

System.Console.Write("Введите координату y второй точки B: ");
bool isNumberY_2 = int.TryParse(Console.ReadLine(), out int y2);

System.Console.Write("Введите координату z третьей точки B: ");
bool isNumberZ_2 = int.TryParse(Console.ReadLine(), out int z2);

if(!isNumberX_1 || !isNumberX_2 || !isNumberZ_1 || !isNumberY_1 || !isNumberY_2 || !isNumberZ_2)
{
     System.Console.WriteLine("Числа введены неверно!");
    return;
}

System.Console.WriteLine($"Расстояние между двумя точками: {GetLenght(x1, y1, z1, x2, y2, z2)}");
double GetLenght(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}



// int Coordinate(string coorName, string pointName)
// {
//     Console.Write($"Введите координату {coorName} точки {pointName}: ");
//     return Convert.ToInt16(Console.ReadLine());
// }

// double Decision(double x1, double x2, 
//                 double y1, double y2, 
//                 double z1, double z2){
//   return Math.Sqrt(Math.Pow((x2-x1), 2) + 
//                    Math.Pow((y2-y1), 2) + 
//                    Math.Pow((z2-z1), 2));
// }

// double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

// Console.WriteLine($"Длина отрезка  {segmentLength}");