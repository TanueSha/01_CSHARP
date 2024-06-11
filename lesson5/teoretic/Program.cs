﻿РЕКУРСИЯ

рекурсия - описание какого-либо объекта внутри этого самого объекта, т.е. ситуация, когда объект является частью самого себя. 
Рекурсия может быть использована для решения больших проблем, таких как вычисление факториала числа или вычисление суммы чисел до определенного числа.

Примеры использования рекурсии:

1. Факториал числа: Рекурсивная функция, которая вычисляет факториал числа.

2. Вычисление суммы чисел до определенного числа: Рекурсивная функция, которая вычисляет сумму чисел до определенного числа.

3. Поиск максимального значения в массиве: Рекурсивная функция, которая ищет максимальное значение в массиве.

4. Разворот числа: Рекурсивная функция, которая разворачивает число.

Рекурсия обладает следующими преимуществами:

- Эффективность: Рекурсивные алгоритмы могут быть более эффективны, чем их итеративные аналоги, поскольку они не требуют дополнительной памяти для хранения стека вызовов.

- Простота и читаемость кода: Рекурсивные алгоритмы часто проще и понятнее, чем их итеративные аналоги, поскольку они не требуют дополнительных условий и контрольных структур.

- Удобство использования: Рекурсивные алгоритмы обладают большими возможностями использования, такими как рекурсивное вычисление факториала, вычисление суммы чисел до определенного числа, и поиск максимального значения в массиве.

Рекурсия в программировании

Рекурсия - процесс, в котором функция вызывает саму себя в качестве части более сложной операции. 
Соответсвующая функци называется рекурсивной. Рекурсивные функции позволяют решать сложные задачи путем деления их на более простые части. 
Рекурсивный вызов - это операция, которая вызывает саму себя в каком-то контексте.

Примеры рекурсивных функций:

1. имитация открытия матрешки: Рекурсивная функция, которая открывает максимального количество матрешек, пока не достигнута определенного уровня сложности.

// пример рекурсивной функции (с ошибками, только для понимания)
void OpenMatrtyoshka(int size) // функция, которая уведомляет что открывает матрешку и выводит на экран ее размер
{
    System.Console.WriteLine($"Открываем матрешку {size}..."); //Вызов этой функции
    OpenMatryoshka(size);  // Рекурсивный вызов
}

OpenMatrtyoshka(5); // Запуск рекурсивной функции с размером матрешки 5

СОСТАВНЫЕ ЧАСТИ РЕКУРСИИ:
1. Рекурсивный вызов 
- цель решение более простой задачи или меньшей, чем текущая
call Function  - call Function - call Function - ... - call Function (вызов самой себя)
на каждом этапе call Function решается более простая задача, чем текущая
Под более простой задачей понимается задача с меньшим объемом вычислений
в данной схеме последнним вызовом будет будет выполняться задача, которая является тривиальной. 
Такая задача называется БАЗОВЫМ СЛУЧАЕМ. ( в матрешках - это самая вложенная  маленькая матрешка)
- обычно достигается за счет упращения (уменьшения) аргумента
call Function(5)  - call Function(4) - call Function(3)

void OpenMatrtyoshka(int size)
{
    System.Console.WriteLine($"Открываем матрешку {size}...");
    OpenMatryoshka(size -1);
}

OpenMatrtyoshka(5);

// этот пример функции в таком решении не остановится, работает как бесконечный цикл


2. Условие остановки рекурсии

Условие остановки рекурсии - это условие, при котором рекурсивный вызов прекращается и возвращается к вызвавшей функции. 
Обычно условие остановки рекурсии определяется в зависимости от конкретной задачи:
- текущая задача стала тривиальной (об этом скажет значение параметра)
- рекурсивный вызов не требуется
- условие размещается перед рекурсивным вызовом

Примеры условий остановки рекурсии:

void OpenMatrtyoshka(int size)
{
    System.Console.WriteLine($"Открываем матрешку {size}...");
    // базовый случай: самая маленькая матрешка
    if (size == 1)
    {
        System.Console.WriteLine($"Достигли самой маленькой матрешки!");
        return; // условие остановки рекурсии
    }
    OpenMatryoshka(size -1);
    
    
}

OpenMatrtyoshka(5);

В этом примере функция делает некоторую работу, а потом объявляет себя рекурсивной и вызывает себя с уменьшенным аргументом

Однако, если функция в начале будет иметь рекурсивный вызов, а затем выполнение работы то поведение буед отличаться

// РЕКУРСИВНАЯ ФУНКЦИЯ ВЫВОДА ЧИСЕЛ ОТ 1 ДО N
// рекурсивный вызов происходит после выполнения остальных действий
void OpenMatrtyoshka(int size)
{
    if (size == 1)
    {
        return;
    }
    System.Console.WriteLine($"Открываем матрешку {size}...");
    OpenMatrtyoshka(size -1);
}

OpenMatrtyoshka(5);

// рекурсивный вызов происходит сначала, а потом остальная работа
void OpenMatrtyoshka(int size)
{
    if (size == 1)
    {
        return;
    }
    OpenMatrtyoshka(size -1);
    System.Console.WriteLine($"Открываем матрешку {size}..."); // вывод сообщения на  экран в конце функции
}
OpenMatrtyoshka(5);
// размеры идут по возрастанию от 5 до 2

void OpenMatrtyoshka(int size)
{
    if (size == 1)
    {
        System.Console.WriteLine("Smallest!");
        return;
    }
    OpenMatrtyoshka(size -1);
    System.Console.WriteLine($"Открываем матрешку {size}..."); 
}
OpenMatrtyoshka(4);

OpenMatrtyoshka(4) - OpenMatrtyoshka(3) - OpenMatrtyoshka(2) - OpenMatrtyoshka(1) - if(1 == 1)                            - OpenMatrtyoshka(1)                                   - OpenMatrtyoshka(2)                                   - OpenMatrtyoshka
                                                                                      System.Console.Write("Smallest!");    System.Console.WriteLine("Открываем матрешку 2...");   System.Console.WriteLine("Открываем матрешку 3...");   System.Console.WriteLine("Открываем матрешку 4...");  
                                                                                      return;   

! ВАЖНЫЕ МОМЕНТЫ ПРИ РЕКУРСИИ:
1. Процесс возврата к местам вызовов рекурсии называется раскручиванием рекурсии.
2. В процессе раскручивания рекурсии возвращаемся в места вызовов рекурсии.
   Места вызовов сохраняются в памяти  
3. Помимо места, куда нужно вернуться (OpenMatrtyoshka(size -1);) в памяти сохраняются значения параметров, с которыми была вызвана функция, т.е 4, 3, 2, 1.
   Это делается для того, чтобы при выводе на консоль (System.Console.WriteLine($"Открываем матрешку {size}..."); ) выводилось корректное значение матрешки (size). Если это не сохранять, то размер был бы один и тот же.  

Стек - область памяти, куда это все сохраняется. 
В стеке хранятся адреса возврата к максимального количеству матрешек, которые были открыты до тех пор, пока не достигнута определенный уровень сложности.

РЕЗЮМЕ
1. раскручивание рекурсии - пройесс возврата к местам вызова функции. 
2. при вызове функции в памяти сохраняются значения параметров, с которыми была вызвана функция. И место возврата - куда возвращаться при раскучивании рекурсии.
   и эта область называется стеком.

РАСПОЛОЖЕНИЕ РЕКУРСИВНОГО ВЫЗОВА ВЛИЯЕТ НА ПОСЛЕДОВАТЕЛЬНОСТЬ ДЕЙСТВИЙ В АЛГОРИТМЕ

ПРИМЕНЕНИЕ РЕКУРСИИ
1. Обход структуры данных Дерево
один из способ хранения и упорядочивания данных наряду с массивом.
в Дереве используется для хранения данных в иерархическом порядке, для поисковых задач и для сортировок. 
рекурсия здесь используется для наиболее понятно и компактной реализации обхода его элементов - обеспечение доступа или проход по всем его элементам.

2. Алгоритм быстрой сортировки (Quick sort)
является одним из самых быстрых алгоритмов. 
рекурсия здесь является одним из основных компонентов. Благодаря ей достигается высокая скорость работы. 

3. Обход каталогов файловой системы (поиск файлов и папок)
здесь рекурсивные системы используются для поиска файлов, папок, а также формирования листингов содержимого. 
 