namespace ssRuntimeDestroyerLib;

public partial class Actions {
public class lcoActionWithOutputs : VarsBag {
public string outParamOut1 = "";

public int outParamOut2 = 0;

public DateTime outParamOut3 = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);

public lcoActionWithOutputs() {
}
}
/// <summary>
/// Action <code>ActionWithOutputs</code> that represents the Service Studio action
///  <code>ActionWithOutputs</code> <p> Description: </p>
/// </summary>
public static async Task<(string,int,DateTime)> ActionActionWithOutputs(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamOut1 = default;
int outParamOut2 = default;
DateTime outParamOut3 = default;
lcoActionWithOutputs result = new lcoActionWithOutputs();
try {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ActionWithOutputs", "ca95887a-c5b8-447d-8974-5fe320856092", "RuntimeDestroyerLib", "70e88f84-20c0-496b-bde5-9831530a09d3") : null){
// Out1 = "First output parameter"
result.outParamOut1="First output parameter";

// Out2 = 11
result.outParamOut2=11;

// Out3 = #2001-11-14 0:0:0#
result.outParamOut3=(new DateTime (2001, 11, 14, 0, 0, 0, DateTimeKind.Utc));
} //close CreateActionActivity using block
} //try

finally {
outParamOut1 = result.outParamOut1;
outParamOut2 = result.outParamOut2;
outParamOut3 = result.outParamOut3;
}
RETURN_STATEMENT:
return (outParamOut1,outParamOut2,outParamOut3);
}

public static class FuncActionActionWithOutputs {



}


}
