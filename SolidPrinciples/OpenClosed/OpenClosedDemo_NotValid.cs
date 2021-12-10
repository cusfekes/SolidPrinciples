
namespace SolidPrinciples.OpenClosed_NotValid
{
    public class OpenClosedDemo
    {
        public static void Main()
        {
            SalaryCalculator ceo = new SalaryCalculator(new TitleDefinition(1, "CEO", 10, 100, TitleType.CEO));
            Console.WriteLine($"{ ceo.ToString() } : { ceo.CalculateSalary() }");

            SalaryCalculator director = new SalaryCalculator(new TitleDefinition(1, "Engineering Director", 15, 65, TitleType.Director));
            Console.WriteLine($"{ director.ToString() } : { director.CalculateSalary() }");

            SalaryCalculator engineer = new SalaryCalculator(new TitleDefinition(1, "Software Engineer", 15, 65, TitleType.Engineer));
            Console.WriteLine($"{ engineer.ToString() } : { engineer.CalculateSalary() }");
        }
    }

    public class TitleDefinition
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int WorkingHour { get; set; }

        public double HourlyRate { get; set; }

        public TitleType TitleType { get; set; }

        public TitleDefinition(int id, string name, int workingHour, double hourlyRate, TitleType titleType)
        {
            Id = id;
            Name = name;
            WorkingHour = workingHour;
            HourlyRate = hourlyRate;
            TitleType = titleType;
        }
    }

    public enum TitleType
    {
        CEO = 1,
        Director = 2,
        Engineer = 3
    }

    public class SalaryCalculator
    {
        TitleDefinition titleDefinition;

        public SalaryCalculator(TitleDefinition _titleDefinition)
        {
            titleDefinition = _titleDefinition;
        }

        public double CalculateSalary()
        {
            if (titleDefinition.TitleType == TitleType.CEO)
                return (titleDefinition.HourlyRate * titleDefinition.WorkingHour * 1.5) + 50;
            else if (titleDefinition.TitleType == TitleType.Director)
                return titleDefinition.HourlyRate * titleDefinition.WorkingHour * 1.3;
            else
                return titleDefinition.HourlyRate * titleDefinition.WorkingHour;
        }

        public override string ToString()
        {
            return "The title of " + titleDefinition.Name;
        }
    }
}
