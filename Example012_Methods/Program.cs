//Вид 1
// Методы, которые ничего не принимают и ничего не возвращают

// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// Method1();



// <<--------------------------->>//



// Вид 2
// Методы, которые ничего не возвращают, но могут принимать аргументы

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");


// void Method21(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method21(msg: "Текст сообщения");


// void Method22(string mesg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(mesg);
//         i++;
//     }
// }
// Method22("Текст", 4); //без явного именования аргументов, нужно соблюдать последовательность аргументов как указано в функции (методе)
// Method22(mesg: "Текст", count: 4); //явное именование аргументов
// Method22(count: 4, mesg: "Текст"); //при явном именовании аргументов, не важна последовательность указания аргументов



// <<--------------------------->>//



// Вид 3
// Методы, которые что-то возвращают, но ничего не принимают

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);



// <<--------------------------->>//



// Вид 4
// Методы, которые что-то принимают и что-то возвращают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);



// <<--------------------------->>//




// Метод 4 с применением цикла for (цикл в цикле). Пример: таблица умножения


// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}"); // называется интерполяция строк
//     }
//     Console.WriteLine();
// }


// <<--------------------------->>//



// Задача. Работа с текстом 
// Дан текст. В тексте нужно все пробелы заменить чёрточками, 
// маленькие буквы “к” заменить большими “К”, а большие “С” маленькими “с”.

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//                 + "ежели бы вас послали вместо нашего милого Винценгероде,"
//                 + "вы бы взяли приступом согласие прусского короля."
//                 + "Вы так красноречивы. Вы дадите мне чаю?";

// string text = "qwerty"
//                012345
// text[3] = r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty; //пустая строка

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);
// Console.WriteLine();


// Задача.
// Сортировка массива по возрастанию значения элементов

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
     Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);