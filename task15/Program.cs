﻿/* программf принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число, обозначающую день недели: ");
int num = int.Parse(Console.ReadLine());

if (5 >= num && num >= 1)
{
    Console.WriteLine(num + " No");
}
if (7 >= num && num >= 6)
{
    Console.WriteLine(num + " Yes");
}