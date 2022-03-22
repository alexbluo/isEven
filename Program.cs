class Program
{
    static async Task Main(string[] args)
    {
        await writeFile();
    }

    static async Task writeFile()
    {
        using StreamWriter file = new("IsEven.cs", append: true);
        await file.WriteLineAsync("bool isEven(int x)");
        await file.WriteLineAsync("{");
        await file.WriteLineAsync("    if (x == " + Int32.MinValue + ")");
        await file.WriteLineAsync("    {");
        await file.WriteLineAsync("        return true;");
        await file.WriteLineAsync("    }");

        // makes your computer explode
        // for (int i = Int32.MinValue + 1; i <= Int32.MaxValue; i++)
        // {
        //     await file.WriteLineAsync("    else if (x == " + i + ")");
        //     await file.WriteLineAsync("    {");
        //     await file.WriteLineAsync("        return " + (i % 2 == 0).ToString().ToLower() + ";");
        //     await file.WriteLineAsync("    }");
        // }

        await file.WriteLineAsync("    return false;");
        await file.WriteLineAsync("}");
    }
}