    /*
    Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29
    */
    int func_akkerman(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return func_akkerman(m - 1, 1);
        else return func_akkerman(m - 1, func_akkerman(m, n - 1));
    }


    int m;
    int n;
    Console.WriteLine("Введите значение M");
    m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество N");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Результат выполнения функции аккермана: " + func_akkerman(m,n));