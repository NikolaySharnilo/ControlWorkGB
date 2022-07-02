//Task 0: Написать программу, которая из имующегося массива строк формируюет массив из строк, 
//длина которых меньше или равна 3 символа.

string[] array = { "hello", "2", "world", ":-)", "world" };

string[] SemplingItemArrayByLenght(string[] arr, int lenght)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length <= 3) count++;

    string[] result = new string[count];

    int a = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            result[a] = arr[i];
            a++;
        }
    }
    return result;
}
void PrintArray(string[] arr, string txt)
{
    Console.Write($"{txt}");
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    
    Console.WriteLine();
}
string[] arrOut = SemplingItemArrayByLenght(array, 3);
PrintArray(arrOut, "Результат выборки: ");

