
// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

// 1 вариант
static void Main()
{
    System.Console.WriteLine("Введите строку из латинских букв в нижнем регистре:");
    string str = System.Console.ReadLine();

    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
    int vowelsCount = 0;

    for (int int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (str[i] == vowels[j])
            {
                vowelsCount++;
                break;
            }
        }
    }
    System.Console.WriteLine($"Количество гласных букв: {vowelsCount}");
}
Main();

// 2 вариант используем метод 

int VowelCount(string str)
{
    str = str.ToLower(); // приводим строку к нижнему регистру
    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };

    int vowelCount = 0;

    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)// skip
        {
            if (str[i] == vowels[j])
            {
                vowelCount++;
                break;
            }
        }
    }
    return vowelCount;
}
Console.WriteLine("Введите строку из латинских букв в нижнем регистре:");
string str = Console.ReadLine();
Console.WriteLine($"Количество гласных букв: {VowelCount(str)}");