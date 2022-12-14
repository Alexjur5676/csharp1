// =======работа с текстом=================
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы"к" заменить большими"К",
//  а большие"В" маленькими"в".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласия прусского короля. "
            + "Вы так красноречивы. Вы дадите чаю?";

// string s = "qwerty"
//             012
// s[3]
// r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');

Console.WriteLine(text);
Console.WriteLine();
Console.WriteLine(newText);
newText = Replace(newText, 'к', 'К');
Console.WriteLine();
Console.WriteLine(newText);
newText = Replace(newText, 'В', 'в');
Console.WriteLine();
Console.WriteLine(newText);
