Console.Write("Enter the name of the file you wish to read from: ");
var fileName = Console.ReadLine() ?? "";
try
{
    var fileReader = new StreamReader(fileName);
    Console.WriteLine("Here is the content of your file:");
    Console.WriteLine(fileReader.ReadToEnd().Trim());
}
catch (FileNotFoundException)
{
    Console.WriteLine("Sorry, that file was not found.");
}
