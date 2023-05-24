/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
class Program {
    public static void Main (string[] args) {
        int number = 0;
        Console.Write("Input number from 1 to 7: ");
        number = Convert.ToInt32(Console.ReadLine());
        if (number == 6 || number == 7) {
          Console.WriteLine("Выходной");
        }
        else {
          Console.WriteLine("Рабочий");
        }
     }
}
