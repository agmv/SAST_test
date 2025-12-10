namespace ssRuntimeDestroyer;

public partial class Actions {
public class lcvSumFunction : VarsBag {
public int inParamX;
public int inParamY;
public int inParamZ;
public lcvSumFunction(int inParamX, int inParamY, int inParamZ) {
this.inParamX = inParamX;
this.inParamY = inParamY;
this.inParamZ = inParamZ;
}
}
public class lcoSumFunction : VarsBag {
public int outParamResult = 0;

public lcoSumFunction() {
}
}
/// <summary>
/// Action <code>SumFunction</code> that represents the Service Studio action <code>SumFunction</code>
///  <p> Description: </p>
/// </summary>
public static async Task<int> ActionSumFunction(IRequestContext requestContext,int inParamX,int inParamY,int inParamZ,CancellationToken cancellationToken) {
int outParamResult = default;
lcoSumFunction result = new lcoSumFunction();
lcvSumFunction localVars = new lcvSumFunction(inParamX, inParamY, inParamZ);
try {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SumFunction", "ff38dd65-a226-4e0d-ac4f-d0822601396b", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669") : null){
// Result = X + Y + Z
result.outParamResult=((localVars.inParamX+localVars.inParamY)+localVars.inParamZ);
} //close CreateActionActivity using block
} //try

finally {
outParamResult = result.outParamResult;
}
RETURN_STATEMENT:
return outParamResult;
}

public static class FuncActionSumFunction {



}


}
