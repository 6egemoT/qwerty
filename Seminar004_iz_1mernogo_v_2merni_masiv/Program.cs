// Переводим из одномерного массива в двумерные
// ищем определенный индекс

int [] arr = new int [16]; // массив из 16 чисел
for (int i = 0; i < arr.Length; i++) // отсчет с 0 индекса; длинна масива; плюсуем индекс
{
    arr[i] = 10 + i; // в массиве будут двузначные числа
    Console.WriteLine(arr[i] + "");
}

Console.WriteLine();


int index = 0;
for (int i = 0; i < 4; i++) // index = 0; длинна линии 4; индекс + 1
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(arr[index] + " ");
        index++;
    }
    Console.WriteLine();
}
int size = arr.Length; // длинна общее количество элементов
int row = 2; // берем третью строку (индексы в строку)
int col = 2; // берем второй столбец

Console.WriteLine(10 / 4); // договариваемся хранить как деление
Console.WriteLine(10 % 4); // договариваемся хранить как остаток

Console.WriteLine(row * 4 + col); // двумерный переводим в одномерный и получаем индекс

