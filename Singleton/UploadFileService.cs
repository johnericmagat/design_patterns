using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Singleton
{
	// use sealed access modifier to not able to inherit
	sealed class UploadFileService
	{
		private UploadFileService() {}

		public int Id { get; set; }

		private static UploadFileService instance;
		private static readonly object isLocked = new object();

		public static UploadFileService Instance(int id)
		{
			if (instance == null)
			{
				lock (isLocked)
				{
					if (instance == null)
					{
						instance = new UploadFileService();
						instance.Id = id;
					}
				}
			}

			return instance;
		}
	}
}
