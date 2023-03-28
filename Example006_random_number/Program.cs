//Напишите программу, которая выводит случайное число из отрезка
// [10, 99] и показывает наибольшую цифру числа.

int randomNumber = new Random().Next(10, 100);
 
int lastDigit = randomNumber % 10; // 56 % 10 = 6 (остаток от деления)
int fisrtDigit = randomNumber / 10; // 56 / 10 = 5 (дробная часть отпадает)
 
Console.WriteLine(randomNumber);
Console.WriteLine($"First digit = {fisrtDigit}"); // способ записи чисел через интерполяцию строк ($)
Console.WriteLine($"Last digit = {lastDigit}"); // $ говорит терминалу что в{} находится переменная 
if (fisrtDigit < lastDigit)
{
    Console.WriteLine(lastDigit);
}
else
{
    Console.WriteLine(fisrtDigit);
}