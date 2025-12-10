namespace ssRuntimeDestroyerLib;

public partial class Actions {
public class lcvActionWithInputs : VarsBag {
public int inParamX;
public int inParamY;
public int inParamZ;
public lcvActionWithInputs(int inParamX, int inParamY, int inParamZ) {
this.inParamX = inParamX;
this.inParamY = inParamY;
this.inParamZ = inParamZ;
}
}
public class lcoActionWithInputs : VarsBag {
public int outParamSum = 0;

public lcoActionWithInputs() {
}
}
/// <summary>
/// Action <code>ActionWithInputs</code> that represents the Service Studio action
///  <code>ActionWithInputs</code> <p> Description: </p>
/// </summary>
public static async Task<int> ActionActionWithInputs(IRequestContext requestContext,int inParamX,int inParamY,int inParamZ,CancellationToken cancellationToken) {
int outParamSum = default;
lcoActionWithInputs result = new lcoActionWithInputs();
lcvActionWithInputs localVars = new lcvActionWithInputs(inParamX, inParamY, inParamZ);
try {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ActionWithInputs", "5eb0b126-ae5e-403d-87bd-cf7e04eb0f3f", "RuntimeDestroyerLib", "70e88f84-20c0-496b-bde5-9831530a09d3") : null){
// Sum = X + Y + Z
result.outParamSum=((localVars.inParamX+localVars.inParamY)+localVars.inParamZ);
} //close CreateActionActivity using block
} //try

finally {
outParamSum = result.outParamSum;
}
RETURN_STATEMENT:
return outParamSum;
}

public static class FuncActionActionWithInputs {



}


}
