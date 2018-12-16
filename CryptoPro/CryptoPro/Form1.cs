using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace CryptoPro
{
    public partial class Form1 : Form
    {

        IList<Datum> CryptoObjects = new List<Datum>();
        IList<JToken> results;
        ListViewItem lvi;
        JObject crypto;
        Datum dataOb;
        ListViewItem listViewItem;
        List<Watching> WatchList = new List<Watching>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnWatch.Enabled = false;

            bool InternetFlag = CheckInternet();
            if(InternetFlag == false)
            {
                DialogResult ok = MessageBox.Show("Please Connect to the Internet Before Running Application", "Disconnected", MessageBoxButtons.OK);
                if (ok == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                Update_MarketData();
            }
            
        } // end formload
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblUpdated.Text = "";
            crypto.RemoveAll();
            CryptoObjects.Clear();
            listView1.Items.Clear();
            Update_MarketData();
        }

        // it is important to note that each time Update_marketData is called, it is a new API Call. Limited to 330 API calls per day for a personal account

        private void Update_MarketData()
        {
            WebClient WebClient = new WebClient();
            
            String rawjson = WebClient.DownloadString("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest?CMC_PRO_API_KEY=7a7e31ec-35c2-4ccd-8ecc-b0bacc702fc0");
            
            crypto = JObject.Parse(rawjson);

            IList<JToken> results = crypto["data"].Children().ToList();
            
            //read out JToken results into our list of Data objects

            foreach (JToken result in results)
            {
                dataOb = result.ToObject<Datum>();
                CryptoObjects.Add(dataOb);
            }

            // populate listview for the front end

            for (int j = 0; j < CryptoObjects.Count; j++)
            {
                string[] details= { CryptoObjects[j].symbol.ToString(), CryptoObjects[j].name.ToString(), CryptoObjects[j].quote.USD.price.ToString("C4") };
                listViewItem = new ListViewItem(details);
                listView1.Items.Add(listViewItem);
            }

            lblUpdated.Text = CryptoObjects[0].last_updated.ToString() + " GMT";
            
        }

        public static bool CheckInternet()
        {
            try
            {
                using (var test = new WebClient())
                using (var Connection = test.OpenRead("https://pro-api.coinmarketcap.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(btnWatch.Enabled == false)
            btnWatch.Enabled = true;

            bool positiveHour = CryptoObjects[listView1.FocusedItem.Index].quote.USD.percent_change_1h > 0;
            bool positiveDay = CryptoObjects[listView1.FocusedItem.Index].quote.USD.percent_change_24h > 0;
            bool positiveWeek = CryptoObjects[listView1.FocusedItem.Index].quote.USD.percent_change_7d > 0;
            int x = listView1.FocusedItem.Index;

            // arrow image
            if (positiveDay)
            {
                imgArrow.Image = Image.FromFile("arrowup.jpg");
                lblPrice.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                imgArrow.Image = Image.FromFile("arrowdwn.jpg");
                lblPrice.ForeColor = System.Drawing.Color.Red;
            }

            lblName.Text = CryptoObjects[x].name.ToString();
            lblPrice.Text = CryptoObjects[x].quote.USD.price.ToString("C5");
            lblMarketCap.Text = CryptoObjects[x].quote.USD.market_cap.ToString("C0");
            lblSupply.Text = CryptoObjects[x].circulating_supply.ToString("N0");

            lblOneHour.Text = CryptoObjects[x].quote.USD.percent_change_1h.ToString("N2") + "%";
            lbl7Days.Text = CryptoObjects[x].quote.USD.percent_change_7d.ToString("N2") + "%";
            lbl24Hours.Text = CryptoObjects[x].quote.USD.percent_change_24h.ToString("N2") + "%";
            lblMaxSupply.Text = CryptoObjects[x].total_supply.ToString("N0");
            lblRank.Text = "#" + CryptoObjects[x].cmc_rank.ToString();

            if (positiveHour)
                lblOneHour.ForeColor = System.Drawing.Color.Green;
            else
                lblOneHour.ForeColor = System.Drawing.Color.Red;
            if (positiveDay)
                lbl24Hours.ForeColor = System.Drawing.Color.Green;
            else
                lbl24Hours.ForeColor = System.Drawing.Color.Red;
            if (positiveWeek)
                lbl7Days.ForeColor = System.Drawing.Color.Green;
            else
                lbl7Days.ForeColor = System.Drawing.Color.Red;

            
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            double roundPrice = Math.Round((Double)CryptoObjects[listView1.FocusedItem.Index].quote.USD.price, 4);
            Watching newWatch = new Watching(0, CryptoObjects[listView1.FocusedItem.Index].name, CryptoObjects[listView1.FocusedItem.Index].symbol, roundPrice,"");

            cryptoDataLayer cryptoData = new cryptoDataLayer();

            cryptoData.addToWatching(newWatch);
            

        }

        private void btnViewWatch_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CryptoPro is a data aggregation application for cryptocurrency traders and enthusiasts. Written for MVCC, MIS-254 by Matt Hartmann, 2018. All rights reserved.", "About");
        }
    } // end form 1
}
