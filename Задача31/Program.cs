/* 
Задача31. Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9;9].Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29,сумма отрицательных равна 20
*/
int[] array = new int[12];//создаем массив
//заполняем массив
for (int i = 0; i < 12; i++ )//12-нумерация с 0
    array[i]= new Random().Next(-9, 10);
Console.WriteLine("[" + string.Join(", ", array) + "]");
int sum_pol = 0;
int sum_neg = 0;
for (int i = 0; i < array.Length; i++)//нахождение самой длины
{
    if (array[i] > 0)
        sum_pol = sum_pol + array[i];
    else// if (array[i] < 0)
        sum_neg = sum_neg +array[i];
}
Console.WriteLine("Сумма положительных равна: " + sum_pol);
Console.WriteLine("Сумма отрицательных равна: " + sum_neg);