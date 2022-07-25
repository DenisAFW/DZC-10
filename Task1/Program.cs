// Задайте массив строк. Напишите программу,которая считает кол-во слов в массиве, начинающихся на гласную букву.

int Current(string[] words, char[] vowels)
{
    int a = 0;

    for (int i = 0; i < words.Length; i++)
        for (int j = 0; j < vowels.Length; j++)
        {
            if (words[i][0] == vowels[j])
            {
                a++;
            }
        }
    return a;
}

char[] vowels = { 'a', 'e', 'i', 'u', 'o', 'y' };
string[] Words = { "ywe", "wer", "ert", "rty", "ayu" };

Console.WriteLine(Current(Words, vowels));

