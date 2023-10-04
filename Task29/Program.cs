// 29: Напишите программу, которая 
// 1/ задаёт массив из 8 элементов, заполненный псевдослучайными числами, 
// 2/ и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]




int[] RandomArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(-100,100);
    }
    return array;
}
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         // // Console.Write(array[i] + ", ");
//         // string str1 = array[i] + ", ";
//         // int str2 = array[i];
//         Console.Write(array[i]);
        
//     }

// }


int[] arr = RandomArray(8);
// string str1 = "[";
// string str2 = "]";
Console.Write($"{arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}, {arr[5]}, {arr[6]}, {arr[7]} -> [{arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}, {arr[5]}, {arr[6]}, {arr[7]}]");


// К сожалению, иного способа получить правильный вывод придумать не смог, только с помощью костылей.