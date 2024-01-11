# SwiftConductor.Model.WorkflowTask

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**TaskReferenceName** | **string** |  | 
**Description** | **string** |  | [optional] 
**InputParameters** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Type** | **string** |  | [optional] 
**DynamicTaskNameParam** | **string** |  | [optional] 
**CaseValueParam** | **string** |  | [optional] 
**CaseExpression** | **string** |  | [optional] 
**ScriptExpression** | **string** |  | [optional] 
**DecisionCases** | **Dictionary&lt;string, List&lt;WorkflowTask&gt;&gt;** |  | [optional] 
**DynamicForkJoinTasksParam** | **string** |  | [optional] 
**DynamicForkTasksParam** | **string** |  | [optional] 
**DynamicForkTasksInputParamName** | **string** |  | [optional] 
**DefaultCase** | [**List&lt;WorkflowTask&gt;**](WorkflowTask.md) |  | [optional] 
**ForkTasks** | **List&lt;List&lt;WorkflowTask&gt;&gt;** |  | [optional] 
**StartDelay** | **int** |  | [optional] 
**SubWorkflowParam** | [**SubWorkflowParams**](SubWorkflowParams.md) |  | [optional] 
**JoinOn** | **List&lt;string&gt;** |  | [optional] 
**Sink** | **string** |  | [optional] 
**Optional** | **bool** |  | [optional] 
**TaskDefinition** | [**TaskDef**](TaskDef.md) |  | [optional] 
**RateLimited** | **bool** |  | [optional] 
**DefaultExclusiveJoinTask** | **List&lt;string&gt;** |  | [optional] 
**AsyncComplete** | **bool** |  | [optional] 
**LoopCondition** | **string** |  | [optional] 
**LoopOver** | [**List&lt;WorkflowTask&gt;**](WorkflowTask.md) |  | [optional] 
**RetryCount** | **int** |  | [optional] 
**EvaluatorType** | **string** |  | [optional] 
**Expression** | **string** |  | [optional] 
**WorkflowTaskType** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

