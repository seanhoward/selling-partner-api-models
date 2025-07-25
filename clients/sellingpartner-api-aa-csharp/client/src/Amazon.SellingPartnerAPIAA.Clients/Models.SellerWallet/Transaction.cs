/* 
 * The Selling Partner API for Amazon Seller Wallet Open Banking API
 *
 * The Selling Partner API for Seller Wallet (Seller Wallet API) provides financial information that is relevant to a seller's Seller Wallet account. You can obtain financial events, balances, and transfer schedules for Seller Wallet accounts. You can also schedule and initiate transactions.
 *
 * OpenAPI spec version: 2024-03-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.SellerWallet
{
    /// <summary>
    /// The current transaction status and historical details related to it.
    /// </summary>
    [DataContract]
    public partial class Transaction : IEquatable<Transaction>, IValidatableObject
    {
        /// <summary>
        /// The type of the transaction.
        /// </summary>
        /// <value>The type of the transaction.</value>
        [DataMember(Name = "transactionType", EmitDefaultValue = false)]
        public TransactionType TransactionType { get; set; }
        /// <summary>
        /// The status of the transaction.
        /// </summary>
        /// <value>The status of the transaction.</value>
        [DataMember(Name = "transactionStatus", EmitDefaultValue = false)]
        public TransactionStatus TransactionStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction" /> class.
        /// </summary>
        [JsonConstructor]
        protected Transaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction" /> class.
        /// </summary>
        /// <param name="transactionId">The unique identifier provided by Amazon to the transaction. (required).</param>
        /// <param name="transactionType">The type of the transaction. (required).</param>
        /// <param name="transactionStatus">The status of the transaction. (required).</param>
        /// <param name="transactionRequestDate">The date on which the transaction was initiated. (required).</param>
        /// <param name="expectedCompletionDate">The expected completion date of the transaction..</param>
        /// <param name="transactionActualCompletionDate">The transaction&#39;s completion date..</param>
        /// <param name="lastUpdateDate">The date of the most recent account balance update. (required).</param>
        /// <param name="requesterName">The Amazon Seller Wallet customer who requested the transaction..</param>
        /// <param name="transactionRequesterSource">The transaction initiation source. This value could be the Amazon portal or PISP name that the customer used to start the transaction. (required).</param>
        /// <param name="transactionDescription">The description provided by the requester in the transaction request at time of transaction initiation. (required).</param>
        /// <param name="transactionSourceAccount">The source bank account details in the transaction. (required).</param>
        /// <param name="transactionDestinationAccount">The destination bank account details in the transaction. (required).</param>
        /// <param name="transactionRequestAmount">The amount for which the transfer was initiated. (required).</param>
        /// <param name="transferRateDetails">The fees and rates applied on the transaction, as applicable. (required).</param>
        /// <param name="transactionFinalAmount">The amount of completed transaction in the destination account currency. This value is only populated for international transactions.</param>
        /// <param name="transactionFailureReason">The reason the transaction failed, if applicable..</param>
        public Transaction(string transactionId = default, TransactionType transactionType = default, TransactionStatus transactionStatus = default, DateTime? transactionRequestDate = default, DateTime? expectedCompletionDate = default, DateTime? transactionActualCompletionDate = default, DateTime? lastUpdateDate = default, string requesterName = default, string transactionRequesterSource = default, string transactionDescription = default, TransactionAccount transactionSourceAccount = default, TransactionAccount transactionDestinationAccount = default, Currency transactionRequestAmount = default, TransferRatePreview transferRateDetails = default, Currency transactionFinalAmount = default, string transactionFailureReason = default)
        {
            // to ensure "transactionId" is required (not null)
            if (transactionId == null)
            {
                throw new InvalidDataException("transactionId is a required property for Transaction and cannot be null");
            }
            else
            {
                this.TransactionId = transactionId;
            }
            // to ensure "transactionType" is required (not null)
            if (transactionType == null)
            {
                throw new InvalidDataException("transactionType is a required property for Transaction and cannot be null");
            }
            else
            {
                this.TransactionType = transactionType;
            }
            // to ensure "transactionStatus" is required (not null)
            if (transactionStatus == null)
            {
                throw new InvalidDataException("transactionStatus is a required property for Transaction and cannot be null");
            }
            else
            {
                this.TransactionStatus = transactionStatus;
            }
            // to ensure "transactionRequestDate" is required (not null)
            if (transactionRequestDate == null)
            {
                throw new InvalidDataException("transactionRequestDate is a required property for Transaction and cannot be null");
            }
            else
            {
                this.TransactionRequestDate = transactionRequestDate;
            }
            // to ensure "lastUpdateDate" is required (not null)
            if (lastUpdateDate == null)
            {
                throw new InvalidDataException("lastUpdateDate is a required property for Transaction and cannot be null");
            }
            else
            {
                this.LastUpdateDate = lastUpdateDate;
            }
            // to ensure "transactionRequesterSource" is required (not null)
            if (transactionRequesterSource == null)
            {
                throw new InvalidDataException("transactionRequesterSource is a required property for Transaction and cannot be null");
            }
            else
            {
                this.TransactionRequesterSource = transactionRequesterSource;
            }
            // to ensure "transactionDescription" is required (not null)
            if (transactionDescription == null)
            {
                throw new InvalidDataException("transactionDescription is a required property for Transaction and cannot be null");
            }
            else
            {
                this.TransactionDescription = transactionDescription;
            }
            // to ensure "transactionSourceAccount" is required (not null)
            if (transactionSourceAccount == null)
            {
                throw new InvalidDataException("transactionSourceAccount is a required property for Transaction and cannot be null");
            }
            else
            {
                this.TransactionSourceAccount = transactionSourceAccount;
            }
            // to ensure "transactionDestinationAccount" is required (not null)
            if (transactionDestinationAccount == null)
            {
                throw new InvalidDataException("transactionDestinationAccount is a required property for Transaction and cannot be null");
            }
            else
            {
                this.TransactionDestinationAccount = transactionDestinationAccount;
            }
            // to ensure "transactionRequestAmount" is required (not null)
            if (transactionRequestAmount == null)
            {
                throw new InvalidDataException("transactionRequestAmount is a required property for Transaction and cannot be null");
            }
            else
            {
                this.TransactionRequestAmount = transactionRequestAmount;
            }
            // to ensure "transferRateDetails" is required (not null)
            if (transferRateDetails == null)
            {
                throw new InvalidDataException("transferRateDetails is a required property for Transaction and cannot be null");
            }
            else
            {
                this.TransferRateDetails = transferRateDetails;
            }
            this.ExpectedCompletionDate = expectedCompletionDate;
            this.TransactionActualCompletionDate = transactionActualCompletionDate;
            this.RequesterName = requesterName;
            this.TransactionFinalAmount = transactionFinalAmount;
            this.TransactionFailureReason = transactionFailureReason;
        }

        /// <summary>
        /// The unique identifier provided by Amazon to the transaction.
        /// </summary>
        /// <value>The unique identifier provided by Amazon to the transaction.</value>
        [DataMember(Name = "transactionId", EmitDefaultValue = false)]
        public string TransactionId { get; set; }



        /// <summary>
        /// The date on which the transaction was initiated.
        /// </summary>
        /// <value>The date on which the transaction was initiated.</value>
        [DataMember(Name = "transactionRequestDate", EmitDefaultValue = false)]
        public DateTime? TransactionRequestDate { get; set; }

        /// <summary>
        /// The expected completion date of the transaction.
        /// </summary>
        /// <value>The expected completion date of the transaction.</value>
        [DataMember(Name = "expectedCompletionDate", EmitDefaultValue = false)]
        public DateTime? ExpectedCompletionDate { get; set; }

        /// <summary>
        /// The transaction&#39;s completion date.
        /// </summary>
        /// <value>The transaction&#39;s completion date.</value>
        [DataMember(Name = "transactionActualCompletionDate", EmitDefaultValue = false)]
        public DateTime? TransactionActualCompletionDate { get; set; }

        /// <summary>
        /// The date of the most recent account balance update.
        /// </summary>
        /// <value>The date of the most recent account balance update.</value>
        [DataMember(Name = "lastUpdateDate", EmitDefaultValue = false)]
        public DateTime? LastUpdateDate { get; set; }

        /// <summary>
        /// The Amazon Seller Wallet customer who requested the transaction.
        /// </summary>
        /// <value>The Amazon Seller Wallet customer who requested the transaction.</value>
        [DataMember(Name = "requesterName", EmitDefaultValue = false)]
        public string RequesterName { get; set; }

        /// <summary>
        /// The transaction initiation source. This value could be the Amazon portal or PISP name that the customer used to start the transaction.
        /// </summary>
        /// <value>The transaction initiation source. This value could be the Amazon portal or PISP name that the customer used to start the transaction.</value>
        [DataMember(Name = "transactionRequesterSource", EmitDefaultValue = false)]
        public string TransactionRequesterSource { get; set; }

        /// <summary>
        /// The description provided by the requester in the transaction request at time of transaction initiation.
        /// </summary>
        /// <value>The description provided by the requester in the transaction request at time of transaction initiation.</value>
        [DataMember(Name = "transactionDescription", EmitDefaultValue = false)]
        public string TransactionDescription { get; set; }

        /// <summary>
        /// The source bank account details in the transaction.
        /// </summary>
        /// <value>The source bank account details in the transaction.</value>
        [DataMember(Name = "transactionSourceAccount", EmitDefaultValue = false)]
        public TransactionAccount TransactionSourceAccount { get; set; }

        /// <summary>
        /// The destination bank account details in the transaction.
        /// </summary>
        /// <value>The destination bank account details in the transaction.</value>
        [DataMember(Name = "transactionDestinationAccount", EmitDefaultValue = false)]
        public TransactionAccount TransactionDestinationAccount { get; set; }

        /// <summary>
        /// The amount for which the transfer was initiated.
        /// </summary>
        /// <value>The amount for which the transfer was initiated.</value>
        [DataMember(Name = "transactionRequestAmount", EmitDefaultValue = false)]
        public Currency TransactionRequestAmount { get; set; }

        /// <summary>
        /// The fees and rates applied on the transaction, as applicable.
        /// </summary>
        /// <value>The fees and rates applied on the transaction, as applicable.</value>
        [DataMember(Name = "transferRateDetails", EmitDefaultValue = false)]
        public TransferRatePreview TransferRateDetails { get; set; }

        /// <summary>
        /// The amount of completed transaction in the destination account currency. This value is only populated for international transactions
        /// </summary>
        /// <value>The amount of completed transaction in the destination account currency. This value is only populated for international transactions</value>
        [DataMember(Name = "transactionFinalAmount", EmitDefaultValue = false)]
        public Currency TransactionFinalAmount { get; set; }

        /// <summary>
        /// The reason the transaction failed, if applicable.
        /// </summary>
        /// <value>The reason the transaction failed, if applicable.</value>
        [DataMember(Name = "transactionFailureReason", EmitDefaultValue = false)]
        public string TransactionFailureReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Transaction {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  TransactionStatus: ").Append(TransactionStatus).Append("\n");
            sb.Append("  TransactionRequestDate: ").Append(TransactionRequestDate).Append("\n");
            sb.Append("  ExpectedCompletionDate: ").Append(ExpectedCompletionDate).Append("\n");
            sb.Append("  TransactionActualCompletionDate: ").Append(TransactionActualCompletionDate).Append("\n");
            sb.Append("  LastUpdateDate: ").Append(LastUpdateDate).Append("\n");
            sb.Append("  RequesterName: ").Append(RequesterName).Append("\n");
            sb.Append("  TransactionRequesterSource: ").Append(TransactionRequesterSource).Append("\n");
            sb.Append("  TransactionDescription: ").Append(TransactionDescription).Append("\n");
            sb.Append("  TransactionSourceAccount: ").Append(TransactionSourceAccount).Append("\n");
            sb.Append("  TransactionDestinationAccount: ").Append(TransactionDestinationAccount).Append("\n");
            sb.Append("  TransactionRequestAmount: ").Append(TransactionRequestAmount).Append("\n");
            sb.Append("  TransferRateDetails: ").Append(TransferRateDetails).Append("\n");
            sb.Append("  TransactionFinalAmount: ").Append(TransactionFinalAmount).Append("\n");
            sb.Append("  TransactionFailureReason: ").Append(TransactionFailureReason).Append("\n");
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
            return this.Equals(input as Transaction);
        }

        /// <summary>
        /// Returns true if Transaction instances are equal
        /// </summary>
        /// <param name="input">Instance of Transaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transaction input)
        {
            if (input == null)
                return false;

            return
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) &&
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
                ) &&
                (
                    this.TransactionStatus == input.TransactionStatus ||
                    (this.TransactionStatus != null &&
                    this.TransactionStatus.Equals(input.TransactionStatus))
                ) &&
                (
                    this.TransactionRequestDate == input.TransactionRequestDate ||
                    (this.TransactionRequestDate != null &&
                    this.TransactionRequestDate.Equals(input.TransactionRequestDate))
                ) &&
                (
                    this.ExpectedCompletionDate == input.ExpectedCompletionDate ||
                    (this.ExpectedCompletionDate != null &&
                    this.ExpectedCompletionDate.Equals(input.ExpectedCompletionDate))
                ) &&
                (
                    this.TransactionActualCompletionDate == input.TransactionActualCompletionDate ||
                    (this.TransactionActualCompletionDate != null &&
                    this.TransactionActualCompletionDate.Equals(input.TransactionActualCompletionDate))
                ) &&
                (
                    this.LastUpdateDate == input.LastUpdateDate ||
                    (this.LastUpdateDate != null &&
                    this.LastUpdateDate.Equals(input.LastUpdateDate))
                ) &&
                (
                    this.RequesterName == input.RequesterName ||
                    (this.RequesterName != null &&
                    this.RequesterName.Equals(input.RequesterName))
                ) &&
                (
                    this.TransactionRequesterSource == input.TransactionRequesterSource ||
                    (this.TransactionRequesterSource != null &&
                    this.TransactionRequesterSource.Equals(input.TransactionRequesterSource))
                ) &&
                (
                    this.TransactionDescription == input.TransactionDescription ||
                    (this.TransactionDescription != null &&
                    this.TransactionDescription.Equals(input.TransactionDescription))
                ) &&
                (
                    this.TransactionSourceAccount == input.TransactionSourceAccount ||
                    (this.TransactionSourceAccount != null &&
                    this.TransactionSourceAccount.Equals(input.TransactionSourceAccount))
                ) &&
                (
                    this.TransactionDestinationAccount == input.TransactionDestinationAccount ||
                    (this.TransactionDestinationAccount != null &&
                    this.TransactionDestinationAccount.Equals(input.TransactionDestinationAccount))
                ) &&
                (
                    this.TransactionRequestAmount == input.TransactionRequestAmount ||
                    (this.TransactionRequestAmount != null &&
                    this.TransactionRequestAmount.Equals(input.TransactionRequestAmount))
                ) &&
                (
                    this.TransferRateDetails == input.TransferRateDetails ||
                    (this.TransferRateDetails != null &&
                    this.TransferRateDetails.Equals(input.TransferRateDetails))
                ) &&
                (
                    this.TransactionFinalAmount == input.TransactionFinalAmount ||
                    (this.TransactionFinalAmount != null &&
                    this.TransactionFinalAmount.Equals(input.TransactionFinalAmount))
                ) &&
                (
                    this.TransactionFailureReason == input.TransactionFailureReason ||
                    (this.TransactionFailureReason != null &&
                    this.TransactionFailureReason.Equals(input.TransactionFailureReason))
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
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.TransactionType != null)
                    hashCode = hashCode * 59 + this.TransactionType.GetHashCode();
                if (this.TransactionStatus != null)
                    hashCode = hashCode * 59 + this.TransactionStatus.GetHashCode();
                if (this.TransactionRequestDate != null)
                    hashCode = hashCode * 59 + this.TransactionRequestDate.GetHashCode();
                if (this.ExpectedCompletionDate != null)
                    hashCode = hashCode * 59 + this.ExpectedCompletionDate.GetHashCode();
                if (this.TransactionActualCompletionDate != null)
                    hashCode = hashCode * 59 + this.TransactionActualCompletionDate.GetHashCode();
                if (this.LastUpdateDate != null)
                    hashCode = hashCode * 59 + this.LastUpdateDate.GetHashCode();
                if (this.RequesterName != null)
                    hashCode = hashCode * 59 + this.RequesterName.GetHashCode();
                if (this.TransactionRequesterSource != null)
                    hashCode = hashCode * 59 + this.TransactionRequesterSource.GetHashCode();
                if (this.TransactionDescription != null)
                    hashCode = hashCode * 59 + this.TransactionDescription.GetHashCode();
                if (this.TransactionSourceAccount != null)
                    hashCode = hashCode * 59 + this.TransactionSourceAccount.GetHashCode();
                if (this.TransactionDestinationAccount != null)
                    hashCode = hashCode * 59 + this.TransactionDestinationAccount.GetHashCode();
                if (this.TransactionRequestAmount != null)
                    hashCode = hashCode * 59 + this.TransactionRequestAmount.GetHashCode();
                if (this.TransferRateDetails != null)
                    hashCode = hashCode * 59 + this.TransferRateDetails.GetHashCode();
                if (this.TransactionFinalAmount != null)
                    hashCode = hashCode * 59 + this.TransactionFinalAmount.GetHashCode();
                if (this.TransactionFailureReason != null)
                    hashCode = hashCode * 59 + this.TransactionFailureReason.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
