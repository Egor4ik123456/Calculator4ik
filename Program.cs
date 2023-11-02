
// приложение , которое принимает с клавиатуры два числа, и действия между ними , а потом возводит первое число в степень второго
using System;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

class ConsoleCalculatorApp// класс приложения (основа приложения)
{
  #region Создание переменных

  static double num; // первое число
  static double num2; // второе число
  static string action; //действия между двумя числами
  #endregion


  static void info()
  { // метод для отображения начальной информации
    Console.WriteLine("~~~~~~~К А Л Ь К У Л Я Т О Р~~~~~~~");
    Console.WriteLine("Введите с помощью клавиатуры и Enter сначала первое число,");
    Console.WriteLine("а затем второе число. Потом введите действия: (-, *, +, /, **)");
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.WriteLine("Поддерживаемые действия: + (сложение), - (вычитание)");
    Console.WriteLine("Поддерживаемые действия: * (умножение), / (деление),");
    Console.WriteLine("Поддерживаемые действия: ** (возведение в степень)");
    Console.WriteLine(" ");
  }

  static void Arguments()
  { // метод для ввода данных и типа операции между ними
    try // здесь пробуем сделать какое-то действие(обработка сключений)
    {
      // в качестве чисел могут вводиться цифры
      Console.WriteLine("Введите первое число:");
      num = Convert.ToDouble(Console.ReadLine()); //превращение ввода с клавиатуры в число

      Console.WriteLine("Введите второе число:");
      num2 = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Введите действие между ними:");
      action = Console.ReadLine();

    }
    catch // если не получаеться сделать действие из try, то выполнить это
    {
      Console.WriteLine("Числа не должны вводиться с помощью букв!");
      Arguments();
    }
  }


  static void Calculation()
  {  // метод для расчета результата
    if (action == "+")
    {
      Console.WriteLine($"Результат сложения чисел {num} и {num2}:");
      Console.WriteLine(num + num2);
    }
    else if (action == "-")
    {
      Console.WriteLine($"Результат вычитания чисел {num} и {num2}");
      Console.WriteLine(num - num2);
    }
    else if (action == "*")
    {
      Console.WriteLine($"Результат умножения чисел {num} и {num2}");
      Console.WriteLine(num * num2);
    }
    else if (action == "/")
    {
      Console.WriteLine($"Результат деления чисел {num} и {num2}");
      Console.WriteLine(num / num2);
    }
    else if (action == "**")
    {
      Console.WriteLine($"Результат возведения  числа {num} в степень {num2}");
      Console.WriteLine(Math.Pow(num, num2));
    }
    else //если вводится не то действие, выводится фраза
    {
      Console.WriteLine("Такое действие не поддерживается!");
    }
  }

  static void Cycle()
  { // метод для повторения программ
    Console.WriteLine(" ");
    Console.WriteLine("Продолжить работу? (да/нет)");
    Console.WriteLine("Введите 'да', чтобы продолжить.");
    Console.WriteLine("Любой другой ввод закроет программу.");
    if (Console.ReadLine() == "да") // вводим ответ на вопрос
    {
      Main(); //в случае положительного ответа вызывается главный цикл
    }
  }
  static void Main()
  { // основной метод, запускающий остальные методы
    info(); // метод для отображения начальной информации
    Arguments(); // метод для ввода данных и типа операции между ними
    Calculation(); // метод для расчета результата
    Cycle(); // метод для повторения программ
  }

}