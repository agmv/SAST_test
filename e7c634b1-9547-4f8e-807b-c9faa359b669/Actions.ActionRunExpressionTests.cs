namespace ssRuntimeDestroyer;

public partial class Actions {
/// <summary>
/// Action <code>RunExpressionTests</code> that represents the Service Studio action
///  <code>RunExpressionTests</code> <p> Description: </p>
/// </summary>
public static async Task ActionRunExpressionTests(IRequestContext requestContext,CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RunExpressionTests", "0dbe683f-fbb2-410b-a79b-47b17b849cf8", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669") : null){
// EntityActionInExpression
await Actions.ActionEntityActionInExpression(requestContext,cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionRunExpressionTests {



}


}
