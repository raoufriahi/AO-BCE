using ebaproxy.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace ebaproxy.Controller.api.etherscan
{
    [ApiController]
    [Route("api/etherscan")]
    public class EthereumController : ControllerBase
    {
        readonly List<string> m_BinanceCexTo;
        readonly List<string> m_BinanceCexFrom;
        readonly List<string> m_BinanceDex;
        public EthereumController()
        {
            m_BinanceCexTo = new List<string>()
            {
                "0xbe0eb53f46cd790cd13851d5eff43d12404d33e8",
                "0xf977814e90da44bfa03b6295a0616a897441acec",
                "0x5a52e96bacdabb82fd05763e25335261b270efcb",
                "0x28c6c06298d514db089934071355e5743bf21d60",
                "0x9696f59e4d72e237be84ffd425dcad154bf96976",
                "0x21a31ee1afc51d94c2efccaa2092ad1028285549",
                "0xdfd5293d8e347dfe59e90efd55b2956a1343963d",
                "0x56eddb7aa87536c09ccc2793473599fd21a8b17f",
                "0x4976a4a02f38326660d17bf34b431dc6e2eb2327"
            };

            m_BinanceCexFrom = new List<string>()
            {
                "0xbe0eb53f46cd790cd13851d5eff43d12404d33e8",
                "0xf977814e90da44bfa03b6295a0616a897441acec",
                "0x5a52e96bacdabb82fd05763e25335261b270efcb",
                "0x28c6c06298d514db089934071355e5743bf21d60",
                "0x9696f59e4d72e237be84ffd425dcad154bf96976",
                "0x21a31ee1afc51d94c2efccaa2092ad1028285549",
                "0xdfd5293d8e347dfe59e90efd55b2956a1343963d",
                "0x56eddb7aa87536c09ccc2793473599fd21a8b17f",
                "0x4976a4a02f38326660d17bf34b431dc6e2eb2327"
            };
            m_BinanceDex = new List<string>()
            {
                "0x7a250d5630B4cF539739dF2C5dAcb4c659F2488D",
                "0x6b175474e89094c44da98b954eedeac495271d0f",
                "0x398eC7346DcD622eDc5ae82352F02bE94C62d119",
                "0x398ec7346dcd622edc5ae82352f02be94c62d119",
                "0xd9e1ce17f2641f24ae83637ab66a2cca9c378b9f",
                "0xc2edad668740f1aa35e4d8f227fb8e17dca888cd",
                "0xae7ab96520de3a18e5e111b5eaab095312d7fe84",
                "0xf5dce57282a584d2746faf1593d3121fcac444dc",
                "0x70e36f6bf80a52b3b46b3af8e106cc0ed743e8e4",
                "0xbbbbca6a901c926f240b89eacb641d8aec7aeafd",
                "0x944644ea989ec64c2ab9ef341d383cef586a5777",
                "0x0baba1ad5be3a5c0a66e7ac838a129bf948f1ea4",
                "0x1111111254fb6c44bac0bed2854e76f90643097d",
                "0x11111112542d85b3ef69ae05771c2dccff4faa26",
                "0x111111125434b319222cdbf8c261674adb56f3ae",
                "0x11111254369792b2ca5d084ab5eea397ca8fa48b",
                "0x3e66b66fd1d0b02fda6c811da9e0547970db2f21",
                "0xba100000625a3754423978a60c9317c58a424e3d",
                "0x6317c5e82a06e1d8bf200d21f4510ac2c038ac81",
                "0xd26114cd6ee289accf82350c8d8487fedb8a0c07",
            };
        }

        [HttpGet("GetBalanceSingleAddr")]
        public async Task<BalanceSingleAddr> GetBalanceSingleAddr(string session, string address)
        {
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            string Request = "https://api.etherscan.io/api?module=account&action=balance&address=" + address + "&tag=latest&apikey=TJIUMFV5ENF1IV2CXFHYVYMWX3Y2358RRY";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = await client.GetAsync(Request);
                if (response.IsSuccessStatusCode)
                    return await response.Content.ReadFromJsonAsync<BalanceSingleAddr>();   
            }
            return new BalanceSingleAddr
            {
                status = 0,
                message = "KO",
                result = ""
            };
        }


        [HttpGet("GetBalanceMultiAddr")]
        public async Task<BalanceMultiAddr> GetBalanceMultiAddr(string session, string address)
        {
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            string Request = @"https://api.etherscan.io/api?module=account&action=balancemulti&address=" + address + "&tag=latest&apikey=TJIUMFV5ENF1IV2CXFHYVYMWX3Y2358RRY";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = await client.GetAsync(Request);
                if (response.IsSuccessStatusCode)
                    return await response.Content.ReadFromJsonAsync<BalanceMultiAddr>();
            }
            return new BalanceMultiAddr();
        }

        [HttpGet("GetCountTransactions")]
        public async Task<NumberTransactions> GetCountTransactions(string session, string address, int page, int offset)
        {
            NumberTransactions Transactions = new NumberTransactions()
            {
                status = 1,
                message = "OK",
                Count = 0
            };

            ListTransactions listTransactions = await GetListTransactions(session, address, page, offset);
            if (listTransactions != null)
            {
                Transactions.Count = listTransactions.result.Count;
            }
            return Transactions;
        }

        [HttpGet("GetListTransactions")]
        public async Task<ListTransactions> GetListTransactions(string session, string address, int page, int offset)
        {
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            string Request = "https://api.etherscan.io/api?module=account&action=txlist&address=" + address + "&startblock=0&endblock=99999999&page=" + page + "&offset=" + offset + "&sort=asc&apikey=TJIUMFV5ENF1IV2CXFHYVYMWX3Y2358RRY";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = await client.GetAsync(Request);
                if (response.IsSuccessStatusCode)
                    return await response.Content.ReadFromJsonAsync<ListTransactions>();
            }
            return new ListTransactions();
        }

        [HttpGet("GetCexInOutflow")]
        public async Task<CexInOutflow> GetCexInOutflow(string session, string address, int page, int offset)
        {
            CexInOutflow iCexInOutflow = new CexInOutflow()
            {
                status = 1,
                message = "OK",
                result = new InOutflow()
                {
                    Inflow = 0,
                    Outflow = 0
                }
            };
            ListTransactions listTransactions = await GetListTransactions(session, address, page, offset);
            foreach (Transaction transaction in listTransactions.result)
            {
                foreach (string Binance in m_BinanceCexFrom)
                {
                    if (Binance.ToUpper().CompareTo(transaction.from.ToUpper()) == 0)
                    {
                        iCexInOutflow.result.Inflow += transaction.value;
                        break;
                    }
                }
                foreach (string Binance in m_BinanceCexTo)
                {
                    if (Binance.ToUpper().CompareTo(transaction.to.ToUpper()) == 0)
                    {
                        iCexInOutflow.result.Outflow += transaction.value;
                    }
                }
            }
            return iCexInOutflow;
        }

        [HttpGet("GetDexInOutflow")]
        public async Task<DexInOutflow> GetDexInOutflow(string session, string address, int page, int offset)
        {
            DexInOutflow iDexInOutflow = new DexInOutflow()
            {
                status = 1,
                message = "OK",
                result = new InOutflow()
                {
                    Inflow = 0,
                    Outflow = 0
                }
            };

            ListTransactions listTransactions = await GetListTransactions(session, address, page, offset);
            foreach (Transaction transaction in listTransactions.result)
            {
                foreach (string Binance in m_BinanceDex)
                {
                    if (Binance.ToUpper().CompareTo(transaction.from.ToUpper()) == 0)
                    {
                        iDexInOutflow.result.Inflow += transaction.value;
                    }
                    if (Binance.ToUpper().CompareTo(transaction.to.ToUpper()) == 0)
                    {
                        iDexInOutflow.result.Outflow += transaction.value;
                    }
                }
            }
            return iDexInOutflow;
        }

        private async Task<BlockReward> Getblockreward(int blockno)
        {
            string Request = "https://api.etherscan.io/api?module=block&action=getblockreward&blockno=" + blockno + "&apikey=TJIUMFV5ENF1IV2CXFHYVYMWX3Y2358RRY";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = await client.GetAsync(Request);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<BlockReward>();
                }
            }
            return null;
        }

        private async Task<MarketChart> GetMarketChart()
        {
            string Request = "https://api.coingecko.com/api/v3/coins/ethereum/market_chart?vs_currency=eur&days=366&interval=daily";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = await client.GetAsync(Request);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<MarketChart>();
                }
            }
            return null;
        }

        /// This method finds the number closest to​​​​​​‌​​‌‌‌​‌​‌​‌‌‌‌​​‌‌‌​​‌‌​ Timestamp.
        public double ClosestToTimestamp(double[][] Prices, double Timestamp)
        {

            double Closest = Timestamp;
            double Price = 0;
            for (int i = 0; i < Prices.GetLength(0); i++)
            {
                if (Closest == Timestamp)
                {
                    Closest = Prices[i][0];
                    Price = Prices[i][1];
                }
                else if (Prices[i][0] <= Closest)
                {
                    Closest = Prices[i][0];
                    Price = Prices[i][1];
                }
                else if (Prices[i][0] > Closest)
                {
                    Closest = Prices[i][0];
                    Price = Prices[i][1];
                }
            }
            return Price;
        }


        [HttpGet("GetProfitAndLoss")]
        public async Task<ProfitAndLoss> GetProfitAndLoss(string session, string address, int page, int offset)
        {
            ProfitAndLoss profitAndLoss = new ProfitAndLoss()
            {
                status = 1,
                message = "OK",
                Sum = 0
            };

            MarketChart marketChart = await GetMarketChart();
            if(marketChart == null)
                return profitAndLoss;
         
            ListTransactions listTransactions = await GetListTransactions(session, address, page, offset);
            foreach (Transaction transaction in listTransactions.result)
            {
                double price = ClosestToTimestamp(marketChart.prices, transaction.timeStamp);
              
                if (address.ToUpper().CompareTo(transaction.to.ToUpper()) == 0)
                    profitAndLoss.Sum += transaction.value * price;
                else if (address.ToUpper().CompareTo(transaction.from.ToUpper()) == 0)
                    profitAndLoss.Sum -= transaction.value * price;

            }
            return profitAndLoss;
        }
    }
}
