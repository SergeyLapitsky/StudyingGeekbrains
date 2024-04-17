//Задача 3: Напишите программу, которая принимает на вход целое
//число из отрезка [10, 99] и показывает наибольшую цифру числа.

int FindLargestDigit(int num)
{
    if(num >= 10 && num <= 99)
    {
        // единицы
        int ed = num % 10;
        // десятки
        int dec = num / 10 % 10;
        if(ed > dec)
        {
            return ed;
        }
        else
        {
            return dec;
        }
    }
    else 
    {
        System.Console.WriteLine("You input number is out of range");
        return 0;
    }
}

System.Console.Write("Input number in the range [10. 99]: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(FindLargestDigit(num));