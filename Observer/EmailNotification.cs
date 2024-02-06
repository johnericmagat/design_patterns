using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Observer
{
	internal class EmailNotification : IObserver<ShiftModel>
	{
		public void OnCompleted()
		{
			Console.WriteLine("Completed Changed Shift!");
		}

		public void OnError(Exception error)
		{
			Console.WriteLine("Failed to Changed Shift!");
		}

		public void OnNext(ShiftModel value)
		{
			Console.WriteLine(String.Format("Successfully Changed Shift to Code: {0} Particulars: {1}", value.ShiftCode, value.Shift));
		}
	}
}
