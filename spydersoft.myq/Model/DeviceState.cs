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
    /// DeviceState
    /// </summary>
    [DataContract]
    public partial class DeviceState :  IEquatable<DeviceState>, IValidatableObject
    {
        /// <summary>
        /// Defines DoorState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DoorStateEnum
        {
            /// <summary>
            /// Enum Closed for value: closed
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed = 1,

            /// <summary>
            /// Enum Closing for value: closing
            /// </summary>
            [EnumMember(Value = "closing")]
            Closing = 2,

            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 3,

            /// <summary>
            /// Enum Opening for value: opening
            /// </summary>
            [EnumMember(Value = "opening")]
            Opening = 4,

            /// <summary>
            /// Enum Stopped for value: stopped
            /// </summary>
            [EnumMember(Value = "stopped")]
            Stopped = 5,

            /// <summary>
            /// Enum Transition for value: transition
            /// </summary>
            [EnumMember(Value = "transition")]
            Transition = 6,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 7

        }

        /// <summary>
        /// Gets or Sets DoorState
        /// </summary>
        [DataMember(Name="door_state", EmitDefaultValue=false)]
        public DoorStateEnum? DoorState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceState" /> class.
        /// </summary>
        /// <param name="gdoLockConnected">gdoLockConnected.</param>
        /// <param name="attachedWorkLightErrorPresent">attachedWorkLightErrorPresent.</param>
        /// <param name="doorState">doorState.</param>
        /// <param name="open">open.</param>
        /// <param name="close">close.</param>
        /// <param name="lastUpdated">lastUpdated.</param>
        /// <param name="passthroughInterval">passthroughInterval.</param>
        /// <param name="doorAjarInterval">doorAjarInterval.</param>
        /// <param name="invalidCredentialWindow">invalidCredentialWindow.</param>
        /// <param name="invalidShutoutPeriod">invalidShutoutPeriod.</param>
        /// <param name="isUnattendedOpenAllowed">isUnattendedOpenAllowed.</param>
        /// <param name="isUnattendedCloseAllowed">isUnattendedCloseAllowed.</param>
        /// <param name="auxRelayDelay">auxRelayDelay.</param>
        /// <param name="useAuxRelay">useAuxRelay.</param>
        /// <param name="auxRelayBehavior">auxRelayBehavior.</param>
        /// <param name="rexFiresDoor">rexFiresDoor.</param>
        /// <param name="commandChannelReportStatus">commandChannelReportStatus.</param>
        /// <param name="controlFromBrowser">controlFromBrowser.</param>
        /// <param name="reportForced">reportForced.</param>
        /// <param name="reportAjar">reportAjar.</param>
        /// <param name="maxInvalidAttempts">maxInvalidAttempts.</param>
        /// <param name="online">online.</param>
        /// <param name="lastStatus">lastStatus.</param>
        public DeviceState(bool gdoLockConnected = default(bool), bool attachedWorkLightErrorPresent = default(bool), DoorStateEnum? doorState = default(DoorStateEnum?), string open = default(string), string close = default(string), DateTime lastUpdated = default(DateTime), string passthroughInterval = default(string), string doorAjarInterval = default(string), string invalidCredentialWindow = default(string), string invalidShutoutPeriod = default(string), bool isUnattendedOpenAllowed = default(bool), bool isUnattendedCloseAllowed = default(bool), string auxRelayDelay = default(string), bool useAuxRelay = default(bool), string auxRelayBehavior = default(string), bool rexFiresDoor = default(bool), bool commandChannelReportStatus = default(bool), bool controlFromBrowser = default(bool), bool reportForced = default(bool), bool reportAjar = default(bool), decimal maxInvalidAttempts = default(decimal), bool online = default(bool), DateTime lastStatus = default(DateTime))
        {
            this.GdoLockConnected = gdoLockConnected;
            this.AttachedWorkLightErrorPresent = attachedWorkLightErrorPresent;
            this.DoorState = doorState;
            this.Open = open;
            this.Close = close;
            this.LastUpdated = lastUpdated;
            this.PassthroughInterval = passthroughInterval;
            this.DoorAjarInterval = doorAjarInterval;
            this.InvalidCredentialWindow = invalidCredentialWindow;
            this.InvalidShutoutPeriod = invalidShutoutPeriod;
            this.IsUnattendedOpenAllowed = isUnattendedOpenAllowed;
            this.IsUnattendedCloseAllowed = isUnattendedCloseAllowed;
            this.AuxRelayDelay = auxRelayDelay;
            this.UseAuxRelay = useAuxRelay;
            this.AuxRelayBehavior = auxRelayBehavior;
            this.RexFiresDoor = rexFiresDoor;
            this.CommandChannelReportStatus = commandChannelReportStatus;
            this.ControlFromBrowser = controlFromBrowser;
            this.ReportForced = reportForced;
            this.ReportAjar = reportAjar;
            this.MaxInvalidAttempts = maxInvalidAttempts;
            this.Online = online;
            this.LastStatus = lastStatus;
        }
        
        /// <summary>
        /// Gets or Sets GdoLockConnected
        /// </summary>
        [DataMember(Name="gdo_lock_connected", EmitDefaultValue=false)]
        public bool GdoLockConnected { get; set; }

        /// <summary>
        /// Gets or Sets AttachedWorkLightErrorPresent
        /// </summary>
        [DataMember(Name="attached_work_light_error_present", EmitDefaultValue=false)]
        public bool AttachedWorkLightErrorPresent { get; set; }

        /// <summary>
        /// Gets or Sets Open
        /// </summary>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public string Open { get; set; }

        /// <summary>
        /// Gets or Sets Close
        /// </summary>
        [DataMember(Name="close", EmitDefaultValue=false)]
        public string Close { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name="last_updated", EmitDefaultValue=false)]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Gets or Sets PassthroughInterval
        /// </summary>
        [DataMember(Name="passthrough_interval", EmitDefaultValue=false)]
        public string PassthroughInterval { get; set; }

        /// <summary>
        /// Gets or Sets DoorAjarInterval
        /// </summary>
        [DataMember(Name="door_ajar_interval", EmitDefaultValue=false)]
        public string DoorAjarInterval { get; set; }

        /// <summary>
        /// Gets or Sets InvalidCredentialWindow
        /// </summary>
        [DataMember(Name="invalid_credential_window", EmitDefaultValue=false)]
        public string InvalidCredentialWindow { get; set; }

        /// <summary>
        /// Gets or Sets InvalidShutoutPeriod
        /// </summary>
        [DataMember(Name="invalid_shutout_period", EmitDefaultValue=false)]
        public string InvalidShutoutPeriod { get; set; }

        /// <summary>
        /// Gets or Sets IsUnattendedOpenAllowed
        /// </summary>
        [DataMember(Name="is_unattended_open_allowed", EmitDefaultValue=false)]
        public bool IsUnattendedOpenAllowed { get; set; }

        /// <summary>
        /// Gets or Sets IsUnattendedCloseAllowed
        /// </summary>
        [DataMember(Name="is_unattended_close_allowed", EmitDefaultValue=false)]
        public bool IsUnattendedCloseAllowed { get; set; }

        /// <summary>
        /// Gets or Sets AuxRelayDelay
        /// </summary>
        [DataMember(Name="aux_relay_delay", EmitDefaultValue=false)]
        public string AuxRelayDelay { get; set; }

        /// <summary>
        /// Gets or Sets UseAuxRelay
        /// </summary>
        [DataMember(Name="use_aux_relay", EmitDefaultValue=false)]
        public bool UseAuxRelay { get; set; }

        /// <summary>
        /// Gets or Sets AuxRelayBehavior
        /// </summary>
        [DataMember(Name="aux_relay_behavior", EmitDefaultValue=false)]
        public string AuxRelayBehavior { get; set; }

        /// <summary>
        /// Gets or Sets RexFiresDoor
        /// </summary>
        [DataMember(Name="rex_fires_door", EmitDefaultValue=false)]
        public bool RexFiresDoor { get; set; }

        /// <summary>
        /// Gets or Sets CommandChannelReportStatus
        /// </summary>
        [DataMember(Name="command_channel_report_status", EmitDefaultValue=false)]
        public bool CommandChannelReportStatus { get; set; }

        /// <summary>
        /// Gets or Sets ControlFromBrowser
        /// </summary>
        [DataMember(Name="control_from_browser", EmitDefaultValue=false)]
        public bool ControlFromBrowser { get; set; }

        /// <summary>
        /// Gets or Sets ReportForced
        /// </summary>
        [DataMember(Name="report_forced", EmitDefaultValue=false)]
        public bool ReportForced { get; set; }

        /// <summary>
        /// Gets or Sets ReportAjar
        /// </summary>
        [DataMember(Name="report_ajar", EmitDefaultValue=false)]
        public bool ReportAjar { get; set; }

        /// <summary>
        /// Gets or Sets MaxInvalidAttempts
        /// </summary>
        [DataMember(Name="max_invalid_attempts", EmitDefaultValue=false)]
        public decimal MaxInvalidAttempts { get; set; }

        /// <summary>
        /// Gets or Sets Online
        /// </summary>
        [DataMember(Name="online", EmitDefaultValue=false)]
        public bool Online { get; set; }

        /// <summary>
        /// Gets or Sets LastStatus
        /// </summary>
        [DataMember(Name="last_status", EmitDefaultValue=false)]
        public DateTime LastStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceState {\n");
            sb.Append("  GdoLockConnected: ").Append(GdoLockConnected).Append("\n");
            sb.Append("  AttachedWorkLightErrorPresent: ").Append(AttachedWorkLightErrorPresent).Append("\n");
            sb.Append("  DoorState: ").Append(DoorState).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  PassthroughInterval: ").Append(PassthroughInterval).Append("\n");
            sb.Append("  DoorAjarInterval: ").Append(DoorAjarInterval).Append("\n");
            sb.Append("  InvalidCredentialWindow: ").Append(InvalidCredentialWindow).Append("\n");
            sb.Append("  InvalidShutoutPeriod: ").Append(InvalidShutoutPeriod).Append("\n");
            sb.Append("  IsUnattendedOpenAllowed: ").Append(IsUnattendedOpenAllowed).Append("\n");
            sb.Append("  IsUnattendedCloseAllowed: ").Append(IsUnattendedCloseAllowed).Append("\n");
            sb.Append("  AuxRelayDelay: ").Append(AuxRelayDelay).Append("\n");
            sb.Append("  UseAuxRelay: ").Append(UseAuxRelay).Append("\n");
            sb.Append("  AuxRelayBehavior: ").Append(AuxRelayBehavior).Append("\n");
            sb.Append("  RexFiresDoor: ").Append(RexFiresDoor).Append("\n");
            sb.Append("  CommandChannelReportStatus: ").Append(CommandChannelReportStatus).Append("\n");
            sb.Append("  ControlFromBrowser: ").Append(ControlFromBrowser).Append("\n");
            sb.Append("  ReportForced: ").Append(ReportForced).Append("\n");
            sb.Append("  ReportAjar: ").Append(ReportAjar).Append("\n");
            sb.Append("  MaxInvalidAttempts: ").Append(MaxInvalidAttempts).Append("\n");
            sb.Append("  Online: ").Append(Online).Append("\n");
            sb.Append("  LastStatus: ").Append(LastStatus).Append("\n");
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
            return this.Equals(input as DeviceState);
        }

        /// <summary>
        /// Returns true if DeviceState instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GdoLockConnected == input.GdoLockConnected ||
                    this.GdoLockConnected.Equals(input.GdoLockConnected)
                ) && 
                (
                    this.AttachedWorkLightErrorPresent == input.AttachedWorkLightErrorPresent ||
                    this.AttachedWorkLightErrorPresent.Equals(input.AttachedWorkLightErrorPresent)
                ) && 
                (
                    this.DoorState == input.DoorState ||
                    this.DoorState.Equals(input.DoorState)
                ) && 
                (
                    this.Open == input.Open ||
                    (this.Open != null &&
                    this.Open.Equals(input.Open))
                ) && 
                (
                    this.Close == input.Close ||
                    (this.Close != null &&
                    this.Close.Equals(input.Close))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.PassthroughInterval == input.PassthroughInterval ||
                    (this.PassthroughInterval != null &&
                    this.PassthroughInterval.Equals(input.PassthroughInterval))
                ) && 
                (
                    this.DoorAjarInterval == input.DoorAjarInterval ||
                    (this.DoorAjarInterval != null &&
                    this.DoorAjarInterval.Equals(input.DoorAjarInterval))
                ) && 
                (
                    this.InvalidCredentialWindow == input.InvalidCredentialWindow ||
                    (this.InvalidCredentialWindow != null &&
                    this.InvalidCredentialWindow.Equals(input.InvalidCredentialWindow))
                ) && 
                (
                    this.InvalidShutoutPeriod == input.InvalidShutoutPeriod ||
                    (this.InvalidShutoutPeriod != null &&
                    this.InvalidShutoutPeriod.Equals(input.InvalidShutoutPeriod))
                ) && 
                (
                    this.IsUnattendedOpenAllowed == input.IsUnattendedOpenAllowed ||
                    this.IsUnattendedOpenAllowed.Equals(input.IsUnattendedOpenAllowed)
                ) && 
                (
                    this.IsUnattendedCloseAllowed == input.IsUnattendedCloseAllowed ||
                    this.IsUnattendedCloseAllowed.Equals(input.IsUnattendedCloseAllowed)
                ) && 
                (
                    this.AuxRelayDelay == input.AuxRelayDelay ||
                    (this.AuxRelayDelay != null &&
                    this.AuxRelayDelay.Equals(input.AuxRelayDelay))
                ) && 
                (
                    this.UseAuxRelay == input.UseAuxRelay ||
                    this.UseAuxRelay.Equals(input.UseAuxRelay)
                ) && 
                (
                    this.AuxRelayBehavior == input.AuxRelayBehavior ||
                    (this.AuxRelayBehavior != null &&
                    this.AuxRelayBehavior.Equals(input.AuxRelayBehavior))
                ) && 
                (
                    this.RexFiresDoor == input.RexFiresDoor ||
                    this.RexFiresDoor.Equals(input.RexFiresDoor)
                ) && 
                (
                    this.CommandChannelReportStatus == input.CommandChannelReportStatus ||
                    this.CommandChannelReportStatus.Equals(input.CommandChannelReportStatus)
                ) && 
                (
                    this.ControlFromBrowser == input.ControlFromBrowser ||
                    this.ControlFromBrowser.Equals(input.ControlFromBrowser)
                ) && 
                (
                    this.ReportForced == input.ReportForced ||
                    this.ReportForced.Equals(input.ReportForced)
                ) && 
                (
                    this.ReportAjar == input.ReportAjar ||
                    this.ReportAjar.Equals(input.ReportAjar)
                ) && 
                (
                    this.MaxInvalidAttempts == input.MaxInvalidAttempts ||
                    this.MaxInvalidAttempts.Equals(input.MaxInvalidAttempts)
                ) && 
                (
                    this.Online == input.Online ||
                    this.Online.Equals(input.Online)
                ) && 
                (
                    this.LastStatus == input.LastStatus ||
                    (this.LastStatus != null &&
                    this.LastStatus.Equals(input.LastStatus))
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
                hashCode = hashCode * 59 + this.GdoLockConnected.GetHashCode();
                hashCode = hashCode * 59 + this.AttachedWorkLightErrorPresent.GetHashCode();
                hashCode = hashCode * 59 + this.DoorState.GetHashCode();
                if (this.Open != null)
                    hashCode = hashCode * 59 + this.Open.GetHashCode();
                if (this.Close != null)
                    hashCode = hashCode * 59 + this.Close.GetHashCode();
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
                if (this.PassthroughInterval != null)
                    hashCode = hashCode * 59 + this.PassthroughInterval.GetHashCode();
                if (this.DoorAjarInterval != null)
                    hashCode = hashCode * 59 + this.DoorAjarInterval.GetHashCode();
                if (this.InvalidCredentialWindow != null)
                    hashCode = hashCode * 59 + this.InvalidCredentialWindow.GetHashCode();
                if (this.InvalidShutoutPeriod != null)
                    hashCode = hashCode * 59 + this.InvalidShutoutPeriod.GetHashCode();
                hashCode = hashCode * 59 + this.IsUnattendedOpenAllowed.GetHashCode();
                hashCode = hashCode * 59 + this.IsUnattendedCloseAllowed.GetHashCode();
                if (this.AuxRelayDelay != null)
                    hashCode = hashCode * 59 + this.AuxRelayDelay.GetHashCode();
                hashCode = hashCode * 59 + this.UseAuxRelay.GetHashCode();
                if (this.AuxRelayBehavior != null)
                    hashCode = hashCode * 59 + this.AuxRelayBehavior.GetHashCode();
                hashCode = hashCode * 59 + this.RexFiresDoor.GetHashCode();
                hashCode = hashCode * 59 + this.CommandChannelReportStatus.GetHashCode();
                hashCode = hashCode * 59 + this.ControlFromBrowser.GetHashCode();
                hashCode = hashCode * 59 + this.ReportForced.GetHashCode();
                hashCode = hashCode * 59 + this.ReportAjar.GetHashCode();
                hashCode = hashCode * 59 + this.MaxInvalidAttempts.GetHashCode();
                hashCode = hashCode * 59 + this.Online.GetHashCode();
                if (this.LastStatus != null)
                    hashCode = hashCode * 59 + this.LastStatus.GetHashCode();
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
