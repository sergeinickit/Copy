// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// Пример:   “aBcD1ef!-” => “abcd1ef!-”

string inputString = "'A','f','b','M','c','z','F'";  // Задаем строку с латинскими буквами в обеих регистрах
 string str = "";                                    // Создаем прерменную

string GetStringFromArrayChar()     // Если нужен результат, который будем возвращать и передовать дальше заводим string
{
  string result="";                 // Создаем переменную типа string (пока пустая)
  for (int i = 0; i < inputString.Length; i++)    // Заполняем переменную
  {
     result = result + inputString[i];   // В переменную str записываем каждый элеменет массива elemets[]  
  }
  return result;                   // Наша функция сработала и её результатом будет result
}
str = GetStringFromArrayChar();    // Заполняем тем, что получилось в нашей функции str = и дальше выводим
System.Console.WriteLine(str);

string lowerCaseString = ToLowerCase(inputString);    // Перводим строку в нижний регистр. В верхний будет ( string upperCaseString = ToUpperCase(inputString);)

Console.WriteLine(lowerCaseString);

string ToLowerCase(string input)          // Метод перевода строки в нижний регистр. В верхний будет (  static string ToUpperCase(string input))
{
    return input.ToLower();
}
