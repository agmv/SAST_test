using OutSystems.Application.RestConsume;

namespace ssRuntimeDestroyer;

public static partial class CcTestClient {
    private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_8544bfc0d6b84c2785fc6ec592a0679f = Guid.Parse("8544bfc0-d6b8-4c27-85fc-6ec592a0679f");
private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_9846fe0cc7a6422c9bcfc76faffb8d64 = Guid.Parse("9846fe0c-c7a6-422c-9bcf-c76faffb8d64");
private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_cf504ba5f77445a2a4bfd91d06164b4a = Guid.Parse("cf504ba5-f774-45a2-a4bf-d91d06164b4a");

    
    /// <summary>
/// Action: GetExcelStatic
/// </summary>

public static async Task<byte[]> ActionGetExcelStatic(IRequestContext requestContext,string inParamContentType,string inParamPort,CancellationToken cancellationToken) {
byte[] outParamResponse = default;
outParamResponse = new byte[] {};

var restService = ServiceLocator.GetService<IRestConsumeService>();
await restService.SendRequestAsync<GetExcelStatic_d9bf9c1de7cf46af9f6985cca067a1d6>(requestContext, key => {
if (key == Key_e7c634b195474f8e807bc9faa359b669_8544bfc0d6b84c2785fc6ec592a0679f) {
return inParamContentType;
}
if (key == Key_e7c634b195474f8e807bc9faa359b669_9846fe0cc7a6422c9bcfc76faffb8d64) {
return inParamPort;
}
throw new Exception("Input key not found.");
}, restConsumeResult => {restConsumeResult.TryReadBodyParameter(ref outParamResponse);}, cancellationToken);
return outParamResponse;
}
 
}