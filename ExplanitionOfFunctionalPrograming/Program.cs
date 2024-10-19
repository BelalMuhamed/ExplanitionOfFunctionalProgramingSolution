using ExplanitionOfFunctionalPrograming.Entities;
using ExplanitionOfFunctionalPrograming.Helper;

namespace ExplanitionOfFunctionalPrograming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ConceptOfFunctionalProgrammingAndPureFunction();


        }
        private static void ConceptOfFunctionalProgrammingAndPureFunction() 
        {
            var Employees = GetAllEmployee.LoadEmployees();
            var q01 = Employees.Filter(e => e.FirstName.ToLowerInvariant() == "ma");
            q01.Print("Employee first name start with \'ma\'");
            var q02 = Employees.Filter(e => e.Department.ToLowerInvariant() == "hr");
            q02.Print("Employee first name start with \'hr\'");
            var q03 = Employees.Filter(e => e.HireDate.Year == 2018);
            q03.Print("Employees there hiring date in 2018");
            var q04 = Employees.Filter(e => e.Salary == 10700);
            q04.Print("Employees with salary == 10700");
        }
    }
}
