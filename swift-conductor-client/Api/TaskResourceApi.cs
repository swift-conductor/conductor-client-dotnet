using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using SwiftConductor.Client;
using SwiftConductor.Client.Models;

namespace SwiftConductor.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITaskResourceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the details about each queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Dictionary&lt;string, long?&gt;</returns>
        Dictionary<string, long?> All();

        /// <summary>
        /// Get the details about each queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Dictionary&lt;string, long?&gt;</returns>
        ApiResponse<Dictionary<string, long?>> AllWithHttpInfo();
        /// <summary>
        /// Get the details about each queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Dictionary&lt;string, Dictionary&lt;string, Dictionary&lt;string, long?&gt;&gt;&gt;</returns>
        Dictionary<string, Dictionary<string, Dictionary<string, long?>>> AllVerbose();

        /// <summary>
        /// Get the details about each queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Dictionary&lt;string, Dictionary&lt;string, Dictionary&lt;string, long?&gt;&gt;&gt;</returns>
        ApiResponse<Dictionary<string, Dictionary<string, Dictionary<string, long?>>>> AllVerboseWithHttpInfo();
        /// <summary>
        /// Batch poll for a task of a certain type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tasktype"></param>
        /// <param name="workerid"> (optional)</param>
        /// <param name="domain"> (optional)</param>
        /// <param name="count"> (optional, default to 1)</param>
        /// <param name="timeout"> (optional, default to 100)</param>
        /// <returns>List&lt;Task&gt;</returns>
        List<WorkerTask> BatchPoll(string tasktype, string workerid = null, string domain = null, int? count = null, int? timeout = null);

        /// <summary>
        /// Batch poll for a task of a certain type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tasktype"></param>
        /// <param name="workerid"> (optional)</param>
        /// <param name="domain"> (optional)</param>
        /// <param name="count"> (optional, default to 1)</param>
        /// <param name="timeout"> (optional, default to 100)</param>
        /// <returns>ApiResponse of List&lt;Task&gt;</returns>
        ApiResponse<List<WorkerTask>> BatchPollWithHttpInfo(string tasktype, string workerid = null, string domain = null, int? count = null, int? timeout = null);
        /// <summary>
        /// Get the last poll data for all task types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workerSize"> (optional)</param>
        /// <param name="workerOpt"> (optional)</param>
        /// <param name="queueSize"> (optional)</param>
        /// <param name="queueOpt"> (optional)</param>
        /// <param name="lastPollTimeSize"> (optional)</param>
        /// <param name="lastPollTimeOpt"> (optional)</param>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        Dictionary<string, Object> GetAllPollData(long? workerSize = null, string workerOpt = null, long? queueSize = null, string queueOpt = null, long? lastPollTimeSize = null, string lastPollTimeOpt = null);

        /// <summary>
        /// Get the last poll data for all task types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workerSize"> (optional)</param>
        /// <param name="workerOpt"> (optional)</param>
        /// <param name="queueSize"> (optional)</param>
        /// <param name="queueOpt"> (optional)</param>
        /// <param name="lastPollTimeSize"> (optional)</param>
        /// <param name="lastPollTimeOpt"> (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        ApiResponse<Dictionary<string, Object>> GetAllPollDataWithHttpInfo(long? workerSize = null, string workerOpt = null, long? queueSize = null, string queueOpt = null, long? lastPollTimeSize = null, string lastPollTimeOpt = null);
        /// <summary>
        /// Get the external uri where the task payload is to be stored
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path"></param>
        /// <param name="operation"></param>
        /// <param name="payloadType"></param>
        /// <returns>ExternalStorageLocation</returns>
        ExternalStorageLocation GetExternalStorageLocation(string path, string operation, string payloadType);

        /// <summary>
        /// Get the external uri where the task payload is to be stored
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path"></param>
        /// <param name="operation"></param>
        /// <param name="payloadType"></param>
        /// <returns>ApiResponse of ExternalStorageLocation</returns>
        ApiResponse<ExternalStorageLocation> GetExternalStorageLocationWithHttpInfo(string path, string operation, string payloadType);
        /// <summary>
        /// Get the last poll data for a given task type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskType"></param>
        /// <returns>List&lt;PollData&gt;</returns>
        List<PollData> GetPollData(string taskType);

        /// <summary>
        /// Get the last poll data for a given task type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskType"></param>
        /// <returns>ApiResponse of List&lt;PollData&gt;</returns>
        ApiResponse<List<PollData>> GetPollDataWithHttpInfo(string taskType);
        /// <summary>
        /// Get task by Id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>Task</returns>
        WorkerTask GetTask(string taskId);

        /// <summary>
        /// Get task by Id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>ApiResponse of Task</returns>
        ApiResponse<WorkerTask> GetTaskWithHttpInfo(string taskId);
        /// <summary>
        /// Get Task Execution Logs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>List&lt;TaskExecLog&gt;</returns>
        List<TaskExecLog> GetTaskLogs(string taskId);

        /// <summary>
        /// Get Task Execution Logs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>ApiResponse of List&lt;TaskExecLog&gt;</returns>
        ApiResponse<List<TaskExecLog>> GetTaskLogsWithHttpInfo(string taskId);
        /// <summary>
        /// Log Task Execution Details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="taskId"></param>
        /// <returns></returns>
        void Log(string body, string taskId);

        /// <summary>
        /// Log Task Execution Details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="taskId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> LogWithHttpInfo(string body, string taskId);
        /// <summary>
        /// Poll for a task of a certain type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tasktype"></param>
        /// <param name="workerid"> (optional)</param>
        /// <param name="domain"> (optional)</param>
        /// <returns>Task</returns>
        WorkerTask Poll(string tasktype, string workerid = null, string domain = null);

        /// <summary>
        /// Poll for a task of a certain type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tasktype"></param>
        /// <param name="workerid"> (optional)</param>
        /// <param name="domain"> (optional)</param>
        /// <returns>ApiResponse of Task</returns>
        ApiResponse<WorkerTask> PollWithHttpInfo(string tasktype, string workerid = null, string domain = null);
        /// <summary>
        /// Requeue pending tasks
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskType"></param>
        /// <returns>string</returns>
        string RequeuePendingTask(string taskType);

        /// <summary>
        /// Requeue pending tasks
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskType"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RequeuePendingTaskWithHttpInfo(string taskType);
        /// <summary>
        /// Search for tasks based in payload and other parameters
        /// </summary>
        /// <remarks>
        /// use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>SearchResultTaskSummary</returns>
        SearchResultTaskSummary Search(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null);

        /// <summary>
        /// Search for tasks based in payload and other parameters
        /// </summary>
        /// <remarks>
        /// use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>ApiResponse of SearchResultTaskSummary</returns>
        ApiResponse<SearchResultTaskSummary> SearchWithHttpInfo(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null);
        /// <summary>
        /// Search for tasks based in payload and other parameters
        /// </summary>
        /// <remarks>
        /// use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>SearchResultTask</returns>
        SearchResultTask SearchV2(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null);

        /// <summary>
        /// Search for tasks based in payload and other parameters
        /// </summary>
        /// <remarks>
        /// use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>ApiResponse of SearchResultTask</returns>
        ApiResponse<SearchResultTask> SearchV2WithHttpInfo(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null);
        /// <summary>
        /// Get Task type queue sizes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskType"> (optional)</param>
        /// <returns>Dictionary&lt;string, int?&gt;</returns>
        Dictionary<string, int?> Size(List<string> taskType = null);

        /// <summary>
        /// Get Task type queue sizes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskType"> (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, int?&gt;</returns>
        ApiResponse<Dictionary<string, int?>> SizeWithHttpInfo(List<string> taskType = null);
        /// <summary>
        /// Update a task
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>string</returns>
        string UpdateTask(WorkerTaskResult body);

        /// <summary>
        /// Update a task
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> UpdateTaskWithHttpInfo(WorkerTaskResult body);
        /// <summary>
        /// Update a task By Ref Name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="workflowId"></param>
        /// <param name="taskRefName"></param>
        /// <param name="status"></param>
        /// <param name="workerid"> (optional)</param>
        /// <returns>string</returns>
        string UpdateTask(Dictionary<string, Object> body, string workflowId, string taskRefName, string status, string workerid = null);

        /// <summary>
        /// Update a task By Ref Name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="workflowId"></param>
        /// <param name="taskRefName"></param>
        /// <param name="status"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> UpdateTaskWithHttpInfo(Dictionary<string, Object> body, string workflowId, string taskRefName, string status, string workerid = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TaskResourceApi : ITaskResourceApi
    {
        private SwiftConductor.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResourceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TaskResourceApi(String basePath)
        {
            this.Configuration = new SwiftConductor.Client.Configuration { BasePath = basePath };

            ExceptionFactory = SwiftConductor.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResourceApi"/> class
        /// </summary>
        /// <returns></returns>
        public TaskResourceApi()
        {
            this.Configuration = SwiftConductor.Client.Configuration.Default;

            ExceptionFactory = SwiftConductor.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResourceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TaskResourceApi(SwiftConductor.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = SwiftConductor.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = SwiftConductor.Client.Configuration.DefaultExceptionFactory;
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
        public SwiftConductor.Client.Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public SwiftConductor.Client.ExceptionFactory ExceptionFactory
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
        /// Get the details about each queue 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Dictionary&lt;string, long?&gt;</returns>
        public Dictionary<string, long?> All()
        {
            ApiResponse<Dictionary<string, long?>> localVarResponse = AllWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the details about each queue 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Dictionary&lt;string, long?&gt;</returns>
        public ApiResponse<Dictionary<string, long?>> AllWithHttpInfo()
        {

            var localVarPath = "/task/queue/all";
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("All", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Dictionary<string, long?>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Dictionary<string, long?>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, long?>)));
        }

        /// <summary>
        /// Get the details about each queue 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Dictionary&lt;string, Dictionary&lt;string, Dictionary&lt;string, long?&gt;&gt;&gt;</returns>
        public Dictionary<string, Dictionary<string, Dictionary<string, long?>>> AllVerbose()
        {
            ApiResponse<Dictionary<string, Dictionary<string, Dictionary<string, long?>>>> localVarResponse = AllVerboseWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the details about each queue 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Dictionary&lt;string, Dictionary&lt;string, Dictionary&lt;string, long?&gt;&gt;&gt;</returns>
        public ApiResponse<Dictionary<string, Dictionary<string, Dictionary<string, long?>>>> AllVerboseWithHttpInfo()
        {

            var localVarPath = "/task/queue/all/verbose";
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AllVerbose", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Dictionary<string, Dictionary<string, Dictionary<string, long?>>>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Dictionary<string, Dictionary<string, Dictionary<string, long?>>>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, Dictionary<string, Dictionary<string, long?>>>)));
        }

        /// <summary>
        /// Batch poll for a task of a certain type 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tasktype"></param>
        /// <param name="workerid"> (optional)</param>
        /// <param name="domain"> (optional)</param>
        /// <param name="count"> (optional, default to 1)</param>
        /// <param name="timeout"> (optional, default to 100)</param>
        /// <returns>List&lt;Task&gt;</returns>
        public List<WorkerTask> BatchPoll(string tasktype, string workerid = null, string domain = null, int? count = null, int? timeout = null)
        {
            ApiResponse<List<WorkerTask>> localVarResponse = BatchPollWithHttpInfo(tasktype, workerid, domain, count, timeout);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Batch poll for a task of a certain type 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tasktype"></param>
        /// <param name="workerid"> (optional)</param>
        /// <param name="domain"> (optional)</param>
        /// <param name="count"> (optional, default to 1)</param>
        /// <param name="timeout"> (optional, default to 100)</param>
        /// <returns>ApiResponse of List&lt;Task&gt;</returns>
        public ApiResponse<List<WorkerTask>> BatchPollWithHttpInfo(string tasktype, string workerid = null, string domain = null, int? count = null, int? timeout = null)
        {
            // verify the required parameter 'tasktype' is set
            if (tasktype == null)
                throw new ApiException(400, "Missing required parameter 'tasktype' when calling TaskResourceApi->BatchPoll");

            var localVarPath = "/task/poll/batch/{tasktype}";
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

            if (tasktype != null) localVarPathParams.Add("tasktype", this.Configuration.ApiClient.ParameterToString(tasktype)); // path parameter
            if (workerid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "workerid", workerid)); // query parameter
            if (domain != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "domain", domain)); // query parameter
            if (count != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (timeout != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "timeout", timeout)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BatchPoll", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<WorkerTask>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<WorkerTask>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WorkerTask>)));
        }

        /// <summary>
        /// Batch poll for a task of a certain type 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tasktype"></param>
        /// <param name="workerid"> (optional)</param>
        /// <param name="domain"> (optional)</param>
        /// <param name="count"> (optional, default to 1)</param>
        /// <param name="timeout"> (optional, default to 100)</param>
        /// <returns>Task of List&lt;Task&gt;</returns>

        /// <summary>
        /// Get the last poll data for all task types 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workerSize"> (optional)</param>
        /// <param name="workerOpt"> (optional)</param>
        /// <param name="queueSize"> (optional)</param>
        /// <param name="queueOpt"> (optional)</param>
        /// <param name="lastPollTimeSize"> (optional)</param>
        /// <param name="lastPollTimeOpt"> (optional)</param>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        public Dictionary<string, Object> GetAllPollData(long? workerSize = null, string workerOpt = null, long? queueSize = null, string queueOpt = null, long? lastPollTimeSize = null, string lastPollTimeOpt = null)
        {
            ApiResponse<Dictionary<string, Object>> localVarResponse = GetAllPollDataWithHttpInfo(workerSize, workerOpt, queueSize, queueOpt, lastPollTimeSize, lastPollTimeOpt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the last poll data for all task types 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workerSize"> (optional)</param>
        /// <param name="workerOpt"> (optional)</param>
        /// <param name="queueSize"> (optional)</param>
        /// <param name="queueOpt"> (optional)</param>
        /// <param name="lastPollTimeSize"> (optional)</param>
        /// <param name="lastPollTimeOpt"> (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        public ApiResponse<Dictionary<string, Object>> GetAllPollDataWithHttpInfo(long? workerSize = null, string workerOpt = null, long? queueSize = null, string queueOpt = null, long? lastPollTimeSize = null, string lastPollTimeOpt = null)
        {

            var localVarPath = "/task/queue/poll-data/all";
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

            if (workerSize != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "workerSize", workerSize)); // query parameter
            if (workerOpt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "workerOpt", workerOpt)); // query parameter
            if (queueSize != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "queueSize", queueSize)); // query parameter
            if (queueOpt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "queueOpt", queueOpt)); // query parameter
            if (lastPollTimeSize != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "lastPollTimeSize", lastPollTimeSize)); // query parameter
            if (lastPollTimeOpt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "lastPollTimeOpt", lastPollTimeOpt)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllPollData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Dictionary<string, Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Dictionary<string, Object>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, Object>)));
        }

        /// <summary>
        /// Get the external uri where the task payload is to be stored 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// Get the external uri where the task payload is to be stored 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path"></param>
        /// <param name="operation"></param>
        /// <param name="payloadType"></param>
        /// <returns>ApiResponse of ExternalStorageLocation</returns>
        public ApiResponse<ExternalStorageLocation> GetExternalStorageLocationWithHttpInfo(string path, string operation, string payloadType)
        {
            // verify the required parameter 'path' is set
            if (path == null)
                throw new ApiException(400, "Missing required parameter 'path' when calling TaskResourceApi->GetExternalStorageLocation");
            // verify the required parameter 'operation' is set
            if (operation == null)
                throw new ApiException(400, "Missing required parameter 'operation' when calling TaskResourceApi->GetExternalStorageLocation");
            // verify the required parameter 'payloadType' is set
            if (payloadType == null)
                throw new ApiException(400, "Missing required parameter 'payloadType' when calling TaskResourceApi->GetExternalStorageLocation");

            var localVarPath = "/task/external-storage-location";
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
        /// Get the last poll data for a given task type 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskType"></param>
        /// <returns>List&lt;PollData&gt;</returns>
        public List<PollData> GetPollData(string taskType)
        {
            ApiResponse<List<PollData>> localVarResponse = GetPollDataWithHttpInfo(taskType);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the last poll data for a given task type 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskType"></param>
        /// <returns>ApiResponse of List&lt;PollData&gt;</returns>
        public ApiResponse<List<PollData>> GetPollDataWithHttpInfo(string taskType)
        {
            // verify the required parameter 'taskType' is set
            if (taskType == null)
                throw new ApiException(400, "Missing required parameter 'taskType' when calling TaskResourceApi->GetPollData");

            var localVarPath = "/task/queue/poll-data";
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

            if (taskType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "taskType", taskType)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPollData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<PollData>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<PollData>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PollData>)));
        }

        /// <summary>
        /// Get task by Id 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>Task</returns>
        public WorkerTask GetTask(string taskId)
        {
            ApiResponse<WorkerTask> localVarResponse = GetTaskWithHttpInfo(taskId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get task by Id 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>ApiResponse of Task</returns>
        public ApiResponse<WorkerTask> GetTaskWithHttpInfo(string taskId)
        {
            // verify the required parameter 'taskId' is set
            if (taskId == null)
                throw new ApiException(400, "Missing required parameter 'taskId' when calling TaskResourceApi->GetTask");

            var localVarPath = "/task/{taskId}";
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

            if (taskId != null) localVarPathParams.Add("taskId", this.Configuration.ApiClient.ParameterToString(taskId)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTask", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WorkerTask>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (WorkerTask)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkerTask)));
        }

        /// <summary>
        /// Get Task Execution Logs 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>List&lt;TaskExecLog&gt;</returns>
        public List<TaskExecLog> GetTaskLogs(string taskId)
        {
            ApiResponse<List<TaskExecLog>> localVarResponse = GetTaskLogsWithHttpInfo(taskId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Task Execution Logs 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskId"></param>
        /// <returns>ApiResponse of List&lt;TaskExecLog&gt;</returns>
        public ApiResponse<List<TaskExecLog>> GetTaskLogsWithHttpInfo(string taskId)
        {
            // verify the required parameter 'taskId' is set
            if (taskId == null)
                throw new ApiException(400, "Missing required parameter 'taskId' when calling TaskResourceApi->GetTaskLogs");

            var localVarPath = "/task/{taskId}/log";
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

            if (taskId != null) localVarPathParams.Add("taskId", this.Configuration.ApiClient.ParameterToString(taskId)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTaskLogs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<TaskExecLog>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<TaskExecLog>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<TaskExecLog>)));
        }

        /// <summary>
        /// Log Task Execution Details 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public void Log(string body, string taskId)
        {
            LogWithHttpInfo(body, taskId);
        }

        /// <summary>
        /// Log Task Execution Details 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="taskId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> LogWithHttpInfo(string body, string taskId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskResourceApi->Log");
            // verify the required parameter 'taskId' is set
            if (taskId == null)
                throw new ApiException(400, "Missing required parameter 'taskId' when calling TaskResourceApi->Log");

            var localVarPath = "/task/{taskId}/log";
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

            if (taskId != null) localVarPathParams.Add("taskId", this.Configuration.ApiClient.ParameterToString(taskId)); // path parameter
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
                Exception exception = ExceptionFactory("Log", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Poll for a task of a certain type 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tasktype"></param>
        /// <param name="workerid"> (optional)</param>
        /// <param name="domain"> (optional)</param>
        /// <returns>Task</returns>
        public WorkerTask Poll(string tasktype, string workerid = null, string domain = null)
        {
            ApiResponse<WorkerTask> localVarResponse = PollWithHttpInfo(tasktype, workerid, domain);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Poll for a task of a certain type 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tasktype"></param>
        /// <param name="workerid"> (optional)</param>
        /// <param name="domain"> (optional)</param>
        /// <returns>ApiResponse of Task</returns>
        public ApiResponse<WorkerTask> PollWithHttpInfo(string tasktype, string workerid = null, string domain = null)
        {
            // verify the required parameter 'tasktype' is set
            if (tasktype == null)
                throw new ApiException(400, "Missing required parameter 'tasktype' when calling TaskResourceApi->Poll");

            var localVarPath = "/task/poll/{tasktype}";
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

            if (tasktype != null) localVarPathParams.Add("tasktype", this.Configuration.ApiClient.ParameterToString(tasktype)); // path parameter
            if (workerid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "workerid", workerid)); // query parameter
            if (domain != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "domain", domain)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Poll", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WorkerTask>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (WorkerTask)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkerTask)));
        }

        /// <summary>
        /// Requeue pending tasks 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskType"></param>
        /// <returns>string</returns>
        public string RequeuePendingTask(string taskType)
        {
            ApiResponse<string> localVarResponse = RequeuePendingTaskWithHttpInfo(taskType);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Requeue pending tasks 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskType"></param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse<string> RequeuePendingTaskWithHttpInfo(string taskType)
        {
            // verify the required parameter 'taskType' is set
            if (taskType == null)
                throw new ApiException(400, "Missing required parameter 'taskType' when calling TaskResourceApi->RequeuePendingTask");

            var localVarPath = "/task/queue/requeue/{taskType}";
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
                "text/plain"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (taskType != null) localVarPathParams.Add("taskType", this.Configuration.ApiClient.ParameterToString(taskType)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RequeuePendingTask", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (string)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Search for tasks based in payload and other parameters use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>SearchResultTaskSummary</returns>
        public SearchResultTaskSummary Search(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null)
        {
            ApiResponse<SearchResultTaskSummary> localVarResponse = SearchWithHttpInfo(start, size, sort, freeText, query);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search for tasks based in payload and other parameters use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>ApiResponse of SearchResultTaskSummary</returns>
        public ApiResponse<SearchResultTaskSummary> SearchWithHttpInfo(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null)
        {

            var localVarPath = "/task/search";
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
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchResultTaskSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SearchResultTaskSummary)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchResultTaskSummary)));
        }

        /// <summary>
        /// Search for tasks based in payload and other parameters use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>SearchResultTask</returns>
        public SearchResultTask SearchV2(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null)
        {
            ApiResponse<SearchResultTask> localVarResponse = SearchV2WithHttpInfo(start, size, sort, freeText, query);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search for tasks based in payload and other parameters use sort options as sort&#x3D;&lt;field&gt;:ASC|DESC e.g. sort&#x3D;name&amp;sort&#x3D;workflowId:DESC. If order is not specified, defaults to ASC
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="size"> (optional, default to 100)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="freeText"> (optional, default to *)</param>
        /// <param name="query"> (optional)</param>
        /// <returns>ApiResponse of SearchResultTask</returns>
        public ApiResponse<SearchResultTask> SearchV2WithHttpInfo(int? start = null, int? size = null, string sort = null, string freeText = null, string query = null)
        {

            var localVarPath = "/task/search-v2";
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

            return new ApiResponse<SearchResultTask>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SearchResultTask)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchResultTask)));
        }

        /// <summary>
        /// Get Task type queue sizes 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskType"> (optional)</param>
        /// <returns>Dictionary&lt;string, int?&gt;</returns>
        public Dictionary<string, int?> Size(List<string> taskType = null)
        {
            ApiResponse<Dictionary<string, int?>> localVarResponse = SizeWithHttpInfo(taskType);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Task type queue sizes 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskType"> (optional)</param>
        /// <returns>ApiResponse of Dictionary&lt;string, int?&gt;</returns>
        public ApiResponse<Dictionary<string, int?>> SizeWithHttpInfo(List<string> taskType = null)
        {

            var localVarPath = "/task/queue/sizes";
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

            if (taskType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "taskType", taskType)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Size", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Dictionary<string, int?>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Dictionary<string, int?>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, int?>)));
        }

        /// <summary>
        /// Update a task 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>string</returns>
        public string UpdateTask(WorkerTaskResult body)
        {
            ApiResponse<string> localVarResponse = UpdateTaskWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a task 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse<string> UpdateTaskWithHttpInfo(WorkerTaskResult body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskResourceApi->UpdateTask");

            var localVarPath = "/task";
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
                Exception exception = ExceptionFactory("UpdateTask", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (string)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Update a task By Ref Name 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="workflowId"></param>
        /// <param name="taskRefName"></param>
        /// <param name="status"></param>
        /// <param name="workerid"> (optional)</param>
        /// <returns>string</returns>
        public string UpdateTask(Dictionary<string, Object> body, string workflowId, string taskRefName, string status, string workerid = null)
        {
            ApiResponse<string> localVarResponse = UpdateTaskWithHttpInfo(body, workflowId, taskRefName, status, workerid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a task By Ref Name 
        /// </summary>
        /// <exception cref="SwiftConductor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="workflowId"></param>
        /// <param name="taskRefName"></param>
        /// <param name="status"></param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse<string> UpdateTaskWithHttpInfo(Dictionary<string, Object> body, string workflowId, string taskRefName, string status, string workerid = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TaskResourceApi->UpdateTask");
            // verify the required parameter 'workflowId' is set
            if (workflowId == null)
                throw new ApiException(400, "Missing required parameter 'workflowId' when calling TaskResourceApi->UpdateTask");
            // verify the required parameter 'taskRefName' is set
            if (taskRefName == null)
                throw new ApiException(400, "Missing required parameter 'taskRefName' when calling TaskResourceApi->UpdateTask");
            // verify the required parameter 'status' is set
            if (status == null)
                throw new ApiException(400, "Missing required parameter 'status' when calling TaskResourceApi->UpdateTask");

            var localVarPath = "/task/{workflowId}/{taskRefName}/{status}";
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

            if (workerid == null)
            {
                workerid = Environment.MachineName;
            }

            if (workflowId != null) localVarPathParams.Add("workflowId", this.Configuration.ApiClient.ParameterToString(workflowId)); // path parameter
            if (taskRefName != null) localVarPathParams.Add("taskRefName", this.Configuration.ApiClient.ParameterToString(taskRefName)); // path parameter
            if (status != null) localVarPathParams.Add("status", this.Configuration.ApiClient.ParameterToString(status)); // path parameter
            if (workerid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "workerid", workerid)); // query parameter
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
                Exception exception = ExceptionFactory("UpdateTask", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (string)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        // public ExternalStorageLocation GetExternalStorageLocation(string path, string operation, string payloadType)
        // {
        //     throw new NotImplementedException();
        // }

        // public ApiResponse<ExternalStorageLocation> GetExternalStorageLocationWithHttpInfo(string path, string operation, string payloadType)
        // {
        //     throw new NotImplementedException();
        // }
    }
}
