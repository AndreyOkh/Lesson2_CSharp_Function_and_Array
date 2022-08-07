//Функция поиска максимального значения из трех аргументов на входе
int Max (int arg1, int arg2, int arg3) {
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 32;
int b1 = 54;
int c1 = 35;
int a2 = 64;
int b2 = 25;
int c2 = 33;
int a3 = 53;
int b3 = 84;
int c3 = 91;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);