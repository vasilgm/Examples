string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
             +"ежели бы вас послали вместо нашего милого Винценгероде";

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + newValue;
        else result = result + text[i];
    }
    return result;
}

string NewText = Replase(text, ' ', '|');
System.Console.WriteLine(NewText);
System.Console.WriteLine();
string NewText2 = Replase(NewText, 'а', 'А');
System.Console.WriteLine(NewText2);
