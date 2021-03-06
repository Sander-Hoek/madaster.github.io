/* 
 * Madaster Private API
 *
 * The Madaster Private API endpoint.
 *
 * OpenAPI spec version: 1.1
 * Contact: service@madaster.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = Madaster.API.Client.SwaggerDateConverter;

namespace Madaster.API.Model
{
    /// <summary>
    /// BuildingFileValidation
    /// </summary>
    [DataContract]
    public partial class BuildingFileValidation :  IEquatable<BuildingFileValidation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingFileValidation" /> class.
        /// </summary>
        /// <param name="percentageClassificationAssignedByNumber">percentageClassificationAssignedByNumber.</param>
        /// <param name="percentageClassificationAssignedByVolume">percentageClassificationAssignedByVolume.</param>
        /// <param name="percentageVolumeBaseQuantityAssignedByNumber">percentageVolumeBaseQuantityAssignedByNumber.</param>
        /// <param name="percentageAreaBaseQuantityAssignedByNumber">percentageAreaBaseQuantityAssignedByNumber.</param>
        /// <param name="percentageLengthBaseQuantityAssignedByNumber">percentageLengthBaseQuantityAssignedByNumber.</param>
        /// <param name="percentageBaseQuantitiesAssignedByNumber">percentageBaseQuantitiesAssignedByNumber.</param>
        /// <param name="percentageMaterialSpecifiedByNumber">percentageMaterialSpecifiedByNumber.</param>
        /// <param name="percentageMaterialSpecifiedByVolume">percentageMaterialSpecifiedByVolume.</param>
        /// <param name="percentageElementsWithKnownMassByNumber">percentageElementsWithKnownMassByNumber.</param>
        /// <param name="percentageElementsMappedByNumber">percentageElementsMappedByNumber.</param>
        /// <param name="percentageElementsMappedByVolume">percentageElementsMappedByVolume.</param>
        public BuildingFileValidation(double? percentageClassificationAssignedByNumber = default(double?), double? percentageClassificationAssignedByVolume = default(double?), double? percentageVolumeBaseQuantityAssignedByNumber = default(double?), double? percentageAreaBaseQuantityAssignedByNumber = default(double?), double? percentageLengthBaseQuantityAssignedByNumber = default(double?), double? percentageBaseQuantitiesAssignedByNumber = default(double?), double? percentageMaterialSpecifiedByNumber = default(double?), double? percentageMaterialSpecifiedByVolume = default(double?), double? percentageElementsWithKnownMassByNumber = default(double?), double? percentageElementsMappedByNumber = default(double?), double? percentageElementsMappedByVolume = default(double?))
        {
            this.PercentageClassificationAssignedByNumber = percentageClassificationAssignedByNumber;
            this.PercentageClassificationAssignedByVolume = percentageClassificationAssignedByVolume;
            this.PercentageVolumeBaseQuantityAssignedByNumber = percentageVolumeBaseQuantityAssignedByNumber;
            this.PercentageAreaBaseQuantityAssignedByNumber = percentageAreaBaseQuantityAssignedByNumber;
            this.PercentageLengthBaseQuantityAssignedByNumber = percentageLengthBaseQuantityAssignedByNumber;
            this.PercentageBaseQuantitiesAssignedByNumber = percentageBaseQuantitiesAssignedByNumber;
            this.PercentageMaterialSpecifiedByNumber = percentageMaterialSpecifiedByNumber;
            this.PercentageMaterialSpecifiedByVolume = percentageMaterialSpecifiedByVolume;
            this.PercentageElementsWithKnownMassByNumber = percentageElementsWithKnownMassByNumber;
            this.PercentageElementsMappedByNumber = percentageElementsMappedByNumber;
            this.PercentageElementsMappedByVolume = percentageElementsMappedByVolume;
        }
        
        /// <summary>
        /// Gets or Sets PercentageClassificationAssignedByNumber
        /// </summary>
        [DataMember(Name="percentageClassificationAssignedByNumber", EmitDefaultValue=false)]
        public double? PercentageClassificationAssignedByNumber { get; set; }

        /// <summary>
        /// Gets or Sets PercentageClassificationAssignedByVolume
        /// </summary>
        [DataMember(Name="percentageClassificationAssignedByVolume", EmitDefaultValue=false)]
        public double? PercentageClassificationAssignedByVolume { get; set; }

        /// <summary>
        /// Gets or Sets PercentageVolumeBaseQuantityAssignedByNumber
        /// </summary>
        [DataMember(Name="percentageVolumeBaseQuantityAssignedByNumber", EmitDefaultValue=false)]
        public double? PercentageVolumeBaseQuantityAssignedByNumber { get; set; }

        /// <summary>
        /// Gets or Sets PercentageAreaBaseQuantityAssignedByNumber
        /// </summary>
        [DataMember(Name="percentageAreaBaseQuantityAssignedByNumber", EmitDefaultValue=false)]
        public double? PercentageAreaBaseQuantityAssignedByNumber { get; set; }

        /// <summary>
        /// Gets or Sets PercentageLengthBaseQuantityAssignedByNumber
        /// </summary>
        [DataMember(Name="percentageLengthBaseQuantityAssignedByNumber", EmitDefaultValue=false)]
        public double? PercentageLengthBaseQuantityAssignedByNumber { get; set; }

        /// <summary>
        /// Gets or Sets PercentageBaseQuantitiesAssignedByNumber
        /// </summary>
        [DataMember(Name="percentageBaseQuantitiesAssignedByNumber", EmitDefaultValue=false)]
        public double? PercentageBaseQuantitiesAssignedByNumber { get; set; }

        /// <summary>
        /// Gets or Sets PercentageMaterialSpecifiedByNumber
        /// </summary>
        [DataMember(Name="percentageMaterialSpecifiedByNumber", EmitDefaultValue=false)]
        public double? PercentageMaterialSpecifiedByNumber { get; set; }

        /// <summary>
        /// Gets or Sets PercentageMaterialSpecifiedByVolume
        /// </summary>
        [DataMember(Name="percentageMaterialSpecifiedByVolume", EmitDefaultValue=false)]
        public double? PercentageMaterialSpecifiedByVolume { get; set; }

        /// <summary>
        /// Gets or Sets PercentageElementsWithKnownMassByNumber
        /// </summary>
        [DataMember(Name="percentageElementsWithKnownMassByNumber", EmitDefaultValue=false)]
        public double? PercentageElementsWithKnownMassByNumber { get; set; }

        /// <summary>
        /// Gets or Sets PercentageElementsMappedByNumber
        /// </summary>
        [DataMember(Name="percentageElementsMappedByNumber", EmitDefaultValue=false)]
        public double? PercentageElementsMappedByNumber { get; set; }

        /// <summary>
        /// Gets or Sets PercentageElementsMappedByVolume
        /// </summary>
        [DataMember(Name="percentageElementsMappedByVolume", EmitDefaultValue=false)]
        public double? PercentageElementsMappedByVolume { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuildingFileValidation {\n");
            sb.Append("  PercentageClassificationAssignedByNumber: ").Append(PercentageClassificationAssignedByNumber).Append("\n");
            sb.Append("  PercentageClassificationAssignedByVolume: ").Append(PercentageClassificationAssignedByVolume).Append("\n");
            sb.Append("  PercentageVolumeBaseQuantityAssignedByNumber: ").Append(PercentageVolumeBaseQuantityAssignedByNumber).Append("\n");
            sb.Append("  PercentageAreaBaseQuantityAssignedByNumber: ").Append(PercentageAreaBaseQuantityAssignedByNumber).Append("\n");
            sb.Append("  PercentageLengthBaseQuantityAssignedByNumber: ").Append(PercentageLengthBaseQuantityAssignedByNumber).Append("\n");
            sb.Append("  PercentageBaseQuantitiesAssignedByNumber: ").Append(PercentageBaseQuantitiesAssignedByNumber).Append("\n");
            sb.Append("  PercentageMaterialSpecifiedByNumber: ").Append(PercentageMaterialSpecifiedByNumber).Append("\n");
            sb.Append("  PercentageMaterialSpecifiedByVolume: ").Append(PercentageMaterialSpecifiedByVolume).Append("\n");
            sb.Append("  PercentageElementsWithKnownMassByNumber: ").Append(PercentageElementsWithKnownMassByNumber).Append("\n");
            sb.Append("  PercentageElementsMappedByNumber: ").Append(PercentageElementsMappedByNumber).Append("\n");
            sb.Append("  PercentageElementsMappedByVolume: ").Append(PercentageElementsMappedByVolume).Append("\n");
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
            return this.Equals(input as BuildingFileValidation);
        }

        /// <summary>
        /// Returns true if BuildingFileValidation instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildingFileValidation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildingFileValidation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PercentageClassificationAssignedByNumber == input.PercentageClassificationAssignedByNumber ||
                    (this.PercentageClassificationAssignedByNumber != null &&
                    this.PercentageClassificationAssignedByNumber.Equals(input.PercentageClassificationAssignedByNumber))
                ) && 
                (
                    this.PercentageClassificationAssignedByVolume == input.PercentageClassificationAssignedByVolume ||
                    (this.PercentageClassificationAssignedByVolume != null &&
                    this.PercentageClassificationAssignedByVolume.Equals(input.PercentageClassificationAssignedByVolume))
                ) && 
                (
                    this.PercentageVolumeBaseQuantityAssignedByNumber == input.PercentageVolumeBaseQuantityAssignedByNumber ||
                    (this.PercentageVolumeBaseQuantityAssignedByNumber != null &&
                    this.PercentageVolumeBaseQuantityAssignedByNumber.Equals(input.PercentageVolumeBaseQuantityAssignedByNumber))
                ) && 
                (
                    this.PercentageAreaBaseQuantityAssignedByNumber == input.PercentageAreaBaseQuantityAssignedByNumber ||
                    (this.PercentageAreaBaseQuantityAssignedByNumber != null &&
                    this.PercentageAreaBaseQuantityAssignedByNumber.Equals(input.PercentageAreaBaseQuantityAssignedByNumber))
                ) && 
                (
                    this.PercentageLengthBaseQuantityAssignedByNumber == input.PercentageLengthBaseQuantityAssignedByNumber ||
                    (this.PercentageLengthBaseQuantityAssignedByNumber != null &&
                    this.PercentageLengthBaseQuantityAssignedByNumber.Equals(input.PercentageLengthBaseQuantityAssignedByNumber))
                ) && 
                (
                    this.PercentageBaseQuantitiesAssignedByNumber == input.PercentageBaseQuantitiesAssignedByNumber ||
                    (this.PercentageBaseQuantitiesAssignedByNumber != null &&
                    this.PercentageBaseQuantitiesAssignedByNumber.Equals(input.PercentageBaseQuantitiesAssignedByNumber))
                ) && 
                (
                    this.PercentageMaterialSpecifiedByNumber == input.PercentageMaterialSpecifiedByNumber ||
                    (this.PercentageMaterialSpecifiedByNumber != null &&
                    this.PercentageMaterialSpecifiedByNumber.Equals(input.PercentageMaterialSpecifiedByNumber))
                ) && 
                (
                    this.PercentageMaterialSpecifiedByVolume == input.PercentageMaterialSpecifiedByVolume ||
                    (this.PercentageMaterialSpecifiedByVolume != null &&
                    this.PercentageMaterialSpecifiedByVolume.Equals(input.PercentageMaterialSpecifiedByVolume))
                ) && 
                (
                    this.PercentageElementsWithKnownMassByNumber == input.PercentageElementsWithKnownMassByNumber ||
                    (this.PercentageElementsWithKnownMassByNumber != null &&
                    this.PercentageElementsWithKnownMassByNumber.Equals(input.PercentageElementsWithKnownMassByNumber))
                ) && 
                (
                    this.PercentageElementsMappedByNumber == input.PercentageElementsMappedByNumber ||
                    (this.PercentageElementsMappedByNumber != null &&
                    this.PercentageElementsMappedByNumber.Equals(input.PercentageElementsMappedByNumber))
                ) && 
                (
                    this.PercentageElementsMappedByVolume == input.PercentageElementsMappedByVolume ||
                    (this.PercentageElementsMappedByVolume != null &&
                    this.PercentageElementsMappedByVolume.Equals(input.PercentageElementsMappedByVolume))
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
                if (this.PercentageClassificationAssignedByNumber != null)
                    hashCode = hashCode * 59 + this.PercentageClassificationAssignedByNumber.GetHashCode();
                if (this.PercentageClassificationAssignedByVolume != null)
                    hashCode = hashCode * 59 + this.PercentageClassificationAssignedByVolume.GetHashCode();
                if (this.PercentageVolumeBaseQuantityAssignedByNumber != null)
                    hashCode = hashCode * 59 + this.PercentageVolumeBaseQuantityAssignedByNumber.GetHashCode();
                if (this.PercentageAreaBaseQuantityAssignedByNumber != null)
                    hashCode = hashCode * 59 + this.PercentageAreaBaseQuantityAssignedByNumber.GetHashCode();
                if (this.PercentageLengthBaseQuantityAssignedByNumber != null)
                    hashCode = hashCode * 59 + this.PercentageLengthBaseQuantityAssignedByNumber.GetHashCode();
                if (this.PercentageBaseQuantitiesAssignedByNumber != null)
                    hashCode = hashCode * 59 + this.PercentageBaseQuantitiesAssignedByNumber.GetHashCode();
                if (this.PercentageMaterialSpecifiedByNumber != null)
                    hashCode = hashCode * 59 + this.PercentageMaterialSpecifiedByNumber.GetHashCode();
                if (this.PercentageMaterialSpecifiedByVolume != null)
                    hashCode = hashCode * 59 + this.PercentageMaterialSpecifiedByVolume.GetHashCode();
                if (this.PercentageElementsWithKnownMassByNumber != null)
                    hashCode = hashCode * 59 + this.PercentageElementsWithKnownMassByNumber.GetHashCode();
                if (this.PercentageElementsMappedByNumber != null)
                    hashCode = hashCode * 59 + this.PercentageElementsMappedByNumber.GetHashCode();
                if (this.PercentageElementsMappedByVolume != null)
                    hashCode = hashCode * 59 + this.PercentageElementsMappedByVolume.GetHashCode();
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
