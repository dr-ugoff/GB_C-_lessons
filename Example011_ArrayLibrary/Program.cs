// voide означает, что функция (метод) ничего не возвращает

void FillArray(int[] collection) // Функция (метод) FillArray заполнения массива
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // Генерация рандомных значений каждого элемента массива collection
        index++;
    }
}

void PrintArray(int[] col) // Функция (метод) печати массива в консоль
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = -1;
//     while (index < count)
//     {
//         if (collection[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index++;
//     }
//     return position;
// }

int[] array = new int[10]; //Создали новый массив array, в котором 10 элеменов (по умолчанию он наполнен нулями)

FillArray(array);
PrintArray(array);

// Console.WriteLine();

// int pos = IndexOf(array, 4);
// Console.WriteLine(pos);