namespace ssRuntimeDestroyerLib;

public partial class Actions {
public class lcvSqrt : VarsBag {
public Actions.lcoSqrtNegative resSqrtNegative =  new Actions.lcoSqrtNegative();
public lcvSqrt() {
}
}
/// <summary>
/// Action <code>Sqrt</code> that represents the Service Studio action <code>Sqrt</code> <p>
///  Description: </p>
/// </summary>
public static async Task ActionSqrt(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvSqrt localVars = new lcvSqrt();
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Sqrt", "8ca9869c-91d9-4ca4-8e2f-9bc6be921dff", "RuntimeDestroyerLib", "70e88f84-20c0-496b-bde5-9831530a09d3") : null){
// Sqrt
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.Sqrt (2.3m)==1.51657508881031m),"BuiltIn_Math Sqrt",cancellationToken);

// SqrtNegative
localVars.resSqrtNegative.outParamErrorMessage = await Actions.ActionSqrtNegative(requestContext,cancellationToken);

// AssertTrue
await Actions.ActionAssertTrue(requestContext,(localVars.resSqrtNegative.outParamErrorMessage=="The input number must be positive."),"BuiltIn_Math Sqrt_Negative",cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionSqrt {



}


}
