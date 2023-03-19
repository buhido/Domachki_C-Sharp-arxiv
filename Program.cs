//// See https://aka.ms/new-console-template for more information
//using System.Globalization;

//Console.WriteLine("Hello, World!");



//                                           Квадрат числа
//int i = 5;
//int result = i * i;
//Console.WriteLine(result);


//                                            Квадрат числа
//int i = int.Parse(Console.ReadLine());
//int result = (int)Math.Pow(i, 2);
//Console.WriteLine($"Квадрат {i} это {result}");


// Сумма чисел
//int numberA = 3;
//int numberB = 5;
//int result = numberA + numberB;
//Console.WriteLine(result);


//                                    Определение большего числа
//int a = 2;
//int b = 10;
//int max = a;
//int min = b;
//if (a > max) max = a;
//if (b > max) max = b;
//if (a < min) min = a;
//if (b < min) min = b;
//Console.Write("-> max =");
//Console.WriteLine(max);
//Console.Write("-> min =");
//Console.WriteLine(min);


//int a = 44;
//int b = 5;
//int c = 78;
//int max = a;
//if (a > max) max = a;
//if (b > max) max = b;
//if (c > max) max = c;
//Console.Write("->");
//Console.WriteLine(max);


//                                                 Определить третье число в трехзначном.
//Console.WriteLine("Введите число");
//int a = int.Parse(Console.ReadLine());
//string number = a.ToString();
//if (number.Length == 3)
//{
//    Console.WriteLine("Третья : " + number[2]);
//}
//else
//{
//    Console.WriteLine("Вы ввели не трехзначное число");
//}



//Console.WriteLine("Введите число");
//int a = Convert.ToInt32(Console.ReadLine());
//string number = Convert.ToString(a);
//if (number.Length == 3)
//{
//    Console.WriteLine("Третья : " + number[2]);
//}
//else
//{
//    Console.WriteLine("Вы ввели не трехзначное число");
//}


//                            Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Console.WriteLine("Введите число a");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите число b");
//int b = int.Parse(Console.ReadLine());
//int max = a;
//int min = b;
//if (a > max) max = a;
//if (b > max) max = b;
//if (a < min) min = a;
//if (b < min) min = b;
//Console.Write("-> max =");
//Console.WriteLine(max);
//Console.Write("-> min =");
//Console.WriteLine(min);


//                                 Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//Console.WriteLine("Введите число a");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите число b");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите число c");
//int c =int.Parse(Console.ReadLine());
//int max = a;
//if (a > max) max = a;
//if (b > max) max = b;
//if (c > max) max = c;
//Console.Write("Максимальное число ->");
//Console.WriteLine(max);


//                  Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//Console.WriteLine("Введите число");
//int n = int.Parse(Console.ReadLine());
//if (n % 2 == 0)
//      Console.Write("Да");
//if (n % 2 != 0)
//      Console.Write("Нет");



//                               Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//Console.WriteLine("Введите число");
//int N = int.Parse(Console.ReadLine());
//for (int i = 1; i <= N; i++) 
//   if (i % 2 == 0)
//   Console.WriteLine(i);




//                                         Задача 10 Показать вторую цифру трехзначного числа.


//Console.Write("Введите трехзначное значение: ");
//int i = int.Parse(Console.ReadLine()!);
//string array = i.ToString(); // Строковое представление , например:918
//if (i > 0)
//    Console.WriteLine(array[1]);  // Вывод в консоль значение индекса 1 : это у строки 918 будет 1
//if (i < 0)
//    Console.WriteLine(array[2]);  // Если значение отрицательное, например -918



//                                             Задача 13 Вывод третьей цифры или вывести её отсутствие.

//Console.Write("Введите значение: ");
//int i = int.Parse(Console.ReadLine()!);
//if (i <= 99)
//{
//    Console.WriteLine("Третьей цифры нет!");
//}
//else
//{
//    string array = i.ToString(); // Строковое представление, например: 645
//    Console.WriteLine(array[2]);  // Вывод в консоль значение индекса 2 : это у 645 будет 5
//}



//                            Задача 15 Вывод дней недели при вводе цифры дня недели и вывод выходного дня, если цифра соответствует.

//int number = int.Parse(Console.ReadLine());

//if (number == 6 || number == 7)
//{
//    Console.WriteLine("Выходной");
//}
//switch (number)
//{
//    case 1:
//        Console.WriteLine("Понедельник");
//        break;
//    case 2:
//        Console.WriteLine("Вторник");
//        break;
//    case 3:
//        Console.WriteLine("Среда");
//        break;
//    case 4:
//        Console.WriteLine("Четверг");
//        break;
//    case 5:
//        Console.WriteLine("Пятница");
//        break;
//    case 6:
//        Console.WriteLine("Суббота");
//        break;
//    case 7:
//        Console.WriteLine("Воскресенье");
//        break;
//    default:
//        break;
//}




//                                                                            Базовые алгоритмы
//                                                             19.Проверить является ли число палиндромом

//Console.Write("Введите пятизначное значение: ");
//int i = int.Parse(Console.ReadLine()!);
//string array = i.ToString(); // Строковое представление , например: 23432
//if (array[0] == array[4] || array[1] == array[3])
//{
//    Console.WriteLine("Это палиндром: " + i);
//}
//else
//{
//    Console.WriteLine(i + " => Не является палиндромом");
//}


//                                   Задача 21 Найти расстояние между двумя точками с заданными координатами в 3Д пространстве.
//                                              формула квадрата расст. между двумя точками в 3Д  s^2=(z2-z1)^2+(y2-y1)^2+(x2-x1)^2

//Console.WriteLine("Введите координаты точки А :");
//Console.WriteLine("Координата x1");
//double x1 = double.Parse(Console.ReadLine()!);
//Console.WriteLine("Координата y1");
//double y1 = double.Parse(Console.ReadLine()!);
//Console.WriteLine("Координата Z1");
//double z1 = double.Parse(Console.ReadLine()!);
//Console.WriteLine("Введите координаты точки В :");
//Console.WriteLine("Координата x2");
//double x2 = double.Parse(Console.ReadLine()!);
//Console.WriteLine("Координата y2");
//double y2 = double.Parse(Console.ReadLine()!);
//Console.WriteLine("Координата Z2");
//double z2 = double.Parse(Console.ReadLine()!);
//double s = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
//Console.WriteLine($"Расстояние между точками {s}");


//                                                  Задача 23  Выдать таблицу кубов чисел от 1 до N


//Console.WriteLine("Введите число");
//int N = int.Parse(Console.ReadLine());
//for (int i = 1; i <= N; i++)
//{
//    Console.Write("Cube: ");
//    Console.WriteLine($"{Math.Pow(i, 3)}, ");
//}


//                    Задача  25   Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

  // Примеры: 3, 5 -> 243 
  //          2, 4 -> 16
//     int numberA = ReadInt("Введите число A: ");
//     int numberB = ReadInt("Введите число B(степень числа А): ");
//     Degree(numberA, numberB);

//     void Degree(int A, int B)  // Функция для возведения в степень
//     {
//         int result = 1;
//         for (int i = 1; i <= B; i++)
//         {
//             result *= A;
//         }
//         Console.WriteLine("Результат:  " + result);
//     }

//     int ReadInt(string input)  // Функция для ввода входных чисел
//     {
//         Console.WriteLine(input);
//         return Convert.ToInt32(Console.ReadLine());
//     }


//                                  Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
  //452 -> 11
  //82 -> 10
  //9012 -> 12

//     int number = ReadInt("Введите число: ");
//     int len = NumberLen(number);
//     SumNumbers(number, len);

//     // Функция ввода
//     int ReadInt(string input)
//     {
//         Console.Write(input);
//         return Convert.ToInt32(Console.ReadLine());
//     }
//         // Функция подсчета цифр в числе
//     int NumberLen(int a)
//     {
//         int index = 0;
//         while (a > 0)
//         {
//             a /= 10;
//             index++;
//         }
//         return index;
//     }
//        // Функция вывода суммы цифр в числе
//     void SumNumbers(int n, int len)
//     {
//         int sum = 0;
//         for (int i = 1; i <= len; i++)
//         {
//             sum += n % 10;
//             n /= 10;
//         }
//         Console.WriteLine(sum);
//     }


//                            Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    //8 -> [1, 2, 5, 7, 4, 11, 16, 19]

//     int lenArray = ReadInt("Введите длину массива: ");

//     int[] randomArray = new int[lenArray];
//     for (int i = 0; i < randomArray.Length; i++)
//     {
//         randomArray[i] = new Random().Next(1, 9);
//         Console.Write(randomArray[i] + " ");
//     }
//         // Функция ввода
//     int ReadInt(string input)
//     {
//         Console.Write(input);
//         return Convert.ToInt32(Console.ReadLine());
//     }

//                              Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
    //                                      Напишите программу, которая покажет количество чётных чисел в массиве.
    //[345, 897, 568, 234] -> 2

//     Console.WriteLine("Введите длину массива:  ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] numbers = new int[size];
//     RandomNumbers(numbers);
//     Console.WriteLine("В этом массиве: ");
//     PrintArray(numbers);

//     void RandomNumbers(int[] numbers)                //случайные числа       
//     {
//         for (int i = 0; i < size; i++)
//         {
//             numbers[i] = new Random().Next(100, 1000);
//         }
//     }

//     int count = 0;

//     for (int x = 0; x < numbers.Length; x++)          //цикл счетчика четных чисел    
//     {
//         if (numbers[x] % 2 == 0)                       
//             count++;
//     }
//     Console.WriteLine($"из {numbers.Length} чисел, {count} четных");


//     void PrintArray(int[] numbers)                 
//     {
//         Console.Write("[");
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine();
//     }

//                                                              Задача 36
//                           Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    //[3, 7, 23, 12] => 19
    //[-4, -6, 89, 6] => 0
//     Console.WriteLine("Введите размер массива  ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] numbers = new int[size];
//     FillArrayRandomNumbers(numbers);
//     Console.WriteLine("Наш массив: ");
//     PrintArray(numbers);
//     int sum = 0;

//     for (int i = 1; i < numbers.Length; i += 2)
//     {
//         sum = sum + numbers[i];
//         Console.WriteLine($"на нечетной позиции => {numbers[i]}");
//     }
//     Console.WriteLine($"Сумма элементов, cтоящих на нечётных позициях = {sum}");
    
//     void FillArrayRandomNumbers(int[] numbers)
//     {
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1, 15);
//         }
//     }
//     void PrintArray(int[] numbers)
//     {
//         Console.Write("[ ");
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine();
//     }


//                                              Задача 38: Задайте массив вещественных чисел. Найдите разницу между
 //                                                          максимальным и минимальным элементов массива.
 //[3 7 22 2 78] -> 76

// int size = 5;
// double[] numbers = new double[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// double max = numbers[0];
// double min = numbers[0];

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > max)
//     {
//         max = numbers[i];
//     }
//     else if (numbers[i] < min)
//     {
//         min = numbers[i];
//     }
// }
// Console.WriteLine($"Минимальный элемент: {min}");
// Console.WriteLine($"Максимальный элемент: {max}");
// Console.WriteLine($"Разница между максимальным и минимальным элементом: {max - min}");

// void FillArrayRandomNumbers(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().NextDouble() * 100;
//     }
// }

// void PrintArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + "   ");
//     }
//     Console.WriteLine();
// }


//                              Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    //0, 7, 8, -2, -2 -> 2
    //1, -7, 567, 89, 223-> 3



//     Console.Write("Введите элементы(через пробел): ");
//     int count = 0;
//     int[] M = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // Split() -задает ожидание разделителя(пробела),
//                                                                        //         который разбивает строку одномерного массива M на части.

//     for (int i = 0; i < M.Length; i++)
//     {
//         if (M[i] > 0)
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"Кол-во элементов больше 0: {count}");


//             Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
    //                                                  значения b1, k1, b2 и k2 задаются пользователем.
    //b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
//     Console.Write("Введите b1: ");
//     var b1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите k1: ");
//     var k1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите b2: ");
//     var b2 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите k2: ");
//     var k2 = Convert.ToDouble(Console.ReadLine());

//     var x = (b2 - b1) / (k1 - k2);
//     var y = k1 * x + b1;

//     x = Math.Round(x, 3);
//     y = Math.Round(y, 3);

//     Console.WriteLine($"Пересечение в точке: ({x};{y})");


//                                   Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    //m = 3, n = 4.
    //0,5 7 - 2 - 0,2

    //String.Empty
//     void PrintArray(double[,] tab)
//     {
//         for (int i = 0; i < tab.GetLength(0); i++)
//         {
//             for (int j = 0; j < tab.GetLength(1); j++)
//             {
//                 Console.Write($"{tab[i, j]} ");
//             }
//             Console.WriteLine();
//         }
//     }

//     void FillArray(double[,] tab)  //Заполняющий таблицу массив               
//     {
//         for (double i = 0; i < tab.GetLength(0); i++)
//         {
//             for (double j = 0; j < tab.GetLength(1); j++)
//             {
//                 tab[(int)i, (int)j] = new Random().NextDouble() * 100;
//             }
//         } 
//     }

//     double[,] table = new double[3, 4];
//     FillArray(table);
//     Console.WriteLine();
//     PrintArray(table);


//                              Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
    //                                     и возвращает значение этого элемента или же указание, что такого элемента нет.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 17 -> такого числа в массиве нет

//     Console.Write("Введите номер строки: ");
//     int rows = Convert.ToInt32(Console.ReadLine()) - 1;
//     Console.Write("Введите номер столбца: ");
//     int columns = Convert.ToInt32(Console.ReadLine()) - 1;
//     int n = 4;
//     int m = 6;
//     Random random = new Random();
//     int[,] arr = new int[n, m];
//     Console.WriteLine("Массив: ");
    
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = random.Next(10, 99);
//             Console.Write("{0} ", arr[i, j]);
//         }
//         Console.WriteLine();
//     }
//     if (rows < 0 | rows > arr.GetLength(0) - 1 | columns < 0 | columns > arr.GetLength(1) - 1)
//     {
//         Console.WriteLine("Элемент не существует  ");
//     }
//     else
//     {
//         Console.WriteLine("Значение элемента массива = {0}", arr[rows, columns]);
//     }
//     Console.ReadLine();


//                                                Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
    //                                                                        в каждом столбце.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//     Random random = new Random();
//     int[,] arr = new int[random.Next(3, 7), random.Next(4, 6)];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = random.Next(1, 9);
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("Среднее арифметическое столбцов:");
//         for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             sum += arr[i, j];
//         }
//         Console.Write($"{sum / arr.GetLength(0)} ");
//     }
//     Console.ReadLine();


//                   Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // В итоге получается вот такой массив:
    // 7 4 2 1
    // 9 5 3 2
    // 8 4 4 2

//     int[,] table = new int[3, 4];
//     FillArrayRandom(table);
//     PrintArray(table);
//     SortToLower(table);
//     Console.WriteLine();
//     PrintArray(table);


//     // Функция заполнения массива рандомно числами от 1 до 9
//     void FillArrayRandom(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array[i, j] = new Random().Next(1, 10);
//             }
//         }
//     }

//     // Функция сортировки элементов в строке двумерного массива, по убыванию
//     void SortToLower(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 for (int k = 0; k < array.GetLength(1) - 1; k++)
//                 {
//                     if (array[i, k] < array[i, k + 1])
//                     {
//                         int temp = array[i, k + 1];
//                         array[i, k + 1] = array[i, k];
//                         array[i, k] = temp;
//                     }
//                 }
//             }
//         }
//     }

//     // Функция вывода двумерного массива
//     void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write($"{array[i, j]} ");
//             }
//             Console.WriteLine();
//         }
//     }


//               Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 5 2 6 7

    // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//     int[,] table = new int[4, 4];
//     FillArrayRandom(table);
//     PrintArray(table);
//     Console.WriteLine();
//     NumberRowMinSumElements(table);


//     // Функция вывода номера строки (не индекса) с наименьшей суммой элементов 
//     void NumberRowMinSumElements(int[,] table)
//     {
//         int minRow = 0;
//         int minSumRow = 0;
//         int sumRow = 0;
//         for (int i = 0; i < table.GetLength(1); i++)
//         {
//             minRow += table[0, i];
//         }
//         for (int i = 0; i < table.GetLength(0); i++)
//         {
//             for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
//             if (sumRow < minRow)
//             {
//                 minRow = sumRow;
//                 minSumRow = i;
//             }
//             sumRow = 0;
//         }
//         Console.Write($"{minSumRow + 1} строка");
//     }

//     // Функция вывода двумерного массива
//     void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write($"{array[i, j]} ");
//             }
//             Console.WriteLine();
//         }
//     }

//     // Функция заполнения массива рандомно числами от 1 до 9
//     void FillArrayRandom(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array[i, j] = new Random().Next(1, 10);
//             }
//         }
//     }


//                               Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

    // Например, даны 2 матрицы:
    // 2 4 | 3 4
    // 3 2 | 3 3
    // Результирующая матрица будет:
    // 18 20
    // 15 18

//     int rows = ReadInt("Введите количество строк: ");
//     int columns = ReadInt("Введите количество столбцов: ");
//     int[,] array = new int[rows, columns];
//     int[,] secondArray = new int[rows, columns];
//     int[,] resultArray = new int[rows, columns];

//     FillArrayRandom(array);
//     PrintArray2D(array);

//     Console.WriteLine();

//     FillArrayRandom(secondArray);
//     PrintArray2D(secondArray);

//     Console.WriteLine();

//     if (array.GetLength(0) != secondArray.GetLength(1))
//     {
//         Console.WriteLine(" Нельзя перемножить ");
//         return;
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < secondArray.GetLength(1); j++)
//         {
//             resultArray[i, j] = 0;
//             for (int k = 0; k < array.GetLength(1); k++)
//             {
//                 resultArray[i, j] += array[i, k] * secondArray[k, j];
//             }
//         }
//     }

//     PrintArray2D(resultArray);



//     // Функция ввода
//     int ReadInt(string message)
//     {
//         Console.Write(message);
//         return Convert.ToInt32(Console.ReadLine());
//     }

//     // Функция заполнения массива рандомными числами от 1 до 9
//     void FillArrayRandom(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array[i, j] = new Random().Next(1, 10);
//             }
//         }
//     }

//     // Функция вывода двумерного массива в терминал 
//     void PrintArray2D(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write($"{array[i, j]} ");
//             }
//             Console.WriteLine();
//         }
//     }


//                                          Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
                                                       //Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    // Массив размером 2 x 2 x 2
    // 66(0,0,0) 25(0,1,0)
    // 34(1,0,0) 41(1,1,0)
    // 27(0,0,1) 90(0,1,1)
    // 26(1,0,1) 55(1,1,1)


//     int[,,] array3D = new int[2, 2, 2];
//     FillArray(array3D);
//     PrintIndex(array3D);


//     // Функция вывода индекса элементов трехмерного массива
//     void PrintIndex(int[,,] array3D)
//     {
//         for (int i = 0; i < array3D.GetLength(0); i++)
//         {
//             for (int j = 0; j < array3D.GetLength(1); j++)
//             {
//                 Console.WriteLine();
//                 for (int k = 0; k < array3D.GetLength(2); k++)
//                 {
//                     Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
//                 }
//             }
//         }
//     }

//     // Функция заполнения трехмерного массива не повторяющимеся числами
//     void FillArray(int[,,] arr)
//     {
//         int count = 10;
//         for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 for (int k = 0; k < arr.GetLength(2); k++)
//                 {
//                     arr[k, i, j] += count;
//                     count += 3;
//                 }
//             }
//         }
//     }


//                                                      Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
    // Например, на выходе получается вот такой массив:
    // 01 02 03 04
    // 12 13 14 05
    // 11 16 15 06
    // 10 09 08 07

//     int len = 4;
//     int[,] table = new int[len, len];
//     FillArraySpiral(table, len);
//     PrintArray(table);


//     //  Функция заполнения массива по спирали начиная с 1
//     void FillArraySpiral(int[,] array, int n)
//     {
//         int i = 0, j = 0;
//         int value = 1;
//         for (int e = 0; e < n * n; e++)
//         {
//             int k = 0;
//             do { array[i, j++] = value++; } while (++k < n - 1);
//             for (k = 0; k < n - 1; k++) array[i++, j] = value++;
//             for (k = 0; k < n - 1; k++) array[i, j--] = value++;
//             for (k = 0; k < n - 1; k++) array[i--, j] = value++;
//             ++i; ++j;
//             n = n < 2 ? 0 : n - 2;
//         }
//     }

//     //  Функция вывода двумерного массива в терминал
//     void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (array[i, j] < 10)
//                 {
//                     Console.Write("0" + array[i, j]);
//                     Console.Write(" ");
//                 }
//                 else Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }


// void Task64()
// {
//     // Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//     // N = 5. -> "5, 4, 3, 2, 1"
//     // N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"

//     Console.Write("Введите число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     int count = 1;
//     NaturalToLow(number, count);


//     void NaturalToLow(int n, int count)
//     {
//         if (count > n)
//         {
//             return;
//         }
//         else
//         {
//             NaturalToLow(n, count + 1);
//             Console.Write(count + " ");
//         }
//     }
// }


// void Task66()
// {
//     // // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//     // // M = 1; N = 15 -> 120
//     // // M = 4; N = 8. -> 30

//     Console.Write("Введите число M: ");
//     int m = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите число N: ");
//     int n = Convert.ToInt32(Console.ReadLine());

//     SumFromMToN(m, n);

//     // вызов функции "сумма чисел от M до N"
//     void SumFromMToN(int m, int n)
//     {
//         Console.Write(SumMN(m - 1, n));
//     }

//     // функция сумма чисел от M до N
//     int SumMN(int m, int n)
//     {
//         int res = m;
//         if (m == n)
//             return 0;
//         else
//         {
//             m++;
//             res = m + SumMN(m, n);
//             return res;
//         }
//     }
// }


// void Task68()
// {
//     // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//     // m = 2, n = 3 -> A(m,n) = 9
//     // m = 3, n = 2 -> A(m,n) = 29

//     Console.Write("Введите число M: ");
//     int m = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите число N: ");
//     int n = Convert.ToInt32(Console.ReadLine());

//     AkkermanFunction(m, n);


//     // вызов функции Аккермана
//     void AkkermanFunction(int m, int n)
//     {
//         Console.Write(Akkerman(m, n));
//     }

//     // функция Аккермана
//     int Akkerman(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (n == 0 && m > 0)
//         {
//             return Akkerman(m - 1, 1);
//         }
//         else
//         {
//             return (Akkerman(m - 1, Akkerman(m, n - 1)));
//         }
//     }
