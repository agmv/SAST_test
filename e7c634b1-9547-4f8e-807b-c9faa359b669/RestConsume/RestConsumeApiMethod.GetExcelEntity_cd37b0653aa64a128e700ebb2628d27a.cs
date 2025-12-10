using System;
using OutSystems.Application.RestConsume.Definitions;
using HttpMethod = OutSystems.Application.RestConsume.Definitions.HttpMethod;

namespace ssRuntimeDestroyer;

public class GetExcelEntity_cd37b0653aa64a128e700ebb2628d27a : IRestConsumeApiMethod {
    public Guid Key { get; } = Guid.Parse("cd37b065-3aa6-4a12-8e70-0ebb2628d27a");
    public string Name => "GetExcelEntity";
    public IRestConsumeApi RestConsumeApi { get; }
    public HttpMethod HttpMethod => HttpMethod.Get;
    public string UrlPath => "RuntimeDestroyer/rest/Test/HttpMethodExcelEntity?Port={Port}";
    public RequestFormat RequestFormat => OutSystems.Application.RestConsume.Definitions.RequestFormat.None;
    public ResponseFormat ResponseFormat => OutSystems.Application.RestConsume.Definitions.ResponseFormat.Json;
    public IReadOnlyList<IRestConsumeApiMethodInputParameter> InputParameters { get; }
    public IReadOnlyList<IRestConsumeApiMethodOutputParameter> OutputParameters { get; }
    public TimeSpan? Timeout { get; } = null;

    public GetExcelEntity_cd37b0653aa64a128e700ebb2628d27a(TestClient_a07c5d9788164016ac17c28c58cf19ad restConsumeApi) {
        RestConsumeApi = restConsumeApi;
        InputParameters = [
            new RestConsumeApiMethodInputParameter(Guid.Parse("83b9f3f0-b6c8-411e-adfc-d18e042fc4ce"), "ContentType", this, false, ParameterType.Text, "",  true, ParameterSendIn.Header,"Content-Type", true),
new RestConsumeApiMethodInputParameter(Guid.Parse("b3452198-0b22-4319-8643-59505e00c1ab"), "Port", this, false, ParameterType.Text, "",  false, ParameterSendIn.Url,null, false),

        ];

        OutputParameters = [
            new RestConsumeApiMethodOutputParameter(Guid.Parse("f2dde5f1-3071-42ea-8e0e-f81e85cf6ae9"), "Response", this, false, ParameterType.List, Array.Empty<RestConsumeStructure_SampleListStruct_00ba72a41660161c6373af90c87d0979>(), ParameterReceiveIn.Body, null),

        ];
    }
}