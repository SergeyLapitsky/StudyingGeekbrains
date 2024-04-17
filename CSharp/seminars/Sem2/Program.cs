void NumToQuad (int num)
{
    System.Console.WriteLine(num * num);
}

int NumToQuadInt(int num)
{
    return num * num;
}

System.Console.WriteLine("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

//NumToQuad(a);
//int result = NumToQuadInt(a);
//System.Console.WriteLine(result);
System.Console.WriteLine(NumToQuadInt(a));