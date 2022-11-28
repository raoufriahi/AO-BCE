# EBA-Proxy API

<div class="app-desc">An ASP.NET Core Web API for managing ToDo items</div>

<div class="app-desc">More information: https://quanteam.fr/contactez-nous/</div>

<div class="app-desc">Contact Info: contact@quanteam.fr</div>

<div class="app-desc">Version: v1</div>

<div class="license-info">Copyright (c) 2022-2023 Quanteam</div>

<div class="license-url">https://quanteam.fr</div>

## Access

## <a name="__Methods">Methods</a>

[ Jump to [Models](#__Models) ]

### Table of Contents

#### [Ethereum](#Ethereum)

*   [<span class="http-method"></span>`get /api/etherscan/GetBalanceMultiAddr`](#apiEtherscanGetBalanceMultiAddrGet)
*   [<span class="http-method"></span>`get /api/etherscan/GetBalanceSingleAddr`](#apiEtherscanGetBalanceSingleAddrGet)
*   [<span class="http-method"></span>`get /api/etherscan/GetCexInOutflow`](#apiEtherscanGetCexInOutflowGet)
*   [<span class="http-method"></span>`get /api/etherscan/GetCountTransactions`](#apiEtherscanGetCountTransactionsGet)
*   [<span class="http-method"></span>`get /api/etherscan/GetDexInOutflow`](#apiEtherscanGetDexInOutflowGet)
*   [<span class="http-method"></span>`get /api/etherscan/GetListTransactions`](#apiEtherscanGetListTransactionsGet)
*   [<span class="http-method"></span>`get /api/etherscan/GetProfitAndLoss`](#apiEtherscanGetProfitAndLossGet)

# <a name="Ethereum">Ethereum</a>
[ Jump to [Up](#__Models) ]
<div class="method"><a name="apiEtherscanGetBalanceMultiAddrGet"></a> get /api/etherscan/GetBalanceMultiAddr</div>

### Query parameters
<div class="field-items">
<div class="param">session: [string]</div>
<div class="param">address: [string]</div>
</div>

### Return type
[ Jump to [BalanceMultiAddr](#BalanceMultiAddr) ]


### Example data

<div class="example-data-content-type">Content-Type: application/json</div>

    {
      "result" : [ {
        "balance" : "balance",
        "account" : "account"
      }, {
        "balance" : "balance",
        "account" : "account"
      } ],
      "message" : "message",
      "status" : 0
    }

### Produces

This API call produces the following media types according to the <span class="header">Accept</span> request header; the media type will be conveyed by the <span class="header">Content-Type</span> response header.

*   `text/plain`
*   `application/json`
*   `text/json`

### Responses

#### 200

Success [BalanceMultiAddr](#BalanceMultiAddr)</div>

* * *
[ Jump to [Up](#__Models) ]
<div class="method"><a name="apiEtherscanGetBalanceSingleAddrGet"></a>get /api/etherscan/GetBalanceSingleAddr</div>

### Query parameters

<div class="field-items">

<div class="param">session: [string]</div>
<div class="param">address: [string]</div>
</div>

### Return type
[ Jump to [BalanceSingleAddr](#BalanceSingleAddr) ]


### Example data

<div class="example-data-content-type">Content-Type: application/json</div>

    {
      "result" : "result",
      "message" : "message",
      "status" : 0
    }

### Produces

This API call produces the following media types according to the <span class="header">Accept</span> request header; the media type will be conveyed by the <span class="header">Content-Type</span> response header.

*   `text/plain`
*   `application/json`
*   `text/json`

### Responses

#### 200

Success [BalanceSingleAddr](#BalanceSingleAddr)</div>

* * *
[ Jump to [Up](#__Models) ]
<div class="method"><a name="apiEtherscanGetCexInOutflowGet"></a>get /api/etherscan/GetCexInOutflow</div>

### Query parameters

<div class="field-items">

<div class="param">session: [string]</div>
<div class="param">address: [string]</div>
<div class="param">page: [int]</div>
<div class="param">offset: [int]</div>
</div>

### Return type
[ Jump to [CexInOutflow](#CexInOutflow) ]


### Example data

<div class="example-data-content-type">Content-Type: application/json</div>

    {
      "result" : {
        "outflow" : 1.4658129805029452,
        "inflow" : 6.027456183070403
      },
      "message" : "message",
      "status" : 0
    }

### Produces

This API call produces the following media types according to the <span class="header">Accept</span> request header; the media type will be conveyed by the <span class="header">Content-Type</span> response header.

*   `text/plain`
*   `application/json`
*   `text/json`

### Responses

#### 200

Success [CexInOutflow](#CexInOutflow)</div>

* * *
[ Jump to [Up](#__Models) ]
<div class="method"><a name="apiEtherscanGetCountTransactionsGet"></a>
<div class="method-path">get /api/etherscan/GetCountTransactions</div>

### Query parameters

<div class="field-items">

<div class="param">session: [string]</div>
<div class="param">address: [string]</div>
<div class="param">page: [int]</div>
<div class="param">offset: [int]</div>
</div>

### Return type
[ Jump to [CountTransactions](#CountTransactions) ]


### Example data

<div class="example-data-content-type">Content-Type: application/json</div>

    {
      "result" : 6,
      "message" : "message",
      "status" : 0
    }

### Produces

This API call produces the following media types according to the <span class="header">Accept</span> request header; the media type will be conveyed by the <span class="header">Content-Type</span> response header.

*   `text/plain`
*   `application/json`
*   `text/json`

### Responses

#### 200

Success [CountTransactions](#CountTransactions)</div>

* * *
[ Jump to [Up](#__Models) ]
<div class="method"><a name="apiEtherscanGetDexInOutflowGet"></a>

<div class="method-path">get /api/etherscan/GetDexInOutflow</div>

### Query parameters

<div class="field-items">
<div class="param">session: [string]</div>
<div class="param">address: [string]</div>
<div class="param">page: [int]</div>
<div class="param">offset: [int]</div>
</div>

### Return type
[ Jump to [DexInOutflow](#DexInOutflow) ]


### Example data

<div class="example-data-content-type">Content-Type: application/json</div>

    {
      "result" : {
        "outflow" : 1.4658129805029452,
        "inflow" : 6.027456183070403
      },
      "message" : "message",
      "status" : 0
    }

### Produces

This API call produces the following media types according to the <span class="header">Accept</span> request header; the media type will be conveyed by the <span class="header">Content-Type</span> response header.

*   `text/plain`
*   `application/json`
*   `text/json`

### Responses

#### 200
[ Jump to [DexInOutflow](#DexInOutflow) ]


* * *
[ Jump to [Up](#__Models) ]
<div class="method"><a name="apiEtherscanGetListTransactionsGet"></a>

<div class="method-path">get /api/etherscan/GetListTransactions</div>

### Query parameters

<div class="field-items">

<div class="param">session: [string]</div>
<div class="param">address: [string]</div>
<div class="param">page: [int]</div>
<div class="param">offset: [int]</div>
</div>

### Return type

<div class="return-type">[ListTransactions](#ListTransactions)</div>

### Example data

<div class="example-data-content-type">Content-Type: application/json</div>

    {
      "result" : [ {
        "blockHash" : "blockHash",
        "functionName" : "functionName",
        "contractAddress" : "contractAddress",
        "methodId" : "methodId",
        "transactionIndex" : 5,
        "confirmations" : 1,
        "nonce" : 5,
        "timeStamp" : 1.4658129805029452,
        "input" : "input",
        "gasUsed" : 7,
        "isError" : 3,
        "txreceipt_status" : 2,
        "blockNumber" : 6,
        "gas" : 7,
        "cumulativeGasUsed" : 4,
        "from" : "from",
        "to" : "to",
        "value" : 2.3021358869347655,
        "hash" : "hash",
        "gasPrice" : 9
      }, {
        "blockHash" : "blockHash",
        "functionName" : "functionName",
        "contractAddress" : "contractAddress",
        "methodId" : "methodId",
        "transactionIndex" : 5,
        "confirmations" : 1,
        "nonce" : 5,
        "timeStamp" : 1.4658129805029452,
        "input" : "input",
        "gasUsed" : 7,
        "isError" : 3,
        "txreceipt_status" : 2,
        "blockNumber" : 6,
        "gas" : 7,
        "cumulativeGasUsed" : 4,
        "from" : "from",
        "to" : "to",
        "value" : 2.3021358869347655,
        "hash" : "hash",
        "gasPrice" : 9
      } ],
      "message" : "message",
      "status" : 0
    }

### Produces

This API call produces the following media types according to the <span class="header">Accept</span> request header; the media type will be conveyed by the <span class="header">Content-Type</span> response header.

*   `text/plain`
*   `application/json`
*   `text/json`

### Responses

#### 200

Success [ListTransactions](#ListTransactions)</div>

* * *
[ Jump to [Up](#__Models) ]
<div class="method"><a name="apiEtherscanGetProfitAndLossGet"></a>
<div class="method-path">get /api/etherscan/GetProfitAndLoss</div>

### Query parameters

<div class="field-items">

<div class="param">session: [string]</div>
<div class="param">address: [string]</div>
<div class="param">page: [int]</div>
<div class="param">offset : [int]</div>
</div>

### Return type
[ Jump to [ProfitAndLoss](#ProfitAndLoss) ]

### Example data

<div class="example-data-content-type">Content-Type: application/json</div>

    {
      "result" : 6.027456183070403,
      "message" : "message",
      "status" : 0
    }

### Produces

This API call produces the following media types according to the <span class="header">Accept</span> request header; the media type will be conveyed by the <span class="header">Content-Type</span> response header.

*   `text/plain`
*   `application/json`
*   `text/json`

### Responses

#### 200

Success [ProfitAndLoss](#ProfitAndLoss)</div>

* * *

## <a name="__Models">Models</a>

[ Jump to [Methods](#__Methods) ]

### Table of Contents

1.  [`Balance`](#Balance)
2.  [`BalanceMultiAddr`](#BalanceMultiAddr)
3.  [`BalanceSingleAddr`](#BalanceSingleAddr)
4.  [`CexInOutflow`](#CexInOutflow)
5.  [`CountTransactions`](#CountTransactions)
6.  [`DexInOutflow`](#DexInOutflow)
7.  [`InOutflow`](#InOutflow)
8.  [`ListTransactions`](#ListTransactions)
9.  [`ProfitAndLoss`](#ProfitAndLoss)
10.  [`Transaction`](#Transaction)

<div class="model">

### <a name="Balance">`Balance`</a> [Up](#__Models)
<div class="field-items">
<div class="param">account: [string]</div>
<div class="param">balance: [string]</div>
</div>
</div>
<div class="model">

### <a name="BalanceMultiAddr">`BalanceMultiAddr`</a> [Up](#__Models)
<div class="field-items">
<div class="param">status: [integer]</div>
<div class="param">message: [string]</div>
<div class="param">result: array[Balance]</div>
</div>

</div>

<div class="model">

### <a name="BalanceSingleAddr">`BalanceSingleAddr`</a> [Up](#__Models)

<div class="field-items">
<div class="param">status: [integer]</div>
<div class="param">message: [string]</div>
<div class="param">result: [string]</div>
</div>

</div>

<div class="model">

### <a name="CexInOutflow">`CexInOutflow`</a> [Up](#__Models)

<div class="field-items">
<div class="param">status: [integer]</div>
<div class="param">message: [string]</div>
<div class="param">result: [InOutflow]</div>
</div>

</div>

<div class="model">

### <a name="CountTransactions">`CountTransactions`</a> [Up](#__Models)

<div class="field-items">
<div class="param">status: [integer]</div>
<div class="param">message: [string]</div>
<div class="param">result: [integer]</div>
</div>

</div>

<div class="model">

### <a name="DexInOutflow">`DexInOutflow`</a> [Up](#__Models)

<div class="field-items">
<div class="param">status: [integer]</div>
<div class="param">message: [string]</div>
<div class="param">result: [InOutflow]</div>
</div>

</div>

<div class="model">

### <a name="InOutflow">`InOutflow`</a> [Up](#__Models)

<div class="field-items">
<div class="param">inflow: [double]</div>
<div class="param">outflow: [double]</div>
</div>

</div>

<div class="model">

### <a name="ListTransactions">`ListTransactions`</a> [Up](#__Models)

<div class="field-items">
<div class="param">status: [integer]</div>
<div class="param">message: [string]</div>
<div class="param">result: [array[Transaction]]</div>
</div>

</div>

<div class="model">

### <a name="ProfitAndLoss">`ProfitAndLoss`</a> [Up](#__Models)
<div class="field-items">
<div class="param">status: [integer]</div>
<div class="param">message: [string]</div>
<div class="param">result: [double]</div>
</div>

</div>

<div class="model">

### <a name="Transaction">`Transaction`</a> [Up](#__Models)

<div class="field-items">
<div class="param">blockNumber: [integer]</div>
<div class="param">timeStamp: [double]</div>
<div class="param">hash: [string]</div>
<div class="param">nonce: [integer]</div>
<div class="param">blockHash: [string]</div>
<div class="param">transactionIndex: [integer]</div>
<div class="param">from: [string]</div>
<div class="param">to: [string]</div>
<div class="param">value: [double]</div>
<div class="param">gas: [integer]</div>
<div class="param">gasPrice: [long]</div>
<div class="param">isError: [integer]</div>
<div class="param">txreceipt_status: [integer]</div>
<div class="param">input: [string]</div>
<div class="param">contractAddress: [string]</div>
<div class="param">cumulativeGasUsed: [integer]</div>
<div class="param">gasUsed: [integer]</div>
<div class="param">confirmations: [integer]</div>
<div class="param">methodId: [string]</div>
<div class="param">functionName: [string]</a></div>
</div>

</div>
