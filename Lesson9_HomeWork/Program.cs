// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void NToOne(int n)
// {
//     if(n > 0)
//     {
//         System.Console.Write(n + " ");
//         NToOne(n-1);
//     } 
// }
// NToOne(5);



// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumMToN(int m, int n)
// {
//     if(m != n)
//     {
//         if(n > m)
//         {
//             return SumMToN(m, n-1) + n;
//         }
//         else
//         {
//             return SumMToN(m-1, n) + m;
            
//         }
//     }
//     else return m;
// }
// System.Console.WriteLine(SumMToN(1, 15));



// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Accerman(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if(m > 0 && n == 0)
    {
        return Accerman(m-1, 1);
    }
    else if(m > 0 && n >0)
    {
        return Accerman(m-1, Accerman(m, n-1));
    }
    else return 1;
}

System.Console.WriteLine(Accerman(3, 5));

