namespace ssRuntimeDestroyerLib;

public partial class Actions {
/// <summary>
/// Action <code>RunJsonTests</code> that represents the Service Studio action
///  <code>RunJsonTests</code> <p> Description: </p>
/// </summary>
public static async Task ActionRunJsonTests(IRequestContext requestContext,CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RunJsonTests", "f7776105-71ce-4b2b-9ba9-763de551fe57", "RuntimeDestroyerLib", "70e88f84-20c0-496b-bde5-9831530a09d3") : null){
// StructToJsonToStruct
await Actions.ActionStructToJsonToStruct(requestContext,cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionRunJsonTests {



}


}
