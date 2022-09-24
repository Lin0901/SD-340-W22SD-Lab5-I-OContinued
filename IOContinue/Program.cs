using System.Text;

//Begin by placing the file somewhere other than the directory of your new program solution
string path = @"C:\Users\1\Desktop\Intro_to_LINQ_and_MVC\";

    StringBuilder builder = new StringBuilder();

try
{
    //Using the Directory class
    Directory.SetCurrentDirectory(path);

    //set your working directory to the same directory as the file you are working with
    string[] workingDirectory = Directory.GetFiles(path, "theMachineStops.txt");

    using (StreamReader reader = File.OpenText(workingDirectory[0]))
    {
        builder.Append(reader.ReadToEnd());
    }

    // replaces every period in the text file with the word “STOP,”
    builder.Replace(".", "STOP,");

    //outputs the result to a new text file called “TelegramCopy”
    string TelegramCopy = "TelegramCopy.txt";

    //in the same directory as the original "path"
    using (StreamWriter writer = File.CreateText(Path.Combine(path, TelegramCopy)))
    {
        writer.Write(builder.ToString());
    }

} catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

Console.WriteLine(Directory.GetCurrentDirectory());