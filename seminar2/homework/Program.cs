// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Метод для проверки кратности числа n одновременно 7 и 23
bool multiplicity(int n)
{
    // Проверка на кратность 7 и 23
    if (n % 7 == 0 && n % 23 == 0)
    {
        return true; // Возвращаем true, если число кратно 7 и 23
    }
    else
    {
        return false; // Возвращаем false, если число не кратно 7 и 23
    }
}

System.Console.Write("Введите число: "); // Исправлено сообщение
int n = Convert.ToInt32(Console.ReadLine());

if (multiplicity(n)) // Исправлен вызов метода и обработка результата
{
    System.Console.WriteLine("True"); // Выводим True, если метод возвращает true
}
else
{
    System.Console.WriteLine("No"); // Выводим No, если метод возвращает false
}


// bool multiplicity(n); 
// {
// if (n % 7 == 0 && n % 23 == 0)
// {
//     System.Console.WriteLine($"True");
// }
// else
// {
// System.Console.WriteLine($"No");
// }

// }
// System.Console.Write($"Введите число: n");
// int n = Convert.ToInt32(Console.ReadLine());


// Анатолий
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine ("Да");
// }
// else 
// {
//     Console.WriteLine ("Нет");
// }


// Мария
// Метод для проверки кратности числа n одновременно 7 и 23
// bool multiplicity(int n)
// {
//     // Проверка на кратность 7 и 23
//     if (n % 7 == 0 && n % 23 == 0)
//     {
//         return true; // True с маленькой буквы
//     }
//     else
//     { 
//         return false; // False с маленькой буквы
//     }
// }

// System.Console.Write("Введите число: "); // Исправлено сообщение
// int n = Convert.ToInt32(Console.ReadLine());

// if (multiplicity(n)) // Исправлен вызов метода
// {
//     System.Console.WriteLine("Число кратно 7 и 23 одновременно");
// }
// else
// {
//     System.Console.WriteLine("Число не кратно 7 и 23 одновременно");
// }
