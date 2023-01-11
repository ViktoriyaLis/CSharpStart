// Метод 1
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();


// Метод 2
void Method2(string msg, int count)
{
    int i =0;
    while (i<count)
    {
        Console.WriteLine(msg);
        count++;
    }
}
    Console.WriteLine(msg);
Method2(msg: "Текст",count: 4); 


// Метод 3

int Method3()
{
    return DateTime.Now.Year;
}

int Year = Method3();
Console.WriteLine(Year);

// Метод 4 приним и выдает

string Method4(int count, string c)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);