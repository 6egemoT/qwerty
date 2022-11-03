// Имеем одномерный массив array из n эллементов, требуется найти 
// элемент массива, равный find

/*int[] array = { 11, 17, 31, 41, 15, 61, 17, 18 }; // может быть любое колличество

int n = array.Length;
int find = 17;  // ищем 17

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // остановиться на первом найденом эллементе
    }
    index++;  //index = index + 1
}*/


// та же самая задача только как метод

void FillArray(int[] collection)   // void - ни чего не возвращает
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOff(array, 4);  // если установим 444, то благодоря int position = -1 будет -1
Console.WriteLine(pos);
