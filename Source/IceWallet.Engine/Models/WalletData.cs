using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWallet.Engine.Models
{
    public class WalletData
    {
		public List<WalletEntry> Entries { get; set; }



		public WalletData()
		{
			Entries = new List<WalletEntry>();
		}

	}
}
