using IceWallet.Engine.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IceWallet.Engine.UnitTests
{
	[TestClass]
	public class WalletEngineTests
	{
		[TestMethod]
		public void BackupWalletData_BasicUsuage()
		{

			WalletEngine engine = new WalletEngine();


			for (int i = 0; i < 5; i++)
			{
				WalletEntry entry = new WalletEntry
				{
					Name = "Test " + i.ToString(),
					DateCreated = System.DateTime.Now.ToShortDateString(),
					Description = "Description " + i.ToString(),
					PrivateKey = "98347659827395274g96b762987346hf87234569827365982347g6f892hf6fh987hf28375" + i,
					PublicAddress = "9208346hg2384h75298hgnf2y3" + i.ToString(),
					Type = "BTC"
				};

				engine.AddWalletDataEntry(entry);
			}

			engine.BackupWalletData("c:\\temp\\");





		}
	}
}
