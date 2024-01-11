# SwiftConductor.Model.WorkflowTestRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**VarVersion** | **int** |  | [optional] 
**CorrelationId** | **string** |  | [optional] 
**Input** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**TaskToDomain** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**WorkflowDef** | [**WorkflowDef**](WorkflowDef.md) |  | [optional] 
**ExternalInputPayloadStoragePath** | **string** |  | [optional] 
**Priority** | **int** |  | [optional] 
**TaskRefToMockOutput** | **Dictionary&lt;string, List&lt;TaskMock&gt;&gt;** |  | [optional] 
**SubWorkflowTestRequest** | [**Dictionary&lt;string, WorkflowTestRequest&gt;**](WorkflowTestRequest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

