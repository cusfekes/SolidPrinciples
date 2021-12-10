
namespace SolidPrinciples.Liskov_Substitution
{
    public class LiskovSubstitutionDemo
    {
        public static void Main()
        {
            IFileWriter writeFile = new WritableFile();
            writeFile.WriteFile("C:\\test.txt");

            IFileReader readFile = new ReadonlyFile();
            readFile.ReadFile("C:\\test.txt");

            IFileReader writeFileLiskov = new WritableFile();
            writeFileLiskov.ReadFile("C:\\test.txt");
        }
    }

    public interface IFileWriter
    {
        public void WriteFile(string filePath);
    }

    public interface IFileReader
    {
        public void ReadFile(string filePath);
    }

    public class WritableFile : IFileWriter, IFileReader
    {
        public void ReadFile(string filePath)
        {
            Console.WriteLine(filePath + " file is read");
        }

        public void WriteFile(string filePath)
        {
            Console.WriteLine(filePath + " file is written");
        }
    }

    public class ReadonlyFile : IFileReader
    {
        public void ReadFile(string filePath)
        {
            Console.WriteLine(filePath + " file is read");
        }
    }
}
