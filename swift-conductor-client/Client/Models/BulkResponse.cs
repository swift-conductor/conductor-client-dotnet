using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace SwiftConductor.Client.Models
{
    /// <summary>
    /// BulkResponse
    /// </summary>
    [DataContract]
    public partial class BulkResponse : IEquatable<BulkResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkResponse" /> class.
        /// </summary>
        /// <param name="bulkErrorResults">bulkErrorResults.</param>
        /// <param name="bulkSuccessfulResults">bulkSuccessfulResults.</param>
        public BulkResponse(Dictionary<string, string> bulkErrorResults = default(Dictionary<string, string>), List<string> bulkSuccessfulResults = default(List<string>))
        {
            this.BulkErrorResults = bulkErrorResults;
            this.BulkSuccessfulResults = bulkSuccessfulResults;
        }

        /// <summary>
        /// Gets or Sets BulkErrorResults
        /// </summary>
        [DataMember(Name = "bulkErrorResults", EmitDefaultValue = false)]
        public Dictionary<string, string> BulkErrorResults { get; set; }

        /// <summary>
        /// Gets or Sets BulkSuccessfulResults
        /// </summary>
        [DataMember(Name = "bulkSuccessfulResults", EmitDefaultValue = false)]
        public List<string> BulkSuccessfulResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkResponse {\n");
            sb.Append("  BulkErrorResults: ").Append(BulkErrorResults).Append("\n");
            sb.Append("  BulkSuccessfulResults: ").Append(BulkSuccessfulResults).Append("\n");
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
            return this.Equals(input as BulkResponse);
        }

        /// <summary>
        /// Returns true if BulkResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.BulkErrorResults == input.BulkErrorResults ||
                    this.BulkErrorResults != null &&
                    input.BulkErrorResults != null &&
                    this.BulkErrorResults.SequenceEqual(input.BulkErrorResults)
                ) &&
                (
                    this.BulkSuccessfulResults == input.BulkSuccessfulResults ||
                    this.BulkSuccessfulResults != null &&
                    input.BulkSuccessfulResults != null &&
                    this.BulkSuccessfulResults.SequenceEqual(input.BulkSuccessfulResults)
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
                if (this.BulkErrorResults != null)
                    hashCode = hashCode * 59 + this.BulkErrorResults.GetHashCode();
                if (this.BulkSuccessfulResults != null)
                    hashCode = hashCode * 59 + this.BulkSuccessfulResults.GetHashCode();
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
