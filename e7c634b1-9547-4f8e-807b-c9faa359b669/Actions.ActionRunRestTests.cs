namespace ssRuntimeDestroyer;

public partial class Actions {
public class lcvRunRestTests : VarsBag {
public string inParamPort;
/// <summary>
/// Variable <code>RestHttpRequest</code> that represents the Service Studio HttpRequestStruct
///  <code>RestHttpRequest</code> <p>Description: </p>
/// </summary>
public ST_34ce93e9f60ca0d98b2e231b96135f86Structure varLcRestHttpRequest = new ST_34ce93e9f60ca0d98b2e231b96135f86Structure();

public RL_45cdd2ed99a529499c43ca5937e1be14 resGetEmptyAfterDelete_outParamResponse = new RL_45cdd2ed99a529499c43ca5937e1be14();

public RL_45cdd2ed99a529499c43ca5937e1be14 resGetEmpty_outParamResponse = new RL_45cdd2ed99a529499c43ca5937e1be14();

public RL_45cdd2ed99a529499c43ca5937e1be14 resGetPostMethod_outParamResponse = new RL_45cdd2ed99a529499c43ca5937e1be14();

public RL_45cdd2ed99a529499c43ca5937e1be14 resGetPutMethod_outParamResponse = new RL_45cdd2ed99a529499c43ca5937e1be14();

public lcvRunRestTests(string inParamPort) {
this.inParamPort = inParamPort;
}
}
/// <summary>
/// Action <code>RunRestTests</code> that represents the Service Studio action
///  <code>RunRestTests</code> <p> Description: </p>
/// </summary>
public static async Task ActionRunRestTests(IRequestContext requestContext,string inParamPort,CancellationToken cancellationToken) {
lcvRunRestTests localVars = new lcvRunRestTests(inParamPort);
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RunRestTests", "8582eb56-7bf6-4d8a-9e4e-29a8a55dcd13", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669") : null){
// GetEmpty
localVars.resGetEmpty_outParamResponse = await ssRuntimeDestroyer.CcTestClient.ActionGet(requestContext,"application/json",localVars.inParamPort,cancellationToken);

// AssertTrueIsEmpty
await Actions.ActionAssertTrue(requestContext,localVars.resGetEmpty_outParamResponse.Empty,"RunRestTests Empty",cancellationToken);

// RestHttpRequest
// RestHttpRequest.HttpMethod = "POST"
localVars.varLcRestHttpRequest.ssHttpMethod = "POST";
// Post
await ssRuntimeDestroyer.CcTestClient.ActionPost(requestContext,"application/json",localVars.varLcRestHttpRequest,localVars.inParamPort,cancellationToken);

// GetPostMethod
localVars.resGetPostMethod_outParamResponse = await ssRuntimeDestroyer.CcTestClient.ActionGet(requestContext,"application/json",localVars.inParamPort,cancellationToken);

// AssertTruePostMethod
await Actions.ActionAssertTrue(requestContext,(localVars.resGetPostMethod_outParamResponse.CurrentRec.ssHttpMethod=="POST"),"RunRestTests PostMethod",cancellationToken);

// RestHttpRequest
// RestHttpRequest.Id = GetPostMethod.Response.Current.Id
localVars.varLcRestHttpRequest.ssId = localVars.resGetPostMethod_outParamResponse.CurrentRec.ssId;

// RestHttpRequest.HttpMethod = "PUT"
localVars.varLcRestHttpRequest.ssHttpMethod = "PUT";
// Put
await ssRuntimeDestroyer.CcTestClient.ActionPut(requestContext,"application/json",localVars.varLcRestHttpRequest,localVars.inParamPort,cancellationToken);

// GetPutMethod
localVars.resGetPutMethod_outParamResponse = await ssRuntimeDestroyer.CcTestClient.ActionGet(requestContext,"application/json",localVars.inParamPort,cancellationToken);

// AssertTruePutMethod
await Actions.ActionAssertTrue(requestContext,((localVars.resGetPutMethod_outParamResponse.CurrentRec.ssId==localVars.resGetPostMethod_outParamResponse.CurrentRec.ssId)&&(localVars.resGetPutMethod_outParamResponse.CurrentRec.ssHttpMethod=="PUT")),"RunRestTests AssertTruePutMethod",cancellationToken);

// Delete
await ssRuntimeDestroyer.CcTestClient.ActionDelete(requestContext,BuiltInFunction.LongIntegerToText(localVars.varLcRestHttpRequest.ssId),"application/json",localVars.inParamPort,cancellationToken);

// GetEmptyAfterDelete
localVars.resGetEmptyAfterDelete_outParamResponse = await ssRuntimeDestroyer.CcTestClient.ActionGet(requestContext,"application/json",localVars.inParamPort,cancellationToken);

// AssertTrueIsEmptyAfterDelete
await Actions.ActionAssertTrue(requestContext,localVars.resGetEmptyAfterDelete_outParamResponse.Empty,"RunRestTests IsEmptyAfterDelete",cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionRunRestTests {



}


}
