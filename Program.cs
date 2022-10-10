// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом. 
//  (можно решить через строку, а можно математически)
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите число: ");
// string number = Console.ReadLine()!;

// void CheckingNumber(string number){
//   if (number[0]==number[4] || number[1]==number[3]){
//     Console.WriteLine($"Ваше число: {number} - да.");
//   }
//   else Console.WriteLine($"Ваше число: {number} - нет.");
// }
// if (number!.Length == 5){
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Введи правильное число");

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.WriteLine("Введите координату X1 точки A");
// int X1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Y1 точки A");
// int Y1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Z1 точки A");
// int Z1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату X2 точки B");
// int X2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Y2 точки B");
// int Y2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Z2 точки B");
// int Z2 = int.Parse(Console.ReadLine()!);

// double result = Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2)+Math.Pow(Z2-Z1,2));
// Console.WriteLine($"{result:f2}");


// Задача 23

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.WriteLine ("Введите число" );
// int N = int.Parse(Console.ReadLine()!);
// int number = 1;
// while(number<N){
// double result = Math.Pow(number,3);
// Console.Write($"{result}, "); 
// number++;
// }
// Console.Write($"{Math.Pow (N,3)} ");