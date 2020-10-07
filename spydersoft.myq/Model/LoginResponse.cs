/* 
 * API for MyQ Devices
 *
 * This is a reverse engineered and incomplete version of the MyQ API.
 *
 * The version of the OpenAPI document: 5.1
 * Contact: geregam@gmail.com
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
using OpenAPIDateConverter = spydersoft.myq.Client.OpenAPIDateConverter;

namespace spydersoft.myq.Model
{
    /// <summary>
    /// LoginResponse
    /// </summary>
    [DataContract]
    public partial class LoginResponse :  IEquatable<LoginResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginResponse" /> class.
        /// </summary>
        /// <param name="securityToken">securityToken.</param>
        public LoginResponse(string securityToken = default(string))
        {
            this.SecurityToken = securityToken;
        }
        
        /// <summary>
        /// Gets or Sets SecurityToken
        /// </summary>
        [DataMember(Name="SecurityToken", EmitDefaultValue=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginResponse {\n");
            sb.Append("  SecurityToken: ").Append(SecurityToken).Append("\n");
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
            return this.Equals(input as LoginResponse);
        }

        /// <summary>
        /// Returns true if LoginResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LoginResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoginResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecurityToken == input.SecurityToken ||
                    (this.SecurityToken != null &&
                    this.SecurityToken.Equals(input.SecurityToken))
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
                if (this.SecurityToken != null)
                    hashCode = hashCode * 59 + this.SecurityToken.GetHashCode();
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
