// ФУНКЦИЯ!!!!!!!

/*void Say(string name, int count)
{
    while (count-- > 0)
    {
        if (name == "Таня")
        {
            Console.WriteLine("Я так ждала вас,  " + name + "!");
        }
        else
        {
            Console.WriteLine("привет, " + name);
        }
    }
}

Say("Таня", 3);
Say("Ваня", 1);
Say("Вася", 0);*/


string Say(string name, int count)
{
    while (count-- > 0)
    {
        if (name == "Таня")
        {
            return ("Я так ждала вас,  " + name + "!");
        }
        else
        {
            return ("привет, " + name);
        }
    }
    return "Ошибка";
}

Console.WriteLine(Say("Таня", 3));
Console.WriteLine(Say("Ваня", 1));
Console.WriteLine(Say("Вася", -1));


