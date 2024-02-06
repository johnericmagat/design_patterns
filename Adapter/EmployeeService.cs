using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Adapter
{
	public class EmployeeService
	{
		public List<EmployeeModel> GetEmployee()
		{
			List<EmployeeModel> employees = new List<EmployeeModel>();

			EmployeeModel emp1 = new EmployeeModel();
			emp1.IdNumber = "1";
			emp1.FullName = "JayR";
			employees.Add(emp1);

			EmployeeModel emp2 = new EmployeeModel();
			emp2.IdNumber = "2";
			emp2.FullName = "Eric";
			employees.Add(emp2);

			return employees;
		}
	}
}
