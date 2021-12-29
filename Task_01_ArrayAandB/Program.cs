/*
Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
Создать на его основе масив B, отбрасывая те, которые

нарушают порядок возрастания
больше среднего арифметического элементов A
чётные
*/
int[] arrayA = new int[10];
int t = arrayA.Length;
int index = 0;
for(index = 0; index < arrayA.Length; index++)
{
    arrayA[index] = new Random().Next(10,100);
    Console.WriteLine((arrayA[index]) + " ");
}
Console.WriteLine();

Console.WriteLine("  Это(и) числа(а) нарушают порядок возрастания: ");
int ElementB = arrayA[0];
Console.Write(ElementB);
for (index = 1; arrayA[index] > ElementB; index++)
{
    ElementB = arrayA[index];
    Console.Write(" " +arrayA[index]+ " ");
}
Console.WriteLine();

Console.WriteLine("  Cреднее арифметическое число массива А: ");
double sumArrayA = 0;
double result;
for(index = 0; index < t; index++)
{
    sumArrayA += arrayA[index];
    Console.Write(" " +sumArrayA+ " ");
}
if(index == t)
{
    result = sumArrayA / t;
    Console.Write(" " + "= " +result+ " ");
}
Console.WriteLine();

int[] GetArrayB(int count) //Сделал почти как у Вас, но не работает
{
    int index = 0;
    int[] arrayB = new int[count]; // Наполнение массива В должно происходить
    //count = ElementB;???         // из количества чисел нарушающих порядок возрастания
    while(index < 10)
    {
        arrayB[index] = new Random().Next(10, 100);
        index++;
    }
    return arrayB;
}
int[] arrayB = GetArrayB(10);
//int index = 0;
while (index < 10)
{
    int val = arrayB[index];
    Console.Write(val);
    index++;
}

// int GetArrayB(int minValue, int maxValue) Это мой вариант, тоже не работает??????
// {
//     return new Random().Next(minValue, maxValue);
// }

// int[] arrayB = new int[ElementB];
// int indexB = 0;
// while(indexB < ElementB)
// {
//     arrayB[index] = GetArrayB(arrayA[0], ElementB);
//     indexB++;
//     Console.Write((arrayB[indexB]) + " ");
// }


// } //Это делал еще вчера, но возник вопрос что нужно будет сравнивать с массивом В, поэтому отложил. На сегодня имена переменных поменялись

// if(result < arrayB)
// {
//     arrayB = arrayA[index];
//     Console.Write(" " +arrayA[index]+ " ");
// }
// else
// {
//     Console.Write("Число меньше среднего арифметического элементов A ( ");
// }

// Console.WriteLine();
// Console.WriteLine("  Четные числа: ");
// //int result = (Array[])
// //for (index = 1; arrayA[index] > arrayB; index++)
// if (arrayA[index]%2==0)
// {
//     arrayB = arrayA[index];
//     Console.Write(" " +arrayA[index]+ " ");
// }
// else
// {
//     Console.Write("четных чисел нет ( ");
// }
// }

