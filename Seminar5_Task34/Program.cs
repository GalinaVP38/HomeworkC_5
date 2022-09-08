// Задайте массив заполненный случайными положительными трёхзначными числами
// Напишите программу, которая покажет количество четных чисел в массиве.
int [] array = new int [10];
int size = array.Length;
int count = 0;

for (int i=0; i<size; i++)
{
    array [i] = new Random().Next(100, 1000);
}
Console.WriteLine("[{0}]", String.Join(", ", array));

for (int i=0; i<size; i++)
{
    if (array[i]%2==0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чётных чисел в массиве - {count}");
