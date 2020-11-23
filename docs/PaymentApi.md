# payrobot.Api.PaymentApi

All URIs are relative to *https://api.payrobot.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePayment**](PaymentApi.md#createpayment) | **POST** /{currency}/payments | Generate a new one-use address to receive a payment
[**GetPayment**](PaymentApi.md#getpayment) | **GET** /{currency}/payments/{paymentId} | Get detailed information about a payment



## CreatePayment

> PaymentRequest CreatePayment (string currency, int type, string destination, decimal amount, string callback, string reference = null)

Generates a new one-use address to receive a payment. It callbacks your web/app server as soon as it's paid and confirmed.


**Payment can be `forwarded` to another address or it can be `stored` in
a payrobot.io wallet**


---

## Important

  * Unpaid requests are deleted after **3 hours** of theirs creation
  * Confirmed payments information is deleted after **3 days** of being confirmed

---

## Minimum Amounts


  * `Bitcoin`: 0.0001 BTC
  * `Litecoin`: 0.001 LTC
  * `Bitcoin Cash`: 0.001 BCH

---

## Callbacks

A **payment notificacion** will be sent to your callback url in the
following scenarios:

  1. *Payment is received partially*
  2. *Payment is being confirmed by network*
  3. *Payment is confirmed at least with 1 confirmation*


The callback sent to your callback url is a **POST** request with the
following parameters:


*Example:*

    currency:         "BTC"
    paymentId:        "698fd3f6-5482-4798-8a46-6732af440616"
    address:          "3KoUDMfrov91G4SXaCKGvTWDjGia9Jod5b"
    type:             0
    partialAmount:    "0.00"
                      //Partial amount received when payment is incomplete
    remainingAmount:  "0.00"
                      //Remaining amount to pay when payment is incomplete
    amount:           "0.1"
    feePct:           0.90
    feeAmount:        "0.0009"
    finalAmount:      "0.0991"
    destination:      "698fd3f6-5482-4798-8a46-6732af440616"
    reference:        "12345"
    status:           2

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using payrobot.Api;
using payrobot.Client;
using payrobot.Model;

namespace Example
{
    public class CreatePaymentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.payrobot.io";
            var apiInstance = new PaymentApi(Configuration.Default);
            var currency = "btc";  // string | Object Currency:   * `btc`: Bitcoin   * `ltc`: Litecoin   * `bch`: Bitcoin Cash 
            var type = 0;  // int | * `0: Receive and forward` payment is forwarded to a desired coin address once it's confirmed  * `1: Receive and store` payment is stored in a payrobot.io wallet 
            var destination = "bc1qzlza4ke65fa2sqacjfu5vtwy8ar6x8xttgk999";  // string | * For `Receive and forward` payment is the `ADDRESS` where the payment is going to be forwarded as soon as it's confirmed. **ADDRESS HAS TO BE OF THE SAME TYPE OF CURRENCY**  * For `Receive and store` payment is the payrobot.io `WALLET ID` where the payment is going to be stored as soon as it's confirmed. **WALLET HAS TO BE OF THE SAME TYPE OF CURRENCY** 
            var amount = 0.0129;  // decimal | Amount of the payment
            var callback = "https://your-callback-url.com";  // string | Your URL where payrobot.io will send the status of the payment (Webhook)
            var reference = "Bill123";  // string | Optional custom reference to identify the payment (optional) 

            try
            {
                // Generate a new one-use address to receive a payment
                PaymentRequest result = apiInstance.CreatePayment(currency, type, destination, amount, callback, reference);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentApi.CreatePayment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Object Currency:   * &#x60;btc&#x60;: Bitcoin   * &#x60;ltc&#x60;: Litecoin   * &#x60;bch&#x60;: Bitcoin Cash  | 
 **type** | **int**| * &#x60;0: Receive and forward&#x60; payment is forwarded to a desired coin address once it&#39;s confirmed  * &#x60;1: Receive and store&#x60; payment is stored in a payrobot.io wallet  | 
 **destination** | **string**| * For &#x60;Receive and forward&#x60; payment is the &#x60;ADDRESS&#x60; where the payment is going to be forwarded as soon as it&#39;s confirmed. **ADDRESS HAS TO BE OF THE SAME TYPE OF CURRENCY**  * For &#x60;Receive and store&#x60; payment is the payrobot.io &#x60;WALLET ID&#x60; where the payment is going to be stored as soon as it&#39;s confirmed. **WALLET HAS TO BE OF THE SAME TYPE OF CURRENCY**  | 
 **amount** | **decimal**| Amount of the payment | 
 **callback** | **string**| Your URL where payrobot.io will send the status of the payment (Webhook) | 
 **reference** | **string**| Optional custom reference to identify the payment | [optional] 

### Return type

[**PaymentRequest**](PaymentRequest.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **500** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPayment

> PaymentRequest GetPayment (string currency, string paymentId)

Get detailed information about a payment

Gets detailed information about a payment

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using payrobot.Api;
using payrobot.Client;
using payrobot.Model;

namespace Example
{
    public class GetPaymentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.payrobot.io";
            var apiInstance = new PaymentApi(Configuration.Default);
            var currency = "btc";  // string | Object Currency:   * `btc`: Bitcoin   * `ltc`: Litecoin   * `bch`: Bitcoin Cash 
            var paymentId = "698fd3f6-5482-4798-8a46-6732af440616";  // string | Payment ID to query

            try
            {
                // Get detailed information about a payment
                PaymentRequest result = apiInstance.GetPayment(currency, paymentId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentApi.GetPayment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Object Currency:   * &#x60;btc&#x60;: Bitcoin   * &#x60;ltc&#x60;: Litecoin   * &#x60;bch&#x60;: Bitcoin Cash  | 
 **paymentId** | **string**| Payment ID to query | 

### Return type

[**PaymentRequest**](PaymentRequest.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Succesful operation |  -  |
| **500** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

