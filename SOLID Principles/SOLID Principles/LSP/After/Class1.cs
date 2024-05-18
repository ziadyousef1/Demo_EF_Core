namespace SOLID_Principles.LSP.After
{
    //To adhere to LSP, we can refactor the class as follows:
    public interface IPrintable
    {
        void Print();
    }

    public class Employee : IPrintable
    {
        public string Name { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"Employee: {Name}");
        }
    }

    public class Manager : Employee
    {
        public override void Print()
        {
            Console.WriteLine($"Manager: {Name}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<IPrintable> employees = new List<IPrintable>
        {
            new Employee { Name = "Ahmed" },
            new Manager { Name = "Samy" }
        };

            foreach (var printable in employees)
            {
                // follow the tell , don't ask principle

                printable.Print(); // No type check, each instance knows how to print itself
            }
        }
    }

}
