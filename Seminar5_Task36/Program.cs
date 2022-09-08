// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов стоящих на нечётных позициях.
int [] array = new int [6];
int size = array.Length;
int sum = 0;

for (int i=0; i<size; i++)
{
    array [i] = new Random().Next(-99, 100);
}

Console.WriteLine("[{0}]", String.Join(", ", array));

for (int i=0; i<size; i++)
{
    if (i%2==1)
    {
        sum+=array[i];
    }
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, - {sum}");
