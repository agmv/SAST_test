using OutSystems.Application.RestConsume;

namespace ssRuntimeDestroyer;

public static partial class CcTestClient {
    private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_83b9f3f0b6c8411eadfcd18e042fc4ce = Guid.Parse("83b9f3f0-b6c8-411e-adfc-d18e042fc4ce");
private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_b34521980b224319864359505e00c1ab = Guid.Parse("b3452198-0b22-4319-8643-59505e00c1ab");
private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_f2dde5f1307142ea8e0ef81e85cf6ae9 = Guid.Parse("f2dde5f1-3071-42ea-8e0e-f81e85cf6ae9");

    
    /// <summary>
/// Action: GetExcelEntity
/// </summary>

public static async Task<RL_82f541a6a3f8132f7af4a58873bc9078> ActionGetExcelEntity(IRequestContext requestContext,string inParamContentType,string inParamPort,CancellationToken cancellationToken) {
RL_82f541a6a3f8132f7af4a58873bc9078 outParamResponse = default;
outParamResponse = new RL_82f541a6a3f8132f7af4a58873bc9078();

var restService = ServiceLocator.GetService<IRestConsumeService>();
await restService.SendRequestAsync<GetExcelEntity_cd37b0653aa64a128e700ebb2628d27a>(requestContext, key => {
if (key == Key_e7c634b195474f8e807bc9faa359b669_83b9f3f0b6c8411eadfcd18e042fc4ce) {
return inParamContentType;
}
if (key == Key_e7c634b195474f8e807bc9faa359b669_b34521980b224319864359505e00c1ab) {
return inParamPort;
}
throw new Exception("Input key not found.");
}, restConsumeResult => {{
var restStructure = default(RestConsumeStructure_SampleListStruct_00ba72a41660161c6373af90c87d0979[]);
restConsumeResult.TryReadBodyParameter(ref restStructure);
outParamResponse = RL_82f541a6a3f8132f7af4a58873bc9078.ToList(restStructure, RestConsumeStructure_SampleListStruct_00ba72a41660161c6373af90c87d0979.ToStructure);
}
}, cancellationToken);
return outParamResponse;
}
 
}