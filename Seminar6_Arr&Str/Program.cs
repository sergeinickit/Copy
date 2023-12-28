// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// Пример:   “aBcD1ef!-” => “abcd1ef!-”

// string inputString = "'A','f','b','M','c','z','F'";  // Задаем строку с латинскими буквами в обеих регистрах
//  string str = "";                                    // Создаем прерменную

// string GetStringFromArrayChar()     // Если нужен результат, который будем возвращать и передовать дальше заводим string
// {
//   string result="";                 // Создаем переменную типа string (пока пустая)
//   for (int i = 0; i < inputString.Length; i++)    // Заполняем переменную
//   {
//      result = result + inputString[i];   // В переменную str записываем каждый элеменет массива elemets[]  
//   }
//   return result;                   // Наша функция сработала и её результатом будет result
// }
// str = GetStringFromArrayChar();    // Заполняем тем, что получилось в нашей функции str = и дальше выводим
// System.Console.WriteLine(str);

// string lowerCaseString = ToLowerCase(inputString);    // Перводим строку в нижний регистр. В верхний будет ( string upperCaseString = ToUpperCase(inputString);)

// Console.WriteLine(lowerCaseString);

// string ToLowerCase(string input)          // Метод перевода строки в нижний регистр. В верхний будет (  static string ToUpperCase(string input))
// {
//     return input.ToLower();
// }



// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// Пример:   “aBcD1ef!-” => Нет
//           “шалаш” => Да
//           “55655” => Да

// Console.Write("Введите слово: ");      // Запрос у пользователя
// // #pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
// string str = Console.ReadLine();       // Чтение введенной строки
// // #pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
// if(IsPalindrome(str))
// {
//   Console.WriteLine("Да");
// }
// else
// {
//   Console.WriteLine("Нет");
// }

// // Console.WriteLine(str);                // Вывод строки
// char[] elemtnts = new char [str.Length];                                     // Создаем прерменную

// string GetStringFromArrayChar()     // Если нужен результат, который будем возвращать и передовать дальше заводим string
// {
//   string result="";                 // Создаем переменную типа string (пока пустая)
//   for (int i = 0; i < elemtnts.Length; i++)    // Заполняем переменную
//   {
//      result = result + elemtnts[i];   // В переменную str записываем каждый элеменет массива elemets[]  
//   }
//   return result;                   // Наша функция сработала и её результатом будет result
// }
// str = GetStringFromArrayChar();    // Заполняем тем, что получилось в нашей функции str = и дальше выводим
// System.Console.WriteLine();

// bool IsPalindrome(string str)       // Функция для прверки, является ли строка палиндромом
// {
//   str = str.ToLower();              // Приведение строки к нижнему регистру для учета регистра букв

//   str = str.Replace(" ","");        // Удаление пробелов из строки

//   string reversed = new string(str.ToCharArray().Reverse().ToArray());      // Создание обратной копии строки

//   return str == reversed;           // Сравнение исходной строки с ее обратной копией
// }
