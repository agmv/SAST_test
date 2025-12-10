namespace ssRuntimeDestroyer;

public partial class Actions {
/// <summary>
/// Action <code>RunFunctionTests</code> that represents the Service Studio action
///  <code>RunFunctionTests</code> <p> Description: </p>
/// </summary>
public static async Task ActionRunFunctionTests(IRequestContext requestContext,CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RunFunctionTests", "21d3e640-37ba-433a-8e1a-4b0aa344c0ce", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669") : null){
// AssertTrueFunction
await Actions.ActionAssertTrue(requestContext,((await Functions.ActionSumFunction(requestContext,1,2,3,cancellationToken))==6),"Wrong result returned from SumFunction",cancellationToken);

// AssertTrueLibFunction
await Actions.ActionAssertTrue(requestContext,((await Functions.ActionGetMethodFunction(requestContext,"GET",cancellationToken))=="GET"),"Lib function returned wrong value",cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionRunFunctionTests {



}


}
