string dirInput = "E:/input";
if (!Directory.Exists(dirInput)) {
    Console.WriteLine("dir not exists: " + dirInput);
    Console.ReadKey();
    return;
}

var timeStart = DateTime.Now;
string dirOutput = Path.Combine(dirInput, "out");
if (!Directory.Exists(dirOutput)) { Directory.CreateDirectory(dirOutput); }
var files = star.files.GetFiles(dirInput, ".txt");
foreach (var filePath in files) {
    File.WriteAllText(Path.Combine(dirOutput, Path.GetFileName(filePath)), star.strings.formatTextBlock(File.ReadAllText(filePath), "\r\n\r\n", "\r\n", @"\n", "\"", "\","));
}

Console.WriteLine("time used: " + (DateTime.Now - timeStart).ToString(@"hh\:mm\:ss"));
Console.ReadKey();