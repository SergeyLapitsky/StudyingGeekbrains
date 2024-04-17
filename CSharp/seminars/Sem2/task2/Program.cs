//Напишите программу, которая принимает на вход
//трёхзначное число и  возводит вторую цифру этого 
//числа в степень, равную третьей цифре.
//Примеры
//487 => 8^7 = 2 097 152
//254 => 5^4 = 625
//617 => 1^7 = 1

int SecondToThirdPower(int num)
{
    if(num >= 100 && num <= 999)
    {
        // для единиц
        int ed = num % 10;
        // десятки
        int dec = num / 10 % 10;
        int result = 1;
        for (int i = 0; i < ed; i++)
        {
            result = result * dec;
        }
        return result;
    }
    else 
    {
        System.Console.WriteLine("You input not three-digit number");
        return 0;
    }
}

System.Console.Write("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(SecondToThirdPower(num));