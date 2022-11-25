using System.Collections.Generic;

namespace ebaproxy.Model
{
    public class BalanceSingleAddr
    {
        public int status { get; set; }
        public string message { get; set; }
        public string result { get; set; }
    }

    public class BalanceMultiAddr
    {
        public int status { get; set; }
        public string message { get; set; }
        public List<Balance> result { get; set; }
    }
    public class Balance
    {
        public string account { get; set; }
        public string balance { get; set; }
    }
    public class ListTransactions
    {
        public int status { get; set; }
        public string message { get; set; }
        public List<Transaction> result { get; set; }
    }

    public class Transaction
    {
        public int blockNumber { get; set; }
        public double timeStamp { get; set; }
        public string hash { get; set; }
        public int nonce { get; set; }
        public string blockHash { get; set; }
        public int transactionIndex { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public double value { get; set; }
        public int gas { get; set; }
        public Int64 gasPrice { get; set; }
        public int isError { get; set; }
        public int txreceipt_status { get; set; }
        public string input { get; set; }
        public string contractAddress { get; set; }
        public int cumulativeGasUsed { get; set; }
        public int gasUsed { get; set; }
        public int confirmations { get; set; }
        public string methodId { get; set; }
        public string functionName { get; set; }
    }

    public class CountTransactions
    {
        public int status { get; set; }
        public string message { get; set; }
        public int result { get; set; }
    }
    public class CexInOutflow
    {
        public int status { get; set; }
        public string message { get; set; }
        public InOutflow result { get; set; }
    }
    public class DexInOutflow
    {
        public int status { get; set; }
        public string message { get; set; }
        public InOutflow result { get; set; }
    }

    public class InOutflow
    {
        public double Inflow { get; set; }
        public double Outflow { get; set; }
    }

    public class ProfitAndLoss
    {
        public int status { get; set; }
        public string message { get; set; }
        public double Sum { get; set; }
    }

   

    public class BlockReward
    {
        public int status { get; set; }
        public string message { get; set; }
        public Block result { get; set; }
    }
    
    
    public class Block
    {
        public  int blockNumber { get; set; }
        public int timeStamp { get; set; }
        public string blockMiner { get; set; }
        public string blockReward { get; set; }
        public List<Uncles> uncles { get; set; }
        public double uncleInclusionReward { get; set; }
    }

    public class Uncles
    {
       public string miner { get; set; }
       public int unclePosition { get; set; }
       public double blockreward { get; set; }
    }
    public class MarketChart
    {
        public double[][] prices { get; set; }
    } 

}

