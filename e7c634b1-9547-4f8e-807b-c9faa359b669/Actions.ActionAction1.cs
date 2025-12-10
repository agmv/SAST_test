namespace ssRuntimeDestroyer;

public partial class Actions {
public class lcvAction1 : VarsBag {
public string resGenerateGuid_outParamGuid = "";

public lcvAction1() {
}
}
public class lcoAction1 : VarsBag {
public string outParamOut1 = "";

public lcoAction1() {
}
}
/// <summary>
/// Action <code>Action1</code> that represents the Service Studio action <code>Action1</code> <p>
///  Description: </p>
/// </summary>
public static async Task<string> ActionAction1(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamOut1 = default;
lcoAction1 result = new lcoAction1();
lcvAction1 localVars = new lcvAction1();
try {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Action1", "47879d43-e7d9-439c-8cef-f5c9c4ff3e48", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669") : null){
// GenerateGuid
localVars.resGenerateGuid_outParamGuid = await ExtendedActions.GenerateGuid(requestContext,cancellationToken);

// Out1 = GenerateGuid.Guid
result.outParamOut1=localVars.resGenerateGuid_outParamGuid;
} //close CreateActionActivity using block
} //try

finally {
outParamOut1 = result.outParamOut1;
}
RETURN_STATEMENT:
return outParamOut1;
}

public static class FuncActionAction1 {



}


}
