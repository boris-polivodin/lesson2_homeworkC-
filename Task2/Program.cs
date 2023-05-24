/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
class Program {
    public static void Main (string[] args) {
        int number = 0;
        Console.Write("Input any number: ");
        number = int.Parse(Console.ReadLine());
        int countDigits = 0;
        int calkNumber = number;
        while (calkNumber > 0) {
          countDigits += 1;
          calkNumber /= 10;
        }
        if (countDigits < 3) {
          Console.WriteLine("Третьей цифры нет!");
        }
        else {
          Console.WriteLine("Третья цифра: " + (number/(int)Math.Pow(10, countDigits - 3)) % 10);
        }
        
    }
}
