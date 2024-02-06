using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Adapter
{
	public class EmployeeAdapter : IEmployeeTarget
	{
		private EmployeeService _employeeService;

		public EmployeeAdapter(EmployeeService employeeService)
		{
			_employeeService = employeeService;
		}

		public List<EmployeeModel> EmployeeList()
		{
			return _employeeService.GetEmployee();
		}
	}
}
