using OutSystems.Application.RestConsume;

namespace ssRuntimeDestroyer;

public static partial class CcTestClient {
    private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_7f4831ba397140f595ac17cc26441846 = Guid.Parse("7f4831ba-3971-40f5-95ac-17cc26441846");
private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_3bae4474e3d1450684f85e305bc93a9f = Guid.Parse("3bae4474-e3d1-4506-84f8-5e305bc93a9f");
private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_a076abf8c7314124aca4fc78cb9d9db2 = Guid.Parse("a076abf8-c731-4124-aca4-fc78cb9d9db2");

    
    /// <summary>
/// Action: Post
/// </summary>

public static async Task ActionPost(IRequestContext requestContext,string inParamContentType,ST_34ce93e9f60ca0d98b2e231b96135f86Structure inParamRequest,string inParamPort,CancellationToken cancellationToken) {
var restService = ServiceLocator.GetService<IRestConsumeService>();
await restService.SendRequestAsync<Post_6e8c7c726de7412e9102f7baccb0765f>(requestContext, key => {
if (key == Key_e7c634b195474f8e807bc9faa359b669_7f4831ba397140f595ac17cc26441846) {
return inParamContentType;
}
if (key == Key_e7c634b195474f8e807bc9faa359b669_3bae4474e3d1450684f85e305bc93a9f) {
return RestConsumeStructure_HttpRequestStruct_34ce93e9f60ca0d98b2e231b96135f86.FromStructure(inParamRequest);
}
if (key == Key_e7c634b195474f8e807bc9faa359b669_a076abf8c7314124aca4fc78cb9d9db2) {
return inParamPort;
}
throw new Exception("Input key not found.");
}, restConsumeResult => {}, cancellationToken);
return;
}
 
}