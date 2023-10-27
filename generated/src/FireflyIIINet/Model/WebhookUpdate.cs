/*
 * Firefly III API v1.5.4
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2021-09-25T14:21:28+00:00 
 *
 * The version of the OpenAPI document: 1.5.4
 * Contact: james@firefly-iii.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = FireflyIIINet.Client.OpenAPIDateConverter;

namespace FireflyIIINet.Model
{
    /// <summary>
    /// WebhookUpdate
    /// </summary>
    [DataContract(Name = "WebhookUpdate")]
    public partial class WebhookUpdate : IEquatable<WebhookUpdate>, IValidatableObject
    {
        /// <summary>
        /// The trigger for the webhook.
        /// </summary>
        /// <value>The trigger for the webhook.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TriggerEnum
        {
            /// <summary>
            /// Enum STORETRANSACTION for value: TRIGGER_STORE_TRANSACTION
            /// </summary>
            [EnumMember(Value = "TRIGGER_STORE_TRANSACTION")]
            STORETRANSACTION = 1,

            /// <summary>
            /// Enum UPDATETRANSACTION for value: TRIGGER_UPDATE_TRANSACTION
            /// </summary>
            [EnumMember(Value = "TRIGGER_UPDATE_TRANSACTION")]
            UPDATETRANSACTION = 2,

            /// <summary>
            /// Enum DESTROYTRANSACTION for value: TRIGGER_DESTROY_TRANSACTION
            /// </summary>
            [EnumMember(Value = "TRIGGER_DESTROY_TRANSACTION")]
            DESTROYTRANSACTION = 3
        }


        /// <summary>
        /// The trigger for the webhook.
        /// </summary>
        /// <value>The trigger for the webhook.</value>
        /// <example>TRIGGER_DESTROY_TRANSACTION</example>
        [DataMember(Name = "trigger", EmitDefaultValue = false)]
        public TriggerEnum? Trigger { get; set; }
        /// <summary>
        /// Indicator for what Firefly III will deliver to the webhook URL.
        /// </summary>
        /// <value>Indicator for what Firefly III will deliver to the webhook URL.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResponseEnum
        {
            /// <summary>
            /// Enum TRANSACTIONS for value: RESPONSE_TRANSACTIONS
            /// </summary>
            [EnumMember(Value = "RESPONSE_TRANSACTIONS")]
            TRANSACTIONS = 1,

            /// <summary>
            /// Enum ACCOUNTS for value: RESPONSE_ACCOUNTS
            /// </summary>
            [EnumMember(Value = "RESPONSE_ACCOUNTS")]
            ACCOUNTS = 2,

            /// <summary>
            /// Enum NONE for value: RESPONSE_NONE
            /// </summary>
            [EnumMember(Value = "RESPONSE_NONE")]
            NONE = 3
        }


        /// <summary>
        /// Indicator for what Firefly III will deliver to the webhook URL.
        /// </summary>
        /// <value>Indicator for what Firefly III will deliver to the webhook URL.</value>
        /// <example>RESPONSE_TRANSACTIONS</example>
        [DataMember(Name = "response", EmitDefaultValue = false)]
        public ResponseEnum? Response { get; set; }
        /// <summary>
        /// Format of the delivered response.
        /// </summary>
        /// <value>Format of the delivered response.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliveryEnum
        {
            /// <summary>
            /// Enum DELIVERYJSON for value: DELIVERY_JSON
            /// </summary>
            [EnumMember(Value = "DELIVERY_JSON")]
            DELIVERYJSON = 1
        }


        /// <summary>
        /// Format of the delivered response.
        /// </summary>
        /// <value>Format of the delivered response.</value>
        /// <example>DELIVERY_JSON</example>
        [DataMember(Name = "delivery", EmitDefaultValue = false)]
        public DeliveryEnum? Delivery { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUpdate" /> class.
        /// </summary>
        /// <param name="active">Boolean to indicate if the webhook is active.</param>
        /// <param name="title">A title for the webhook for easy recognition..</param>
        /// <param name="secret">A 24-character secret for the webhook. It&#39;s generated by Firefly III when saving a new webhook. If you submit a new secret through the PUT endpoint it will generate a new secret for the selected webhook, a new secret bearing no relation to whatever you just submitted..</param>
        /// <param name="trigger">The trigger for the webhook..</param>
        /// <param name="response">Indicator for what Firefly III will deliver to the webhook URL..</param>
        /// <param name="delivery">Format of the delivered response..</param>
        /// <param name="url">The URL of the webhook. Has to start with &#x60;https&#x60;..</param>
        public WebhookUpdate(bool active = default(bool), string title = default(string), string secret = default(string), TriggerEnum? trigger = default(TriggerEnum?), ResponseEnum? response = default(ResponseEnum?), DeliveryEnum? delivery = default(DeliveryEnum?), string url = default(string))
        {
            this.Active = active;
            this.Title = title;
            this.Secret = secret;
            this.Trigger = trigger;
            this.Response = response;
            this.Delivery = delivery;
            this.Url = url;
        }

        /// <summary>
        /// Boolean to indicate if the webhook is active
        /// </summary>
        /// <value>Boolean to indicate if the webhook is active</value>
        /// <example>false</example>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// A title for the webhook for easy recognition.
        /// </summary>
        /// <value>A title for the webhook for easy recognition.</value>
        /// <example>Update magic mirror on new transaction</example>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// A 24-character secret for the webhook. It&#39;s generated by Firefly III when saving a new webhook. If you submit a new secret through the PUT endpoint it will generate a new secret for the selected webhook, a new secret bearing no relation to whatever you just submitted.
        /// </summary>
        /// <value>A 24-character secret for the webhook. It&#39;s generated by Firefly III when saving a new webhook. If you submit a new secret through the PUT endpoint it will generate a new secret for the selected webhook, a new secret bearing no relation to whatever you just submitted.</value>
        /// <example>iMLZLtLx2JHWhK9Dtyuoqyir</example>
        [DataMember(Name = "secret", EmitDefaultValue = false)]
        public string Secret { get; set; }

        /// <summary>
        /// The URL of the webhook. Has to start with &#x60;https&#x60;.
        /// </summary>
        /// <value>The URL of the webhook. Has to start with &#x60;https&#x60;.</value>
        /// <example>https://example.com</example>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookUpdate {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  Trigger: ").Append(Trigger).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  Delivery: ").Append(Delivery).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebhookUpdate);
        }

        /// <summary>
        /// Returns true if WebhookUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookUpdate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.Trigger == input.Trigger ||
                    this.Trigger.Equals(input.Trigger)
                ) && 
                (
                    this.Response == input.Response ||
                    this.Response.Equals(input.Response)
                ) && 
                (
                    this.Delivery == input.Delivery ||
                    this.Delivery.Equals(input.Delivery)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Secret != null)
                {
                    hashCode = (hashCode * 59) + this.Secret.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Trigger.GetHashCode();
                hashCode = (hashCode * 59) + this.Response.GetHashCode();
                hashCode = (hashCode * 59) + this.Delivery.GetHashCode();
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
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
