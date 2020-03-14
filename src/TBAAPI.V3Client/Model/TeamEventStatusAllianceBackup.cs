/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.8.0
 * 
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
using OpenAPIDateConverter = TBAAPI.V3Client.Client.OpenAPIDateConverter;

namespace TBAAPI.V3Client.Model
{
    /// <summary>
    /// Backup status, may be null.
    /// </summary>
    [DataContract]
    public partial class TeamEventStatusAllianceBackup :  IEquatable<TeamEventStatusAllianceBackup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamEventStatusAllianceBackup" /> class.
        /// </summary>
        /// <param name="_out">TBA key for the team replaced by the backup..</param>
        /// <param name="_in">TBA key for the backup team called in..</param>
        public TeamEventStatusAllianceBackup(string _out = default(string), string _in = default(string))
        {
            this.Out = _out;
            this.In = _in;
        }
        
        /// <summary>
        /// TBA key for the team replaced by the backup.
        /// </summary>
        /// <value>TBA key for the team replaced by the backup.</value>
        [DataMember(Name="out", EmitDefaultValue=false)]
        public string Out { get; set; }

        /// <summary>
        /// TBA key for the backup team called in.
        /// </summary>
        /// <value>TBA key for the backup team called in.</value>
        [DataMember(Name="in", EmitDefaultValue=false)]
        public string In { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamEventStatusAllianceBackup {\n");
            sb.Append("  Out: ").Append(Out).Append("\n");
            sb.Append("  In: ").Append(In).Append("\n");
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
            return this.Equals(input as TeamEventStatusAllianceBackup);
        }

        /// <summary>
        /// Returns true if TeamEventStatusAllianceBackup instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamEventStatusAllianceBackup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamEventStatusAllianceBackup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Out == input.Out ||
                    (this.Out != null &&
                    this.Out.Equals(input.Out))
                ) && 
                (
                    this.In == input.In ||
                    (this.In != null &&
                    this.In.Equals(input.In))
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
                if (this.Out != null)
                    hashCode = hashCode * 59 + this.Out.GetHashCode();
                if (this.In != null)
                    hashCode = hashCode * 59 + this.In.GetHashCode();
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
