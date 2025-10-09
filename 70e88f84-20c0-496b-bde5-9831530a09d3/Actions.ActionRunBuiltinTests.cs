namespace ssRuntimeDestroyerLib;

public partial class Actions {
/// <summary>
/// Action <code>RunBuiltinTests</code> that represents the Service Studio action
///  <code>RunBuiltinTests</code> <p> Description: </p>
/// </summary>
public static async Task ActionRunBuiltinTests(IRequestContext requestContext,CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RunBuiltinTests", "043b8bb0-d1f4-4edd-9462-0a493a9d42c0", "RuntimeDestroyerLib", "70e88f84-20c0-496b-bde5-9831530a09d3") : null){
// Math
await Actions.ActionMath(requestContext,cancellationToken);

// Numeric
await Actions.ActionNumeric(requestContext,cancellationToken);

// Text
await Actions.ActionText(requestContext,cancellationToken);

// DateAndTime
await Actions.ActionDateAndTime(requestContext,cancellationToken);

// DataConversion
await Actions.ActionDataConversion(requestContext,cancellationToken);

// Format
await Actions.ActionFormat(requestContext,cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionRunBuiltinTests {



}


}
