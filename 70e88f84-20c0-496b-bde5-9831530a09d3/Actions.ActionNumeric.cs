namespace ssRuntimeDestroyerLib;

public partial class Actions {
/// <summary>
/// Action <code>Numeric</code> that represents the Service Studio action <code>Numeric</code> <p>
///  Description: </p>
/// </summary>
public static async Task ActionNumeric(IRequestContext requestContext,CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Numeric", "457a4835-3a4e-4ec5-9afd-fa19d815c5c5", "RuntimeDestroyerLib", "70e88f84-20c0-496b-bde5-9831530a09d3") : null){
// Max
await Actions.ActionAssertTrue(requestContext,((BuiltInFunction.Max ((-10.89m), (-2.3m))==(-2.3m))&&(BuiltInFunction.Max (10.89m, 2.3m)==10.89m)),"BuiltIn_Numeric Max",cancellationToken);

// Min
await Actions.ActionAssertTrue(requestContext,((BuiltInFunction.Min ((-10.89m), (-2.3m))==(-10.89m))&&(BuiltInFunction.Min (10.89m, 2.3m)==2.3m)),"BuiltIn_Numeric Min",cancellationToken);

// Sign
await Actions.ActionAssertTrue(requestContext,(((BuiltInFunction.Sign ((-10.89m))==(-1))&&(BuiltInFunction.Sign (2.3m)==1))&&(BuiltInFunction.Sign (0.0m)==0)),"BuiltIn_Numeric Sign",cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionNumeric {



}


}
