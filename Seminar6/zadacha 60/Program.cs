/* Составить частотный словарь элементов двумерного массива



Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.



Пример: 

Есть набор данных 



```

{ 1, 9, 9, 0, 2, 8, 0, 9 }

```

частотный массив может быть представлен так:

```

0 встречается 2 раза

1 встречается 1 раз

2 встречается 1 раз

8 встречается 1 раз

9 встречается 3 раза*/


/*Console.Clear();
int cube = new Random().Next(6) + 1;
Console.WriteLine(cube); // бросание кубика
//                         1  2  3  4  5   6      будем хранить цифры
//                         0  1  2  3  4   5      наименование позиции массива
int[] items = new int[6] { 0, 0, 0, 0, 0, 0 };
double count = 100000; // количество бросков кубика
for (int i = 0; i < count; i++)
{
    int cube = new Random().Next(6);
    items[cube]++;
}

for (int i = 0; i < items.Length; i++)
{
    Console.WriteLine($"{i + 1}: {items[i] / count * 100}");  // получаем сколько раз выпадают числа из 10 раз
// {items[i] / count*100} считаем проценты, если без /count тогда количество бросков
}*/

//  ДАНО!!!!
// data = { 1, 2, 3, 1, 2, 3, 4, 5, 6, 7, 55, 0};
// max(data)
// result = {0...55}

int[] data = { 1, 2, 3, 1, 2, 3, 4, 5, 6, 7, 55, 0 };

string Solve(int[] dataNumbers)
{
    string outtput = String.Empty;
    int max = dataNumbers[0];
    for (int i = 0; i < dataNumbers.Length; i++)
    {
        if (dataNumbers[i] > max) max = dataNumbers[i];
    }
    int[] result = new int[max + 1];

    for (int i = 0; i < dataNumbers.Length; i++)   // это результат
    {
        int value = dataNumbers[i];
        result[value]++;
    }
    for (int i = 0; i < result.Length; i++)
    {
        if (result[i] != 0)
        {
            outtput += $"{i} - {result[i]}p.\n";
        }
    }
    return outtput;
}

Console.WriteLine(Solve(data));