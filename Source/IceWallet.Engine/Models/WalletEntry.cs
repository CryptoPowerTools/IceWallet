using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWallet.Engine.Models
{
	public class WalletEntry
	{
		public string Type { get; set; }
		public string PublicAddress { get; set; }
		public string PrivateKey { get; set; }
		public string PrivateKeyObfuscated { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string DateCreated { get; set; }

	}
}
