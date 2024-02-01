using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Singleton
{
	class UploadFileService
	{
		private UploadFileService() {}

		private static UploadFileService instance;
		private static readonly object isLocked = new object();

		public static UploadFileService Instance()
		{
			if (instance == null)
			{
				lock (isLocked)
				{
					if (instance == null)
					{
						instance = new UploadFileService();
					}
				}

				instance = new UploadFileService();
			}

			return instance;
		}
	}
}
