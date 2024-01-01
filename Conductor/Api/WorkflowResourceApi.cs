using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using Conductor.Client;
using Conductor.Client.Models;

namespace Conductor.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWorkflowResourceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Starts the decision task for a workflow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <returns></returns>
        void Decide(string workflowId);

        /// <summary>
        /// Starts the decision task for a workflow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DecideWithHttpInfo(string workflowId);
        /// <summary>
        /// Removes the workflow from the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="archiveWorkflow"> (optional, default to true)</param>
        /// <returns></returns>
        void Delete(string workflowId, bool? archiveWorkflow = null);

        /// <summary>
        /// Removes the workflow from the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="archiveWorkflow"> (optional, default to true)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWithHttpInfo(string workflowId, bool? archiveWorkflow = null);
        /// <summary>
        /// Execute a workflow synchronously
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="requestId"></param>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="waitUntilTaskRef"> (optional)</param>
        /// <returns>WorkflowRun</returns>
        WorkflowRun ExecuteWorkflow(StartWorkflowRequest body, string requestId, string name, int? version, string waitUntilTaskRef = null);

        /// <summary>
        /// Execute a workflow synchronously
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="requestId"></param>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="waitUntilTaskRef"> (optional)</param>
        /// <returns>ApiResponse of WorkflowRun</returns>
        ApiResponse<WorkflowRun> ExecuteWorkflowWithHttpInfo(StartWorkflowRequest body, string requestId, string name, int? version, string waitUntilTaskRef = null);
        /// <summary>
        /// Gets the workflow by workflow id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="includeTasks"> (optional, default to true)</param>
        /// <param name="summarize"> (optional, default to false)</param>
        /// <returns>Workflow</returns>
        Workflow GetExecutionStatus(string workflowId, bool? includeTasks = null, bool? summarize = null);

        /// <summary>
        /// Gets the workflow by workflow id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="includeTasks"> (optional, default to true)</param>
        /// <param name="summarize"> (optional, default to false)</param>
        /// <returns>ApiResponse of Workflow</returns>
        ApiResponse<Workflow> GetExecutionStatusWithHttpInfo(string workflowId, bool? includeTasks = null, bool? summarize = null);
        /// <summary>
        /// Gets the workflow tasks by workflow id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 15)</param>
        /// <param name="status"> (optional)</param>
        /// <returns>TaskListSearchResultSummary</returns>
        TaskListSearchResultSummary GetExecutionStatusTaskList(string workflowId, int? start = null, int? count = null, string status = null);

        /// <summary>
        /// Gets the workflow tasks by workflow id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 15)</param>
        /// <param name="status"> (optional)</param>
        /// <returns>ApiResponse of TaskListSearchResultSummary</returns>
        ApiResponse<TaskListSearchResultSummary> GetExecutionStatusTaskListWithHttpInfo(string workflowId, int? start = null, int? count = null, string status = null);
        /// <summary>
        /// Get the uri and path of the external storage where the workflow payload is to be stored
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path"></param>
        /// <param name="operation"></param>
        /// <param name="payloadType"></param>
        /// <returns>ExternalStorageLocation</returns>
        ExternalStorageLocation GetExternalStorageLocation(string path, string operation, string payloadType);

        /// <summary>
        /// Get the uri and path of the external storage where the workflow payload is to be stored
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path"></param>
        /// <param name="operation"></param>
        /// <param name="payloadType"></param>
        /// <returns>ApiResponse of ExternalStorageLocation</returns>
        ApiResponse<ExternalStorageLocation> GetExternalStorageLocationWithHttpInfo(string path, string operation, string payloadType);
        /// <summary>
        /// Retrieve all the running workflows
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="version"> (optional, default to 1)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetRunningWorkflow(string name, int? version = null, long? startTime = null, long? endTime = null);

        /// <summary>
        /// Retrieve all the running workflows
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="version"> (optional, default to 1)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> GetRunningWorkflowWithHttpInfo(string name, int? version = null, long? startTime = null, long? endTime = null);
        /// <summary>
        /// Gets the workflow by workflow id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="includeOutput"> (optional, default to false)</param>
        /// <param name="includeVariables"> (optional, default to false)</param>
        /// <returns>WorkflowStatus</returns>
        WorkflowStatus GetWorkflowStatusSummary(string workflowId, bool? includeOutput = null, bool? includeVariables = null);

        /// <summary>
        /// Gets the workflow by workflow id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="includeOutput"> (optional, default to false)</param>
        /// <param name="includeVariables"> (optional, default to false)</param>
        /// <returns>ApiResponse of WorkflowStatus</returns>
        ApiResponse<WorkflowStatus> GetWorkflowStatusSummaryWithHttpInfo(string workflowId, bool? includeOutput = null, bool? includeVariables = null);
        /// <summary>
        /// Lists workflows for the given correlation id list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="name"></param>
        /// <param name="includeClosed"> (optional, default to false)</param>
        /// <param name="includeTasks"> (optional, default to false)</param>
        /// <returns>Dictionary&lt;string, List&lt;Workflow&gt;&gt;</returns>
        Dictionary<string, List<Workflow>> GetWorkflows(List<string> body, string name, bool? includeClosed = null, bool? includeTasks = null);

        /// <summary>
        /// Lists workflows for the given correlation id list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="name"></param>
        /// <param name="includeClosed"> (optional, default to false)</param>
        /// <param name="includeTasks"> (optional, default to false)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;Workflow&gt;&gt;</returns>
        ApiResponse<Dictionary<string, List<Workflow>>> GetWorkflowsWithHttpInfo(List<string> body, string name, bool? includeClosed = null, bool? includeTasks = null);
        /// <summary>
        /// Lists workflows for the given correlation id list and workflow name list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="includeClosed"> (optional, default to false)</param>
        /// <param name="includeTasks"> (optional, default to false)</param>
        /// <returns>Dictionary&lt;string, List&lt;Workflow&gt;&gt;</returns>
        Dictionary<string, List<Workflow>> GetWorkflows(CorrelationIdsSearchRequest body, bool? includeClosed = null, bool? includeTasks = null);

        /// <summary>
        /// Lists workflows for the given correlation id list and workflow name list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="includeClosed"> (optional, default to false)</param>
        /// <param name="includeTasks"> (optional, default to false)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;Workflow&gt;&gt;</returns>
        ApiResponse<Dictionary<string, List<Workflow>>> GetWorkflowsWithHttpInfo(CorrelationIdsSearchRequest body, bool? includeClosed = null, bool? includeTasks = null);
        /// <summary>
        /// Lists workflows for the given correlation id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="correlationId"></param>
        /// <param name="includeClosed"> (optional, default to false)</param>
        /// <param name="includeTasks"> (optional, default to false)</param>
        /// <returns>List&lt;Workflow&gt;</returns>
        List<Workflow> GetWorkflows(string name, string correlationId, bool? includeClosed = null, bool? includeTasks = null);

        /// <summary>
        /// Lists workflows for the given correlation id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="correlationId"></param>
        /// <param name="includeClosed"> (optional, default to false)</param>
        /// <param name="includeTasks"> (optional, default to false)</param>
        /// <returns>ApiResponse of List&lt;Workflow&gt;</returns>
        ApiResponse<List<Workflow>> GetWorkflowsWithHttpInfo(string name, string correlationId, bool? includeClosed = null, bool? includeTasks = null);
        /// <summary>
        /// Pauses the workflow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <returns></returns>
        void PauseWorkflow(string workflowId);

        /// <summary>
        /// Pauses the workflow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PauseWorkflowWithHttpInfo(string workflowId);
        /// <summary>
        /// Jump workflow execution to given task
        /// </summary>
        /// <remarks>
        /// Jump workflow execution to given task.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input"></param>
        /// <param name="workflowId"></param>
        /// <param name="taskReferenceName"> (optional)</param>
        /// <returns></returns>
        void JumpToTask(string workflowId, Dictionary<string, Object> input, string taskReferenceName = null);

        /// <summary>
        /// Jump workflow execution to given task
        /// </summary>
        /// <remarks>
        /// Jump workflow execution to given task.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="workflowId"></param>
        /// <param name="taskReferenceName"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> JumpToTaskWithHttpInfo(Dictionary<string, Object> body, string workflowId, string taskReferenceName = null);

        /// <summary>
        /// Reruns the workflow from a specific task
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="workflowId"></param>
        /// <returns>string</returns>
        string Rerun(RerunWorkflowRequest body, string workflowId);

        /// <summary>
        /// Reruns the workflow from a specific task
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="workflowId"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RerunWithHttpInfo(RerunWorkflowRequest body, string workflowId);
        /// <summary>
        /// Resets callback times of all non-terminal SIMPLE tasks to 0
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <returns></returns>
        void ResetWorkflow(string workflowId);

        /// <summary>
        /// Resets callback times of all non-terminal SIMPLE tasks to 0
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ResetWorkflowWithHttpInfo(string workflowId);
        /// <summary>
        /// Restarts a completed workflow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="useLatestDefinitions"> (optional, default to false)</param>
        /// <returns></returns>
        void Restart(string workflowId, bool? useLatestDefinitions = null);

        /// <summary>
        /// Restarts a completed workflow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="useLatestDefinitions"> (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RestartWithHttpInfo(string workflowId, bool? useLatestDefinitions = null);
        /// <summary>
        /// Resumes the workflow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <returns></returns>
        void ResumeWorkflow(string workflowId);

        /// <summary>
        /// Resumes the workflow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ResumeWorkflowWithHttpInfo(string workflowId);
        /// <summary>
        /// Retries the last failed task
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="resumeSubworkflowTasks"> (optional, default to false)</param>
        /// <returns></returns>
        void Retry(string workflowId, bool? resumeSubworkflowTasks = null);

        /// <summary>
        /// Retries the last failed task
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="resumeSubworkflowTasks"> (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RetryWithHttpInfo(string workflowId, bool? resumeSubworkflowTasks = null);
        /// <summary>
        /// Search for workflows based on payload and other parameters
        /// </summary>
        /// <remarks>
        /// use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC.
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"> (optional)</param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <param name="skipCache"> (optional, default to false)</param>
        /// <returns>ScrollableSearchResultWorkflowSummary</returns>
        ScrollableSearchResultWorkflowSummary Search(string queryId = null, int? start = null, int? size = null, string sort = null, string freeText = null, string query = null, bool? skipCache = null);

        /// <summary>
        /// Search for workflows based on payload and other parameters
        /// </summary>
        /// <remarks>
        /// use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC.
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"> (optional)</param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <param name="skipCache"> (optional, default to false)</param>
        /// <returns>ApiResponse of ScrollableSearchResultWorkflowSummary</returns>
        ApiResponse<ScrollableSearchResultWorkflowSummary> SearchWithHttpInfo(string queryId = null, int? start = null, int? size = null, string sort = null, string freeText = null, string query = null, bool? skipCache = null);
        /// <summary>
        /// Search for workflows based on payload and other parameters
        /// </summary>
        /// <remarks>
        /// use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC.
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>SearchResultWorkflow</returns>
        SearchResultWorkflow SearchV2(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null);

        /// <summary>
        /// Search for workflows based on payload and other parameters
        /// </summary>
        /// <remarks>
        /// use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC.
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>ApiResponse of SearchResultWorkflow</returns>
        ApiResponse<SearchResultWorkflow> SearchV2WithHttpInfo(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null);
        /// <summary>
        /// Search for workflows based on task parameters
        /// </summary>
        /// <remarks>
        /// use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>SearchResultWorkflowSummary</returns>
        SearchResultWorkflowSummary SearchWorkflowsByTasks(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null);

        /// <summary>
        /// Search for workflows based on task parameters
        /// </summary>
        /// <remarks>
        /// use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>ApiResponse of SearchResultWorkflowSummary</returns>
        ApiResponse<SearchResultWorkflowSummary> SearchWorkflowsByTasksWithHttpInfo(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null);
        /// <summary>
        /// Search for workflows based on task parameters
        /// </summary>
        /// <remarks>
        /// use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>SearchResultWorkflow</returns>
        SearchResultWorkflow SearchWorkflowsByTasksV2(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null);

        /// <summary>
        /// Search for workflows based on task parameters
        /// </summary>
        /// <remarks>
        /// use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>ApiResponse of SearchResultWorkflow</returns>
        ApiResponse<SearchResultWorkflow> SearchWorkflowsByTasksV2WithHttpInfo(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null);
        /// <summary>
        /// Skips a given task from a current running workflow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="taskReferenceName"></param>
        /// <param name="skipTaskRequest"></param>
        /// <returns></returns>
        void SkipTaskFromWorkflow(string workflowId, string taskReferenceName, SkipTaskRequest skipTaskRequest);

        /// <summary>
        /// Skips a given task from a current running workflow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="taskReferenceName"></param>
        /// <param name="skipTaskRequest"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SkipTaskFromWorkflowWithHttpInfo(string workflowId, string taskReferenceName, SkipTaskRequest skipTaskRequest);
        /// <summary>
        /// Start a new workflow with StartWorkflowRequest, which allows task to be executed in a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>string</returns>
        string StartWorkflow(StartWorkflowRequest body);

        /// <summary>
        /// Start a new workflow with StartWorkflowRequest, which allows task to be executed in a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> StartWorkflowWithHttpInfo(StartWorkflowRequest body);
        /// <summary>
        /// Start a new workflow. Returns the ID of the workflow instance that can be later used for tracking
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="name"></param>
        /// <param name="version"> (optional)</param>
        /// <param name="correlationId"> (optional)</param>
        /// <param name="priority"> (optional, default to 0)</param>
        /// <returns>string</returns>
        string StartWorkflow(string name, Dictionary<string, Object> body, int? version = null, string correlationId = null, int? priority = null);

        /// <summary>
        /// Start a new workflow. Returns the ID of the workflow instance that can be later used for tracking
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="name"></param>
        /// <param name="version"> (optional)</param>
        /// <param name="correlationId"> (optional)</param>
        /// <param name="priority"> (optional, default to 0)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> StartWorkflowWithHttpInfo(string name, Dictionary<string, Object> body, int? version = null, string correlationId = null, int? priority = null);
        /// <summary>
        /// Terminate workflow execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="reason"> (optional)</param>
        /// <param name="triggerFailureWorkflow"> (optional, default to false)</param>
        /// <returns></returns>
        void Terminate(string workflowId, string reason = null, bool? triggerFailureWorkflow = null);

        /// <summary>
        /// Terminate workflow execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="reason"> (optional)</param>
        /// <param name="triggerFailureWorkflow"> (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TerminateWithHttpInfo(string workflowId, string reason = null, bool? triggerFailureWorkflow = null);
        /// <summary>
        /// Test workflow execution using mock data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Workflow</returns>
        Workflow TestWorkflow(WorkflowTestRequest body);

        /// <summary>
        /// Test workflow execution using mock data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Workflow</returns>
        ApiResponse<Workflow> TestWorkflowWithHttpInfo(WorkflowTestRequest body);
        /// <summary>
        /// Force upload all completed workflows to document store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Object</returns>
        Object UploadCompletedWorkflows();

        /// <summary>
        /// Force upload all completed workflows to document store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> UploadCompletedWorkflowsWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WorkflowResourceApi : IWorkflowResourceApi
    {
        private Conductor.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowResourceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WorkflowResourceApi(String basePath)
        {
            this.Configuration = new Conductor.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Conductor.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowResourceApi"/> class
        /// </summary>
        /// <returns></returns>
        public WorkflowResourceApi()
        {
            this.Configuration = Conductor.Client.Configuration.Default;

            ExceptionFactory = Conductor.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowResourceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WorkflowResourceApi(Conductor.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Conductor.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Conductor.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Conductor.Client.Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Conductor.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Starts the decision task for a workflow 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <returns></returns>
        public void Decide(string workflowId)
        {
            DecideWithHttpInfo(workflowId);
        }

        /// <summary>
        /// Starts the decision task for a workflow 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DecideWithHttpInfo(string workflowId)
        {
            // verify the required parameter 'workflowId' is set
            if (workflowId == null)
                throw new ApiException(400, "Missing required parameter 'workflowId' when calling WorkflowResourceApi->Decide");

            var localVarPath = "/workflow/decide/{workflowId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (workflowId != null) 
                localVarPathParams.Add("workflowId", this.Configuration.ApiClient.ParameterToString(workflowId)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Decide", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Removes the workflow from the system 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="archiveWorkflow"> (optional, default to true)</param>
        /// <returns></returns>
        public void Delete(string workflowId, bool? archiveWorkflow = null)
        {
            DeleteWithHttpInfo(workflowId, archiveWorkflow);
        }

        /// <summary>
        /// Removes the workflow from the system 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="archiveWorkflow"> (optional, default to true)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWithHttpInfo(string workflowId, bool? archiveWorkflow = null)
        {
            // verify the required parameter 'workflowId' is set
            if (workflowId == null)
                throw new ApiException(400, "Missing required parameter 'workflowId' when calling WorkflowResourceApi->Delete");

            var localVarPath = "/workflow/{workflowId}/remove";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (workflowId != null) localVarPathParams.Add("workflowId", this.Configuration.ApiClient.ParameterToString(workflowId)); // path parameter
            if (archiveWorkflow != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "archiveWorkflow", archiveWorkflow)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Delete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Execute a workflow synchronously 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="requestId"></param>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="waitUntilTaskRef"> (optional)</param>
        /// <returns>WorkflowRun</returns>
        public WorkflowRun ExecuteWorkflow(StartWorkflowRequest body, string requestId, string name, int? version, string waitUntilTaskRef = null)
        {
            ApiResponse<WorkflowRun> localVarResponse = ExecuteWorkflowWithHttpInfo(body, requestId, name, version, waitUntilTaskRef);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Execute a workflow synchronously 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="requestId"></param>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="waitUntilTaskRef"> (optional)</param>
        /// <returns>ApiResponse of WorkflowRun</returns>
        public ApiResponse<WorkflowRun> ExecuteWorkflowWithHttpInfo(StartWorkflowRequest body, string requestId, string name, int? version, string waitUntilTaskRef = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkflowResourceApi->ExecuteWorkflow");
            // verify the required parameter 'requestId' is set
            if (requestId == null)
                throw new ApiException(400, "Missing required parameter 'requestId' when calling WorkflowResourceApi->ExecuteWorkflow");
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling WorkflowResourceApi->ExecuteWorkflow");
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling WorkflowResourceApi->ExecuteWorkflow");

            var localVarPath = "/workflow/execute/{name}/{version}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", this.Configuration.ApiClient.ParameterToString(name)); // path parameter
            if (version != null) localVarPathParams.Add("version", this.Configuration.ApiClient.ParameterToString(version)); // path parameter
            if (requestId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "requestId", requestId)); // query parameter
            if (waitUntilTaskRef != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "waitUntilTaskRef", waitUntilTaskRef)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExecuteWorkflow", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WorkflowRun>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (WorkflowRun)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkflowRun)));
        }

        /// <summary>
        /// Gets the workflow by workflow id 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="includeTasks"> (optional, default to true)</param>
        /// <param name="summarize"> (optional, default to false)</param>
        /// <returns>Workflow</returns>
        public Workflow GetExecutionStatus(string workflowId, bool? includeTasks = null, bool? summarize = null)
        {
            ApiResponse<Workflow> localVarResponse = GetExecutionStatusWithHttpInfo(workflowId, includeTasks, summarize);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the workflow by workflow id 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="includeTasks"> (optional, default to true)</param>
        /// <param name="summarize"> (optional, default to false)</param>
        /// <returns>ApiResponse of Workflow</returns>
        public ApiResponse<Workflow> GetExecutionStatusWithHttpInfo(string workflowId, bool? includeTasks = null, bool? summarize = null)
        {
            // verify the required parameter 'workflowId' is set
            if (workflowId == null)
                throw new ApiException(400, "Missing required parameter 'workflowId' when calling WorkflowResourceApi->GetExecutionStatus");

            var localVarPath = "/workflow/{workflowId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (workflowId != null) localVarPathParams.Add("workflowId", this.Configuration.ApiClient.ParameterToString(workflowId)); // path parameter
            if (includeTasks != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "includeTasks", includeTasks)); // query parameter
            if (summarize != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "summarize", summarize)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetExecutionStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Workflow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Workflow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workflow)));
        }

        /// <summary>
        /// Gets the workflow tasks by workflow id 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 15)</param>
        /// <param name="status"> (optional)</param>
        /// <returns>TaskListSearchResultSummary</returns>
        public TaskListSearchResultSummary GetExecutionStatusTaskList(string workflowId, int? start = null, int? count = null, string status = null)
        {
            ApiResponse<TaskListSearchResultSummary> localVarResponse = GetExecutionStatusTaskListWithHttpInfo(workflowId, start, count, status);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the workflow tasks by workflow id 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 15)</param>
        /// <param name="status"> (optional)</param>
        /// <returns>ApiResponse of TaskListSearchResultSummary</returns>
        public ApiResponse<TaskListSearchResultSummary> GetExecutionStatusTaskListWithHttpInfo(string workflowId, int? start = null, int? count = null, string status = null)
        {
            // verify the required parameter 'workflowId' is set
            if (workflowId == null)
                throw new ApiException(400, "Missing required parameter 'workflowId' when calling WorkflowResourceApi->GetExecutionStatusTaskList");

            var localVarPath = "/workflow/{workflowId}/tasks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (workflowId != null) localVarPathParams.Add("workflowId", this.Configuration.ApiClient.ParameterToString(workflowId)); // path parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (count != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (status != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetExecutionStatusTaskList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TaskListSearchResultSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (TaskListSearchResultSummary)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaskListSearchResultSummary)));
        }

        /// <summary>
        /// Get the uri and path of the external storage where the workflow payload is to be stored 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path"></param>
        /// <param name="operation"></param>
        /// <param name="payloadType"></param>
        /// <returns>ExternalStorageLocation</returns>
        public ExternalStorageLocation GetExternalStorageLocation(string path, string operation, string payloadType)
        {
            ApiResponse<ExternalStorageLocation> localVarResponse = GetExternalStorageLocationWithHttpInfo(path, operation, payloadType);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the uri and path of the external storage where the workflow payload is to be stored 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path"></param>
        /// <param name="operation"></param>
        /// <param name="payloadType"></param>
        /// <returns>ApiResponse of ExternalStorageLocation</returns>
        public ApiResponse<ExternalStorageLocation> GetExternalStorageLocationWithHttpInfo(string path, string operation, string payloadType)
        {
            // verify the required parameter 'path' is set
            if (path == null)
                throw new ApiException(400, "Missing required parameter 'path' when calling WorkflowResourceApi->GetExternalStorageLocation");
            // verify the required parameter 'operation' is set
            if (operation == null)
                throw new ApiException(400, "Missing required parameter 'operation' when calling WorkflowResourceApi->GetExternalStorageLocation");
            // verify the required parameter 'payloadType' is set
            if (payloadType == null)
                throw new ApiException(400, "Missing required parameter 'payloadType' when calling WorkflowResourceApi->GetExternalStorageLocation");

            var localVarPath = "/workflow/externalstoragelocation";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (path != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "path", path)); // query parameter
            if (operation != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "operation", operation)); // query parameter
            if (payloadType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "payloadType", payloadType)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetExternalStorageLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ExternalStorageLocation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ExternalStorageLocation)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalStorageLocation)));
        }

        /// <summary>
        /// Retrieve all the running workflows 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="version"> (optional, default to 1)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> GetRunningWorkflow(string name, int? version = null, long? startTime = null, long? endTime = null)
        {
            ApiResponse<List<string>> localVarResponse = GetRunningWorkflowWithHttpInfo(name, version, startTime, endTime);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve all the running workflows 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="version"> (optional, default to 1)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse<List<string>> GetRunningWorkflowWithHttpInfo(string name, int? version = null, long? startTime = null, long? endTime = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling WorkflowResourceApi->GetRunningWorkflow");

            var localVarPath = "/workflow/running/{name}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", this.Configuration.ApiClient.ParameterToString(name)); // path parameter
            if (version != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "version", version)); // query parameter
            if (startTime != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "startTime", startTime)); // query parameter
            if (endTime != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "endTime", endTime)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRunningWorkflow", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<string>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
        }

        /// <summary>
        /// Gets the workflow by workflow id 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="includeOutput"> (optional, default to false)</param>
        /// <param name="includeVariables"> (optional, default to false)</param>
        /// <returns>WorkflowStatus</returns>
        public WorkflowStatus GetWorkflowStatusSummary(string workflowId, bool? includeOutput = null, bool? includeVariables = null)
        {
            ApiResponse<WorkflowStatus> localVarResponse = GetWorkflowStatusSummaryWithHttpInfo(workflowId, includeOutput, includeVariables);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the workflow by workflow id 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="includeOutput"> (optional, default to false)</param>
        /// <param name="includeVariables"> (optional, default to false)</param>
        /// <returns>ApiResponse of WorkflowStatus</returns>
        public ApiResponse<WorkflowStatus> GetWorkflowStatusSummaryWithHttpInfo(string workflowId, bool? includeOutput = null, bool? includeVariables = null)
        {
            // verify the required parameter 'workflowId' is set
            if (workflowId == null)
                throw new ApiException(400, "Missing required parameter 'workflowId' when calling WorkflowResourceApi->GetWorkflowStatusSummary");

            var localVarPath = "/workflow/{workflowId}/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (workflowId != null) localVarPathParams.Add("workflowId", this.Configuration.ApiClient.ParameterToString(workflowId)); // path parameter
            if (includeOutput != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "includeOutput", includeOutput)); // query parameter
            if (includeVariables != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "includeVariables", includeVariables)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWorkflowStatusSummary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WorkflowStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (WorkflowStatus)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkflowStatus)));
        }

        /// <summary>
        /// Lists workflows for the given correlation id list 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="name"></param>
        /// <param name="includeClosed"> (optional, default to false)</param>
        /// <param name="includeTasks"> (optional, default to false)</param>
        /// <returns>Dictionary&lt;string, List&lt;Workflow&gt;&gt;</returns>
        public Dictionary<string, List<Workflow>> GetWorkflows(List<string> body, string name, bool? includeClosed = null, bool? includeTasks = null)
        {
            ApiResponse<Dictionary<string, List<Workflow>>> localVarResponse = GetWorkflowsWithHttpInfo(body, name, includeClosed, includeTasks);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Lists workflows for the given correlation id list 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="name"></param>
        /// <param name="includeClosed"> (optional, default to false)</param>
        /// <param name="includeTasks"> (optional, default to false)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;Workflow&gt;&gt;</returns>
        public ApiResponse<Dictionary<string, List<Workflow>>> GetWorkflowsWithHttpInfo(List<string> body, string name, bool? includeClosed = null, bool? includeTasks = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkflowResourceApi->GetWorkflows");
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling WorkflowResourceApi->GetWorkflows");

            var localVarPath = "/workflow/{name}/correlated";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", this.Configuration.ApiClient.ParameterToString(name)); // path parameter
            if (includeClosed != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "includeClosed", includeClosed)); // query parameter
            if (includeTasks != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "includeTasks", includeTasks)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWorkflows", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Dictionary<string, List<Workflow>>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Dictionary<string, List<Workflow>>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, List<Workflow>>)));
        }

        /// <summary>
        /// Lists workflows for the given correlation id list and workflow name list 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="includeClosed"> (optional, default to false)</param>
        /// <param name="includeTasks"> (optional, default to false)</param>
        /// <returns>Dictionary&lt;string, List&lt;Workflow&gt;&gt;</returns>
        public Dictionary<string, List<Workflow>> GetWorkflows(CorrelationIdsSearchRequest body, bool? includeClosed = null, bool? includeTasks = null)
        {
            ApiResponse<Dictionary<string, List<Workflow>>> localVarResponse = GetWorkflowsWithHttpInfo(body, includeClosed, includeTasks);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Lists workflows for the given correlation id list and workflow name list 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="includeClosed"> (optional, default to false)</param>
        /// <param name="includeTasks"> (optional, default to false)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;Workflow&gt;&gt;</returns>
        public ApiResponse<Dictionary<string, List<Workflow>>> GetWorkflowsWithHttpInfo(CorrelationIdsSearchRequest body, bool? includeClosed = null, bool? includeTasks = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkflowResourceApi->GetWorkflows");

            var localVarPath = "/workflow/correlated/batch";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (includeClosed != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "includeClosed", includeClosed)); // query parameter
            if (includeTasks != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "includeTasks", includeTasks)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWorkflows", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Dictionary<string, List<Workflow>>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Dictionary<string, List<Workflow>>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, List<Workflow>>)));
        }

        /// <summary>
        /// Lists workflows for the given correlation id 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="correlationId"></param>
        /// <param name="includeClosed"> (optional, default to false)</param>
        /// <param name="includeTasks"> (optional, default to false)</param>
        /// <returns>List&lt;Workflow&gt;</returns>
        public List<Workflow> GetWorkflows(string name, string correlationId, bool? includeClosed = null, bool? includeTasks = null)
        {
            ApiResponse<List<Workflow>> localVarResponse = GetWorkflowsWithHttpInfo(name, correlationId, includeClosed, includeTasks);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Lists workflows for the given correlation id 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="correlationId"></param>
        /// <param name="includeClosed"> (optional, default to false)</param>
        /// <param name="includeTasks"> (optional, default to false)</param>
        /// <returns>ApiResponse of List&lt;Workflow&gt;</returns>
        public ApiResponse<List<Workflow>> GetWorkflowsWithHttpInfo(string name, string correlationId, bool? includeClosed = null, bool? includeTasks = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling WorkflowResourceApi->GetWorkflows");
            // verify the required parameter 'correlationId' is set
            if (correlationId == null)
                throw new ApiException(400, "Missing required parameter 'correlationId' when calling WorkflowResourceApi->GetWorkflows");

            var localVarPath = "/workflow/{name}/correlated/{correlationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", this.Configuration.ApiClient.ParameterToString(name)); // path parameter
            if (correlationId != null) localVarPathParams.Add("correlationId", this.Configuration.ApiClient.ParameterToString(correlationId)); // path parameter
            if (includeClosed != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "includeClosed", includeClosed)); // query parameter
            if (includeTasks != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "includeTasks", includeTasks)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWorkflows", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Workflow>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<Workflow>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Workflow>)));
        }

        /// <summary>
        /// Pauses the workflow 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <returns></returns>
        public void PauseWorkflow(string workflowId)
        {
            PauseWorkflowWithHttpInfo(workflowId);
        }

        /// <summary>
        /// Pauses the workflow 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PauseWorkflowWithHttpInfo(string workflowId)
        {
            // verify the required parameter 'workflowId' is set
            if (workflowId == null)
                throw new ApiException(400, "Missing required parameter 'workflowId' when calling WorkflowResourceApi->PauseWorkflow");

            var localVarPath = "/workflow/{workflowId}/pause";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (workflowId != null) localVarPathParams.Add("workflowId", this.Configuration.ApiClient.ParameterToString(workflowId)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PauseWorkflow", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }


        /// <summary>
        /// Jump workflow execution to given task Jump workflow execution to given task.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input"></param>
        /// <param name="workflowId"></param>
        /// <param name="taskReferenceName"> (optional)</param>
        /// <returns></returns>
        public void JumpToTask(string workflowId, Dictionary<string, Object> input, string taskReferenceName = null)
        {
            JumpToTaskWithHttpInfo(input, workflowId, taskReferenceName);
        }


        /// <summary>
        /// Jump workflow execution to given task Jump workflow execution to given task.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="workflowId"></param>
        /// <param name="taskReferenceName"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> JumpToTaskWithHttpInfo(Dictionary<string, Object> body, string workflowId, string taskReferenceName = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling WorkflowResourceApi->JumpToTask");
            // verify the required parameter 'workflowId' is set
            if (workflowId == null)
                throw new ApiException(400, "Missing required parameter 'workflowId' when calling WorkflowResourceApi->JumpToTask");

            var localVarPath = "/workflow/{workflowId}/jump/{taskReferenceName}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (workflowId != null) localVarPathParams.Add("workflowId", this.Configuration.ApiClient.ParameterToString(workflowId)); // path parameter
            if (taskReferenceName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "taskReferenceName", taskReferenceName)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("JumpToTask", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }


        /// <summary>
        /// Reruns the workflow from a specific task 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="workflowId"></param>
        /// <returns>string</returns>
        public string Rerun(RerunWorkflowRequest body, string workflowId)
        {
            ApiResponse<string> localVarResponse = RerunWithHttpInfo(body, workflowId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Reruns the workflow from a specific task 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="workflowId"></param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse<string> RerunWithHttpInfo(RerunWorkflowRequest body, string workflowId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkflowResourceApi->Rerun");
            // verify the required parameter 'workflowId' is set
            if (workflowId == null)
                throw new ApiException(400, "Missing required parameter 'workflowId' when calling WorkflowResourceApi->Rerun");

            var localVarPath = "/workflow/{workflowId}/rerun";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (workflowId != null) localVarPathParams.Add("workflowId", this.Configuration.ApiClient.ParameterToString(workflowId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Rerun", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (string)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Resets callback times of all non-terminal SIMPLE tasks to 0 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <returns></returns>
        public void ResetWorkflow(string workflowId)
        {
            ResetWorkflowWithHttpInfo(workflowId);
        }

        /// <summary>
        /// Resets callback times of all non-terminal SIMPLE tasks to 0 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ResetWorkflowWithHttpInfo(string workflowId)
        {
            // verify the required parameter 'workflowId' is set
            if (workflowId == null)
                throw new ApiException(400, "Missing required parameter 'workflowId' when calling WorkflowResourceApi->ResetWorkflow");

            var localVarPath = "/workflow/{workflowId}/resetcallbacks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (workflowId != null) localVarPathParams.Add("workflowId", this.Configuration.ApiClient.ParameterToString(workflowId)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ResetWorkflow", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Restarts a completed workflow 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="useLatestDefinitions"> (optional, default to false)</param>
        /// <returns></returns>
        public void Restart(string workflowId, bool? useLatestDefinitions = null)
        {
            RestartWithHttpInfo(workflowId, useLatestDefinitions);
        }

        /// <summary>
        /// Restarts a completed workflow 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="useLatestDefinitions"> (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RestartWithHttpInfo(string workflowId, bool? useLatestDefinitions = null)
        {
            // verify the required parameter 'workflowId' is set
            if (workflowId == null)
                throw new ApiException(400, "Missing required parameter 'workflowId' when calling WorkflowResourceApi->Restart");

            var localVarPath = "/workflow/{workflowId}/restart";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (workflowId != null) localVarPathParams.Add("workflowId", this.Configuration.ApiClient.ParameterToString(workflowId)); // path parameter
            if (useLatestDefinitions != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "useLatestDefinitions", useLatestDefinitions)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Restart", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Resumes the workflow 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <returns></returns>
        public void ResumeWorkflow(string workflowId)
        {
            ResumeWorkflowWithHttpInfo(workflowId);
        }

        /// <summary>
        /// Resumes the workflow 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ResumeWorkflowWithHttpInfo(string workflowId)
        {
            // verify the required parameter 'workflowId' is set
            if (workflowId == null)
                throw new ApiException(400, "Missing required parameter 'workflowId' when calling WorkflowResourceApi->ResumeWorkflow");

            var localVarPath = "/workflow/{workflowId}/resume";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (workflowId != null) localVarPathParams.Add("workflowId", this.Configuration.ApiClient.ParameterToString(workflowId)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ResumeWorkflow", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Retries the last failed task 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="resumeSubworkflowTasks"> (optional, default to false)</param>
        /// <returns></returns>
        public void Retry(string workflowId, bool? resumeSubworkflowTasks = null)
        {
            RetryWithHttpInfo(workflowId, resumeSubworkflowTasks);
        }

        /// <summary>
        /// Retries the last failed task 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="resumeSubworkflowTasks"> (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RetryWithHttpInfo(string workflowId, bool? resumeSubworkflowTasks = null)
        {
            // verify the required parameter 'workflowId' is set
            if (workflowId == null)
                throw new ApiException(400, "Missing required parameter 'workflowId' when calling WorkflowResourceApi->Retry");

            var localVarPath = "/workflow/{workflowId}/retry";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (workflowId != null) localVarPathParams.Add("workflowId", this.Configuration.ApiClient.ParameterToString(workflowId)); // path parameter
            if (resumeSubworkflowTasks != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "resumeSubworkflowTasks", resumeSubworkflowTasks)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Retry", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Search for workflows based on payload and other parameters use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC.
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"> (optional)</param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <param name="skipCache"> (optional, default to false)</param>
        /// <returns>ScrollableSearchResultWorkflowSummary</returns>
        public ScrollableSearchResultWorkflowSummary Search(string queryId = null, int? start = null, int? size = null, string sort = null, string freeText = null, string query = null, bool? skipCache = null)
        {
            ApiResponse<ScrollableSearchResultWorkflowSummary> localVarResponse = SearchWithHttpInfo(queryId, start, size, sort, freeText, query, skipCache);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search for workflows based on payload and other parameters use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC.
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"> (optional)</param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <param name="skipCache"> (optional, default to false)</param>
        /// <returns>ApiResponse of ScrollableSearchResultWorkflowSummary</returns>
        public ApiResponse<ScrollableSearchResultWorkflowSummary> SearchWithHttpInfo(string queryId = null, int? start = null, int? size = null, string sort = null, string freeText = null, string query = null, bool? skipCache = null)
        {

            var localVarPath = "/workflow/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (queryId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "queryId", queryId)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (size != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "size", size)); // query parameter
            if (sort != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort", sort)); // query parameter
            if (freeText != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "freeText", freeText)); // query parameter
            if (query != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter
            if (skipCache != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "skipCache", skipCache)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ScrollableSearchResultWorkflowSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ScrollableSearchResultWorkflowSummary)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScrollableSearchResultWorkflowSummary)));
        }

        /// <summary>
        /// Search for workflows based on payload and other parameters use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC.
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>SearchResultWorkflow</returns>
        public SearchResultWorkflow SearchV2(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null)
        {
            ApiResponse<SearchResultWorkflow> localVarResponse = SearchV2WithHttpInfo(start, size, sort, freeText, query);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search for workflows based on payload and other parameters use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC.
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>ApiResponse of SearchResultWorkflow</returns>
        public ApiResponse<SearchResultWorkflow> SearchV2WithHttpInfo(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null)
        {

            var localVarPath = "/workflow/search-v2";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (size != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "size", size)); // query parameter
            if (sort != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort", sort)); // query parameter
            if (freeText != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "freeText", freeText)); // query parameter
            if (query != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchResultWorkflow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SearchResultWorkflow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchResultWorkflow)));
        }

        /// <summary>
        /// Search for workflows based on task parameters use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>SearchResultWorkflowSummary</returns>
        public SearchResultWorkflowSummary SearchWorkflowsByTasks(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null)
        {
            ApiResponse<SearchResultWorkflowSummary> localVarResponse = SearchWorkflowsByTasksWithHttpInfo(start, size, sort, freeText, query);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search for workflows based on task parameters use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>ApiResponse of SearchResultWorkflowSummary</returns>
        public ApiResponse<SearchResultWorkflowSummary> SearchWorkflowsByTasksWithHttpInfo(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null)
        {

            var localVarPath = "/workflow/search-by-tasks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (size != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "size", size)); // query parameter
            if (sort != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort", sort)); // query parameter
            if (freeText != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "freeText", freeText)); // query parameter
            if (query != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchWorkflowsByTasks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchResultWorkflowSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SearchResultWorkflowSummary)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchResultWorkflowSummary)));
        }

        /// <summary>
        /// Search for workflows based on task parameters use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>SearchResultWorkflow</returns>
        public SearchResultWorkflow SearchWorkflowsByTasksV2(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null)
        {
            ApiResponse<SearchResultWorkflow> localVarResponse = SearchWorkflowsByTasksV2WithHttpInfo(start, size, sort, freeText, query);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search for workflows based on task parameters use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>ApiResponse of SearchResultWorkflow</returns>
        public ApiResponse<SearchResultWorkflow> SearchWorkflowsByTasksV2WithHttpInfo(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null)
        {

            var localVarPath = "/workflow/search-by-tasks-v2";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (size != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "size", size)); // query parameter
            if (sort != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort", sort)); // query parameter
            if (freeText != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "freeText", freeText)); // query parameter
            if (query != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchWorkflowsByTasksV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchResultWorkflow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SearchResultWorkflow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchResultWorkflow)));
        }

        /// <summary>
        /// Skips a given task from a current running workflow 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="taskReferenceName"></param>
        /// <param name="skipTaskRequest"></param>
        /// <returns></returns>
        public void SkipTaskFromWorkflow(string workflowId, string taskReferenceName, SkipTaskRequest skipTaskRequest)
        {
            SkipTaskFromWorkflowWithHttpInfo(workflowId, taskReferenceName, skipTaskRequest);
        }

        /// <summary>
        /// Skips a given task from a current running workflow 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="taskReferenceName"></param>
        /// <param name="skipTaskRequest"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SkipTaskFromWorkflowWithHttpInfo(string workflowId, string taskReferenceName, SkipTaskRequest skipTaskRequest)
        {
            // verify the required parameter 'workflowId' is set
            if (workflowId == null)
                throw new ApiException(400, "Missing required parameter 'workflowId' when calling WorkflowResourceApi->SkipTaskFromWorkflow");
            // verify the required parameter 'taskReferenceName' is set
            if (taskReferenceName == null)
                throw new ApiException(400, "Missing required parameter 'taskReferenceName' when calling WorkflowResourceApi->SkipTaskFromWorkflow");
            // verify the required parameter 'skipTaskRequest' is set
            if (skipTaskRequest == null)
                throw new ApiException(400, "Missing required parameter 'skipTaskRequest' when calling WorkflowResourceApi->SkipTaskFromWorkflow");

            var localVarPath = "/workflow/{workflowId}/skiptask/{taskReferenceName}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (workflowId != null) localVarPathParams.Add("workflowId", this.Configuration.ApiClient.ParameterToString(workflowId)); // path parameter
            if (taskReferenceName != null) localVarPathParams.Add("taskReferenceName", this.Configuration.ApiClient.ParameterToString(taskReferenceName)); // path parameter
            if (skipTaskRequest != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "skipTaskRequest", skipTaskRequest)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SkipTaskFromWorkflow", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Start a new workflow with StartWorkflowRequest, which allows task to be executed in a domain 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>string</returns>
        public string StartWorkflow(StartWorkflowRequest body)
        {
            ApiResponse<string> localVarResponse = StartWorkflowWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start a new workflow with StartWorkflowRequest, which allows task to be executed in a domain 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse<string> StartWorkflowWithHttpInfo(StartWorkflowRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkflowResourceApi->StartWorkflow");

            var localVarPath = "/workflow";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("StartWorkflow", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (string)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Start a new workflow. Returns the ID of the workflow instance that can be later used for tracking 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="name"></param>
        /// <param name="version"> (optional)</param>
        /// <param name="correlationId"> (optional)</param>
        /// <param name="priority"> (optional, default to 0)</param>
        /// <returns>string</returns>
        public string StartWorkflow(string name, Dictionary<string, Object> body, int? version = null, string correlationId = null, int? priority = null)
        {
            ApiResponse<string> localVarResponse = StartWorkflowWithHttpInfo(name, body, version, correlationId, priority);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start a new workflow. Returns the ID of the workflow instance that can be later used for tracking 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="name"></param>
        /// <param name="version"> (optional)</param>
        /// <param name="correlationId"> (optional)</param>
        /// <param name="priority"> (optional, default to 0)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse<string> StartWorkflowWithHttpInfo(string name, Dictionary<string, Object> body, int? version = null, string correlationId = null, int? priority = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkflowResourceApi->StartWorkflow");
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling WorkflowResourceApi->StartWorkflow");

            var localVarPath = "/workflow/{name}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", this.Configuration.ApiClient.ParameterToString(name)); // path parameter
            if (version != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "version", version)); // query parameter
            if (correlationId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "correlationId", correlationId)); // query parameter
            if (priority != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "priority", priority)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("StartWorkflow", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (string)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Terminate workflow execution 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="reason"> (optional)</param>
        /// <param name="triggerFailureWorkflow"> (optional, default to false)</param>
        /// <returns></returns>
        public void Terminate(string workflowId, string reason = null, bool? triggerFailureWorkflow = null)
        {
            TerminateWithHttpInfo(workflowId, reason, triggerFailureWorkflow);
        }

        /// <summary>
        /// Terminate workflow execution 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workflowId"></param>
        /// <param name="reason"> (optional)</param>
        /// <param name="triggerFailureWorkflow"> (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TerminateWithHttpInfo(string workflowId, string reason = null, bool? triggerFailureWorkflow = null)
        {
            // verify the required parameter 'workflowId' is set
            if (workflowId == null)
                throw new ApiException(400, "Missing required parameter 'workflowId' when calling WorkflowResourceApi->Terminate");

            var localVarPath = "/workflow/{workflowId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (workflowId != null) localVarPathParams.Add("workflowId", this.Configuration.ApiClient.ParameterToString(workflowId)); // path parameter
            if (reason != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "reason", reason)); // query parameter
            if (triggerFailureWorkflow != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "triggerFailureWorkflow", triggerFailureWorkflow)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Terminate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Test workflow execution using mock data 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Workflow</returns>
        public Workflow TestWorkflow(WorkflowTestRequest body)
        {
            ApiResponse<Workflow> localVarResponse = TestWorkflowWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Test workflow execution using mock data 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Workflow</returns>
        public ApiResponse<Workflow> TestWorkflowWithHttpInfo(WorkflowTestRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkflowResourceApi->TestWorkflow");

            var localVarPath = "/workflow/test";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TestWorkflow", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Workflow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Workflow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workflow)));
        }

        /// <summary>
        /// Force upload all completed workflows to document store 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Object</returns>
        public Object UploadCompletedWorkflows()
        {
            ApiResponse<Object> localVarResponse = UploadCompletedWorkflowsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Force upload all completed workflows to document store 
        /// </summary>
        /// <exception cref="Conductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse<Object> UploadCompletedWorkflowsWithHttpInfo()
        {

            var localVarPath = "/workflow/document-store/upload";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UploadCompletedWorkflows", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }
    }
}
