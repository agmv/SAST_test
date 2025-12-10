namespace ssRuntimeDestroyerLib;

public partial class Actions {
public class lcvFibonacciRecursive : VarsBag {
public int inParamIn;
public Actions.lcoFibonacciRecursive resMinus2 =  new Actions.lcoFibonacciRecursive();
public Actions.lcoFibonacciRecursive resMinus1 =  new Actions.lcoFibonacciRecursive();
public lcvFibonacciRecursive(int inParamIn) {
this.inParamIn = inParamIn;
}
}
public class lcoFibonacciRecursive : VarsBag {
public long outParamResult = 0L;

public lcoFibonacciRecursive() {
}
}
/// <summary>
/// Action <code>FibonacciRecursive</code> that represents the Service Studio action
///  <code>FibonacciRecursive</code> <p> Description: </p>
/// </summary>
public static async Task<long> ActionFibonacciRecursive(IRequestContext requestContext,int inParamIn,CancellationToken cancellationToken) {
long outParamResult = default;
lcoFibonacciRecursive result = new lcoFibonacciRecursive();
lcvFibonacciRecursive localVars = new lcvFibonacciRecursive(inParamIn);
try {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FibonacciRecursive", "64a464f8-54d1-4e9c-9821-ecafe310ddc6", "RuntimeDestroyerLib", "70e88f84-20c0-496b-bde5-9831530a09d3") : null){
if((((localVars.inParamIn==0)||(localVars.inParamIn==1)))) {
// Result = In
result.outParamResult=Convert.ToInt64(localVars.inParamIn);
} else {
// Minus1
localVars.resMinus1.outParamResult = await Actions.ActionFibonacciRecursive(requestContext,(localVars.inParamIn-1),cancellationToken);

// Minus2
localVars.resMinus2.outParamResult = await Actions.ActionFibonacciRecursive(requestContext,(localVars.inParamIn-2),cancellationToken);

// Result = Minus1.Result + Minus2.Result
result.outParamResult=(localVars.resMinus1.outParamResult+localVars.resMinus2.outParamResult);
}

} //close CreateActionActivity using block
} //try

finally {
outParamResult = result.outParamResult;
}
RETURN_STATEMENT:
return outParamResult;
}

public static class FuncActionFibonacciRecursive {



}


}
