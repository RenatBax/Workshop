// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
// Создать на его основе масив B, отбрасывая те, которые нарушают порядок

// возрастания
// элементы, больше 8
// знакочередования

int GetArrayA (int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue);
}
// int[] ArrayA = new int[10]; // Тоже работает
// int index = 0; 
// while (index < 10)
// {
//     ArrayA[index] = GetArrayA(1, 20);
//     index++;
// }
// void PrintArrayA(int[] ArrayA)
// {
//     for(int index = 0; index < 10; index++)
//     Console.WriteLine(ArrayA[index] + " ");
// }
// //int[] arr = CreateArray(10);
// PrintArrayA(ArrayA);

int[] CreateArray(int n)
{
    int[] Array = new int[n];
    for (int index = 0; index < Array.Length; index++)
    Array[index] = GetArrayA(-10,20);
    return Array;
}
void PrintArrayA(int[] array)
{
    // int position = 0;
    // while (position < Array.Length)
    // {
    //     Console.Write(" " +Array[position]+ " ");
    //     position++;
    // }
    for(int index = 0; index < array.Length; index++)
    Console.WriteLine(array[index] + " ");
    
    
}
// int IndexOff(int[] Array)//, int find Не пригодилось
// {
//     int point = Array.Length;
//     int index = 0;
//     int position = 0;
//     while(index < point)
//     {
//         if(Array[index] < 0)//== find)
//         {
//             position = index;
//             break;
//         }
//         index++;
//     }
//     return position;
//}
int[] arrA = CreateArray(10);
PrintArrayA(arrA);
Console.WriteLine();
//Элементы массива не нарушающие порядок возрастания
Console.WriteLine("  Это(и) числа(а) не нарушают порядок возрастания: ");
int ElementB = arrA[0];
Console.Write(ElementB);
int index = 1;
while (arrA[index] > ElementB)
{
    ElementB = arrA[index];
    Console.Write(" " +arrA[index]+ " ");
    index++;
}
Console.WriteLine();
//Элементы массива больше восьми
Console.WriteLine("  Это(и) числа(а) больше восьми: ");
int Namber = 8;
for (index = 0; index < 10; index++)
if(arrA[index] > Namber)
{
    Console.Write(" " +arrA[index]+ " ");
}
// index = 0; // Работает
// while (index < 10) //или 10
// {
//     if (arrA[index] > Namber)
//     {
//         Console.Write(" " +arrA[index]+ " ");
//     }
//     index++;
// }
Console.WriteLine();
// Нарушают знакочередование - НЕ СДЕЛАНО
Console.WriteLine("  Это(и) числа(а) нарушают знакочередование: ЕЩЕ В РАБОТЕ");
index = 0;

while(arrA[index] < 10)    
{
    if(arrA[0] > 0)
    {
        Console.Write(" " + (arrA[index] < 0) + " ");
        //index++;
    }
    else
    {
        if(arrA[0] < 0)    
        {
            Console.Write(" " +arrA[index]+ " ");
            index++;
        }
    }
    index++; 
}
   


// int pos = arrA[0];

// index = 0;
// while(arrA[0] < 0)
// {
//     Console.Write(" " +arrA[0]+ " ");
//     pos++;
//     index++;
//     {
//         if(arrA[1] > 0)
//         {
//             Console.Write(" " +arrA[0]+ " ");
//             pos++;
//             index++;
//         }
//         // else
//         // {
//         // Console.Write(" " +arrA[0]+ " ");
//         // break;
//         // }
//     }
   
// }
    




// Возможно Создал массив В, не проверял??????
// int[] GetArrayB(int n)
// {
//     int index = 0;
//     int[] arrayB = new int[n]; 
//     //count = ???         
//     while(index < n)
//     {
//         arrayB[index] = GetArrayA(-10, 10);//new Random().Next(10, 10);
//         index++;
//     }
//     return arrayB;
// }
// int[] arrayB = GetArrayB(n);
// int index = 1;
// while (index < 10)
// {
//     int val = arrayB[index];
//     Console.Write(" " +val+ " ");
//     index++;
// }
