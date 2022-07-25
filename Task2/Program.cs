//Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

string[] Plus(string[] array)
{
    string[] sum = new string[array.Length / 2];

    int j = 0;
    for(int i = 0; i < sum.Length; i++)
    {
        sum[i] = array[j] + array[j+1];
        j+=2;
    }
    return sum;
}

void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ,");
    }
    Console.WriteLine();
}

string[] massive = { "qwe", "wer", "ert", "rty", "tyu", "yui" };

Print(Plus(massive));