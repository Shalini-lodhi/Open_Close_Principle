using OCPLibrary;

namespace OCP_Library
{
    public class Accounts
    {
        public EmployeeModel Create(PersonModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}.{person.LastName}@acm.com";

            switch (person.TypeOfEmployee)
            {
                case EmployType.Staff:
                    break;
                case EmployType.Executive:
                    output.IsExecutive = true;
                    output.IsManager = true;
                    break;
                case EmployType.Manager:
                    output.IsManager = true;
                    break;
                default:
                    break;
            }

            return output;
        }
    }
}
