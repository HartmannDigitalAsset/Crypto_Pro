using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoPro
{
    class Watching
    {
        private int cID;
        private string CryptoName;
        private string CryptoTick;
        private double WatchPrice;
        private string Description;

        public Watching(int id, string cryptoName, string cryptoTick, double watchPrice, string Description)
        {
            CID = id;
            CryptoName1 = cryptoName;
            CryptoTick1 = cryptoTick;
            WatchPrice1 = watchPrice;
            Description1 = Description;
        }

        public string CryptoName1 { get => CryptoName; set => CryptoName = value; }
        public string CryptoTick1 { get => CryptoTick; set => CryptoTick = value; }
        public double WatchPrice1 { get => WatchPrice; set => WatchPrice = value; }
        public string Description1 { get => Description; set => Description = value; }
        public int CID { get => cID; set => cID = value; }
    }
}
