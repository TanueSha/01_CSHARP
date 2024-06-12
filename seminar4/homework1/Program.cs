// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

    while(true)
    {
        Console.WriteLine("Введите целое число:");
        string input = Console.ReadLine();
        {
            Console.WriteLine("Для остановки цикла введите 'q'");
            if (input == "q")
            {
                break;
            }
            else
            {
                int number = Convert.ToInt32(input);
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                if (sum % 2 == 0)
                {
                    Console.WriteLine("Сумма цифр чётная");
                }
                
            }
           
        }
        
    }


