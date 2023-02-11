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
//            Console.WriteLine(i);





//                                                                           Задача 19 Базовые алгоритмы
//Проверить является ли число палиндромом
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