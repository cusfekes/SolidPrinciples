
namespace SolidPrinciples.Liskov_Substitution_NotValid
{
    public class LiskovSubstitutionDemo
    {
        public static void Main()
        {
            BaseFile writeFile = new WritableFile();
            writeFile.ReadFile("C:\\test.txt");
            writeFile.WriteFile("C:\\test.txt");

            BaseFile readFile = new ReadonlyFile();
            readFile.ReadFile("C:\\test.txt");
            readFile.WriteFile("C:\\test.txt"); // throws not implemented exception
        }
    }

    public class BaseFile
    {
        public virtual void ReadFile(string filePath)
        {
            Console.WriteLine(filePath + " BASE file is read");
        }

        public virtual void WriteFile(string filePath)
        {
            Console.WriteLine(filePath + " BASE file is written");

        }
    }

    public class WritableFile : BaseFile
    {
        public override void ReadFile(string filePath)
        {
            Console.WriteLine(filePath + " file is read");
        }

        public override void WriteFile(string filePath)
        {
            Console.WriteLine(filePath + " file is written");
        }
    }

    public class ReadonlyFile : BaseFile
    {
        public override void ReadFile(string filePath)
        {
            Console.WriteLine(filePath + " file is read");
        }

        public override void WriteFile(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
