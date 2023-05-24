/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
class Program {
    public static void Main (string[] args) {
        int number = 0;
        Console.Write("Input a three-digit number: ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("Вторая цифра: " + number/10%10);
    }
}
