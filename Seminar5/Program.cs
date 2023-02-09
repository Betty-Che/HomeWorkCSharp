// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


// 1. Создаем и заполняем массив
// 2. Циклом проверяем отрицательные и положительные элементы массива
// 

int[] array = GetRandomArray(12, -9, 9);
int[] minAndMax = GetMinAndMaxFromArray(array);
System.Console.WriteLine($"Введен массив {string.Join("", array)}");
System.Console.WriteLine($"Сумма положительных {minAndMax[0]}, сумма отрицательных {minAndMax[1]}");

int [] GetRandomArray(int length, int min, int max)
{
    int[] array = new int [length];
    Random num = new Random();

    for (int counter = 0; counter < length; counter++)
    {
        array[counter] = num.Next(min, max + 1);
    }
    return array;

}

int [] GetMinAndMaxFromArray(int[] array)
{
    int[] minAndMax = new int [2];
    
    for(int counter = 0; counter < array.Length; counter++)
    {
        if(array[counter] > 0)
        {
            minAndMax[0] = minAndMax[0] + array[counter];
        }
        else
        {
            minAndMax[1] = minAndMax[1] + array[counter];
        }
    }
    return minAndMax;
}