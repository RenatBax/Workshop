/*
1 Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
2 Создать на его основе масив B, отбрасывая те, которые

нарушают порядок возрастания
больше среднего арифметического элементов A
чётные
*/

void createArrayA(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(10, 100);
    }
}

void printArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] != 0)
        Console.Write((array[index]) + " ");
    }
}

int arithmeticMeanArrayA(int[] array)
{
    int arithmeticMean = 0;
    int sum = 0;
    int size = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
        arithmeticMean = sum / size;
    }
    return arithmeticMean;
}
int[] arrayA = new int[10];
createArrayA(arrayA);
Console.Write("Массив А: ");
printArray(arrayA);
Console.WriteLine();
int mean = arithmeticMeanArrayA(arrayA);

int[] createArrayB(int[] array)
{
    int[] arrayB = new int[10];
    int ElementB = array[0];
    int c = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < ElementB || c > array[i])
        {
            ElementB = array[i];
            continue;
        }
        else
        {
            c = array[i];
        }
        arrayB[i] = array[i];
    }
    return arrayB;
}

int[] createArrayBMean(int[] array, int numberMean)
{
    int[] arrayB = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        //if (array[i] < numberMean && array[i] % 2 != 0)
        if (array[i] < numberMean)
        {
            arrayB[i] = array[i];
        }
    }
    return arrayB;
}

int[] createArrayBMeanEvent(int[] array)
{
    int[] arrayB = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            arrayB[i] = array[i];
        }
    }
    return arrayB;
}

int[] arrayB = createArrayB(arrayA);
int[] arrayBmean = createArrayBMean(arrayB, mean);
int[] arrayBevent = createArrayBMeanEvent(arrayBmean);
Console.WriteLine("Массив В, без чисел нарушаюших порядок возрастания: ");
printArray(arrayB);
Console.WriteLine();
Console.WriteLine($"Массив В, без чисел больше среднего арифметического элементов массива A = {mean}");
printArray(arrayBmean);
Console.WriteLine();
Console.WriteLine("Массив В, без четных чисел элементов массива A: ");
printArray(arrayBevent);