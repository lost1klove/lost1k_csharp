//Вид 1 (метод Void)
void Method1()
{
    Console.WriteLine("Автор @lost1k");
}
// Method1();



//Вид 2 (метод Void с аргументом)
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg: "Message");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Message", 4);
// Method21(count: 4, msg:"new message");



// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);




//Вид 4

string Method4(int count, string text )
{
    int i=0;
    string result = String.Empty;

    while (i<count)
    {
        result += text;
        i++;
    }
return result;
}

string res = Method4(10, "GB ");
System.Console.WriteLine(res);