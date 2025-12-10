using System;
using OutSystems.Application.RestConsume.Definitions;
using HttpMethod = OutSystems.Application.RestConsume.Definitions.HttpMethod;

namespace ssRuntimeDestroyer;

public class Get_548da56df6704fe192b00d07defa157e : IRestConsumeApiMethod {
    public Guid Key { get; } = Guid.Parse("548da56d-f670-4fe1-92b0-0d07defa157e");
    public string Name => "Get";
    public IRestConsumeApi RestConsumeApi { get; }
    public HttpMethod HttpMethod => HttpMethod.Get;
    public string UrlPath => "RuntimeDestroyer/rest/Test/HttpMethod?Port={Port}";
    public RequestFormat RequestFormat => OutSystems.Application.RestConsume.Definitions.RequestFormat.None;
    public ResponseFormat ResponseFormat => OutSystems.Application.RestConsume.Definitions.ResponseFormat.Json;
    public IReadOnlyList<IRestConsumeApiMethodInputParameter> InputParameters { get; }
    public IReadOnlyList<IRestConsumeApiMethodOutputParameter> OutputParameters { get; }
    public TimeSpan? Timeout { get; } = null;

    public Get_548da56df6704fe192b00d07defa157e(TestClient_a07c5d9788164016ac17c28c58cf19ad restConsumeApi) {
        RestConsumeApi = restConsumeApi;
        InputParameters = [
            new RestConsumeApiMethodInputParameter(Guid.Parse("9d319e4d-c2f7-486e-a72b-a7c0136b8b29"), "ContentType", this, false, ParameterType.Text, "",  true, ParameterSendIn.Header,"Content-Type", true),
new RestConsumeApiMethodInputParameter(Guid.Parse("e4c85c23-0cca-47e2-9eaa-77b96875695e"), "Port", this, false, ParameterType.Text, "",  false, ParameterSendIn.Url,null, false),

        ];

        OutputParameters = [
            new RestConsumeApiMethodOutputParameter(Guid.Parse("e9ab4ce7-99dc-4757-b82d-3279713eeff1"), "Response", this, false, ParameterType.List, Array.Empty<RestConsumeStructure_HttpRequestStruct_34ce93e9f60ca0d98b2e231b96135f86>(), ParameterReceiveIn.Body, null),

        ];
    }
}