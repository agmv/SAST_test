using System.Diagnostics;
using ssRuntimeDestroyer;

namespace ssRuntimeDestroyer.CsRESTExpose.Csv1;

public class Csv1ControllerFlows {
    private static readonly ActivitySource activitySource = new(typeof(Csv1ControllerFlows).Namespace);
public class lcvRunTests : VarsBag {
public string inParamPort;
public lcvRunTests(string inParamPort) {
this.inParamPort = inParamPort;
}
}
public class lcoRunTests : VarsBag {
public string outParamBody = "";

public lcoRunTests() {
}
}
/// <summary>
/// Action <code>RunTests</code> that represents the Service Studio action <code>RunTests</code> <p>
///  Description: </p>
/// </summary>
public static async Task<string> Flowv1ActionRunTests(IRequestContext requestContext,string inParamPort,CancellationToken cancellationToken) {
string outParamBody = default;
lcoRunTests result = new lcoRunTests();
lcvRunTests localVars = new lcvRunTests(inParamPort);
try {
cancellationToken.ThrowIfCancellationRequested();
using (activitySource.CreateCustomActionActivity("REST (Expose)", "RunTests", "4c615965-3adb-4f90-89df-e02881697de2", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669")){
// RunAllTests
await Actions.ActionRunAllTests(requestContext,localVars.inParamPort,cancellationToken);

// Body = "Ok"
result.outParamBody="Ok";
} //close CreateActionActivity using block
} //try

catch (Ex_AssertExceptionUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
#pragma warning disable 612,618 
DatabaseAccess.RollbackAllTransactions();
#pragma warning restore 612,618 

// Body = AssertException.ExceptionMessage
result.outParamBody=ex.Message;
goto RETURN_STATEMENT;

} // Catch
catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
#pragma warning disable 612,618 
DatabaseAccess.RollbackAllTransactions();
#pragma warning restore 612,618 

// Body = "Unhandled exception: " + AllExceptions.ExceptionMessage
result.outParamBody=("Unhandled exception: "+ex.Message);
goto RETURN_STATEMENT;

} // Catch
finally {
outParamBody = result.outParamBody;
}
RETURN_STATEMENT:
return outParamBody;
}

public static class FuncFlowv1ActionRunTests {



}


}
