/* 
 * Payrobot
 *
 * # Introduction Accept, store, send or forward Bitcoin, Litecoin and Bitcoin Cash for your website or app and protect your privacy.  Supported crytocurrencies:   * BTC Bitcoin   * LTC Litecoin   * BCH Bitcoin Cash   ## Benefits    * **Anonymous** No personal details are required and transactions are mixed among all payments. You can forward your payments so as soon payrobot.io receives it forwards it to another address under your control.      * **No Registration** No registration, sign-up, application or form required to use payrobot.io      * **Easy Integration** Integrate your web / app through our simple RESTful API, you can accept payments with just one line of code!      * **Instant Payment Notification** Our servers notify your web / app the status of your payments. No polling, daemons or cronjobs required on your side!      * **Secure** Payrobot.io works with SSL and bank-level security protocols. Your transactions are safe!   ## Features **Payment Forward** Generate one-time addresses to recieve payments. Payrobot will notify your web /app through callbacks (webhooks) the status of the payment. As soon as it's confirmed the payment is forwarded to your desired address.  **Wallet** Receive, send payments and store your coins in a secure, private and anonymous wallet. All events are notified to your web / app through callbacks (webhooks). You can generate wallets with just one line of code without registration or further information  ## Fees **Only 0.90% per inbound transaction** (receive payments), NO HIDDEN FEES. All outbound transactions (send funds) are totally free.  Minimum fees applies, therefore the largest amount is going to be considered as fee either: `(inboundAmount*feePct)` or `the minimum fee`  **Inbound Fees (Receive payments)**    - `Bitcoin` 0.90% *(Minimum fee 0.00005 BTC)*   - `Litecoin` 0.90% *(Minimum fee 0.0005 LTC)*   - `Bitcoin Cash` 0.90% *(Minimum fee 0.0005 BCH)*     **Outbound Fees (Send funds)**    - `Bitcoin` 0.00%   - `Litecoin` 0.00%   - `Bitcoin Cash` 0.00%   ## Rate Limit To guarantee the good performance of the service and its fair use. The API is **limited to receiving 120 requests per minute per IP**, which is sufficient for most use cases.  Payrobot.io is asynchronous in most API methods to communicate with your application through callbacks (webhooks), thus reducing unnecessary calls to the service.  **If the limit is exceeded, the IP will be banned for 1 minute.**  If you require an upper limit for your application, do not hesitate to contact us  ## Considerations    * Amounts in responses are expresed as `strings`      * Wallets are not multi-currency, you have to create a different wallet per cryptocurrency (You can't store Litecoin in a Bitcoin wallet and vice-versa)      * Payment forwarding has to be of the same type of currency (You can't forward a Bitcoin Cash payment to a Bitcoin address and vice-versa)    
 *
 * The version of the OpenAPI document: 1.0
 * Contact: contact@payrobot.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using payrobot.Client;
using payrobot.Api;
using payrobot.Model;

namespace payrobot.Test
{
    /// <summary>
    ///  Class for testing PaymentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PaymentApiTests
    {
        private PaymentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PaymentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PaymentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' PaymentApi
            //Assert.IsInstanceOf(typeof(PaymentApi), instance);
        }

        
        /// <summary>
        /// Test CreatePayment
        /// </summary>
        [Test]
        public void CreatePaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //int type = null;
            //string destination = null;
            //decimal amount = null;
            //string callback = null;
            //string reference = null;
            //var response = instance.CreatePayment(currency, type, destination, amount, callback, reference);
            //Assert.IsInstanceOf(typeof(PaymentRequest), response, "response is PaymentRequest");
        }
        
        /// <summary>
        /// Test GetPayment
        /// </summary>
        [Test]
        public void GetPaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //string paymentId = null;
            //var response = instance.GetPayment(currency, paymentId);
            //Assert.IsInstanceOf(typeof(PaymentRequest), response, "response is PaymentRequest");
        }
        
    }

}