using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Adapter
{
	public interface IEmployeeTarget
	{
		public List<EmployeeModel> EmployeeList()
		{
			return new List<EmployeeModel>();
		}
	}
}
