using System;
using OutSystems.Application.RestConsume.Definitions;
using HttpMethod = OutSystems.Application.RestConsume.Definitions.HttpMethod;

namespace ssRuntimeDestroyer;

public class Put_c7995280c528440bb7e278e874eb1f29 : IRestConsumeApiMethod {
    public Guid Key { get; } = Guid.Parse("c7995280-c528-440b-b7e2-78e874eb1f29");
    public string Name => "Put";
    public IRestConsumeApi RestConsumeApi { get; }
    public HttpMethod HttpMethod => HttpMethod.Put;
    public string UrlPath => "RuntimeDestroyer/rest/Test/HttpMethod?Port={Port}";
    public RequestFormat RequestFormat => OutSystems.Application.RestConsume.Definitions.RequestFormat.Json;
    public ResponseFormat ResponseFormat => OutSystems.Application.RestConsume.Definitions.ResponseFormat.None;
    public IReadOnlyList<IRestConsumeApiMethodInputParameter> InputParameters { get; }
    public IReadOnlyList<IRestConsumeApiMethodOutputParameter> OutputParameters { get; }
    public TimeSpan? Timeout { get; } = null;

    public Put_c7995280c528440bb7e278e874eb1f29(TestClient_a07c5d9788164016ac17c28c58cf19ad restConsumeApi) {
        RestConsumeApi = restConsumeApi;
        InputParameters = [
            new RestConsumeApiMethodInputParameter(Guid.Parse("754dacbf-7f77-4dc3-8357-75d16a954184"), "ContentType", this, false, ParameterType.Text, "",  true, ParameterSendIn.Header,"Content-Type", true),
new RestConsumeApiMethodInputParameter(Guid.Parse("83c606a6-7c82-4c6b-bccd-a4e9aeb0b66a"), "Request", this, false, ParameterType.Structure, new RestConsumeStructure_HttpRequestStruct_34ce93e9f60ca0d98b2e231b96135f86(),  true, ParameterSendIn.Body,null, true),
new RestConsumeApiMethodInputParameter(Guid.Parse("19208f72-23e6-414e-b767-5889fe7d8850"), "Port", this, false, ParameterType.Text, "",  false, ParameterSendIn.Url,null, false),

        ];

        OutputParameters = [
            
        ];
    }
}