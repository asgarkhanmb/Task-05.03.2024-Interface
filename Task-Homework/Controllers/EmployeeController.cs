using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Homework.Models;
using Task_Homework.Services.Interfaces;

namespace Task_Homework.Controllers
{
    public class EmployeeController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController() 
        {
          _employeeService = new EmployeeService();
        }
        public void GetAll()
        {
            var employees= _employeeService.GetAll();
            foreach (var employee in employees) 
            {
                string result = $"{employee.Name} {employee.Surname} {employee.Address}" +
                $"{employee.Email} {employee.Age} {employee.Birthday.ToString("MM-dd-yyyy")}";
                Console.WriteLine(result);
            }
        }
        public void GetById() 
        {
            int? id = null;
            var response=_employeeService.GetByid(_employeeService.GetAll(),id);
            if(response.ErrorMessage is null)
            {
                string result = $"{response.Employee.Name} {response.Employee.Surname} {response.Employee.Address}" +
              $"{response.Employee.Email} {response.Employee.Age} {response.Employee.Birthday.ToString("MM-dd-yyyy")}";
                
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
        }
        public void GetSearchUser() 
        {
            string name="Cavid";
            string surname="";
            var response=_employeeService.GetSearchUser(_employeeService.GetAll(),name,surname);
            if(response.ErrorMessage ==null) 
            {
               var result=$"{response.Employee.Name} {response.Employee.Surname}";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
        }
    }
}
