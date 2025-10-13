using OutSystems.Application.RestConsume;

namespace ssRuntimeDestroyer;

public static partial class CcTestClient {
    private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_4cae9874ca694b688ab0b5d058efe413 = Guid.Parse("4cae9874-ca69-4b68-8ab0-b5d058efe413");
private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_804d38be6b934836b663b771bed5eafe = Guid.Parse("804d38be-6b93-4836-b663-b771bed5eafe");
private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_10b6634b55af479dae428b4edc6f10be = Guid.Parse("10b6634b-55af-479d-ae42-8b4edc6f10be");

    
    /// <summary>
/// Action: PostExcel
/// </summary>

public static async Task ActionPostExcel(IRequestContext requestContext,string inParamContentType,byte[] inParamRequest,string inParamPort,CancellationToken cancellationToken) {
var restService = ServiceLocator.GetService<IRestConsumeService>();
await restService.SendRequestAsync<PostExcel_e72d0ac20ead47ddbed9491d8ee7ef15>(requestContext, key => {
if (key == Key_e7c634b195474f8e807bc9faa359b669_4cae9874ca694b688ab0b5d058efe413) {
return inParamContentType;
}
if (key == Key_e7c634b195474f8e807bc9faa359b669_804d38be6b934836b663b771bed5eafe) {
return inParamRequest;
}
if (key == Key_e7c634b195474f8e807bc9faa359b669_10b6634b55af479dae428b4edc6f10be) {
return inParamPort;
}
throw new Exception("Input key not found.");
}, restConsumeResult => {}, cancellationToken);
return;
}
 
}