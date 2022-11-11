// Напишите программу замены эллементов массива: положительные 
// эллементы замените на соотвествующую отрицательные и наоборот


//  сделаем случайно заданный массив
Console.WriteLine("Ведите длинну массива  ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int[] array = new int[N];

for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(-10, 10);



    Console.Write(" " + array[i]);
}

Console.WriteLine(array);