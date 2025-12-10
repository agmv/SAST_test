namespace ssRuntimeDestroyerLib;

public partial class Actions {
public class lcvAssertAreEqual : VarsBag {
public long inParamExpected;
public long inParamResult;
public string inParamMessage;
public lcvAssertAreEqual(long inParamExpected, long inParamResult, string inParamMessage) {
this.inParamExpected = inParamExpected;
this.inParamResult = inParamResult;
this.inParamMessage = inParamMessage;
}
}
/// <summary>
/// Action <code>AssertAreEqual</code> that represents the Service Studio action
///  <code>AssertAreEqual</code> <p> Description: </p>
/// </summary>
public static async Task ActionAssertAreEqual(IRequestContext requestContext,long inParamExpected,long inParamResult,string inParamMessage,CancellationToken cancellationToken) {
lcvAssertAreEqual localVars = new lcvAssertAreEqual(inParamExpected, inParamResult, inParamMessage);
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("AssertAreEqual", "3a924ec4-e003-4903-bada-eef9ec5b5e67", "RuntimeDestroyerLib", "70e88f84-20c0-496b-bde5-9831530a09d3") : null){
if(((localVars.inParamExpected!=localVars.inParamResult))) {
// RaiseError AssertException
throw new Ex_AssertExceptionUserException ((((((("AssertAreEqual failed "+localVars.inParamMessage)+". Expected '")+BuiltInFunction.LongIntegerToText(localVars.inParamExpected))+"' but was '")+BuiltInFunction.LongIntegerToText(localVars.inParamResult))+"'"));

}

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionAssertAreEqual {



}


}
