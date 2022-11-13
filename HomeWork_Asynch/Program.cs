Print1('A');
ThreadPool.QueueUserWorkItem(Print); 

//основной поток может выполниться быстрее чем дочерний, и программа завершится.

Console.WriteLine(WriteToFileAsync().Result);

//Делегат представляющеий метод, который выполняет задачу
void Print(object? state)
{
    Print1('B');
}

static void  Print1(char c)
{
    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine(c);
    }
}

static async Task<string> WriteToFileAsync()
{
    string path =  @"c:\\VisualStudioProject\\HomeWork_Asynch\\content.txt";
    string MyText = "Dart Waider is not Sith";
    try
    {
        await File.WriteAllTextAsync(path, MyText);
        return "Read is compleat";

    }
    catch (Exception e)
    {
        return "Read is not compleat";
    }
    

}


//. Написать асинхронный метод, который записывает в файл какую-то информацию.
//После завершения записи, вывести на консоль информацию об успешной/неуспешной записи
//в виде продолжения.