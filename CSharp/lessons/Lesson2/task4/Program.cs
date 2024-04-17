// Дано N гирь с разным весом в случайном
// порядке. Определить вес самой тяжелой гири.

int n = 10;
int[] arr = { 4, 8, 12, 18, 3, 7, 1, 9, 4, 11 };
int i = 0;
int max = arr[0];
while (i < n)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i = i + 1;
}
Console.WriteLine(max);