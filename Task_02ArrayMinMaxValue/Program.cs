// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
// Создать на его основе масив B, отбрасывая те, которые нарушают порядок

// возрастания
// элементы, больше 8
// знакочередования

int[] createArrayA(int n, int minValue, int maxValue)
{
    int[] array = new int[n];
    for (int index = 0; index < array.Length; index++)
    array[index] = new Random().Next(minValue, maxValue);
    return array;
}
void printArray(int[] array)
{
    for(int index = 0; index < array.Length; index++)
    Console.Write(array[index] + " ");
}

int[] arrayA = createArrayA(10, -5, 15);
Console.Write("Массив А: ");
printArray(arrayA);
Console.WriteLine();

int[] createArrayB(int[]array, int find)
{
    int[] arrayB = new int[array.Length];
    int elementB = array[0];
    int c = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < elementB)
        {
            c = array[i];
            continue;
        }
        else  if (array[i] > elementB || c < array[i])
        {
            elementB = array[i];
        }
        if (array[i] > find)
        arrayB[i] = array[i];
    }
    return arrayB;
}

//Элементы массива не нарушающие порядок возрастания
Console.WriteLine("Это(и) числа(а) не нарушают порядок возрастания и больше 8: ");
int[] arrayB = createArrayB(arrayA, 8);
printArray(arrayB);

Console.WriteLine();
// Нарушают знакочередование - НЕ СДЕЛАНО
Console.WriteLine("Это(и) числа(а) нарушают знакочередование: ");
//int[] posnig = new int[arrayA.Length];

//printArray(posnig);
for (int index = 0; index < arrayA.Length; index++)
{
    if(arrayA[0] < 0)
    {
        int j = 0;
        while (arrayA[j] < 0)
        Console.Write(arrayA[j] +" ");
        
        // arrayA[posit] = arrayA[index];
        // Console.Write(arrayA[posit] +" ");
        break;
    }
    // if (arrayA[0] > 0)
    // {
    //     int k = 0;
    //     while (arrayA[k] > 0)
    //     Console.Write(arrayA[k] + " ");
    //     break;
    // } 
    //break;
    //posnig[posit] = arrayA[posit];
    //return posnig; 
}
//return posnig[posit];

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
    


