    /*
    Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
    */

    void summ_chisel(int m, int n, int sum)
    {
        sum = sum + n;
        if (n <= m)
        {
            Console.WriteLine("Сумма элементов == " + sum);
            return;
        }
        summ_chisel(m, n - 1, sum);
    }

    int m;
    int n;
    int temp;
    Console.WriteLine("Введите значение M");
    m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество N");
    n = Convert.ToInt32(Console.ReadLine());

    //проверяем какое число больше
    if (m > n) 
    {
        temp = m;
        m = n; 
        n = temp;
    }
    temp=0;
    summ_chisel(m, n, temp);
    



    