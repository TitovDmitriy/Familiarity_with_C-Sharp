int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 12, 35, 35, 45, 78, 13, 48, 19 };

array[0] = 12;
Console.WriteLine(array[0]);
