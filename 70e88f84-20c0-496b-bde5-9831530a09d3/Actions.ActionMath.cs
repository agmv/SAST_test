namespace ssRuntimeDestroyerLib;

public partial class Actions {
/// <summary>
/// Action <code>Math</code> that represents the Service Studio action <code>Math</code> <p>
///  Description: </p>
/// </summary>
public static async Task ActionMath(IRequestContext requestContext,CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Math", "e76c55fc-cea3-4c83-94f8-a02c836e54f1", "RuntimeDestroyerLib", "70e88f84-20c0-496b-bde5-9831530a09d3") : null){
// Abs
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.Abs ((-10.89m))==10.89m),"BuiltIn_Math Abs",cancellationToken);

// Mod
await Actions.ActionAssertTrue(requestContext,((BuiltInFunction.Mod ((((decimal)10)), (((decimal)3)))==(((decimal)1)))&&(BuiltInFunction.Mod ((((decimal)4)), 3.5m)==0.5m)),"BuiltIn_Math Mod",cancellationToken);

// Power
await Actions.ActionAssertTrue(requestContext,((BuiltInFunction.Power ((((decimal)100)), (((decimal)2)))==(((decimal)10000)))&&(BuiltInFunction.Power ((-10.89m), 2.3m)==(((decimal)0)))),"BuiltIn_Math Power",cancellationToken);

// Round
await Actions.ActionAssertTrue(requestContext,((((((BuiltInFunction.Round ((-10.89m), 0)==(((decimal)(-11))))&&(BuiltInFunction.Round ((-5.5m), 0)==(((decimal)(-6)))))&&(BuiltInFunction.Round (9.3m, 0)==(((decimal)9))))&&(BuiltInFunction.Round (2.5m, 0)==(((decimal)2))))&&(BuiltInFunction.Round (3.5m, 0)==(((decimal)4))))&&(BuiltInFunction.Round (9.123456789m, 5)==9.12346m)),"BuiltIn_Math Round",cancellationToken);

// Sqrt
await Actions.ActionSqrt(requestContext,cancellationToken);

// Trunc
await Actions.ActionAssertTrue(requestContext,((BuiltInFunction.Trunc ((-10.89m))==(((decimal)(-10))))&&(BuiltInFunction.Trunc (7.51m)==(((decimal)7)))),"BuiltIn_Math Trunc",cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionMath {



}


}
