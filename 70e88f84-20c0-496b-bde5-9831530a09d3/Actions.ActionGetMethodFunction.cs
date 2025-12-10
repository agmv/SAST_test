namespace ssRuntimeDestroyerLib;

public partial class Actions {
public class lcvGetMethodFunction : VarsBag {
public string inParamId;
public RC_f7a56746c7bb090f072113e146ed4d38 resGetHttpMethod_outParamRecord = new RC_f7a56746c7bb090f072113e146ed4d38();

public lcvGetMethodFunction(string inParamId) {
this.inParamId = inParamId;
}
}
public class lcoGetMethodFunction : VarsBag {
public string outParamLabel = "";

public lcoGetMethodFunction() {
}
}
/// <summary>
/// Action <code>GetMethodFunction</code> that represents the Service Studio action
///  <code>GetMethodFunction</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionGetMethodFunction(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
string outParamLabel = default;
lcoGetMethodFunction result = new lcoGetMethodFunction();
lcvGetMethodFunction localVars = new lcvGetMethodFunction(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetMethodFunction", "c7bf8a13-aec3-4ffd-847c-e188a4eb0e01", "RuntimeDestroyerLib", "70e88f84-20c0-496b-bde5-9831530a09d3") : null){
// GetHttpMethod
localVars.resGetHttpMethod_outParamRecord = await ExtendedActions.GetHttpMethod(requestContext,localVars.inParamId,cancellationToken);

// Label = GetHttpMethod.Record.HttpMethod.Label
result.outParamLabel=localVars.resGetHttpMethod_outParamRecord.ssENHttpMethod.ssLabel;
} //close CreateActionActivity using block
} //try

finally {
outParamLabel = result.outParamLabel;
}
RETURN_STATEMENT:
return outParamLabel;
}

public static class FuncActionGetMethodFunction {



}


}
