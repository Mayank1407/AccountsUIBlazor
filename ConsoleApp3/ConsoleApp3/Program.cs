// See https://aka.ms/new-console-template for more information

namespace MethodHiding
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public void printfullname()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
        public class parttimeemployee : Employee
        {
            public void printfullname()
            {
                Console.WriteLine(FirstName + " " + LastName + "----contractor");
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                parttimeemployee pte = new parttimeemployee();
                pte.FirstName = "telugu";
                pte.LastName = "programmer";
                pte.printfullname();

            }
        }
    }
}