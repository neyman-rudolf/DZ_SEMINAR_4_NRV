// Задача 25
//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// 
// Console.Write("Введите число A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// int Construction(int numberA, int numberB)
// {
//   int result = 1;
//   for(int i=1; i <= numberB; i++)
//   {
//     result = result * numberA;
//   }
//   return result;
// }
//   int Constr = Construction(numberA, numberB);
//   Console.WriteLine("Ответ: " + Constr);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

//   int SumNumber(int numberN)
//   {
    
//     int count = Convert.ToString(numberN).Length;
//     int category = 0;
//     int result = 0;

//     for (int i = 0; i < count; i++)
//     {
//       category = numberN - numberN % 10;
//       result = result + (numberN - category);
//       numberN = numberN / 10;
//     }
//    return result;
//   }

// int sumNumber = SumNumber(numberN);
// Console.WriteLine("Сумма цифр в числе: " + sumNumber);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//  int[] GetBinaryArray(int size)
// {
//     int[] result = new int[size]; 
//     for (int i = 0; i < result.Length; i++) 
//     {
//         result[i] = new Random().Next(0,100); 
//     }
//     return result;
// }
// int[] testArray = GetBinaryArray(8);
// Console.WriteLine($"Массив: [ {String.Join("; ",testArray)} ]");