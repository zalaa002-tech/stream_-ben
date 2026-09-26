

using System.Text;

bool aa =System.IO.File.Exists ("D:\\Uni\\SS-26\\Prog_2\\aa\\alaa.txt");
Console.WriteLine(aa);


FileInfo bb = new FileInfo("D:\\Uni\\SS-26\\Prog_2\\aa\\alaa.txt");
Console.WriteLine(bb.Extension);

File.WriteAllText("D:\\Uni\\SS-26\\Prog_2\\aa\\alaa.txt", "Alaaaa");
File.AppendAllText("D:\\Uni\\SS-26\\Prog_2\\aa\\alaa.txt", "\n Zein");

string filee = File.ReadAllText("D:\\Uni\\SS-26\\Prog_2\\aa\\alaa.txt");
//File.Delete("D:\\Uni\\SS-26\\Prog_2\\aa\\alaa.txt");
string[] arrayy = File.ReadAllLines("D:\\Uni\\SS-26\\Prog_2\\aa\\alaa.txt");

foreach (string aaa in arrayy)
{
    Console.WriteLine(aaa);
}

for (int i = 0; i<= arrayy.Length-1; i++)
{
    Console.WriteLine(arrayy[i]);
}

for (int e =arrayy.Length-1; e>=0;e--)
{
    Console.WriteLine(arrayy[e]);
}
    


try
{
     filee = File.ReadAllText("D:\\Uni\\SS-26\\Prog_2\\aa\\alaa.txt");
    //File.Delete("D:\\Uni\\SS-26\\Prog_2\\aa\\alaa.txt");
    arrayy = File.ReadAllLines("D:\\Uni\\SS-26\\Prog_2\\aa\\alaa.txt");


}
catch(FileNotFoundException ex1)
{
    Console.WriteLine(ex1.Message);
}
catch (UnauthorizedAccessException ex2)
{
    Console.WriteLine(ex2.Message);
}
finally
{
    Console.WriteLine("we dont know");
}

/////////////////////////////////////////////////////////////Stream///////////////////////////////////////////
//Schreiben
using (FileStream fs = File.OpenWrite("D:\\Uni\\SS-26\\Prog_2\\aa\\alaa.txt"))
{
    //fs.Seek(0, SeekOrigin.End);
    //fs.Seek(0, SeekOrigin.Begin);
    //fs.Seek(9, SeekOrigin.Current);
    fs.Seek(2, SeekOrigin.Current);
    byte[] info = new UTF8Encoding().GetBytes("test text");
    fs.Write(info, 0, info.Length);
    Console.WriteLine(info.Length);
}

using (FileStream fs = File.OpenRead("D:\\Uni\\SS-26\\Prog_2\\aa\\alaa.txt"))
{
    byte[] b = new byte[1024];
    UTF8Encoding temp = new UTF8Encoding(true);
    while (fs.Read(b, 0, b.Length) > 0)
    {
        Console.WriteLine(temp.GetString(b));
    }


}