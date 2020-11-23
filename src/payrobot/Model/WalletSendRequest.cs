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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = payrobot.Client.OpenAPIDateConverter;

namespace payrobot.Model
{
    /// <summary>
    /// WalletSendRequest
    /// </summary>
    [DataContract]
    public partial class WalletSendRequest :  IEquatable<WalletSendRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public CryptoCurrency? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletSendRequest" /> class.
        /// </summary>
        /// <param name="currency">currency.</param>
        /// <param name="walletId">Unique ID of the new created Wallet.</param>
        /// <param name="requestId">ID of this transaction, it can be used letter in the callback or to query it.</param>
        /// <param name="timestamp">Request creation date expressed in UNIX timestamp.</param>
        /// <param name="lastupdate">Last update expressed in UNIX timestamp.</param>
        /// <param name="amount">Total amount sent from wallet.</param>
        /// <param name="callback">Optional callback to notify your web / app as soon as the send request has been fully broadcasted to the network.</param>
        /// <param name="destination">Array with all the destination coin addres(es) and the amount(s) to send .</param>
        /// <param name="txid">Tx Hash. *Only available in requests with confirmed status* .</param>
        /// <param name="status">Status of this send request:   * &#x60;0: Queued&#x60; Request has been queued for broadcasting. It usually takes few seconds under normal conditions   * &#x60;1: Broadcasted&#x60; Request has been fully broadcasted to Bitcoin Network   (default to 0).</param>
        /// <param name="error">&#x60;true&#x60; is there was a problem. &#x60;false&#x60; if not .</param>
        public WalletSendRequest(CryptoCurrency? currency = default(CryptoCurrency?), string walletId = default(string), string requestId = default(string), int timestamp = default(int), int lastupdate = default(int), string amount = default(string), string callback = default(string), List<AddressDetail> destination = default(List<AddressDetail>), string txid = default(string), int status = 0, bool error = default(bool))
        {
            this.Currency = currency;
            this.WalletId = walletId;
            this.RequestId = requestId;
            this.Timestamp = timestamp;
            this.Lastupdate = lastupdate;
            this.Amount = amount;
            this.Callback = callback;
            this.Destination = destination;
            this.Txid = txid;
            // use default value if no "status" provided
            if (status == null)
            {
                this.Status = 0;
            }
            else
            {
                this.Status = status;
            }
            this.Error = error;
        }
        

        /// <summary>
        /// Unique ID of the new created Wallet
        /// </summary>
        /// <value>Unique ID of the new created Wallet</value>
        [DataMember(Name="walletId", EmitDefaultValue=false)]
        public string WalletId { get; set; }

        /// <summary>
        /// ID of this transaction, it can be used letter in the callback or to query it
        /// </summary>
        /// <value>ID of this transaction, it can be used letter in the callback or to query it</value>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Request creation date expressed in UNIX timestamp
        /// </summary>
        /// <value>Request creation date expressed in UNIX timestamp</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public int Timestamp { get; set; }

        /// <summary>
        /// Last update expressed in UNIX timestamp
        /// </summary>
        /// <value>Last update expressed in UNIX timestamp</value>
        [DataMember(Name="lastupdate", EmitDefaultValue=false)]
        public int Lastupdate { get; set; }

        /// <summary>
        /// Total amount sent from wallet
        /// </summary>
        /// <value>Total amount sent from wallet</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Optional callback to notify your web / app as soon as the send request has been fully broadcasted to the network
        /// </summary>
        /// <value>Optional callback to notify your web / app as soon as the send request has been fully broadcasted to the network</value>
        [DataMember(Name="callback", EmitDefaultValue=false)]
        public string Callback { get; set; }

        /// <summary>
        /// Array with all the destination coin addres(es) and the amount(s) to send 
        /// </summary>
        /// <value>Array with all the destination coin addres(es) and the amount(s) to send </value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public List<AddressDetail> Destination { get; set; }

        /// <summary>
        /// Tx Hash. *Only available in requests with confirmed status* 
        /// </summary>
        /// <value>Tx Hash. *Only available in requests with confirmed status* </value>
        [DataMember(Name="txid", EmitDefaultValue=false)]
        public string Txid { get; set; }

        /// <summary>
        /// Status of this send request:   * &#x60;0: Queued&#x60; Request has been queued for broadcasting. It usually takes few seconds under normal conditions   * &#x60;1: Broadcasted&#x60; Request has been fully broadcasted to Bitcoin Network  
        /// </summary>
        /// <value>Status of this send request:   * &#x60;0: Queued&#x60; Request has been queued for broadcasting. It usually takes few seconds under normal conditions   * &#x60;1: Broadcasted&#x60; Request has been fully broadcasted to Bitcoin Network  </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int Status { get; set; }

        /// <summary>
        /// &#x60;true&#x60; is there was a problem. &#x60;false&#x60; if not 
        /// </summary>
        /// <value>&#x60;true&#x60; is there was a problem. &#x60;false&#x60; if not </value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public bool Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WalletSendRequest {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  WalletId: ").Append(WalletId).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Lastupdate: ").Append(Lastupdate).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Callback: ").Append(Callback).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Txid: ").Append(Txid).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WalletSendRequest);
        }

        /// <summary>
        /// Returns true if WalletSendRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletSendRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletSendRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.WalletId == input.WalletId ||
                    (this.WalletId != null &&
                    this.WalletId.Equals(input.WalletId))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Lastupdate == input.Lastupdate ||
                    (this.Lastupdate != null &&
                    this.Lastupdate.Equals(input.Lastupdate))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Callback == input.Callback ||
                    (this.Callback != null &&
                    this.Callback.Equals(input.Callback))
                ) && 
                (
                    this.Destination == input.Destination ||
                    this.Destination != null &&
                    input.Destination != null &&
                    this.Destination.SequenceEqual(input.Destination)
                ) && 
                (
                    this.Txid == input.Txid ||
                    (this.Txid != null &&
                    this.Txid.Equals(input.Txid))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.WalletId != null)
                    hashCode = hashCode * 59 + this.WalletId.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Lastupdate != null)
                    hashCode = hashCode * 59 + this.Lastupdate.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Callback != null)
                    hashCode = hashCode * 59 + this.Callback.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Txid != null)
                    hashCode = hashCode * 59 + this.Txid.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}