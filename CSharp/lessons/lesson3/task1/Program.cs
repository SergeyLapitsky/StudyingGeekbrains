// Вычислить значение формулы a * b / c + d, где
// a, b, c, d - некоторые целые числа. Решение
// оформить в виде функции.

double CalculateFormul(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denomenator = c + d;
    double result = numenator / denomenator;
    return result;
}
Console.WriteLine(CalculateFormul(1, 2, 3, 4));