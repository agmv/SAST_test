using OutSystems.Application.RestConsume;

namespace ssRuntimeDestroyer;

public static partial class CcTestClient {
    private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_9d319e4dc2f7486ea72ba7c0136b8b29 = Guid.Parse("9d319e4d-c2f7-486e-a72b-a7c0136b8b29");
private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_e4c85c230cca47e29eaa77b96875695e = Guid.Parse("e4c85c23-0cca-47e2-9eaa-77b96875695e");
private static readonly Guid Key_e7c634b195474f8e807bc9faa359b669_e9ab4ce799dc4757b82d3279713eeff1 = Guid.Parse("e9ab4ce7-99dc-4757-b82d-3279713eeff1");

    
    /// <summary>
/// Action: Get
/// </summary>

public static async Task<RL_45cdd2ed99a529499c43ca5937e1be14> ActionGet(IRequestContext requestContext,string inParamContentType,string inParamPort,CancellationToken cancellationToken) {
RL_45cdd2ed99a529499c43ca5937e1be14 outParamResponse = default;
outParamResponse = new RL_45cdd2ed99a529499c43ca5937e1be14();

var restService = ServiceLocator.GetService<IRestConsumeService>();
await restService.SendRequestAsync<Get_548da56df6704fe192b00d07defa157e>(requestContext, key => {
if (key == Key_e7c634b195474f8e807bc9faa359b669_9d319e4dc2f7486ea72ba7c0136b8b29) {
return inParamContentType;
}
if (key == Key_e7c634b195474f8e807bc9faa359b669_e4c85c230cca47e29eaa77b96875695e) {
return inParamPort;
}
throw new Exception("Input key not found.");
}, restConsumeResult => {{
var restStructure = default(RestConsumeStructure_HttpRequestStruct_34ce93e9f60ca0d98b2e231b96135f86[]);
restConsumeResult.TryReadBodyParameter(ref restStructure);
outParamResponse = RL_45cdd2ed99a529499c43ca5937e1be14.ToList(restStructure, RestConsumeStructure_HttpRequestStruct_34ce93e9f60ca0d98b2e231b96135f86.ToStructure);
}
}, cancellationToken);
return outParamResponse;
}
 
}