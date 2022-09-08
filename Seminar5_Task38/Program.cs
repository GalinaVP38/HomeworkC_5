// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива
double [] array = new double [10];
int size = array.Length;
double MaxNum = array [0];
double MinNum = array [0];
double result = 0;

for (int i=0; i<size; i++)
{
    array [i] = new Random().Next(-10, 11);
}

Console.WriteLine("[{0}]", String.Join(", ", array));

for (int i=1; i<size; i++)
    {
        if (MaxNum<array[i]) MaxNum=array[i];
        if (MinNum>array[i]) MinNum=array[i];
    }

result=MaxNum-MinNum;

Console.WriteLine($"Разница между min и max = {result}");
