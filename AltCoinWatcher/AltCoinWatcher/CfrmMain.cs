using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AltCoinWatcher
{
    public partial class CfrmMain : Form
    {

        #region Global Variables

        private CryptoCurrencies SelectedCryptoCurrency;

        private APIModel CryptoCurrenyData;

        private decimal AboveValue;
        private decimal BelowValue;

        private int RefreshTargetSeconds;
        private int RefreshSeconds;

        private decimal BTCAbove;
        private decimal BTCBelow;
        private decimal ETHAbove;
        private decimal ETHBelow;

        #endregion

        public CfrmMain()
        {
            InitializeComponent();
        }

        #region Overhead

        public enum CryptoCurrencies
        {
            BTC,LTC,NMC,XRP,ETH,DASH,ZEC
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trbrInterval_Scroll(object sender, EventArgs e)
        {
            switch (trbrInterval.Value)
            {
                case 1: lblInterval.Text = "15 sec"; RefreshTargetSeconds = 15; break;
                case 2: lblInterval.Text = "30 sec"; RefreshTargetSeconds = 30; break;
                case 3: lblInterval.Text = "1 min"; RefreshTargetSeconds = 60; break;
                case 4: lblInterval.Text = "10 min"; RefreshTargetSeconds = 600; break;
                case 5: lblInterval.Text = "15 min"; RefreshTargetSeconds = 900; break;
                case 6: lblInterval.Text = "30 min"; RefreshTargetSeconds = 1800; break;
                case 7: lblInterval.Text = "45 min"; RefreshTargetSeconds = 2700; break;
                case 8: lblInterval.Text = "1 hour"; RefreshTargetSeconds = 3600; break;
            }
        }

        #endregion

        #region Switch Crypto Currency

private void btnSelectBTC_ButtonClicked(object sender, EventArgs e)
        {
            SelectedCryptoCurrency = CryptoCurrencies.BTC;
            lblSelectedCryptcurreny.Text = "Bitcoin";
            pnlDetails.BackColor = btnSelectBTC.Normal_FillColor1;

            lblCurrentPrice.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.BTC.Price).ToString("F2");
            lblCurrentSell.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.BTC.Sell).ToString("F2");
            lblCurrentBuy.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.BTC.Buy).ToString("F2");
            lblCurrentHigh.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.BTC.High).ToString("F2");
            lblCurrentLow.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.BTC.Low).ToString("F2");
        }

        private void btnSelectLTC_ButtonClicked(object sender, EventArgs e)
        {
            SelectedCryptoCurrency = CryptoCurrencies.LTC;
            lblSelectedCryptcurreny.Text = "Litecoin";
            pnlDetails.BackColor = btnSelectLTC.Normal_FillColor1;

            lblCurrentPrice.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.LTC.Price).ToString("F2");
            lblCurrentSell.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.LTC.Sell).ToString("F2");
            lblCurrentBuy.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.LTC.Buy).ToString("F2");
            lblCurrentHigh.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.LTC.High).ToString("F2");
            lblCurrentLow.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.LTC.Low).ToString("F2");
        }

        private void btnSelectNMC_ButtonClicked(object sender, EventArgs e)
        {
            SelectedCryptoCurrency = CryptoCurrencies.NMC;
            lblSelectedCryptcurreny.Text = "Namecoin";
            pnlDetails.BackColor = btnSelectNMC.Normal_FillColor1;

            lblCurrentPrice.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.NMC.Price).ToString("F2");
            lblCurrentSell.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.NMC.Sell).ToString("F2");
            lblCurrentBuy.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.NMC.Buy).ToString("F2");
            lblCurrentHigh.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.NMC.High).ToString("F2");
            lblCurrentLow.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.NMC.Low).ToString("F2");
        }

        private void btnSelectXRP_ButtonClicked(object sender, EventArgs e)
        {
            SelectedCryptoCurrency = CryptoCurrencies.XRP;
            lblSelectedCryptcurreny.Text = "Ripple";
            pnlDetails.BackColor = btnSelectXRP.Normal_FillColor1;

            lblCurrentPrice.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.XRP.Price).ToString("F2");
            lblCurrentSell.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.XRP.Sell).ToString("F2");
            lblCurrentBuy.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.XRP.Buy).ToString("F2");
            lblCurrentHigh.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.XRP.High).ToString("F2");
            lblCurrentLow.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.XRP.Low).ToString("F2");
        }

        private void btnSelectETH_ButtonClicked(object sender, EventArgs e)
        {
            SelectedCryptoCurrency = CryptoCurrencies.ETH;
            lblSelectedCryptcurreny.Text = "Etherium";
            pnlDetails.BackColor = btnSelectETH.Normal_FillColor1;

            lblCurrentPrice.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.ETH.Price).ToString("F2");
            lblCurrentSell.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.ETH.Sell).ToString("F2");
            lblCurrentBuy.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.ETH.Buy).ToString("F2");
            lblCurrentHigh.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.ETH.High).ToString("F2");
            lblCurrentLow.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.ETH.Low).ToString("F2");

            txtAlertAbove.Text = ETHAbove.ToString();
            txtAlertBelow.Text = ETHBelow.ToString();
        }

        private void btnSelectDASH_ButtonClicked(object sender, EventArgs e)
        {
            SelectedCryptoCurrency = CryptoCurrencies.DASH;
            lblSelectedCryptcurreny.Text = "Dashcoin";
            pnlDetails.BackColor = btnSelectDASH.Normal_FillColor1;

            lblCurrentPrice.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.DASH.Price).ToString("F2");
            lblCurrentSell.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.DASH.Sell).ToString("F2");
            lblCurrentBuy.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.DASH.Buy).ToString("F2");
            lblCurrentHigh.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.DASH.High).ToString("F2");
            lblCurrentLow.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.DASH.Low).ToString("F2");
        }

        private void btnSelectZEC_ButtonClicked(object sender, EventArgs e)
        {
            SelectedCryptoCurrency = CryptoCurrencies.ZEC;
            lblSelectedCryptcurreny.Text = "Zcoin";
            pnlDetails.BackColor = btnSelectZEC.Normal_FillColor1;

            lblCurrentPrice.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.ZEC.Price).ToString("F2");
            lblCurrentSell.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.ZEC.Sell).ToString("F2");
            lblCurrentBuy.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.ZEC.Buy).ToString("F2");
            lblCurrentHigh.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.ZEC.High).ToString("F2");
            lblCurrentLow.Text = "R" + Convert.ToDecimal(CryptoCurrenyData.ZEC.Low).ToString("F2");
        }

        private void SetValuesToControlls()
        {
            lblBTCPrice.Text = "R " + Convert.ToDecimal(CryptoCurrenyData.BTC.Price).ToString("F2");
            lblLTCPrice.Text = "R " + Convert.ToDecimal(CryptoCurrenyData.LTC.Price).ToString("F2");
            lblNMCPrice.Text = "R " + Convert.ToDecimal(CryptoCurrenyData.NMC.Price).ToString("F2");
            lblXRPPrice.Text = "R " + Convert.ToDecimal(CryptoCurrenyData.XRP.Price).ToString("F2");
            lblETHPrice.Text = "R " + Convert.ToDecimal(CryptoCurrenyData.ETH.Price).ToString("F2");
            lblDASHPrice.Text = "R " + Convert.ToDecimal(CryptoCurrenyData.DASH.Price).ToString("F2");
            lblZECPrice.Text = "R " + Convert.ToDecimal(CryptoCurrenyData.ZEC.Price).ToString("F2");
        }

        #endregion

        #region API

        public class BTC
        {
            public string Price { get; set; }
            public string Sell { get; set; }
            public string Buy { get; set; }
            public string High { get; set; }
            public string Low { get; set; }
            public string Volume { get; set; }
        }

        public class LTC
        {
            public string Price { get; set; }
            public string Sell { get; set; }
            public string Buy { get; set; }
            public string High { get; set; }
            public string Low { get; set; }
            public string Volume { get; set; }
        }

        public class NMC
        {
            public string Price { get; set; }
            public string Sell { get; set; }
            public string Buy { get; set; }
            public string High { get; set; }
            public string Low { get; set; }
            public string Volume { get; set; }
        }

        public class XRP
        {
            public string Price { get; set; }
            public string Sell { get; set; }
            public string Buy { get; set; }
            public string High { get; set; }
            public string Low { get; set; }
            public string Volume { get; set; }
        }

        public class ETH
        {
            public string Price { get; set; }
            public string Sell { get; set; }
            public string Buy { get; set; }
            public string High { get; set; }
            public string Low { get; set; }
            public string Volume { get; set; }
        }

        public class DASH
        {
            public string Price { get; set; }
            public string Sell { get; set; }
            public string Buy { get; set; }
            public string High { get; set; }
            public string Low { get; set; }
            public string Volume { get; set; }
        }

        public class ZEC
        {
            public string Price { get; set; }
            public string Sell { get; set; }
            public string Buy { get; set; }
            public string High { get; set; }
            public string Low { get; set; }
            public string Volume { get; set; }
        }

        public class APIModel
        {
            public BTC BTC { get; set; }
            public LTC LTC { get; set; }
            public NMC NMC { get; set; }
            public XRP XRP { get; set; }
            public ETH ETH { get; set; }
            public DASH DASH { get; set; }
            public ZEC ZEC { get; set; }
        }

        private void GetAPIData()
        {
            WebClient client = new WebClient();

            client.Headers.Add("user-agent", "ozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/59.0.3071.115 Safari/537.36");
            client.Headers.Add("cookie", "__cfduid=d7c60df7aeadef44978c9f32c390021261495894577; ALTSECURE=n3v7rtilstutag9o4pc0ctsok5; _ga=GA1.3.974150145.1495894580; _gid=GA1.3.891733417.1500572478");

            Stream data = client.OpenRead("https://www.altcointrader.co.za/api/v2/live-stats");
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();

            CryptoCurrenyData = JsonConvert.DeserializeObject<APIModel>(s);
            SetValuesToControlls();

        }

        #endregion

        private void CfrmMain_Load(object sender, EventArgs e)
        {
            GetAPIData();
            RefreshSeconds = 61;
            RefreshTargetSeconds = 60;
            ETHAbove = 3500;
            ETHBelow = 1000;
        }

        private void tmrInterval_Tick(object sender, EventArgs e)
        {
            RefreshSeconds--;
            lblTimeToRefresh.Text = RefreshSeconds.ToString();

            if (RefreshSeconds == 0)
            {
                lblTimeToRefresh.Text = "Refreshed";
                GetAPIData();
                RefreshSeconds = RefreshTargetSeconds;

                switch (SelectedCryptoCurrency)
                {
                    case CryptoCurrencies.BTC:
                        break;
                    case CryptoCurrencies.LTC:
                        break;
                    case CryptoCurrencies.NMC:
                        break;
                    case CryptoCurrencies.XRP:
                        break;
                    case CryptoCurrencies.ETH:
                        if (Decimal.Parse(CryptoCurrenyData.ETH.Price) >= ETHAbove)
                        {
                            MessageBox.Show("ALERT - ETH is Above " + ETHAbove);
                        }

                        if (Decimal.Parse(CryptoCurrenyData.ETH.Price) <= BelowValue)
                        {
                            MessageBox.Show("ALERT - ETH is Below " + ETHAbove);
                        }
                        
                        break;
                    case CryptoCurrencies.DASH:
                        break;
                    case CryptoCurrencies.ZEC:
                        break;
                }
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (SelectedCryptoCurrency)
            {
                case CryptoCurrencies.BTC:
                    break;
                case CryptoCurrencies.LTC:
                    break;
                case CryptoCurrencies.NMC:
                    break;
                case CryptoCurrencies.XRP:
                    break;
                case CryptoCurrencies.ETH:
                    ETHAbove = decimal.Parse(txtAlertAbove.Text);
                    ETHBelow = decimal.Parse(txtAlertBelow.Text);
                    break;
                case CryptoCurrencies.DASH:
                    break;
                case CryptoCurrencies.ZEC:
                    break;
            }
        }
        
    }
}
