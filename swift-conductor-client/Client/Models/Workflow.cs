
using System.Linq;
using Newtonsoft.Json.Converters;
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace SwiftConductor.Client.Models
{
    /// <summary>
    /// Workflow
    /// </summary>
    [DataContract]
    public partial class Workflow : IEquatable<Workflow>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum RUNNING for value: RUNNING
            /// </summary>
            [EnumMember(Value = "RUNNING")]
            RUNNING = 1,
            /// <summary>
            /// Enum COMPLETED for value: COMPLETED
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            COMPLETED = 2,
            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 3,
            /// <summary>
            /// Enum TIMEDOUT for value: TIMED_OUT
            /// </summary>
            [EnumMember(Value = "TIMED_OUT")]
            TIMEDOUT = 4,
            /// <summary>
            /// Enum TERMINATED for value: TERMINATED
            /// </summary>
            [EnumMember(Value = "TERMINATED")]
            TERMINATED = 5,
            /// <summary>
            /// Enum PAUSED for value: PAUSED
            /// </summary>
            [EnumMember(Value = "PAUSED")]
            PAUSED = 6
        }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Workflow" /> class.
        /// </summary>
        /// <param name="correlationId">correlationId.</param>
        /// <param name="createTime">createTime.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="_event">_event.</param>
        /// <param name="externalInputPayloadStoragePath">externalInputPayloadStoragePath.</param>
        /// <param name="externalOutputPayloadStoragePath">externalOutputPayloadStoragePath.</param>
        /// <param name="failedReferenceTaskNames">failedReferenceTaskNames.</param>
        /// <param name="input">input.</param>
        /// <param name="lastRetriedTime">lastRetriedTime.</param>
        /// <param name="output">output.</param>
        /// <param name="ownerApp">ownerApp.</param>
        /// <param name="parentWorkflowId">parentWorkflowId.</param>
        /// <param name="parentWorkflowTaskId">parentWorkflowTaskId.</param>
        /// <param name="priority">priority.</param>
        /// <param name="reRunFromWorkflowId">reRunFromWorkflowId.</param>
        /// <param name="reasonForIncompletion">reasonForIncompletion.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="status">status.</param>
        /// <param name="taskToDomain">taskToDomain.</param>
        /// <param name="tasks">tasks.</param>
        /// <param name="updateTime">updateTime.</param>
        /// <param name="updatedBy">updatedBy.</param>
        /// <param name="variables">variables.</param>
        /// <param name="workflowDefinition">workflowDefinition.</param>
        /// <param name="workflowId">workflowId.</param>
        /// <param name="workflowName">workflowName.</param>
        /// <param name="workflowVersion">workflowVersion.</param>
        public Workflow(string correlationId = default(string), long? createTime = default(long?), string createdBy = default(string), long? endTime = default(long?), string _event = default(string), string externalInputPayloadStoragePath = default(string), string externalOutputPayloadStoragePath = default(string), List<string> failedReferenceTaskNames = default(List<string>), Dictionary<string, Object> input = default(Dictionary<string, Object>), long? lastRetriedTime = default(long?), Dictionary<string, Object> output = default(Dictionary<string, Object>), string ownerApp = default(string), string parentWorkflowId = default(string), string parentWorkflowTaskId = default(string), int? priority = default(int?), string reRunFromWorkflowId = default(string), string reasonForIncompletion = default(string), long? startTime = default(long?), StatusEnum? status = default(StatusEnum?), Dictionary<string, string> taskToDomain = default(Dictionary<string, string>), List<WorkerTask> tasks = default(List<WorkerTask>), long? updateTime = default(long?), string updatedBy = default(string), Dictionary<string, Object> variables = default(Dictionary<string, Object>), WorkflowDef workflowDefinition = default(WorkflowDef), string workflowId = default(string), string workflowName = default(string), int? workflowVersion = default(int?))
        {
            this.CorrelationId = correlationId;
            this.CreateTime = createTime;
            this.CreatedBy = createdBy;
            this.EndTime = endTime;
            this._Event = _event;
            this.ExternalInputPayloadStoragePath = externalInputPayloadStoragePath;
            this.ExternalOutputPayloadStoragePath = externalOutputPayloadStoragePath;
            this.FailedReferenceTaskNames = failedReferenceTaskNames;
            this.Input = input;
            this.LastRetriedTime = lastRetriedTime;
            this.Output = output;
            this.OwnerApp = ownerApp;
            this.ParentWorkflowId = parentWorkflowId;
            this.ParentWorkflowTaskId = parentWorkflowTaskId;
            this.Priority = priority;
            this.ReRunFromWorkflowId = reRunFromWorkflowId;
            this.ReasonForIncompletion = reasonForIncompletion;
            this.StartTime = startTime;
            this.Status = status;
            this.TaskToDomain = taskToDomain;
            this.Tasks = tasks;
            this.UpdateTime = updateTime;
            this.UpdatedBy = updatedBy;
            this.Variables = variables;
            this.WorkflowDefinition = workflowDefinition;
            this.WorkflowId = workflowId;
            this.WorkflowName = workflowName;
            this.WorkflowVersion = workflowVersion;
        }

        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name = "correlationId", EmitDefaultValue = false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or Sets CreateTime
        /// </summary>
        [DataMember(Name = "createTime", EmitDefaultValue = false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name = "endTime", EmitDefaultValue = false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// Gets or Sets _Event
        /// </summary>
        [DataMember(Name = "event", EmitDefaultValue = false)]
        public string _Event { get; set; }

        /// <summary>
        /// Gets or Sets ExternalInputPayloadStoragePath
        /// </summary>
        [DataMember(Name = "externalInputPayloadStoragePath", EmitDefaultValue = false)]
        public string ExternalInputPayloadStoragePath { get; set; }

        /// <summary>
        /// Gets or Sets ExternalOutputPayloadStoragePath
        /// </summary>
        [DataMember(Name = "externalOutputPayloadStoragePath", EmitDefaultValue = false)]
        public string ExternalOutputPayloadStoragePath { get; set; }

        /// <summary>
        /// Gets or Sets FailedReferenceTaskNames
        /// </summary>
        [DataMember(Name = "failedReferenceTaskNames", EmitDefaultValue = false)]
        public List<string> FailedReferenceTaskNames { get; set; }

        /// <summary>
        /// Gets or Sets Input
        /// </summary>
        [DataMember(Name = "input", EmitDefaultValue = false)]
        public Dictionary<string, Object> Input { get; set; }

        /// <summary>
        /// Gets or Sets LastRetriedTime
        /// </summary>
        [DataMember(Name = "lastRetriedTime", EmitDefaultValue = false)]
        public long? LastRetriedTime { get; set; }

        /// <summary>
        /// Gets or Sets Output
        /// </summary>
        [DataMember(Name = "output", EmitDefaultValue = false)]
        public Dictionary<string, Object> Output { get; set; }

        /// <summary>
        /// Gets or Sets OwnerApp
        /// </summary>
        [DataMember(Name = "ownerApp", EmitDefaultValue = false)]
        public string OwnerApp { get; set; }

        /// <summary>
        /// Gets or Sets ParentWorkflowId
        /// </summary>
        [DataMember(Name = "parentWorkflowId", EmitDefaultValue = false)]
        public string ParentWorkflowId { get; set; }

        /// <summary>
        /// Gets or Sets ParentWorkflowTaskId
        /// </summary>
        [DataMember(Name = "parentWorkflowTaskId", EmitDefaultValue = false)]
        public string ParentWorkflowTaskId { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or Sets ReRunFromWorkflowId
        /// </summary>
        [DataMember(Name = "reRunFromWorkflowId", EmitDefaultValue = false)]
        public string ReRunFromWorkflowId { get; set; }

        /// <summary>
        /// Gets or Sets ReasonForIncompletion
        /// </summary>
        [DataMember(Name = "reasonForIncompletion", EmitDefaultValue = false)]
        public string ReasonForIncompletion { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public long? StartTime { get; set; }


        /// <summary>
        /// Gets or Sets TaskToDomain
        /// </summary>
        [DataMember(Name = "taskToDomain", EmitDefaultValue = false)]
        public Dictionary<string, string> TaskToDomain { get; set; }

        /// <summary>
        /// Gets or Sets Tasks
        /// </summary>
        [DataMember(Name = "tasks", EmitDefaultValue = false)]
        public List<WorkerTask> Tasks { get; set; }

        /// <summary>
        /// Gets or Sets UpdateTime
        /// </summary>
        [DataMember(Name = "updateTime", EmitDefaultValue = false)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name = "updatedBy", EmitDefaultValue = false)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or Sets Variables
        /// </summary>
        [DataMember(Name = "variables", EmitDefaultValue = false)]
        public Dictionary<string, Object> Variables { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowDefinition
        /// </summary>
        [DataMember(Name = "workflowDefinition", EmitDefaultValue = false)]
        public WorkflowDef WorkflowDefinition { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowId
        /// </summary>
        [DataMember(Name = "workflowId", EmitDefaultValue = false)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowName
        /// </summary>
        [DataMember(Name = "workflowName", EmitDefaultValue = false)]
        public string WorkflowName { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowVersion
        /// </summary>
        [DataMember(Name = "workflowVersion", EmitDefaultValue = false)]
        public int? WorkflowVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Workflow {\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  _Event: ").Append(_Event).Append("\n");
            sb.Append("  ExternalInputPayloadStoragePath: ").Append(ExternalInputPayloadStoragePath).Append("\n");
            sb.Append("  ExternalOutputPayloadStoragePath: ").Append(ExternalOutputPayloadStoragePath).Append("\n");
            sb.Append("  FailedReferenceTaskNames: ").Append(FailedReferenceTaskNames).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  LastRetriedTime: ").Append(LastRetriedTime).Append("\n");
            sb.Append("  Output: ").Append(Output).Append("\n");
            sb.Append("  OwnerApp: ").Append(OwnerApp).Append("\n");
            sb.Append("  ParentWorkflowId: ").Append(ParentWorkflowId).Append("\n");
            sb.Append("  ParentWorkflowTaskId: ").Append(ParentWorkflowTaskId).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  ReRunFromWorkflowId: ").Append(ReRunFromWorkflowId).Append("\n");
            sb.Append("  ReasonForIncompletion: ").Append(ReasonForIncompletion).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TaskToDomain: ").Append(TaskToDomain).Append("\n");
            sb.Append("  Tasks: ").Append(Tasks).Append("\n");
            sb.Append("  UpdateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  WorkflowDefinition: ").Append(WorkflowDefinition).Append("\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  WorkflowName: ").Append(WorkflowName).Append("\n");
            sb.Append("  WorkflowVersion: ").Append(WorkflowVersion).Append("\n");
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
            return this.Equals(input as Workflow);
        }

        /// <summary>
        /// Returns true if Workflow instances are equal
        /// </summary>
        /// <param name="input">Instance of Workflow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Workflow input)
        {
            if (input == null)
                return false;

            return
                (
                    this.CorrelationId == input.CorrelationId ||
                    (this.CorrelationId != null &&
                    this.CorrelationId.Equals(input.CorrelationId))
                ) &&
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) &&
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) &&
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) &&
                (
                    this._Event == input._Event ||
                    (this._Event != null &&
                    this._Event.Equals(input._Event))
                ) &&
                (
                    this.ExternalInputPayloadStoragePath == input.ExternalInputPayloadStoragePath ||
                    (this.ExternalInputPayloadStoragePath != null &&
                    this.ExternalInputPayloadStoragePath.Equals(input.ExternalInputPayloadStoragePath))
                ) &&
                (
                    this.ExternalOutputPayloadStoragePath == input.ExternalOutputPayloadStoragePath ||
                    (this.ExternalOutputPayloadStoragePath != null &&
                    this.ExternalOutputPayloadStoragePath.Equals(input.ExternalOutputPayloadStoragePath))
                ) &&
                (
                    this.FailedReferenceTaskNames == input.FailedReferenceTaskNames ||
                    this.FailedReferenceTaskNames != null &&
                    input.FailedReferenceTaskNames != null &&
                    this.FailedReferenceTaskNames.SequenceEqual(input.FailedReferenceTaskNames)
                ) &&
                (
                    this.Input == input.Input ||
                    this.Input != null &&
                    input.Input != null &&
                    this.Input.SequenceEqual(input.Input)
                ) &&
                (
                    this.LastRetriedTime == input.LastRetriedTime ||
                    (this.LastRetriedTime != null &&
                    this.LastRetriedTime.Equals(input.LastRetriedTime))
                ) &&
                (
                    this.Output == input.Output ||
                    this.Output != null &&
                    input.Output != null &&
                    this.Output.SequenceEqual(input.Output)
                ) &&
                (
                    this.OwnerApp == input.OwnerApp ||
                    (this.OwnerApp != null &&
                    this.OwnerApp.Equals(input.OwnerApp))
                ) &&
                (
                    this.ParentWorkflowId == input.ParentWorkflowId ||
                    (this.ParentWorkflowId != null &&
                    this.ParentWorkflowId.Equals(input.ParentWorkflowId))
                ) &&
                (
                    this.ParentWorkflowTaskId == input.ParentWorkflowTaskId ||
                    (this.ParentWorkflowTaskId != null &&
                    this.ParentWorkflowTaskId.Equals(input.ParentWorkflowTaskId))
                ) &&
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) &&
                (
                    this.ReRunFromWorkflowId == input.ReRunFromWorkflowId ||
                    (this.ReRunFromWorkflowId != null &&
                    this.ReRunFromWorkflowId.Equals(input.ReRunFromWorkflowId))
                ) &&
                (
                    this.ReasonForIncompletion == input.ReasonForIncompletion ||
                    (this.ReasonForIncompletion != null &&
                    this.ReasonForIncompletion.Equals(input.ReasonForIncompletion))
                ) &&
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) &&
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) &&
                (
                    this.TaskToDomain == input.TaskToDomain ||
                    this.TaskToDomain != null &&
                    input.TaskToDomain != null &&
                    this.TaskToDomain.SequenceEqual(input.TaskToDomain)
                ) &&
                (
                    this.Tasks == input.Tasks ||
                    this.Tasks != null &&
                    input.Tasks != null &&
                    this.Tasks.SequenceEqual(input.Tasks)
                ) &&
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) &&
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
                ) &&
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    input.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
                ) &&
                (
                    this.WorkflowDefinition == input.WorkflowDefinition ||
                    (this.WorkflowDefinition != null &&
                    this.WorkflowDefinition.Equals(input.WorkflowDefinition))
                ) &&
                (
                    this.WorkflowId == input.WorkflowId ||
                    (this.WorkflowId != null &&
                    this.WorkflowId.Equals(input.WorkflowId))
                ) &&
                (
                    this.WorkflowName == input.WorkflowName ||
                    (this.WorkflowName != null &&
                    this.WorkflowName.Equals(input.WorkflowName))
                ) &&
                (
                    this.WorkflowVersion == input.WorkflowVersion ||
                    (this.WorkflowVersion != null &&
                    this.WorkflowVersion.Equals(input.WorkflowVersion))
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
                if (this.CorrelationId != null)
                    hashCode = hashCode * 59 + this.CorrelationId.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this._Event != null)
                    hashCode = hashCode * 59 + this._Event.GetHashCode();
                if (this.ExternalInputPayloadStoragePath != null)
                    hashCode = hashCode * 59 + this.ExternalInputPayloadStoragePath.GetHashCode();
                if (this.ExternalOutputPayloadStoragePath != null)
                    hashCode = hashCode * 59 + this.ExternalOutputPayloadStoragePath.GetHashCode();
                if (this.FailedReferenceTaskNames != null)
                    hashCode = hashCode * 59 + this.FailedReferenceTaskNames.GetHashCode();
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.LastRetriedTime != null)
                    hashCode = hashCode * 59 + this.LastRetriedTime.GetHashCode();
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.OwnerApp != null)
                    hashCode = hashCode * 59 + this.OwnerApp.GetHashCode();
                if (this.ParentWorkflowId != null)
                    hashCode = hashCode * 59 + this.ParentWorkflowId.GetHashCode();
                if (this.ParentWorkflowTaskId != null)
                    hashCode = hashCode * 59 + this.ParentWorkflowTaskId.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.ReRunFromWorkflowId != null)
                    hashCode = hashCode * 59 + this.ReRunFromWorkflowId.GetHashCode();
                if (this.ReasonForIncompletion != null)
                    hashCode = hashCode * 59 + this.ReasonForIncompletion.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TaskToDomain != null)
                    hashCode = hashCode * 59 + this.TaskToDomain.GetHashCode();
                if (this.Tasks != null)
                    hashCode = hashCode * 59 + this.Tasks.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.UpdatedBy != null)
                    hashCode = hashCode * 59 + this.UpdatedBy.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.WorkflowDefinition != null)
                    hashCode = hashCode * 59 + this.WorkflowDefinition.GetHashCode();
                if (this.WorkflowId != null)
                    hashCode = hashCode * 59 + this.WorkflowId.GetHashCode();
                if (this.WorkflowName != null)
                    hashCode = hashCode * 59 + this.WorkflowName.GetHashCode();
                if (this.WorkflowVersion != null)
                    hashCode = hashCode * 59 + this.WorkflowVersion.GetHashCode();
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
