//Напишите программу, которая принимает на
//вход трёхзначное число и удаляет вторую
//цифру этого числа.
//Примеры
//a = 256 => 26
//a = 891 => 81

int DeleteSecondDigit(int num)
{
    if(num >= 100 && num <= 999)
    {
        // для единиц
        int ed = num % 10;
        // для сотен
        int sot = num / 100;
        // первый способ 
        //int result = sot * 10 + ed;
        //return result;
        //укороченный метод 
        return sot * 10 + ed;
    }
    else 
    {
        System.Console.WriteLine("You input not three-digit number");
        return 0;
    }
}

System.Console.Write("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(DeleteSecondDigit(num));