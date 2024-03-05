using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Homework.Helpers.Responses;
using Task_Homework.Models;

namespace Task_Homework.Services.Interfaces
{
    public interface IEmployeeService
    {
        Employee[] GetAll();
        EmployeeResponse GetByid(Employee [] employees,int? id);
        EmployeeResponse GetSearchUser(Employee[] employees,string name,string surname );
    }
}
