# FireflyIIINet.Api.AutocompleteApi

All URIs are relative to *https://demo.firefly-iii.org/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAccountsAC**](AutocompleteApi.md#getaccountsac) | **GET** /v1/autocomplete/accounts | Returns all accounts of the user returned in a basic auto-complete array. |
| [**GetBillsAC**](AutocompleteApi.md#getbillsac) | **GET** /v1/autocomplete/bills | Returns all bills of the user returned in a basic auto-complete array. |
| [**GetBudgetsAC**](AutocompleteApi.md#getbudgetsac) | **GET** /v1/autocomplete/budgets | Returns all budgets of the user returned in a basic auto-complete array. |
| [**GetCategoriesAC**](AutocompleteApi.md#getcategoriesac) | **GET** /v1/autocomplete/categories | Returns all categories of the user returned in a basic auto-complete array. |
| [**GetCurrenciesAC**](AutocompleteApi.md#getcurrenciesac) | **GET** /v1/autocomplete/currencies | Returns all currencies of the user returned in a basic auto-complete array. |
| [**GetCurrenciesCodeAC**](AutocompleteApi.md#getcurrenciescodeac) | **GET** /v1/autocomplete/currencies-with-code | Returns all currencies of the user returned in a basic auto-complete array. This endpoint is DEPRECATED and I suggest you DO NOT use it. |
| [**GetObjectGroupsAC**](AutocompleteApi.md#getobjectgroupsac) | **GET** /v1/autocomplete/object-groups | Returns all object groups of the user returned in a basic auto-complete array. |
| [**GetPiggiesAC**](AutocompleteApi.md#getpiggiesac) | **GET** /v1/autocomplete/piggy-banks | Returns all piggy banks of the user returned in a basic auto-complete array. |
| [**GetPiggiesBalanceAC**](AutocompleteApi.md#getpiggiesbalanceac) | **GET** /v1/autocomplete/piggy-banks-with-balance | Returns all piggy banks of the user returned in a basic auto-complete array complemented with balance information. |
| [**GetRecurringAC**](AutocompleteApi.md#getrecurringac) | **GET** /v1/autocomplete/recurring | Returns all recurring transactions of the user returned in a basic auto-complete array. |
| [**GetRuleGroupsAC**](AutocompleteApi.md#getrulegroupsac) | **GET** /v1/autocomplete/rule-groups | Returns all rule groups of the user returned in a basic auto-complete array. |
| [**GetRulesAC**](AutocompleteApi.md#getrulesac) | **GET** /v1/autocomplete/rules | Returns all rules of the user returned in a basic auto-complete array. |
| [**GetTagAC**](AutocompleteApi.md#gettagac) | **GET** /v1/autocomplete/tags | Returns all tags of the user returned in a basic auto-complete array. |
| [**GetTransactionTypesAC**](AutocompleteApi.md#gettransactiontypesac) | **GET** /v1/autocomplete/transaction-types | Returns all transaction types returned in a basic auto-complete array. English only. |
| [**GetTransactionsAC**](AutocompleteApi.md#gettransactionsac) | **GET** /v1/autocomplete/transactions | Returns all transaction descriptions of the user returned in a basic auto-complete array. |
| [**GetTransactionsIDAC**](AutocompleteApi.md#gettransactionsidac) | **GET** /v1/autocomplete/transactions-with-id | Returns all transactions, complemented with their ID, of the user returned in a basic auto-complete array. This endpoint is DEPRECATED and I suggest you DO NOT use it. |

<a id="getaccountsac"></a>
# **GetAccountsAC**
> List&lt;AutocompleteAccount&gt; GetAccountsAC (Guid? xTraceId = null, string? query = null, int? limit = null, string? date = null, List<AccountTypeFilter>? types = null)

Returns all accounts of the user returned in a basic auto-complete array.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIIINet.Api;
using FireflyIIINet.Client;
using FireflyIIINet.Model;

namespace Example
{
    public class GetAccountsACExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo.firefly-iii.org/api";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutocompleteApi(config);
            var xTraceId = "xTraceId_example";  // Guid? | Unique identifier associated with this request. (optional) 
            var query = string;  // string? | The autocomplete search query. (optional) 
            var limit = 10;  // int? | The number of items returned. (optional) 
            var date = 2020-09-17;  // string? | If the account is an asset account or a liability, the autocomplete will also return the balance of the account on this date. (optional) 
            var types = new List<AccountTypeFilter>?(); // List<AccountTypeFilter>? | Optional filter on the account type(s) used in the autocomplete. (optional) 

            try
            {
                // Returns all accounts of the user returned in a basic auto-complete array.
                List<AutocompleteAccount> result = apiInstance.GetAccountsAC(xTraceId, query, limit, date, types);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutocompleteApi.GetAccountsAC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountsACWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all accounts of the user returned in a basic auto-complete array.
    ApiResponse<List<AutocompleteAccount>> response = apiInstance.GetAccountsACWithHttpInfo(xTraceId, query, limit, date, types);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutocompleteApi.GetAccountsACWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xTraceId** | **Guid?** | Unique identifier associated with this request. | [optional]  |
| **query** | **string?** | The autocomplete search query. | [optional]  |
| **limit** | **int?** | The number of items returned. | [optional]  |
| **date** | **string?** | If the account is an asset account or a liability, the autocomplete will also return the balance of the account on this date. | [optional]  |
| **types** | [**List&lt;AccountTypeFilter&gt;?**](AccountTypeFilter.md) | Optional filter on the account type(s) used in the autocomplete. | [optional]  |

### Return type

[**List&lt;AutocompleteAccount&gt;**](AutocompleteAccount.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthenticated |  -  |
| **404** | Page not found |  -  |
| **400** | Bad request |  -  |
| **500** | Internal exception |  -  |
| **200** | A list of accounts with very basic information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbillsac"></a>
# **GetBillsAC**
> List&lt;AutocompleteBill&gt; GetBillsAC (Guid? xTraceId = null, string? query = null, int? limit = null)

Returns all bills of the user returned in a basic auto-complete array.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIIINet.Api;
using FireflyIIINet.Client;
using FireflyIIINet.Model;

namespace Example
{
    public class GetBillsACExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo.firefly-iii.org/api";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutocompleteApi(config);
            var xTraceId = "xTraceId_example";  // Guid? | Unique identifier associated with this request. (optional) 
            var query = string;  // string? | The autocomplete search query. (optional) 
            var limit = 10;  // int? | The number of items returned. (optional) 

            try
            {
                // Returns all bills of the user returned in a basic auto-complete array.
                List<AutocompleteBill> result = apiInstance.GetBillsAC(xTraceId, query, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutocompleteApi.GetBillsAC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBillsACWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all bills of the user returned in a basic auto-complete array.
    ApiResponse<List<AutocompleteBill>> response = apiInstance.GetBillsACWithHttpInfo(xTraceId, query, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutocompleteApi.GetBillsACWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xTraceId** | **Guid?** | Unique identifier associated with this request. | [optional]  |
| **query** | **string?** | The autocomplete search query. | [optional]  |
| **limit** | **int?** | The number of items returned. | [optional]  |

### Return type

[**List&lt;AutocompleteBill&gt;**](AutocompleteBill.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthenticated |  -  |
| **404** | Page not found |  -  |
| **400** | Bad request |  -  |
| **500** | Internal exception |  -  |
| **200** | A list of bills with very basic information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbudgetsac"></a>
# **GetBudgetsAC**
> List&lt;AutocompleteBudget&gt; GetBudgetsAC (Guid? xTraceId = null, string? query = null, int? limit = null)

Returns all budgets of the user returned in a basic auto-complete array.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIIINet.Api;
using FireflyIIINet.Client;
using FireflyIIINet.Model;

namespace Example
{
    public class GetBudgetsACExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo.firefly-iii.org/api";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutocompleteApi(config);
            var xTraceId = "xTraceId_example";  // Guid? | Unique identifier associated with this request. (optional) 
            var query = string;  // string? | The autocomplete search query. (optional) 
            var limit = 10;  // int? | The number of items returned. (optional) 

            try
            {
                // Returns all budgets of the user returned in a basic auto-complete array.
                List<AutocompleteBudget> result = apiInstance.GetBudgetsAC(xTraceId, query, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutocompleteApi.GetBudgetsAC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBudgetsACWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all budgets of the user returned in a basic auto-complete array.
    ApiResponse<List<AutocompleteBudget>> response = apiInstance.GetBudgetsACWithHttpInfo(xTraceId, query, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutocompleteApi.GetBudgetsACWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xTraceId** | **Guid?** | Unique identifier associated with this request. | [optional]  |
| **query** | **string?** | The autocomplete search query. | [optional]  |
| **limit** | **int?** | The number of items returned. | [optional]  |

### Return type

[**List&lt;AutocompleteBudget&gt;**](AutocompleteBudget.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthenticated |  -  |
| **404** | Page not found |  -  |
| **400** | Bad request |  -  |
| **500** | Internal exception |  -  |
| **200** | A list of budgets with very basic information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcategoriesac"></a>
# **GetCategoriesAC**
> List&lt;AutocompleteCategory&gt; GetCategoriesAC (Guid? xTraceId = null, string? query = null, int? limit = null)

Returns all categories of the user returned in a basic auto-complete array.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIIINet.Api;
using FireflyIIINet.Client;
using FireflyIIINet.Model;

namespace Example
{
    public class GetCategoriesACExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo.firefly-iii.org/api";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutocompleteApi(config);
            var xTraceId = "xTraceId_example";  // Guid? | Unique identifier associated with this request. (optional) 
            var query = string;  // string? | The autocomplete search query. (optional) 
            var limit = 10;  // int? | The number of items returned. (optional) 

            try
            {
                // Returns all categories of the user returned in a basic auto-complete array.
                List<AutocompleteCategory> result = apiInstance.GetCategoriesAC(xTraceId, query, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutocompleteApi.GetCategoriesAC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCategoriesACWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all categories of the user returned in a basic auto-complete array.
    ApiResponse<List<AutocompleteCategory>> response = apiInstance.GetCategoriesACWithHttpInfo(xTraceId, query, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutocompleteApi.GetCategoriesACWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xTraceId** | **Guid?** | Unique identifier associated with this request. | [optional]  |
| **query** | **string?** | The autocomplete search query. | [optional]  |
| **limit** | **int?** | The number of items returned. | [optional]  |

### Return type

[**List&lt;AutocompleteCategory&gt;**](AutocompleteCategory.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthenticated |  -  |
| **404** | Page not found |  -  |
| **400** | Bad request |  -  |
| **500** | Internal exception |  -  |
| **200** | A list of categories with very basic information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcurrenciesac"></a>
# **GetCurrenciesAC**
> List&lt;AutocompleteCurrency&gt; GetCurrenciesAC (Guid? xTraceId = null, string? query = null, int? limit = null)

Returns all currencies of the user returned in a basic auto-complete array.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIIINet.Api;
using FireflyIIINet.Client;
using FireflyIIINet.Model;

namespace Example
{
    public class GetCurrenciesACExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo.firefly-iii.org/api";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutocompleteApi(config);
            var xTraceId = "xTraceId_example";  // Guid? | Unique identifier associated with this request. (optional) 
            var query = string;  // string? | The autocomplete search query. (optional) 
            var limit = 10;  // int? | The number of items returned. (optional) 

            try
            {
                // Returns all currencies of the user returned in a basic auto-complete array.
                List<AutocompleteCurrency> result = apiInstance.GetCurrenciesAC(xTraceId, query, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutocompleteApi.GetCurrenciesAC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCurrenciesACWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all currencies of the user returned in a basic auto-complete array.
    ApiResponse<List<AutocompleteCurrency>> response = apiInstance.GetCurrenciesACWithHttpInfo(xTraceId, query, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutocompleteApi.GetCurrenciesACWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xTraceId** | **Guid?** | Unique identifier associated with this request. | [optional]  |
| **query** | **string?** | The autocomplete search query. | [optional]  |
| **limit** | **int?** | The number of items returned. | [optional]  |

### Return type

[**List&lt;AutocompleteCurrency&gt;**](AutocompleteCurrency.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthenticated |  -  |
| **404** | Page not found |  -  |
| **400** | Bad request |  -  |
| **500** | Internal exception |  -  |
| **200** | A list of currencies with very basic information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcurrenciescodeac"></a>
# **GetCurrenciesCodeAC**
> List&lt;AutocompleteCurrencyCode&gt; GetCurrenciesCodeAC (Guid? xTraceId = null, string? query = null, int? limit = null)

Returns all currencies of the user returned in a basic auto-complete array. This endpoint is DEPRECATED and I suggest you DO NOT use it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIIINet.Api;
using FireflyIIINet.Client;
using FireflyIIINet.Model;

namespace Example
{
    public class GetCurrenciesCodeACExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo.firefly-iii.org/api";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutocompleteApi(config);
            var xTraceId = "xTraceId_example";  // Guid? | Unique identifier associated with this request. (optional) 
            var query = string;  // string? | The autocomplete search query. (optional) 
            var limit = 10;  // int? | The number of items returned. (optional) 

            try
            {
                // Returns all currencies of the user returned in a basic auto-complete array. This endpoint is DEPRECATED and I suggest you DO NOT use it.
                List<AutocompleteCurrencyCode> result = apiInstance.GetCurrenciesCodeAC(xTraceId, query, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutocompleteApi.GetCurrenciesCodeAC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCurrenciesCodeACWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all currencies of the user returned in a basic auto-complete array. This endpoint is DEPRECATED and I suggest you DO NOT use it.
    ApiResponse<List<AutocompleteCurrencyCode>> response = apiInstance.GetCurrenciesCodeACWithHttpInfo(xTraceId, query, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutocompleteApi.GetCurrenciesCodeACWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xTraceId** | **Guid?** | Unique identifier associated with this request. | [optional]  |
| **query** | **string?** | The autocomplete search query. | [optional]  |
| **limit** | **int?** | The number of items returned. | [optional]  |

### Return type

[**List&lt;AutocompleteCurrencyCode&gt;**](AutocompleteCurrencyCode.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthenticated |  -  |
| **404** | Page not found |  -  |
| **400** | Bad request |  -  |
| **500** | Internal exception |  -  |
| **200** | A list of currencies with very basic information and the currency code between brackets. This endpoint is DEPRECATED and I suggest you DO NOT use it. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getobjectgroupsac"></a>
# **GetObjectGroupsAC**
> List&lt;AutocompleteObjectGroup&gt; GetObjectGroupsAC (Guid? xTraceId = null, string? query = null, int? limit = null)

Returns all object groups of the user returned in a basic auto-complete array.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIIINet.Api;
using FireflyIIINet.Client;
using FireflyIIINet.Model;

namespace Example
{
    public class GetObjectGroupsACExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo.firefly-iii.org/api";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutocompleteApi(config);
            var xTraceId = "xTraceId_example";  // Guid? | Unique identifier associated with this request. (optional) 
            var query = string;  // string? | The autocomplete search query. (optional) 
            var limit = 10;  // int? | The number of items returned. (optional) 

            try
            {
                // Returns all object groups of the user returned in a basic auto-complete array.
                List<AutocompleteObjectGroup> result = apiInstance.GetObjectGroupsAC(xTraceId, query, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutocompleteApi.GetObjectGroupsAC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetObjectGroupsACWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all object groups of the user returned in a basic auto-complete array.
    ApiResponse<List<AutocompleteObjectGroup>> response = apiInstance.GetObjectGroupsACWithHttpInfo(xTraceId, query, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutocompleteApi.GetObjectGroupsACWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xTraceId** | **Guid?** | Unique identifier associated with this request. | [optional]  |
| **query** | **string?** | The autocomplete search query. | [optional]  |
| **limit** | **int?** | The number of items returned. | [optional]  |

### Return type

[**List&lt;AutocompleteObjectGroup&gt;**](AutocompleteObjectGroup.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthenticated |  -  |
| **404** | Page not found |  -  |
| **400** | Bad request |  -  |
| **500** | Internal exception |  -  |
| **200** | A list of object groups with very basic information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpiggiesac"></a>
# **GetPiggiesAC**
> List&lt;AutocompletePiggy&gt; GetPiggiesAC (Guid? xTraceId = null, string? query = null, int? limit = null)

Returns all piggy banks of the user returned in a basic auto-complete array.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIIINet.Api;
using FireflyIIINet.Client;
using FireflyIIINet.Model;

namespace Example
{
    public class GetPiggiesACExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo.firefly-iii.org/api";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutocompleteApi(config);
            var xTraceId = "xTraceId_example";  // Guid? | Unique identifier associated with this request. (optional) 
            var query = string;  // string? | The autocomplete search query. (optional) 
            var limit = 10;  // int? | The number of items returned. (optional) 

            try
            {
                // Returns all piggy banks of the user returned in a basic auto-complete array.
                List<AutocompletePiggy> result = apiInstance.GetPiggiesAC(xTraceId, query, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutocompleteApi.GetPiggiesAC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPiggiesACWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all piggy banks of the user returned in a basic auto-complete array.
    ApiResponse<List<AutocompletePiggy>> response = apiInstance.GetPiggiesACWithHttpInfo(xTraceId, query, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutocompleteApi.GetPiggiesACWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xTraceId** | **Guid?** | Unique identifier associated with this request. | [optional]  |
| **query** | **string?** | The autocomplete search query. | [optional]  |
| **limit** | **int?** | The number of items returned. | [optional]  |

### Return type

[**List&lt;AutocompletePiggy&gt;**](AutocompletePiggy.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthenticated |  -  |
| **404** | Page not found |  -  |
| **400** | Bad request |  -  |
| **500** | Internal exception |  -  |
| **200** | A list of piggy banks with very basic information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpiggiesbalanceac"></a>
# **GetPiggiesBalanceAC**
> List&lt;AutocompletePiggyBalance&gt; GetPiggiesBalanceAC (Guid? xTraceId = null, string? query = null, int? limit = null)

Returns all piggy banks of the user returned in a basic auto-complete array complemented with balance information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIIINet.Api;
using FireflyIIINet.Client;
using FireflyIIINet.Model;

namespace Example
{
    public class GetPiggiesBalanceACExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo.firefly-iii.org/api";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutocompleteApi(config);
            var xTraceId = "xTraceId_example";  // Guid? | Unique identifier associated with this request. (optional) 
            var query = string;  // string? | The autocomplete search query. (optional) 
            var limit = 10;  // int? | The number of items returned. (optional) 

            try
            {
                // Returns all piggy banks of the user returned in a basic auto-complete array complemented with balance information.
                List<AutocompletePiggyBalance> result = apiInstance.GetPiggiesBalanceAC(xTraceId, query, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutocompleteApi.GetPiggiesBalanceAC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPiggiesBalanceACWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all piggy banks of the user returned in a basic auto-complete array complemented with balance information.
    ApiResponse<List<AutocompletePiggyBalance>> response = apiInstance.GetPiggiesBalanceACWithHttpInfo(xTraceId, query, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutocompleteApi.GetPiggiesBalanceACWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xTraceId** | **Guid?** | Unique identifier associated with this request. | [optional]  |
| **query** | **string?** | The autocomplete search query. | [optional]  |
| **limit** | **int?** | The number of items returned. | [optional]  |

### Return type

[**List&lt;AutocompletePiggyBalance&gt;**](AutocompletePiggyBalance.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthenticated |  -  |
| **404** | Page not found |  -  |
| **400** | Bad request |  -  |
| **500** | Internal exception |  -  |
| **200** | A list of piggy banks with very basic balance information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrecurringac"></a>
# **GetRecurringAC**
> List&lt;AutocompleteRecurrence&gt; GetRecurringAC (Guid? xTraceId = null, string? query = null, int? limit = null)

Returns all recurring transactions of the user returned in a basic auto-complete array.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIIINet.Api;
using FireflyIIINet.Client;
using FireflyIIINet.Model;

namespace Example
{
    public class GetRecurringACExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo.firefly-iii.org/api";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutocompleteApi(config);
            var xTraceId = "xTraceId_example";  // Guid? | Unique identifier associated with this request. (optional) 
            var query = string;  // string? | The autocomplete search query. (optional) 
            var limit = 10;  // int? | The number of items returned. (optional) 

            try
            {
                // Returns all recurring transactions of the user returned in a basic auto-complete array.
                List<AutocompleteRecurrence> result = apiInstance.GetRecurringAC(xTraceId, query, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutocompleteApi.GetRecurringAC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecurringACWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all recurring transactions of the user returned in a basic auto-complete array.
    ApiResponse<List<AutocompleteRecurrence>> response = apiInstance.GetRecurringACWithHttpInfo(xTraceId, query, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutocompleteApi.GetRecurringACWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xTraceId** | **Guid?** | Unique identifier associated with this request. | [optional]  |
| **query** | **string?** | The autocomplete search query. | [optional]  |
| **limit** | **int?** | The number of items returned. | [optional]  |

### Return type

[**List&lt;AutocompleteRecurrence&gt;**](AutocompleteRecurrence.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthenticated |  -  |
| **404** | Page not found |  -  |
| **400** | Bad request |  -  |
| **500** | Internal exception |  -  |
| **200** | A list of recurring transactions with very basic information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrulegroupsac"></a>
# **GetRuleGroupsAC**
> List&lt;AutocompleteRuleGroup&gt; GetRuleGroupsAC (Guid? xTraceId = null, string? query = null, int? limit = null)

Returns all rule groups of the user returned in a basic auto-complete array.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIIINet.Api;
using FireflyIIINet.Client;
using FireflyIIINet.Model;

namespace Example
{
    public class GetRuleGroupsACExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo.firefly-iii.org/api";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutocompleteApi(config);
            var xTraceId = "xTraceId_example";  // Guid? | Unique identifier associated with this request. (optional) 
            var query = string;  // string? | The autocomplete search query. (optional) 
            var limit = 10;  // int? | The number of items returned. (optional) 

            try
            {
                // Returns all rule groups of the user returned in a basic auto-complete array.
                List<AutocompleteRuleGroup> result = apiInstance.GetRuleGroupsAC(xTraceId, query, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutocompleteApi.GetRuleGroupsAC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRuleGroupsACWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all rule groups of the user returned in a basic auto-complete array.
    ApiResponse<List<AutocompleteRuleGroup>> response = apiInstance.GetRuleGroupsACWithHttpInfo(xTraceId, query, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutocompleteApi.GetRuleGroupsACWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xTraceId** | **Guid?** | Unique identifier associated with this request. | [optional]  |
| **query** | **string?** | The autocomplete search query. | [optional]  |
| **limit** | **int?** | The number of items returned. | [optional]  |

### Return type

[**List&lt;AutocompleteRuleGroup&gt;**](AutocompleteRuleGroup.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthenticated |  -  |
| **404** | Page not found |  -  |
| **400** | Bad request |  -  |
| **500** | Internal exception |  -  |
| **200** | A list of rule groups with very basic information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrulesac"></a>
# **GetRulesAC**
> List&lt;AutocompleteRule&gt; GetRulesAC (Guid? xTraceId = null, string? query = null, int? limit = null)

Returns all rules of the user returned in a basic auto-complete array.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIIINet.Api;
using FireflyIIINet.Client;
using FireflyIIINet.Model;

namespace Example
{
    public class GetRulesACExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo.firefly-iii.org/api";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutocompleteApi(config);
            var xTraceId = "xTraceId_example";  // Guid? | Unique identifier associated with this request. (optional) 
            var query = string;  // string? | The autocomplete search query. (optional) 
            var limit = 10;  // int? | The number of items returned. (optional) 

            try
            {
                // Returns all rules of the user returned in a basic auto-complete array.
                List<AutocompleteRule> result = apiInstance.GetRulesAC(xTraceId, query, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutocompleteApi.GetRulesAC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRulesACWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all rules of the user returned in a basic auto-complete array.
    ApiResponse<List<AutocompleteRule>> response = apiInstance.GetRulesACWithHttpInfo(xTraceId, query, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutocompleteApi.GetRulesACWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xTraceId** | **Guid?** | Unique identifier associated with this request. | [optional]  |
| **query** | **string?** | The autocomplete search query. | [optional]  |
| **limit** | **int?** | The number of items returned. | [optional]  |

### Return type

[**List&lt;AutocompleteRule&gt;**](AutocompleteRule.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthenticated |  -  |
| **404** | Page not found |  -  |
| **400** | Bad request |  -  |
| **500** | Internal exception |  -  |
| **200** | A list of rules with very basic information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettagac"></a>
# **GetTagAC**
> List&lt;AutocompleteTag&gt; GetTagAC (Guid? xTraceId = null, string? query = null, int? limit = null)

Returns all tags of the user returned in a basic auto-complete array.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIIINet.Api;
using FireflyIIINet.Client;
using FireflyIIINet.Model;

namespace Example
{
    public class GetTagACExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo.firefly-iii.org/api";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutocompleteApi(config);
            var xTraceId = "xTraceId_example";  // Guid? | Unique identifier associated with this request. (optional) 
            var query = string;  // string? | The autocomplete search query. (optional) 
            var limit = 10;  // int? | The number of items returned. (optional) 

            try
            {
                // Returns all tags of the user returned in a basic auto-complete array.
                List<AutocompleteTag> result = apiInstance.GetTagAC(xTraceId, query, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutocompleteApi.GetTagAC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTagACWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all tags of the user returned in a basic auto-complete array.
    ApiResponse<List<AutocompleteTag>> response = apiInstance.GetTagACWithHttpInfo(xTraceId, query, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutocompleteApi.GetTagACWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xTraceId** | **Guid?** | Unique identifier associated with this request. | [optional]  |
| **query** | **string?** | The autocomplete search query. | [optional]  |
| **limit** | **int?** | The number of items returned. | [optional]  |

### Return type

[**List&lt;AutocompleteTag&gt;**](AutocompleteTag.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthenticated |  -  |
| **404** | Page not found |  -  |
| **400** | Bad request |  -  |
| **500** | Internal exception |  -  |
| **200** | A list of tags with very basic information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettransactiontypesac"></a>
# **GetTransactionTypesAC**
> List&lt;AutocompleteTransactionType&gt; GetTransactionTypesAC (Guid? xTraceId = null, string? query = null, int? limit = null)

Returns all transaction types returned in a basic auto-complete array. English only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIIINet.Api;
using FireflyIIINet.Client;
using FireflyIIINet.Model;

namespace Example
{
    public class GetTransactionTypesACExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo.firefly-iii.org/api";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutocompleteApi(config);
            var xTraceId = "xTraceId_example";  // Guid? | Unique identifier associated with this request. (optional) 
            var query = string;  // string? | The autocomplete search query. (optional) 
            var limit = 10;  // int? | The number of items returned. (optional) 

            try
            {
                // Returns all transaction types returned in a basic auto-complete array. English only.
                List<AutocompleteTransactionType> result = apiInstance.GetTransactionTypesAC(xTraceId, query, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutocompleteApi.GetTransactionTypesAC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionTypesACWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all transaction types returned in a basic auto-complete array. English only.
    ApiResponse<List<AutocompleteTransactionType>> response = apiInstance.GetTransactionTypesACWithHttpInfo(xTraceId, query, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutocompleteApi.GetTransactionTypesACWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xTraceId** | **Guid?** | Unique identifier associated with this request. | [optional]  |
| **query** | **string?** | The autocomplete search query. | [optional]  |
| **limit** | **int?** | The number of items returned. | [optional]  |

### Return type

[**List&lt;AutocompleteTransactionType&gt;**](AutocompleteTransactionType.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthenticated |  -  |
| **404** | Page not found |  -  |
| **400** | Bad request |  -  |
| **500** | Internal exception |  -  |
| **200** | A list of transaction types with very basic information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettransactionsac"></a>
# **GetTransactionsAC**
> List&lt;AutocompleteTransaction&gt; GetTransactionsAC (Guid? xTraceId = null, string? query = null, int? limit = null)

Returns all transaction descriptions of the user returned in a basic auto-complete array.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIIINet.Api;
using FireflyIIINet.Client;
using FireflyIIINet.Model;

namespace Example
{
    public class GetTransactionsACExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo.firefly-iii.org/api";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutocompleteApi(config);
            var xTraceId = "xTraceId_example";  // Guid? | Unique identifier associated with this request. (optional) 
            var query = string;  // string? | The autocomplete search query. (optional) 
            var limit = 10;  // int? | The number of items returned. (optional) 

            try
            {
                // Returns all transaction descriptions of the user returned in a basic auto-complete array.
                List<AutocompleteTransaction> result = apiInstance.GetTransactionsAC(xTraceId, query, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutocompleteApi.GetTransactionsAC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionsACWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all transaction descriptions of the user returned in a basic auto-complete array.
    ApiResponse<List<AutocompleteTransaction>> response = apiInstance.GetTransactionsACWithHttpInfo(xTraceId, query, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutocompleteApi.GetTransactionsACWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xTraceId** | **Guid?** | Unique identifier associated with this request. | [optional]  |
| **query** | **string?** | The autocomplete search query. | [optional]  |
| **limit** | **int?** | The number of items returned. | [optional]  |

### Return type

[**List&lt;AutocompleteTransaction&gt;**](AutocompleteTransaction.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthenticated |  -  |
| **404** | Page not found |  -  |
| **400** | Bad request |  -  |
| **500** | Internal exception |  -  |
| **200** | A list of transaction descriptions with very basic information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettransactionsidac"></a>
# **GetTransactionsIDAC**
> List&lt;AutocompleteTransactionID&gt; GetTransactionsIDAC (Guid? xTraceId = null, string? query = null, int? limit = null)

Returns all transactions, complemented with their ID, of the user returned in a basic auto-complete array. This endpoint is DEPRECATED and I suggest you DO NOT use it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIIINet.Api;
using FireflyIIINet.Client;
using FireflyIIINet.Model;

namespace Example
{
    public class GetTransactionsIDACExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo.firefly-iii.org/api";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutocompleteApi(config);
            var xTraceId = "xTraceId_example";  // Guid? | Unique identifier associated with this request. (optional) 
            var query = string;  // string? | The autocomplete search query. (optional) 
            var limit = 10;  // int? | The number of items returned. (optional) 

            try
            {
                // Returns all transactions, complemented with their ID, of the user returned in a basic auto-complete array. This endpoint is DEPRECATED and I suggest you DO NOT use it.
                List<AutocompleteTransactionID> result = apiInstance.GetTransactionsIDAC(xTraceId, query, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutocompleteApi.GetTransactionsIDAC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionsIDACWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all transactions, complemented with their ID, of the user returned in a basic auto-complete array. This endpoint is DEPRECATED and I suggest you DO NOT use it.
    ApiResponse<List<AutocompleteTransactionID>> response = apiInstance.GetTransactionsIDACWithHttpInfo(xTraceId, query, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutocompleteApi.GetTransactionsIDACWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xTraceId** | **Guid?** | Unique identifier associated with this request. | [optional]  |
| **query** | **string?** | The autocomplete search query. | [optional]  |
| **limit** | **int?** | The number of items returned. | [optional]  |

### Return type

[**List&lt;AutocompleteTransactionID&gt;**](AutocompleteTransactionID.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthenticated |  -  |
| **404** | Page not found |  -  |
| **400** | Bad request |  -  |
| **500** | Internal exception |  -  |
| **200** | A list of transactions with very basic information. This endpoint is DEPRECATED and I suggest you DO NOT use it. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

