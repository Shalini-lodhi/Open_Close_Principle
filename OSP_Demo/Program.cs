using OCP_Library;
using OCPLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        List<IApplicantModel> applications = new List<IApplicantModel>
        {
            new PersonModel {FirstName = "firstname1", LastName = "lastname1"},
            new ManagerModel {FirstName = "firstname2", LastName = "lastname2"},
            new ExecutiveModel {FirstName = "firstname3", LastName = "lastname3"}
        };

        List<EmployeeModel> employee = new List<EmployeeModel>();

        foreach (var person in applications)
        {
            employee.Add(person.AccountProcessor.Create(person));
        }

        foreach (var emp in employee)
        {
            Console.WriteLine($"{emp.FirstName} {emp.LastName} : {emp.EmailAddress}, IsExecutive : {emp.IsExecutive}, IsManager : {emp.IsManager}");
        }
        Console.ReadLine();
    }
}