namespace ssRuntimeDestroyer;

public partial class Actions {
public class lcvRunServiceActionTests : VarsBag {
public string resGetDay_outParamWeekday = "";

public lcvRunServiceActionTests() {
}
}
/// <summary>
/// Action <code>RunServiceActionTests</code> that represents the Service Studio action
///  <code>RunServiceActionTests</code> <p> Description: </p>
/// </summary>
public static async Task ActionRunServiceActionTests(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvRunServiceActionTests localVars = new lcvRunServiceActionTests();
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RunServiceActionTests", "9e1e7ddf-98ce-4d3c-85f7-acd3d7a603f6", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669") : null){
// GetDay
localVars.resGetDay_outParamWeekday = await ServiceAPIs.ServiceAPIGetDay(requestContext,3,cancellationToken);

// AssertTrue
await Actions.ActionAssertTrue(requestContext,(localVars.resGetDay_outParamWeekday=="Wednesday"),"Wrong weekday returned",cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionRunServiceActionTests {



}


}
