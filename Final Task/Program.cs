// Написать программу, котоая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
string [] GetArray ( int lengthArray)
{
    string [] array1 = new string [lengthArray];
    Console.WriteLine ("Введите 5 элементов массива строк:");
    for (int i =0; i< lengthArray; i++)
    {
        array1 [i] = Console.ReadLine();
    }
return array1;
}

string [] NewArray (string [] array1)
{
    string [] array2= new string [array1.Length];
    int count = 0;
    for (int i=0; i < array1.Length; i++)
    {
        if (array1 [i].Length <= 3)
        {
            array2 [count] = array1 [i];
            count ++;
        }
    }
    return array2;
}

void PrintNewArray (string [] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
    Console.WriteLine();
}

string [] array1 = GetArray (5);
string [] array2 = NewArray (array1);
Console.WriteLine ("Массив из строк, длина которых меньше либо равна 3 символа");
PrintNewArray (array2);
