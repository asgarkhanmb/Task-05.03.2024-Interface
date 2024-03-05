using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Homework.Models;

namespace Task_Homework.Helpers.Responses
{
    public class EmployeeResponse
    {
        public Employee Employee { get; set; }
        public string ErrorMessage { get; set; }    
    }

}
