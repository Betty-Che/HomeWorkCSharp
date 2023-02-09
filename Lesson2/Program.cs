//Найти максимум из 9 чисел
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2 > result) result = arg2;
//     if(arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 15;
// int b1 = 2136;
// int c1 = 39;
// int a2 = 12;
// int b2 = 223;
// int c2 = 33;
// int a3 = 12;
// int b3 = 23;
// int c3 = 325;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);

// int [] array = {16, 23, 36, 48, 56, 65, 73, 82, 91};

// int max = Max(
//     Max(array[0], array[1], array[2]), 
//     Max(array[3], array[4], array[5]), 
//     Max(array[6], array[7], array[8]));

// Console.WriteLine(max);

// int [] array = {1, 2, 3, 4, 5, 6, 7};
// int n = array.Length;
// int find = 4;

// int index = 0;

// while(index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index ++;
// }
void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find);
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int [] array = new int [10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);

System.Console.WriteLine();
int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);