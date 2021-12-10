
namespace SolidPrinciples.OpenClosed
{
    public class OpenClosedDemo
    {
        public static void Main()
        {
            CEOSalary ceo = new CEOSalary(new TitleDefinition(1, "CEO", 10, 100));
            Console.WriteLine($"{ ceo.ToString() } : { ceo.CalculateSalary() }");

            DirectorSalary director = new DirectorSalary(new TitleDefinition(1, "Engineering Director", 15, 65));
            Console.WriteLine($"{ director.ToString() } : { director.CalculateSalary() }");
        }
    }

    public class TitleDefinition
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int WorkingHour { get; set; }

        public double HourlyRate { get; set; }

        public TitleDefinition(int id, string name, int workingHour, double hourlyRate)
        {
            Id = id;
            Name = name;
            WorkingHour = workingHour;
            HourlyRate = hourlyRate;
        }
    }

    public interface ITitleSalaryCalculation
    {
        public double CalculateSalary();
    }

    public class CEOSalary : ITitleSalaryCalculation
    {
        TitleDefinition titleDefinition;

        public CEOSalary(TitleDefinition _titleDefinition)
        {
            titleDefinition = _titleDefinition;
        }

        public double CalculateSalary()
        {
            return (titleDefinition.HourlyRate * titleDefinition.WorkingHour * 1.5) + 50;
        }

        public override string ToString()
        {
            return "The title of " + titleDefinition.Name;
        }
    }

    public class DirectorSalary : ITitleSalaryCalculation
    {
        TitleDefinition titleDefinition;

        public DirectorSalary(TitleDefinition _titleDefinition)
        {
            titleDefinition = _titleDefinition;
        }

        public double CalculateSalary()
        {
            return titleDefinition.HourlyRate * titleDefinition.WorkingHour;
        }

        public override string ToString()
        {
            return "The title of " + titleDefinition.Name;
        }
    }
}
