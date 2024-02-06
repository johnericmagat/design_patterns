using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Observer
{
	public class Shift : IObservable<ShiftModel>, IDisposable
	{
		private ShiftModel shiftModel;
		private IList<IObserver<ShiftModel>> observers = new List<IObserver<ShiftModel>>();

		public Shift(string shiftCode, string shift)
		{
			shiftModel = new ShiftModel { ShiftCode = shiftCode, Shift = shift };
		}

		public void UpdateShift(string shiftCode, string shift)
		{
			shiftModel.ShiftCode = shiftCode;
			shiftModel.Shift = shift;
			foreach (var observer in observers)
			{
				observer.OnNext(shiftModel);
			}
		}

		public IDisposable Subscribe(IObserver<ShiftModel> observer)
		{
			this.observers.Add(observer);
			observer.OnNext(shiftModel);
			return this;
		}

		public void Dispose()
		{
			observers.Clear();
		}
	}
}
