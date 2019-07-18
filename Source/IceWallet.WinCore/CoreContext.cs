using IceWallet.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWallet.WinCore
{
	public static class CoreContext
	{
		public static WalletEngine WalletEngine { get; set; }



		static CoreContext()
		{
			// Create the Global Wallet Engine and Refresh the Data
			WalletEngine = new WalletEngine();
			WalletEngine.RefreshWalletData();



		}

	}
}
