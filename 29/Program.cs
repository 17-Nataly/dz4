/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int lenght = 8;
int [] digitsArr = new int [8];
Random rnd = new Random();

for(int i = 0; i < lenght; i++)
{
    digitsArr[i] = rnd.Next(-100, 100);
    Console.Write(digitsArr[i] + " ");
}
