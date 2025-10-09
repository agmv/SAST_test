namespace ssRuntimeDestroyerLib;

public partial class Actions {
public class lcvSqrtNegative : VarsBag {
/// <summary>
/// Variable <code>Result</code> that represents the Service Studio Decimal <code>Result</code>
///  <p>Description: </p>
/// </summary>
public decimal varLcResult = 0.0M;

public lcvSqrtNegative() {
}
}
public class lcoSqrtNegative : VarsBag {
public string outParamErrorMessage = "";

public lcoSqrtNegative() {
}
}
/// <summary>
/// Action <code>SqrtNegative</code> that represents the Service Studio action
///  <code>SqrtNegative</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionSqrtNegative(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamErrorMessage = default;
lcoSqrtNegative result = new lcoSqrtNegative();
lcvSqrtNegative localVars = new lcvSqrtNegative();
try {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SqrtNegative", "5bb15394-851a-4624-bd36-ae538214f330", "RuntimeDestroyerLib", "70e88f84-20c0-496b-bde5-9831530a09d3") : null){
// TryAssignSqrtFromNegativeNumber
// Result = Sqrt
localVars.varLcResult=BuiltInFunction.Sqrt ((((decimal)(-1))));
} //close CreateActionActivity using block
} //try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
#pragma warning disable 612,618 
DatabaseAccess.RollbackAllTransactions();
#pragma warning restore 612,618 

// ErrorMessage = AllExceptions.ExceptionMessage
result.outParamErrorMessage=ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamErrorMessage = result.outParamErrorMessage;
}
RETURN_STATEMENT:
return outParamErrorMessage;
}

public static class FuncActionSqrtNegative {



}


}
