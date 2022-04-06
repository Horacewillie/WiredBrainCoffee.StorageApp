using System;
using WiredBrainCoffee.StorageApp.Data;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)  
        {
            //ListRepository<Employee> employeeRepository = new ListRepository<Employee>();
            //ListRepository<Organisation> organisationRepository = new();

            //Base class can require more than one type paramter and subclasses also
            //ListRepository<Employee, string> newEmployeeRepository = new();
            var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());
            var organisationRepository = new ListRepository<Organisation>();
            AddEmployees(employeeRepository);
            GetEmployeedById(employeeRepository);
            employeeRepository.Save();
            AddOrganisations(organisationRepository);
            organisationRepository.Save();

            Console.ReadLine();

        }

        private static void GetEmployeedById(IRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(2);
            Console.WriteLine($"The employee with Id 2 : {employee.FirstName}");
        }

        private static void AddEmployees(IRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee { FirstName = "Horace" });
            employeeRepository.Add(new Employee { FirstName = "Sandra" });
            employeeRepository.Add(new Employee { FirstName = "Mayaki" });
        }

        private static void AddOrganisations(IRepository<Organisation> organisationRepository)
        {
            organisationRepository.Add(new Organisation { Name = "GPC" });
            organisationRepository.Add(new Organisation { Name = "Wema Bank" });
            organisationRepository.Add(new Organisation { Name = "Zanetta Limited" });
        }
    }
}
