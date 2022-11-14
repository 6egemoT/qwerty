/* Дан текст. В тексте нужно все пробелы заменить черточками, маленькие 
буквы "к" заменить большими "К", а большие "С" заменить маленькими "c" */

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде"
            + "вы бы взяли приступом согласие прусского короля"
            + "вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012        
// s[3]   //     r


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int Length = text.Length;
    for (int i = 0; i < Length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine();