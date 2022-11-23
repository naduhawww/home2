//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Напишите цифру , обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 5)
{
    Console.WriteLine("Это рабочий день ");
}
else
{
    Console.WriteLine("Это выходной ");
}