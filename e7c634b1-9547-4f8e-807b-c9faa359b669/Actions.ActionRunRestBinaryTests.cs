namespace ssRuntimeDestroyer;

public partial class Actions {
public class lcvRunRestBinaryTests : VarsBag {
public string inParamPort;
public byte[] resGetExcelStatic_outParamResponse = new byte[] {};

public RL_82f541a6a3f8132f7af4a58873bc9078 resGetExcelEntity_outParamResponse = new RL_82f541a6a3f8132f7af4a58873bc9078();

public lcvRunRestBinaryTests(string inParamPort) {
this.inParamPort = inParamPort;
}
}
/// <summary>
/// Action <code>RunRestBinaryTests</code> that represents the Service Studio action
///  <code>RunRestBinaryTests</code> <p> Description: </p>
/// </summary>
public static async Task ActionRunRestBinaryTests(IRequestContext requestContext,string inParamPort,CancellationToken cancellationToken) {
lcvRunRestBinaryTests localVars = new lcvRunRestBinaryTests(inParamPort);
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RunRestBinaryTests", "6f97a12c-4856-45f7-a7c6-346daaf49dac", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669") : null){
// GetExcelStatic
localVars.resGetExcelStatic_outParamResponse = await ssRuntimeDestroyer.CcTestClient.ActionGetExcelStatic(requestContext,"application/octet-stream",localVars.inParamPort,cancellationToken);

// AssertTrueIsEmpty
await Actions.ActionAssertTrue(requestContext,!(BuiltInFunction.AreBinaryNulls(localVars.resGetExcelStatic_outParamResponse, BuiltInFunction.NullBinary ())),"Excel Empty",cancellationToken);

// PostExcel
await ssRuntimeDestroyer.CcTestClient.ActionPostExcel(requestContext,"application/octet-stream",localVars.resGetExcelStatic_outParamResponse,localVars.inParamPort,cancellationToken);

// GetExcelEntity
localVars.resGetExcelEntity_outParamResponse = await ssRuntimeDestroyer.CcTestClient.ActionGetExcelEntity(requestContext,"application/json",localVars.inParamPort,cancellationToken);

// AssertTrueGetExcelEntityMethod
await Actions.ActionAssertTrue(requestContext,(!localVars.resGetExcelEntity_outParamResponse.Empty),"RunRestTests PostMethod",cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionRunRestBinaryTests {



}


}
