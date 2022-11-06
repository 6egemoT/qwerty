// Виды методов
// Вид 1 Ни чего не возвращают 

/*void Method1();
{
    Console.WriteLine("Автор ...")
}
/*Method1();*/  // - вызов метода

// вид 2

void Method21(string msg, int count) // метод кторый ни чего не возвращают, но могут принимать аргументы
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "текст сообщения", count: 4);
//Method21(count: 4, msg: "текст сообщения");


// Вид 3 Что то возвращают, но ни чего не принимают

int Method3()
{
    return DateTime.Now.Year;
}

/*int year = Method3();
Console.WriteLine(year);*/


// Вид 4 - методы которые что то принимают и что то возвращают

/*string Method4(int count, string text)  //count - количество
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);*/


string Method4(int count, string text)  //count - количество
{
    
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

//string res = Method4(3, "z");
//Console.WriteLine(res);


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}


