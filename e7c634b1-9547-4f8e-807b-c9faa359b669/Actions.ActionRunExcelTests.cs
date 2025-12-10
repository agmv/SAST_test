namespace ssRuntimeDestroyer;

public partial class Actions {
/// <summary>
/// Action <code>RunExcelTests</code> that represents the Service Studio action
///  <code>RunExcelTests</code> <p> Description: </p>
/// </summary>
public static async Task ActionRunExcelTests(IRequestContext requestContext,CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RunExcelTests", "07d318bc-b2b0-46c8-8df6-59965d375d93", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669") : null){
// EntityToExcelToEntity
await Actions.ActionEntityToExcelToEntity(requestContext,cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionRunExcelTests {



}


}
