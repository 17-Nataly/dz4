/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("введите число: ");
int camelCase = Convert.ToInt32(Console.ReadLine());
{
    int sum = 0;
    while(camelCase != 0)
    {
        sum += camelCase % 10;
        camelCase /= 10;
    }
    Console.WriteLine(sum);
    return sum;
}

