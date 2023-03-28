//Напишите программу, которая выводит случайное трехзначное 
// число и удаляет вторую цифру этого числа.

int randomNumber = new Random().Next(100, 1000);

int a = randomNumber / 100;

int b = randomNumber % 10;


Console.WriteLine(randomNumber);
Console.Write(a);
Console.Write(b);

// Второе решение
// Console.Clear();

// int num = new Random().Next(100, 1000);

// Console.WriteLine(num);

// int firstNum = num / 100;
// int thirdNum = num % 10;

// int result = firstNum * 10 + thirdNum;
// Console.WriteLine($"Число {result}");

// Console.WriteLine($"Число {firstNum}{thirdNum}"); - замена последней строки
