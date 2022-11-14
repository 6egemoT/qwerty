// Напишите метод, который принимает на вход два 
// числа (A и B) и возводит число A в целую степень B.


double Pow(int a, int b)
{
    if (a == 0 && b == 0) return double.NaN;
bool flag = b > 0;

if (b < 0) b = -b;
int res = 1;
for (int i = 0; i < b; i++) res *= a;
if (flag) return res;
else return 1.0 / res;
}

Console.WriteLine(Pow(5, -2));
Console.WriteLine(Pow(5, 2));
Console.WriteLine(Pow(0, 0));