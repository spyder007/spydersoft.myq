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
    /// Device
    /// </summary>
    [DataContract]
    public partial class Device :  IEquatable<Device>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Device" /> class.
        /// </summary>
        /// <param name="href">href.</param>
        /// <param name="serialNumber">serialNumber.</param>
        /// <param name="deviceFamily">deviceFamily.</param>
        /// <param name="devicePlatform">devicePlatform.</param>
        /// <param name="deviceType">deviceType.</param>
        /// <param name="name">name.</param>
        /// <param name="parentDevice">parentDevice.</param>
        /// <param name="parentDeviceId">parentDeviceId.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="state">state.</param>
        public Device(string href = default(string), string serialNumber = default(string), string deviceFamily = default(string), string devicePlatform = default(string), string deviceType = default(string), string name = default(string), string parentDevice = default(string), string parentDeviceId = default(string), DateTime createdDate = default(DateTime), DeviceState state = default(DeviceState))
        {
            this.Href = href;
            this.SerialNumber = serialNumber;
            this.DeviceFamily = deviceFamily;
            this.DevicePlatform = devicePlatform;
            this.DeviceType = deviceType;
            this.Name = name;
            this.ParentDevice = parentDevice;
            this.ParentDeviceId = parentDeviceId;
            this.CreatedDate = createdDate;
            this.State = state;
        }
        
        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name="serial_number", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets DeviceFamily
        /// </summary>
        [DataMember(Name="device_family", EmitDefaultValue=false)]
        public string DeviceFamily { get; set; }

        /// <summary>
        /// Gets or Sets DevicePlatform
        /// </summary>
        [DataMember(Name="device_platform", EmitDefaultValue=false)]
        public string DevicePlatform { get; set; }

        /// <summary>
        /// Gets or Sets DeviceType
        /// </summary>
        [DataMember(Name="device_type", EmitDefaultValue=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ParentDevice
        /// </summary>
        [DataMember(Name="parent_device", EmitDefaultValue=false)]
        public string ParentDevice { get; set; }

        /// <summary>
        /// Gets or Sets ParentDeviceId
        /// </summary>
        [DataMember(Name="parent_device_id", EmitDefaultValue=false)]
        public string ParentDeviceId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public DeviceState State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Device {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  DeviceFamily: ").Append(DeviceFamily).Append("\n");
            sb.Append("  DevicePlatform: ").Append(DevicePlatform).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParentDevice: ").Append(ParentDevice).Append("\n");
            sb.Append("  ParentDeviceId: ").Append(ParentDeviceId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as Device);
        }

        /// <summary>
        /// Returns true if Device instances are equal
        /// </summary>
        /// <param name="input">Instance of Device to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Device input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.DeviceFamily == input.DeviceFamily ||
                    (this.DeviceFamily != null &&
                    this.DeviceFamily.Equals(input.DeviceFamily))
                ) && 
                (
                    this.DevicePlatform == input.DevicePlatform ||
                    (this.DevicePlatform != null &&
                    this.DevicePlatform.Equals(input.DevicePlatform))
                ) && 
                (
                    this.DeviceType == input.DeviceType ||
                    (this.DeviceType != null &&
                    this.DeviceType.Equals(input.DeviceType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ParentDevice == input.ParentDevice ||
                    (this.ParentDevice != null &&
                    this.ParentDevice.Equals(input.ParentDevice))
                ) && 
                (
                    this.ParentDeviceId == input.ParentDeviceId ||
                    (this.ParentDeviceId != null &&
                    this.ParentDeviceId.Equals(input.ParentDeviceId))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.DeviceFamily != null)
                    hashCode = hashCode * 59 + this.DeviceFamily.GetHashCode();
                if (this.DevicePlatform != null)
                    hashCode = hashCode * 59 + this.DevicePlatform.GetHashCode();
                if (this.DeviceType != null)
                    hashCode = hashCode * 59 + this.DeviceType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ParentDevice != null)
                    hashCode = hashCode * 59 + this.ParentDevice.GetHashCode();
                if (this.ParentDeviceId != null)
                    hashCode = hashCode * 59 + this.ParentDeviceId.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
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
