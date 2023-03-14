using OCP_Library;
using OCPLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        List<PersonModel> applications = new List<PersonModel>
        {
            new PersonModel {FirstName = "firstname1", LastName = "lastname1"},
            new PersonModel {FirstName = "firstname2", LastName = "lastname2", TypeOfEmployee = EmployType.Manager},
            new PersonModel {FirstName = "firstname3", LastName = "lastname3", TypeOfEmployee = EmployType.Executive }
        };

        List<EmployeeModel> employee = new List<EmployeeModel>();

        Accounts accountProcessor = new Accounts();

        foreach (var person in applications)
        {
            employee.Add(accountProcessor.Create(person));
        }

        foreach (var emp in employee)
        {
            Console.WriteLine($"{emp.FirstName} {emp.LastName} : {emp.EmailAddress}, IsExecutive : {emp.IsExecutive}, IsManager : {emp.IsManager}");
        }
        Console.ReadLine();
    }
}