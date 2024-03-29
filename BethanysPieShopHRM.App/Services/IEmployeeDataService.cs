﻿using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.App.Services
{
    public interface IEmployeeDataService
    {
        Task<IEnumerable<Employee>> GetAllEmployees();

        Task<IEnumerable<Employee>> GetLongEmployeeList();

        Task<IEnumerable<Employee>> GetTakeLongEmpoyeeList(int startindex, int count);

        Task<Employee> GetEmployeeDetails(int employeeId);

        Task<Employee> AddEmployee(Employee employee);

        Task UpdateEmployee(Employee employee);

        Task DeleteEmployee(int employeeId);


    }
}
