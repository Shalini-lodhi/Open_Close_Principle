using OCPLibrary;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

internal class Program
{
    private static void Main(string[] args)
    {
        List<PersonModel> applications = new List<PersonModel>
        {
            new PersonModel {FirstName = "firstname1", LastName = "lastname1"},
            new PersonModel {FirstName = "firstname2", LastName = "lastname2"},
            new PersonModel {FirstName = "firstname3", LastName = "lastname3"}
        };

        List<EmployeeModel> employee = new List<EmployeeModel>();

        Accounts accountProcessor = new Accounts();

        foreach(var person in applications)
        {
            employee.Add(accountProcessor.Create(person));
        }

        foreach(var emp in employee)
        {
            Console.WriteLine($"{emp.FirstName} {emp.LastName} : {emp.EmailAddress}");
        }
        Console.ReadLine();
    }
}