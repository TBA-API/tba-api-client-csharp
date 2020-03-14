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
    /// Rank of a team in a district.
    /// </summary>
    [DataContract]
    public partial class DistrictRanking :  IEquatable<DistrictRanking>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DistrictRanking" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DistrictRanking() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DistrictRanking" /> class.
        /// </summary>
        /// <param name="teamKey">TBA team key for the team. (required).</param>
        /// <param name="rank">Numerical rank of the team, 1 being top rank. (required).</param>
        /// <param name="rookieBonus">Any points added to a team as a result of the rookie bonus..</param>
        /// <param name="pointTotal">Total district points for the team. (required).</param>
        /// <param name="eventPoints">List of events that contributed to the point total for the team..</param>
        public DistrictRanking(string teamKey = default(string), int rank = default(int), int rookieBonus = default(int), int pointTotal = default(int), List<DistrictRankingEventPoints> eventPoints = default(List<DistrictRankingEventPoints>))
        {
            // to ensure "teamKey" is required (not null)
            if (teamKey == null)
            {
                throw new InvalidDataException("teamKey is a required property for DistrictRanking and cannot be null");
            }
            else
            {
                this.TeamKey = teamKey;
            }
            
            // to ensure "rank" is required (not null)
            if (rank == null)
            {
                throw new InvalidDataException("rank is a required property for DistrictRanking and cannot be null");
            }
            else
            {
                this.Rank = rank;
            }
            
            // to ensure "pointTotal" is required (not null)
            if (pointTotal == null)
            {
                throw new InvalidDataException("pointTotal is a required property for DistrictRanking and cannot be null");
            }
            else
            {
                this.PointTotal = pointTotal;
            }
            
            this.RookieBonus = rookieBonus;
            this.EventPoints = eventPoints;
        }
        
        /// <summary>
        /// TBA team key for the team.
        /// </summary>
        /// <value>TBA team key for the team.</value>
        [DataMember(Name="team_key", EmitDefaultValue=false)]
        public string TeamKey { get; set; }

        /// <summary>
        /// Numerical rank of the team, 1 being top rank.
        /// </summary>
        /// <value>Numerical rank of the team, 1 being top rank.</value>
        [DataMember(Name="rank", EmitDefaultValue=false)]
        public int Rank { get; set; }

        /// <summary>
        /// Any points added to a team as a result of the rookie bonus.
        /// </summary>
        /// <value>Any points added to a team as a result of the rookie bonus.</value>
        [DataMember(Name="rookie_bonus", EmitDefaultValue=false)]
        public int RookieBonus { get; set; }

        /// <summary>
        /// Total district points for the team.
        /// </summary>
        /// <value>Total district points for the team.</value>
        [DataMember(Name="point_total", EmitDefaultValue=false)]
        public int PointTotal { get; set; }

        /// <summary>
        /// List of events that contributed to the point total for the team.
        /// </summary>
        /// <value>List of events that contributed to the point total for the team.</value>
        [DataMember(Name="event_points", EmitDefaultValue=false)]
        public List<DistrictRankingEventPoints> EventPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DistrictRanking {\n");
            sb.Append("  TeamKey: ").Append(TeamKey).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  RookieBonus: ").Append(RookieBonus).Append("\n");
            sb.Append("  PointTotal: ").Append(PointTotal).Append("\n");
            sb.Append("  EventPoints: ").Append(EventPoints).Append("\n");
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
            return this.Equals(input as DistrictRanking);
        }

        /// <summary>
        /// Returns true if DistrictRanking instances are equal
        /// </summary>
        /// <param name="input">Instance of DistrictRanking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistrictRanking input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TeamKey == input.TeamKey ||
                    (this.TeamKey != null &&
                    this.TeamKey.Equals(input.TeamKey))
                ) && 
                (
                    this.Rank == input.Rank ||
                    (this.Rank != null &&
                    this.Rank.Equals(input.Rank))
                ) && 
                (
                    this.RookieBonus == input.RookieBonus ||
                    (this.RookieBonus != null &&
                    this.RookieBonus.Equals(input.RookieBonus))
                ) && 
                (
                    this.PointTotal == input.PointTotal ||
                    (this.PointTotal != null &&
                    this.PointTotal.Equals(input.PointTotal))
                ) && 
                (
                    this.EventPoints == input.EventPoints ||
                    this.EventPoints != null &&
                    input.EventPoints != null &&
                    this.EventPoints.SequenceEqual(input.EventPoints)
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
                if (this.TeamKey != null)
                    hashCode = hashCode * 59 + this.TeamKey.GetHashCode();
                if (this.Rank != null)
                    hashCode = hashCode * 59 + this.Rank.GetHashCode();
                if (this.RookieBonus != null)
                    hashCode = hashCode * 59 + this.RookieBonus.GetHashCode();
                if (this.PointTotal != null)
                    hashCode = hashCode * 59 + this.PointTotal.GetHashCode();
                if (this.EventPoints != null)
                    hashCode = hashCode * 59 + this.EventPoints.GetHashCode();
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
