
//ThreadPool.QueueUserWorkItem((_)=>Print("Thread Pool"));
//Print("Main Thread");


//static void  Print(string c)
//{
//    for(int i = 0; i < 5; i++)
//    {
//        Thread.Sleep(1);
//        Console.WriteLine(c);
//    }
//}




string path = @"\\VisualStudioProject\\HomeWork_Asynch\\content.txt";
string TextForWrite = "Dart Waider is not Sith";


Task task1 = Task.Run(() => WriteToFileAsync(path, TextForWrite));


await task1.ContinueWith((tas) =>
{

    if (task1.Exception == null)
    {
        Console.WriteLine("Write is ready");
    }
    else
    {
        Console.WriteLine("Write is not ready");
        Console.WriteLine("Ошибка: " + task1.Exception.Message);
    }

});


static async Task WriteToFileAsync(string path, string MyText)
{
    await File.WriteAllTextAsync(path, MyText);
}

