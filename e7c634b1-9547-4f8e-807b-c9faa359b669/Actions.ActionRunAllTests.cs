namespace ssRuntimeDestroyer;

public partial class Actions {
public class lcvRunAllTests : VarsBag {
public string inParamPort;
public lcvRunAllTests(string inParamPort) {
this.inParamPort = inParamPort;
}
}
/// <summary>
/// Action <code>RunAllTests</code> that represents the Service Studio action <code>RunAllTests</code>
///  <p> Description: </p>
/// </summary>
public static async Task ActionRunAllTests(IRequestContext requestContext,string inParamPort,CancellationToken cancellationToken) {
lcvRunAllTests localVars = new lcvRunAllTests(inParamPort);
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RunAllTests", "b109e707-c8d4-464d-a63b-1a6757f9a8c6", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669") : null){
// RunBuiltinTests
await Actions.ActionRunBuiltinTests(requestContext,cancellationToken);

// RunRestTests
await Actions.ActionRunRestTests(requestContext,localVars.inParamPort,cancellationToken);

// RunRestBinaryTests
await Actions.ActionRunRestBinaryTests(requestContext,localVars.inParamPort,cancellationToken);

// RunExcelTests
await Actions.ActionRunExcelTests(requestContext,cancellationToken);

// RunJsonTests
await Actions.ActionRunJsonTests(requestContext,cancellationToken);

// RunActionTests
await Actions.ActionRunActionTests(requestContext,cancellationToken);

// RunServiceActionTests
await Actions.ActionRunServiceActionTests(requestContext,cancellationToken);

// RunExtensionTests
await Actions.ActionRunExtensionTests(requestContext,cancellationToken);

// RunFunctionTests
await Actions.ActionRunFunctionTests(requestContext,cancellationToken);

// RunAdvancedQueryTests
await Actions.ActionRunAdvancedQueryTests(requestContext,cancellationToken);

// RunExpressionTests
await Actions.ActionRunExpressionTests(requestContext,cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionRunAllTests {



}


}
