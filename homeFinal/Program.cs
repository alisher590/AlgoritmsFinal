Console.Clear();
//Задача 1. Найти среднее арифметическое среди всех элементов массива [2, 5, 13, 7, 6, 4] с помощью блок-схемы
int[] number = {2, 5, 13, 7, 6, 4};
int size = 6;
int sum = 0;
int avg = 0;
int index = 0;

    if (index < size)
    {
        sum = sum + number[index];
        index++;
    }
    else
    {
        avg = sum/size;

    }

Console.Write(avg);
