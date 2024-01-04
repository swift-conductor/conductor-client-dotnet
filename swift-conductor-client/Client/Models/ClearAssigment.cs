using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace SwiftConductor.Client.Models
{
    /// <summary>
    /// ClearAssigment
    /// </summary>
    [DataContract]
    public partial class ClearAssigment : TimeoutPolicy, IEquatable<ClearAssigment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClearAssigment" /> class.
        /// </summary>
        /// <param name="timeoutSeconds">timeoutSeconds.</param>
        public ClearAssigment(long? timeoutSeconds = default(long?), string type = default(string)) : base(type)
        {
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Gets or Sets TimeoutSeconds
        /// </summary>
        [DataMember(Name = "timeoutSeconds", EmitDefaultValue = false)]
        public long? TimeoutSeconds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClearAssigment {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  TimeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as ClearAssigment);
        }

        /// <summary>
        /// Returns true if ClearAssigment instances are equal
        /// </summary>
        /// <param name="input">Instance of ClearAssigment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClearAssigment input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.TimeoutSeconds == input.TimeoutSeconds ||
                    (this.TimeoutSeconds != null &&
                    this.TimeoutSeconds.Equals(input.TimeoutSeconds))
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
                int hashCode = base.GetHashCode();
                if (this.TimeoutSeconds != null)
                    hashCode = hashCode * 59 + this.TimeoutSeconds.GetHashCode();
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
