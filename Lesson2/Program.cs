// void DeleteSecondDigit()
// {
//     int randomNum = new Random().Next(100, 999 + 1);
//     System.Console.WriteLine($"{randomNum} -> {randomNum / 100 * 10 + randomNum % 10}");
// }
// DeleteSecondDigit();


// void ChecMultiplicity(int num1, int num2)
// {
//     if(num1 % num2 == 0)
//     {
//         System.Console.writeLine($"{num1}, {num2} -> multiple");
//     }
//     else
//     {
//         System.Console.writeLine($"{num1}, {num2} -> not multiple, rminder ->{num1 % nam2}");
//     }
// }

// System.Console.Write("Input first num: ");
// int n1 = Convart.ToInt32(Console.ReadLine());
// System.Console.Write("Input second num: ");
// int n2 = Convart.ToInt32(Console.ReadLine());

// ChecMultiplicity(n1, n2);



bool ChecMultiplicity(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

System.Console.Write("Input num: ");
int n = Convert.ToInt32(Console.ReadLine());
bool multiple = ChecMultiplicity(n);
System.Console.WriteLine($"{n} -> {multiple}");