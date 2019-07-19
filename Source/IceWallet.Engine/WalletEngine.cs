
using CryptoTools.Common.FileSystems;
using CryptoTools.Common.Serialization;
using IceWallet.Engine.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWallet.Engine
{
    public class WalletEngine
    {



		private bool _isBackupRequired = false;

		public const string WalletDataFileNameExt = "json";
		public const string WalletDataFileNameWithoutExtension = "IceWalletData";
		public const string WalletDataFileName = WalletDataFileNameWithoutExtension + "." + WalletDataFileNameExt;
		public static readonly string WalletDataFileNameBackupPostFix = $"_Backup-{DateTime.UtcNow.Year}-{DateTime.UtcNow.Month}-{DateTime.UtcNow.Day}-{DateTime.UtcNow.Hour}-{DateTime.UtcNow.Minute}-{DateTime.UtcNow.Second}-{DateTime.UtcNow.Millisecond}";
		public WalletData WalletData { get; set; }
		public bool IsBackupRequired { get { return _isBackupRequired; } }

		public WalletEngine()
		{
			WalletData = new WalletData();
		}

		public void RefreshWalletData()
		{
			try
			{
				WalletData = JsonSerializer.ReadFromJsonFile<WalletData>(WalletDataFileName);
			}
			catch(FileNotFoundException)
			{
				// File does not exist yet do just create an empty data file
				WalletData = new WalletData();
			}
		}

		private void UpdateWalletData(WalletData data)
		{
			JsonSerializer.WriteToJsonFile<WalletData>(WalletDataFileName, data);
			_isBackupRequired = true;
			RefreshWalletData();
		}

		public void AddWalletDataEntry(WalletEntry entry)
		{
			WalletData.Entries.Add(entry);
			UpdateWalletData(WalletData);			
		}

		public void BackupWalletData(string locationPath)
		{
			string backupFileName = BuildBackupFileName();
			File.Copy(WalletDataFileName, Path.Combine(locationPath, backupFileName), overwrite:true);


			// reset thebackup flag
			_isBackupRequired = false;
		}

		private string BuildBackupFileName()
		{
			string backupFileName = WalletDataFileNameWithoutExtension + WalletDataFileNameBackupPostFix + "." + WalletDataFileNameExt;
			return backupFileName;
		}
	}
}
