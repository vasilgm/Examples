int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 25;
int b1 = 55;
int c1 = 42525;
int a2 = 51;
int b2 = 78;
int c2 = 10;
int a3 = 215;
int b3 = 515;
int c3 = 432;

//int Max1 = Max (a1, b1, c1);
//int Max2 = Max (a2, b2, c2);
//int Max3 = Max (a3, b3, c3);
int Max4 = Max (
    Max (a1, b1, c1), 
    Max (a2, b2, c2), 
    Max (a3, b3, c3));

Console.WriteLine (Max4);