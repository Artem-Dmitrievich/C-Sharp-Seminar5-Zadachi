/*
Задача32.Напишите программу замены элементов
массива: положительные элементы замените на 
соответствующие отрицательные, и наоборот
[-4,-8,8,2] ->[4,8,-8,-2]
*/
Console.WriteLine("Введите кол-во элементов в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
for (int i = 0; i < n; i++)
    array[i] *= (-1);//просто меняем знаки у цифр в массиве
    //array[i] = array[i] *(-1);
Console.WriteLine("[" + string.Join(", ", array) + "]");
