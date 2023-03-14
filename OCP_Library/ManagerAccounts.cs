using OCPLibrary;

namespace OCP_Library
{
    public class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}.{person.LastName}@acm_corp.com";
            output.IsManager = true;
            return output;
        }
    }
}
