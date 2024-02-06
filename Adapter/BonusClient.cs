using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Adapter
{
	public class BonusClient
	{
		private IEmployeeTarget _employeeTarget;
		public BonusClient(IEmployeeTarget employee_target)
		{
			_employeeTarget = employee_target;
		}
		public void ShowEmployees()
		{
			List<EmployeeModel> employees = new List<EmployeeModel>();
			employees = _employeeTarget.EmployeeList().ToList();

			foreach (EmployeeModel employee in employees)
			{
				Console.WriteLine("Congratulations! :" + employee.FullName);
			}
		}
	}
}
