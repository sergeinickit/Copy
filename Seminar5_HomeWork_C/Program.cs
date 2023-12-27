// Задача 1: Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Пример:
// 4 3 1 (1,2) => 9
// 2 6 9 

// using System;

// class Program
// {
//     static int[,] array;

//     static void Main()
//     {
//         Console.Write("Введите количество строк: ");
//         int rows = int.Parse(Console.ReadLine());

//         Console.Write("Введите количество столбцов: ");
//         int columns = int.Parse(Console.ReadLine());

//         array = new int[rows,columns]; 

//         CreateArray();
//         PrintArray();
//         // GetElementValue();

//         Console.Write("Введите номер строки: ");
//         int row = int.Parse(Console.ReadLine()); 

//         Console.Write("Введите номер столбца: ");
//         int column = int.Parse(Console.ReadLine());

//         int elementValue = GetElementValue(row, column);
//         Console.WriteLine($"Значение элемента в строке {row}, столбце {column}: {elementValue} ");
//     }
                                 
//     static void CreateArray()       
//     {
//          for (int i = 0; i < array.GetLength(0); i++)   
   
//          {
//              for (int j = 0; j < array.GetLength(1); j++)  
//              {
//                  array[i, j] = new Random().Next(1, 10);        
//              }
                   
//          }
//     }

//     static void PrintArray()          
//     {
//         for (int i = 0; i < array.GetLength(0); i++) 
//         {
//             for (int j = 0; j < array.GetLength(1); j++)  
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();                   
//         }
//     }

//     static int GetElementValue(int row, int column)       
//     {
//              if(row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
//            {
//               return array[row, column];
//            }
//             Console.WriteLine("Некорректные индексы!");
//            return -1;              
//     }  
// }


//Вот исправленный код:
// using System;

// class Program
// {
//     static int[,]? array; // Объявление массива как глобальной переменной

//     static void Main()
//     {
//         Console.Write("Введите количество строк: ");
//         int rows = int.Parse(Console.ReadLine());

//         Console.Write("Введите количество столбцов: ");
//         int columns = int.Parse(Console.ReadLine());

//         array = new int[rows, columns]; // Инициализация массива

//         CreateArray();
//         PrintArray();

//         Console.Write("Введите номер строки: ");
//         int row = int.Parse(Console.ReadLine());

//         Console.Write("Введите номер столбца: ");
//         int column = int.Parse(Console.ReadLine());

//         int elementValue = GetElementValue(row, column);
//         Console.WriteLine($"Значение элемента в строке {row}, столбце {column}: {elementValue}");
//     }

//     static void CreateArray()
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array[i, j] = new Random().Next(1, 10);
//             }
//         }
//     }

//     static void PrintArray()
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }

//     static int GetElementValue(int row, int column)
//     {
//         if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
//         {
//             return array[row, column];
//         }
        

//         Console.WriteLine("Некорректные индексы!");
//         return -1; // или другое значение по умолчанию
//     }
// }


// Пример решенния от ChartGPT:
// using System;

// class Program
// {
//     static void Main()
//     {
//         int[,] myTwoDimArray = {
//             {1, 2, 3},
//             {4, 5, 6},
//             {7, 8, 9}
//         };

//         Console.Write("Введите номер строки: ");
//         int row = int.Parse(Console.ReadLine());

//         Console.Write("Введите номер столбца: ");
//         int column = int.Parse(Console.ReadLine());

//         int value = GetElementValue(myTwoDimArray, row, column);

//         Console.WriteLine($"Значение элемента в строке {row}, столбце {column}: {value}");
//     }

//     static int GetElementValue(int[,] array, int row, int column)
//     {
//         // Проверка на корректные индексы
//         if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
//         {
//             return array[row, column];
//         }
//         else
//         {
//             Console.WriteLine("Некорректные индексы!");
//             return -1; // или другое значение, которое указывает на ошибку
//         }
//     }
// }









// Задача 2: Задайте двумерный массив. Напишите 
// программу, которая поменяет местами первую и 
// последнюю строку массива
// Пример:
// 4 3 1 => 4 6 2
// 2 6 9    2 6 9
// 4 6 2    4 3 1

// int[,]? array = new int[5,3];

//     //Двухмерный массив обозначается [,] и справа ставим через запятую "1" - кол-во строчек;
//                                      // и "2" - кол-во столбцов ( new int[5,3] )

// int[,] CreateArray()       // Вводим функцию для заполнения массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)    //Создаем массив.Проходимся по какой-то строчке. (0) размерность - это коол-во строчек (5);
   
//     {
//         for (int j = 0; j < array.GetLength(1); j++)  // Чтобы пройтись по всему массиву - создаем второй цикл.(1) - кол-во столбцов
//         {
//             array[i,j] = new Random().Next(1,10);        //Обращаемся к каждому злементу массива и заполняем его случайными числами
//             // System.Console.WriteLine(array[i,j] + " ");       //Выводим в строчку все элементы. Ставим Write. !
//         }
//     //   System.Console.WriteLine();                   // Делаем пропуск, чтобы получилась таблица
//     }
//     return array;

// }  

// CreateArray();
// PrintArray();
// Exchange();

//  void PrintArray()          //Вводим функцию для вывода массива
//  {
//      for (int i = 0; i < array.GetLength(0); i++) 

//     {
//         for (int j = 0; j < array.GetLength(1); j++)  // Чтобы пройтись по всему массиву - создаем второй цикл.(1) - кол-во столбцов
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//       System.Console.WriteLine();                   // Делаем пропуск, чтобы получилась таблица
//     }
//     System.Console.WriteLine();      // Чтобы избежать дубляжа - выводим изменнеый массив здесь же

//  } 

// void Exchange()
// {
//     int numberOfRows = array.GetLength(0);
//     int numberOfColumns = array.GetLength(1);

//     int[] firstRow = new int[numberOfColumns];
    
//     // Console.WriteLine("Первая строка:");
//     // foreach (int element in firstRow)
//     // {
//     //     Console.Write(element + " ");
//     // }

//     // Console.WriteLine();

//     // int[] lastRow = new int [numberOfColumns];
//     // for (int j = 0; j < numberOfColumns; j++)
//     // {
//     //     lastRow[j] = array[numberOfRows -1, j];
//     // }
//     // Console.WriteLine("Последняя строка:");
//     // foreach (int element in lastRow)
//     // {
//     //    Console.Write(element + " "); 
//     // }

//     // Console.WriteLine();

//     // int[] arr = new int[numberOfColumns];
//     // int[] arr2 = new int [numberOfRows];

//     // for (int j = 0; j < numberOfColumns; j++)
//     // {
//     //     arr[j] = array[numberOfRows -1, j];
//     // }

//     // for (int j = 0; j < numberOfColumns; j++)
//     // {
//     //     array[0, j] = arr[j];        
//     // }


//     //  for (int j = 0; j < numberOfRows; j++)
//     // {
//     //     arr2[j] = array[numberOfColumns -1, j];
//     // }

//     // for (int j = 0; j < numberOfRows; j++)
//     // {
//     //     array[numberOfColumns -1, j] = arr2[j];        
//     // }

//     for (int j = 0; j < numberOfColumns; j++)     // Сохраняем первую строку в отдельный массив
//     {
//         firstRow[j] = array[0,j];
//     }


//     for (int j = 0; j < numberOfColumns; j++)      // Заменяем первую строку на последнюю
//     {
//         array[0,j] = array[numberOfRows -1, j];
//     }

//     for (int j = 0; j < numberOfColumns; j++)       // Востанавливаем первую строку из временног массива
//     {
//         array[numberOfRows -1,j] = firstRow[j];
//     }

//     Console.WriteLine("Массив после замены:");
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j]+ " ");
//         } 
//       Console.WriteLine(); 
//     }
//     Console.WriteLine();
// }

     // Правильно с исправлениями:
     
// Задача 2: Задайте двумерный массив. Напишите 
// программу, которая поменяет местами первую и 
// последнюю строку массива
// Пример:
// 4 3 1 => 4 6 2
// 2 6 9    2 6 9
// 4 6 2    4 3 1

int[,]? array = new int[5,3];

void CreateArray()       
{
    for (int i = 0; i < array.GetLength(0); i++)    
   
    {
        for (int j = 0; j < array.GetLength(1); j++)  
        {
            array[i,j] = new Random().Next(1,10);        
        }
    }
}  

CreateArray();
PrintArray();
Exchange();

 void PrintArray()          
 {
     for (int i = 0; i < array.GetLength(0); i++) 

    {
        for (int j = 0; j < array.GetLength(1); j++)  
        {
            System.Console.Write(array[i,j] + " ");
        }
      System.Console.WriteLine();                   
    }
    System.Console.WriteLine();      

 } 

void Exchange()
{
    int numberOfRows = array.GetLength(0);
    int numberOfColumns = array.GetLength(1);

     int[] firstRow = new int[numberOfColumns];

    // for (int j = 0; j < numberOfColumns; j++)
    // {
    //     firstRow [j] = array[0, j];
    // }
    
    // Console.WriteLine("Первая строка:");
    // foreach (int element in firstRow)
    // {
    //     Console.Write(element + " ");
    // }

    // Console.WriteLine();

    // int[] lastRow = new int [numberOfColumns];
    // for (int j = 0; j < numberOfColumns; j++)
    // {
    //     lastRow[j] = array[numberOfRows -1, j];
    // }
    // Console.WriteLine("Последняя строка:");
    // foreach (int element in lastRow)
    // {
    //    Console.Write(element + " "); 
    // }

    // Console.WriteLine();

    for (int j = 0; j < numberOfColumns; j++)     
    {
        firstRow[j] = array[0,j];
    }


    for (int j = 0; j < numberOfColumns; j++)      
    {
        array[0,j] = array[numberOfRows -1, j];
    }

    for (int j = 0; j < numberOfColumns; j++)       
    {
        array[numberOfRows -1,j] = firstRow[j];
    }

    Console.WriteLine("Массив после замены:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]+ " ");
        } 
      Console.WriteLine(); 
    }
    Console.WriteLine();
}
      



// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов
// Пример:
// 4 3 1 => Строка с индексом 0
// 2 6 9
// 4 6 2 

// int[,] array = new int[3,4];

//     //Двухмерный массив обозначается [,] и справа ставим через запятую "1" - кол-во строчек;
//                                      // и "2" - кол-во столбцов ( new int[5,3] )

// int[,] CreateArray()       // Вводим функцию для заполнения массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)    //Создаем массив.Проходимся по какой-то строчке. (0) размерность - это коол-во строчек (5);
   
//     {
//         for (int j = 0; j < array.GetLength(1); j++)  // Чтобы пройтись по всему массиву - создаем второй цикл.(1) - кол-во столбцов
//         {
//             array[i,j] = new Random().Next(1,10);        //Обращаемся к каждому злементу массива и заполняем его случайными числами
//             // System.Console.WriteLine(array[i,j] + " ");       //Выводим в строчку все элементы. Ставим Write. !
//         }
//     //   System.Console.WriteLine();                   // Делаем пропуск, чтобы получилась таблица
//     }
//     return array;

// }  

// CreateArray();
// PrintArray();
// SumEiements();

//  void PrintArray()          //Вводим функцию для вывода массива
//  {
//      for (int i = 0; i < array.GetLength(0); i++) 

//     {
//         for (int j = 0; j < array.GetLength(1); j++)  // Чтобы пройтись по всему массиву - создаем второй цикл.(1) - кол-во столбцов
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//       System.Console.WriteLine();                   // Делаем пропуск, чтобы получилась таблица
//     }
//     System.Console.WriteLine();      // Чтобы избежать дубляжа - выводим изменнеый массив здесь же
//  } 
//  void SumEiements()
//  {
//     int numberOfRows = array.GetLength(0);
//     int numberOfColumns = array.GetLength(1);

//     int minSum = int.MaxValue;
//     int minSumRowIndex = -1;

//     for (int i = 0; i < numberOfRows; i++)
//     {
//         int sum =  0;

//         for (int j = 0; j < numberOfColumns; j++)
//         {
//             sum += array[i,j];
//         }

//         if(sum < minSum)
//         {
//             minSum = sum;
//             minSumRowIndex = i;
//         }
//     }
//     Console.WriteLine($"Строка с индексом: { minSumRowIndex +1}");
//     Console.WriteLine($"Сумма элементов в строке: {minSum}");
   
//  }

 // К Задаче 3 от ChartGPT:

 // using System;

// class Program
// {
//     static void Main()
//     {
//         int[,] array = new int[,]
//         {
//             {1, 2, 3},
//             {4, 5, 6},
//             {7, 8, 9},
//             {10, 11, 12}
//         };

//         int numberOfRows = array.GetLength(0);
//         int numberOfColumns = array.GetLength(1);

//         int minSum = int.MaxValue; // Используем максимальное значение int в качестве начального значения
//         int minSumRowIndex = -1;

//         // Находим строку с наименьшей суммой элементов
//         for (int i = 0; i < numberOfRows; i++)
//         {
//             int sum = 0;

//             for (int j = 0; j < numberOfColumns; j++)
//             {
//                 sum += array[i, j];
//             }

//             if (sum < minSum)
//             {
//                 minSum = sum;
//                 minSumRowIndex = i;
//             }
//         }

//         // Выводим результат
//         Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex + 1}");
//         Console.WriteLine($"Сумма элементов в этой строке: {minSum}");
//     }
// }




// Задача 4*(не обязательная): Задайте двумерный массив 
// из целых чисел. Напишите программу, которая удалит 
// строку и столбец, на пересечении которых расположен 
// наименьший элемент массива. Под удалением 
// понимается создание нового двумерного массива без 
// строки и столбца
// Пример:
// 4 3 1 => 2 6
// 2 6 9    4 6
// 4 6 2