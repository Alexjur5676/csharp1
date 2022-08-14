// Вид
void Method1()
{
    Console.WriteLine("Автор Журавлев А.В.");
}
// Method1();

// Вид 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg:"Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст", 4);
// или
// Method21(msg: "Текст", count: 4);
// или
// Method21( count: 4, msg: "новый текст");


// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);

// Вид 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string result = Method4(10, "abcd");
// Console.WriteLine(result);

// или

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;

//     }
//     return result;
// }
// string result = Method4(10, "abcd");
// Console.WriteLine(result);

// Цикл в цикле(таблица умножения) 
for (int i =2;i <=10; i++)
{
    for(int j =2;j <=10; j++)
    {
        Console.WriteLine($"{i}*{j} = {i*j}");
    }
    Console.WriteLine();
}

