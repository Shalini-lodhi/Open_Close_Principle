using OCPLibrary;

namespace OCP_Library
{
    public interface IAccounts
    {
        EmployeeModel Create(IApplicantModel person);
    }
}