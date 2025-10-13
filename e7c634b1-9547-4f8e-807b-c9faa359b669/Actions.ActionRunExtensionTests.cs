namespace ssRuntimeDestroyer;

public partial class Actions {
/// <summary>
/// Action <code>RunExtensionTests</code> that represents the Service Studio action
///  <code>RunExtensionTests</code> <p> Description: </p>
/// </summary>
public static async Task ActionRunExtensionTests(IRequestContext requestContext,CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RunExtensionTests", "99485f0a-9753-47c4-9b81-ed312bab846a", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669") : null){
} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionRunExtensionTests {



}


}
