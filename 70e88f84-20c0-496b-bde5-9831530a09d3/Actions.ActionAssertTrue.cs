namespace ssRuntimeDestroyerLib;

public partial class Actions {
public class lcvAssertTrue : VarsBag {
public bool inParamResult;
public string inParamMessage;
public lcvAssertTrue(bool inParamResult, string inParamMessage) {
this.inParamResult = inParamResult;
this.inParamMessage = inParamMessage;
}
}
/// <summary>
/// Action <code>AssertTrue</code> that represents the Service Studio action <code>AssertTrue</code>
///  <p> Description: </p>
/// </summary>
public static async Task ActionAssertTrue(IRequestContext requestContext,bool inParamResult,string inParamMessage,CancellationToken cancellationToken) {
lcvAssertTrue localVars = new lcvAssertTrue(inParamResult, inParamMessage);
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("AssertTrue", "ec236471-1a1f-4ac0-b281-ae3ffe68520d", "RuntimeDestroyerLib", "70e88f84-20c0-496b-bde5-9831530a09d3") : null){
if(((!localVars.inParamResult))) {
// RaiseError AssertException
throw new Ex_AssertExceptionUserException (("AssertTrue failed "+localVars.inParamMessage));

}

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionAssertTrue {



}


}
