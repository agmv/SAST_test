using System;
using OutSystems.Application.RestConsume.Definitions;
using HttpMethod = OutSystems.Application.RestConsume.Definitions.HttpMethod;

namespace ssRuntimeDestroyer;

public class GetExcelStatic_d9bf9c1de7cf46af9f6985cca067a1d6 : IRestConsumeApiMethod {
    public Guid Key { get; } = Guid.Parse("d9bf9c1d-e7cf-46af-9f69-85cca067a1d6");
    public string Name => "GetExcelStatic";
    public IRestConsumeApi RestConsumeApi { get; }
    public HttpMethod HttpMethod => HttpMethod.Get;
    public string UrlPath => "RuntimeDestroyer/rest/Test/HttpMethodExcelStatic?Port={Port}";
    public RequestFormat RequestFormat => OutSystems.Application.RestConsume.Definitions.RequestFormat.None;
    public ResponseFormat ResponseFormat => OutSystems.Application.RestConsume.Definitions.ResponseFormat.Binary;
    public IReadOnlyList<IRestConsumeApiMethodInputParameter> InputParameters { get; }
    public IReadOnlyList<IRestConsumeApiMethodOutputParameter> OutputParameters { get; }
    public TimeSpan? Timeout { get; } = null;

    public GetExcelStatic_d9bf9c1de7cf46af9f6985cca067a1d6(TestClient_a07c5d9788164016ac17c28c58cf19ad restConsumeApi) {
        RestConsumeApi = restConsumeApi;
        InputParameters = [
            new RestConsumeApiMethodInputParameter(Guid.Parse("8544bfc0-d6b8-4c27-85fc-6ec592a0679f"), "ContentType", this, false, ParameterType.Text, "",  true, ParameterSendIn.Header,"Content-Type", true),
new RestConsumeApiMethodInputParameter(Guid.Parse("9846fe0c-c7a6-422c-9bcf-c76faffb8d64"), "Port", this, false, ParameterType.Text, "",  false, ParameterSendIn.Url,null, false),

        ];

        OutputParameters = [
            new RestConsumeApiMethodOutputParameter(Guid.Parse("cf504ba5-f774-45a2-a4bf-d91d06164b4a"), "Response", this, false, ParameterType.BinaryData, new byte[] {}, ParameterReceiveIn.Body, null),

        ];
    }
}