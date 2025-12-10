namespace ssRuntimeDestroyerLib;

public partial class Actions {
public class lcvRunActionTests : VarsBag {
public Actions.lcoActionWithInputs resActionWithInputs =  new Actions.lcoActionWithInputs();
public Actions.lcoFibonacciRecursive resFibonacciRecursive =  new Actions.lcoFibonacciRecursive();
public Actions.lcoActionWithOutputs resActionWithOutputs =  new Actions.lcoActionWithOutputs();
public lcvRunActionTests() {
}
}
/// <summary>
/// Action <code>RunActionTests</code> that represents the Service Studio action
///  <code>RunActionTests</code> <p> Description: </p>
/// </summary>
public static async Task ActionRunActionTests(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvRunActionTests localVars = new lcvRunActionTests();
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RunActionTests", "cf6d641d-5678-4c93-ab60-d94a67505420", "RuntimeDestroyerLib", "70e88f84-20c0-496b-bde5-9831530a09d3") : null){
// FibonacciRecursive
localVars.resFibonacciRecursive.outParamResult = await Actions.ActionFibonacciRecursive(requestContext,9,cancellationToken);

// FibonacciRecursiveAssertAreEqual
await Actions.ActionAssertAreEqual(requestContext,Convert.ToInt64(34),localVars.resFibonacciRecursive.outParamResult,"Action FibonacciRecursive",cancellationToken);

// ActionWithInputs
localVars.resActionWithInputs.outParamSum = await Actions.ActionActionWithInputs(requestContext,1,2,3,cancellationToken);

// AssertAreEqual
await Actions.ActionAssertAreEqual(requestContext,Convert.ToInt64(6),Convert.ToInt64(localVars.resActionWithInputs.outParamSum),"Wrong sum result",cancellationToken);

// ActionWithOutputs
(localVars.resActionWithOutputs.outParamOut1,localVars.resActionWithOutputs.outParamOut2,localVars.resActionWithOutputs.outParamOut3) = await Actions.ActionActionWithOutputs(requestContext,cancellationToken);

// ActionWithOutputs1AssertTrue
await Actions.ActionAssertTrue(requestContext,(localVars.resActionWithOutputs.outParamOut1=="First output parameter"),"First output parameter had wrong value",cancellationToken);

// ActionWithOutputs2AssertTrue
await Actions.ActionAssertTrue(requestContext,(localVars.resActionWithOutputs.outParamOut2==11),"Second output parameter had wrong value",cancellationToken);

// ActionWithOutputs3AssertTrue
await Actions.ActionAssertTrue(requestContext,(localVars.resActionWithOutputs.outParamOut3==(new DateTime (2001, 11, 14, 0, 0, 0, DateTimeKind.Utc))),"Third output parameter had wrong value",cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionRunActionTests {



}


}
