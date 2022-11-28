# EBA-Proxy API

<div class="app-desc">An ASP.NET Core Web API for managing ToDo items</div>

<div class="app-desc">More information: [https://quanteam.fr/contactez-nous/](https://quanteam.fr/contactez-nous/)</div>

<div class="app-desc">Contact Info: [hello@helloreverb.com](hello@helloreverb.com)</div>

<div class="app-desc">Version: v1</div>

<div class="license-info">Copyright (c) 2022-2023 Quanteam</div>

<div class="license-url">https://quanteam.fr</div>

## Access

## <a name="__Methods">Methods</a>

[ Jump to [Models](#__Models) ]

### Table of Contents

#### [Ethereum](#Ethereum)

*   [`<span class="http-method">get</span> /api/etherscan/GetBalanceMultiAddr`](#apiEtherscanGetBalanceMultiAddrGet)
*   [`<span class="http-method">get</span> /api/etherscan/GetBalanceSingleAddr`](#apiEtherscanGetBalanceSingleAddrGet)
*   [`<span class="http-method">get</span> /api/etherscan/GetCexInOutflow`](#apiEtherscanGetCexInOutflowGet)
*   [`<span class="http-method">get</span> /api/etherscan/GetCountTransactions`](#apiEtherscanGetCountTransactionsGet)
*   [`<span class="http-method">get</span> /api/etherscan/GetDexInOutflow`](#apiEtherscanGetDexInOutflowGet)
*   [`<span class="http-method">get</span> /api/etherscan/GetListTransactions`](#apiEtherscanGetListTransactionsGet)
*   [`<span class="http-method">get</span> /api/etherscan/GetProfitAndLoss`](#apiEtherscanGetProfitAndLossGet)

# <a name="Ethereum">Ethereum</a>

<div class="method"><a name="apiEtherscanGetBalanceMultiAddrGet"></a>

<div class="method-path">[Up](#__Methods)

    get /api/etherscan/GetBalanceMultiAddr

</div>

<div class="method-summary">(<span class="nickname">apiEtherscanGetBalanceMultiAddrGet</span>)</div>

### Query parameters

<div class="field-items">

<div class="param">session (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> —</div>

<div class="param">address (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> —</div>

</div>

### Return type

<div class="return-type">[BalanceMultiAddr](#BalanceMultiAddr)</div>

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

<div class="method"><a name="apiEtherscanGetBalanceSingleAddrGet"></a>

<div class="method-path">[Up](#__Methods)

    get /api/etherscan/GetBalanceSingleAddr

</div>

<div class="method-summary">(<span class="nickname">apiEtherscanGetBalanceSingleAddrGet</span>)</div>

### Query parameters

<div class="field-items">

<div class="param">session (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> —</div>

<div class="param">address (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> —</div>

</div>

### Return type

<div class="return-type">[BalanceSingleAddr](#BalanceSingleAddr)</div>

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

<div class="method"><a name="apiEtherscanGetCexInOutflowGet"></a>

<div class="method-path">[Up](#__Methods)

    get /api/etherscan/GetCexInOutflow

</div>

<div class="method-summary">(<span class="nickname">apiEtherscanGetCexInOutflowGet</span>)</div>

### Query parameters

<div class="field-items">

<div class="param">session (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> —</div>

<div class="param">address (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> —</div>

<div class="param">page (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> — format: int32</div>

<div class="param">offset (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> — format: int32</div>

</div>

### Return type

<div class="return-type">[CexInOutflow](#CexInOutflow)</div>

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

<div class="method"><a name="apiEtherscanGetCountTransactionsGet"></a>

<div class="method-path">[Up](#__Methods)

    get /api/etherscan/GetCountTransactions

</div>

<div class="method-summary">(<span class="nickname">apiEtherscanGetCountTransactionsGet</span>)</div>

### Query parameters

<div class="field-items">

<div class="param">session (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> —</div>

<div class="param">address (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> —</div>

<div class="param">page (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> — format: int32</div>

<div class="param">offset (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> — format: int32</div>

</div>

### Return type

<div class="return-type">[CountTransactions](#CountTransactions)</div>

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

<div class="method"><a name="apiEtherscanGetDexInOutflowGet"></a>

<div class="method-path">[Up](#__Methods)

    get /api/etherscan/GetDexInOutflow

</div>

<div class="method-summary">(<span class="nickname">apiEtherscanGetDexInOutflowGet</span>)</div>

### Query parameters

<div class="field-items">

<div class="param">session (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> —</div>

<div class="param">address (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> —</div>

<div class="param">page (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> — format: int32</div>

<div class="param">offset (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> — format: int32</div>

</div>

### Return type

<div class="return-type">[DexInOutflow](#DexInOutflow)</div>

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

Success [DexInOutflow](#DexInOutflow)</div>

* * *

<div class="method"><a name="apiEtherscanGetListTransactionsGet"></a>

<div class="method-path">[Up](#__Methods)

    get /api/etherscan/GetListTransactions

</div>

<div class="method-summary">(<span class="nickname">apiEtherscanGetListTransactionsGet</span>)</div>

### Query parameters

<div class="field-items">

<div class="param">session (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> —</div>

<div class="param">address (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> —</div>

<div class="param">page (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> — format: int32</div>

<div class="param">offset (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> — format: int32</div>

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

<div class="method"><a name="apiEtherscanGetProfitAndLossGet"></a>

<div class="method-path">[Up](#__Methods)

    get /api/etherscan/GetProfitAndLoss

</div>

<div class="method-summary">(<span class="nickname">apiEtherscanGetProfitAndLossGet</span>)</div>

### Query parameters

<div class="field-items">

<div class="param">session (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> —</div>

<div class="param">address (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> —</div>

<div class="param">page (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> — format: int32</div>

<div class="param">offset (optional)</div>

<div class="param-desc"><span class="param-type">Query Parameter</span> — format: int32</div>

</div>

### Return type

<div class="return-type">[ProfitAndLoss](#ProfitAndLoss)</div>

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

<div class="param">account (optional)</div>

<div class="param-desc"><span class="param-type">[String](#string)</span></div>

<div class="param">balance (optional)</div>

<div class="param-desc"><span class="param-type">[String](#string)</span></div>

</div>

</div>

<div class="model">

### <a name="BalanceMultiAddr">`BalanceMultiAddr`</a> [Up](#__Models)

<div class="field-items">

<div class="param">status (optional)</div>

<div class="param-desc"><span class="param-type">[Integer](#integer)</span> format: int32</div>

<div class="param">message (optional)</div>

<div class="param-desc"><span class="param-type">[String](#string)</span></div>

<div class="param">result (optional)</div>

<div class="param-desc"><span class="param-type">[array[Balance]](#Balance)</span></div>

</div>

</div>

<div class="model">

### <a name="BalanceSingleAddr">`BalanceSingleAddr`</a> [Up](#__Models)

<div class="field-items">

<div class="param">status (optional)</div>

<div class="param-desc"><span class="param-type">[Integer](#integer)</span> format: int32</div>

<div class="param">message (optional)</div>

<div class="param-desc"><span class="param-type">[String](#string)</span></div>

<div class="param">result (optional)</div>

<div class="param-desc"><span class="param-type">[String](#string)</span></div>

</div>

</div>

<div class="model">

### <a name="CexInOutflow">`CexInOutflow`</a> [Up](#__Models)

<div class="field-items">

<div class="param">status (optional)</div>

<div class="param-desc"><span class="param-type">[Integer](#integer)</span> format: int32</div>

<div class="param">message (optional)</div>

<div class="param-desc"><span class="param-type">[String](#string)</span></div>

<div class="param">result (optional)</div>

<div class="param-desc"><span class="param-type">[InOutflow](#InOutflow)</span></div>

</div>

</div>

<div class="model">

### <a name="CountTransactions">`CountTransactions`</a> [Up](#__Models)

<div class="field-items">

<div class="param">status (optional)</div>

<div class="param-desc"><span class="param-type">[Integer](#integer)</span> format: int32</div>

<div class="param">message (optional)</div>

<div class="param-desc"><span class="param-type">[String](#string)</span></div>

<div class="param">result (optional)</div>

<div class="param-desc"><span class="param-type">[Integer](#integer)</span> format: int32</div>

</div>

</div>

<div class="model">

### <a name="DexInOutflow">`DexInOutflow`</a> [Up](#__Models)

<div class="field-items">

<div class="param">status (optional)</div>

<div class="param-desc"><span class="param-type">[Integer](#integer)</span> format: int32</div>

<div class="param">message (optional)</div>

<div class="param-desc"><span class="param-type">[String](#string)</span></div>

<div class="param">result (optional)</div>

<div class="param-desc"><span class="param-type">[InOutflow](#InOutflow)</span></div>

</div>

</div>

<div class="model">

### <a name="InOutflow">`InOutflow`</a> [Up](#__Models)

<div class="field-items">

<div class="param">inflow (optional)</div>

<div class="param-desc"><span class="param-type">[Double](#double)</span> format: double</div>

<div class="param">outflow (optional)</div>

<div class="param-desc"><span class="param-type">[Double](#double)</span> format: double</div>

</div>

</div>

<div class="model">

### <a name="ListTransactions">`ListTransactions`</a> [Up](#__Models)

<div class="field-items">

<div class="param">status (optional)</div>

<div class="param-desc"><span class="param-type">[Integer](#integer)</span> format: int32</div>

<div class="param">message (optional)</div>

<div class="param-desc"><span class="param-type">[String](#string)</span></div>

<div class="param">result (optional)</div>

<div class="param-desc"><span class="param-type">[array[Transaction]](#Transaction)</span></div>

</div>

</div>

<div class="model">

### <a name="ProfitAndLoss">`ProfitAndLoss`</a> [Up](#__Models)

<div class="field-items">

<div class="param">status (optional)</div>

<div class="param-desc"><span class="param-type">[Integer](#integer)</span> format: int32</div>

<div class="param">message (optional)</div>

<div class="param-desc"><span class="param-type">[String](#string)</span></div>

<div class="param">result (optional)</div>

<div class="param-desc"><span class="param-type">[Double](#double)</span> format: double</div>

</div>

</div>

<div class="model">

### <a name="Transaction">`Transaction`</a> [Up](#__Models)

<div class="field-items">

<div class="param">blockNumber (optional)</div>

<div class="param-desc"><span class="param-type">[Integer](#integer)</span> format: int32</div>

<div class="param">timeStamp (optional)</div>

<div class="param-desc"><span class="param-type">[Double](#double)</span> format: double</div>

<div class="param">hash (optional)</div>

<div class="param-desc"><span class="param-type">[String](#string)</span></div>

<div class="param">nonce (optional)</div>

<div class="param-desc"><span class="param-type">[Integer](#integer)</span> format: int32</div>

<div class="param">blockHash (optional)</div>

<div class="param-desc"><span class="param-type">[String](#string)</span></div>

<div class="param">transactionIndex (optional)</div>

<div class="param-desc"><span class="param-type">[Integer](#integer)</span> format: int32</div>

<div class="param">from (optional)</div>

<div class="param-desc"><span class="param-type">[String](#string)</span></div>

<div class="param">to (optional)</div>

<div class="param-desc"><span class="param-type">[String](#string)</span></div>

<div class="param">value (optional)</div>

<div class="param-desc"><span class="param-type">[Double](#double)</span> format: double</div>

<div class="param">gas (optional)</div>

<div class="param-desc"><span class="param-type">[Integer](#integer)</span> format: int32</div>

<div class="param">gasPrice (optional)</div>

<div class="param-desc"><span class="param-type">[Long](#long)</span> format: int64</div>

<div class="param">isError (optional)</div>

<div class="param-desc"><span class="param-type">[Integer](#integer)</span> format: int32</div>

<div class="param">txreceipt_status (optional)</div>

<div class="param-desc"><span class="param-type">[Integer](#integer)</span> format: int32</div>

<div class="param">input (optional)</div>

<div class="param-desc"><span class="param-type">[String](#string)</span></div>

<div class="param">contractAddress (optional)</div>

<div class="param-desc"><span class="param-type">[String](#string)</span></div>

<div class="param">cumulativeGasUsed (optional)</div>

<div class="param-desc"><span class="param-type">[Integer](#integer)</span> format: int32</div>

<div class="param">gasUsed (optional)</div>

<div class="param-desc"><span class="param-type">[Integer](#integer)</span> format: int32</div>

<div class="param">confirmations (optional)</div>

<div class="param-desc"><span class="param-type">[Integer](#integer)</span> format: int32</div>

<div class="param">methodId (optional)</div>

<div class="param-desc"><span class="param-type">[String](#string)</span></div>

<div class="param">functionName (optional)</div>

<div class="param-desc"><span class="param-type">[String](#string)</span></div>

</div>

</div>
