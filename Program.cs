// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void ScanDirectory(string directory)
{
    string[] directories = System.IO.Directory.GetDirectories(directory);
    foreach (string subdir in directories)
    {
        ScanDirectory(subdir);
    }

    string[] files = System.IO.Directory.GetFiles(directory);
    foreach (string file in files) {
        DateTime lastWrite = System.IO.File.GetLastWriteTime(file);
        string extension = System.IO.Path.GetExtension(file);
        Console.WriteLine($"{extension},{lastWrite.Year},{lastWrite.Month},{file}");
    }
}

ScanDirectory(@"C:\Users\alank\OneDrive");