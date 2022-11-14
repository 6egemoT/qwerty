// Код Фибоначи
/* f(1) = f(2) => 1
   f(3) = f(2) + f(1) => 2 вызовов
   f(4) = f(4) + f(3) => 3
   f(5) = f(4) + f(3) => 5
   f(6) = f(5) + f(4) => 8
   f(7) = f(6) + f(5) => 13 */

int c = 0;
double Fibonachi(int n)
{
    c++;
    if (n == 1 || n == 2) return 1;
    else return Fibonachi(n - 1) + Fibonachi(n - 2);

}

    Console.WriteLine(Fibonachi(43));
    Console.WriteLine($"c: {c}");


