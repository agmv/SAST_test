using OutSystems.Application.RestConsume;

namespace ssRuntimeDestroyer;

public static partial class CcTestClient {
    private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_dbecb014a480497d9cc0b902d15a2f91 = Guid.Parse("dbecb014-a480-497d-9cc0-b902d15a2f91");
private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_b0e4162acbf74a8c9db4b4de20574623 = Guid.Parse("b0e4162a-cbf7-4a8c-9db4-b4de20574623");
private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_17fe98de998f492187250c5a9bb5514d = Guid.Parse("17fe98de-998f-4921-8725-0c5a9bb5514d");

    
    /// <summary>
/// Action: Delete
/// </summary>

public static async Task ActionDelete(IRequestContext requestContext,string inParamHttpRequestIdentifier,string inParamContentType,string inParamPort,CancellationToken cancellationToken) {
var restService = ServiceLocator.GetService<IRestConsumeService>();
await restService.SendRequestAsync<Delete_9c89313a85174a028eaec128a0886c15>(requestContext, key => {
if (key == Key_e7c634b195474f8e807bc9faa359b669_dbecb014a480497d9cc0b902d15a2f91) {
return inParamHttpRequestIdentifier;
}
if (key == Key_e7c634b195474f8e807bc9faa359b669_b0e4162acbf74a8c9db4b4de20574623) {
return inParamContentType;
}
if (key == Key_e7c634b195474f8e807bc9faa359b669_17fe98de998f492187250c5a9bb5514d) {
return inParamPort;
}
throw new Exception("Input key not found.");
}, restConsumeResult => {}, cancellationToken);
return;
}
 
}