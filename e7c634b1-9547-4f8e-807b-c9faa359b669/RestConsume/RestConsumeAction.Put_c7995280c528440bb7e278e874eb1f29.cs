using OutSystems.Application.RestConsume;

namespace ssRuntimeDestroyer;

public static partial class CcTestClient {
    private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_754dacbf7f774dc3835775d16a954184 = Guid.Parse("754dacbf-7f77-4dc3-8357-75d16a954184");
private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_83c606a67c824c6bbccda4e9aeb0b66a = Guid.Parse("83c606a6-7c82-4c6b-bccd-a4e9aeb0b66a");
private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_19208f7223e6414eb7675889fe7d8850 = Guid.Parse("19208f72-23e6-414e-b767-5889fe7d8850");

    
    /// <summary>
/// Action: Put
/// </summary>

public static async Task ActionPut(IRequestContext requestContext,string inParamContentType,ST_34ce93e9f60ca0d98b2e231b96135f86Structure inParamRequest,string inParamPort,CancellationToken cancellationToken) {
var restService = ServiceLocator.GetService<IRestConsumeService>();
await restService.SendRequestAsync<Put_c7995280c528440bb7e278e874eb1f29>(requestContext, key => {
if (key == Key_e7c634b195474f8e807bc9faa359b669_754dacbf7f774dc3835775d16a954184) {
return inParamContentType;
}
if (key == Key_e7c634b195474f8e807bc9faa359b669_83c606a67c824c6bbccda4e9aeb0b66a) {
return RestConsumeStructure_HttpRequestStruct_34ce93e9f60ca0d98b2e231b96135f86.FromStructure(inParamRequest);
}
if (key == Key_e7c634b195474f8e807bc9faa359b669_19208f7223e6414eb7675889fe7d8850) {
return inParamPort;
}
throw new Exception("Input key not found.");
}, restConsumeResult => {}, cancellationToken);
return;
}
 
}