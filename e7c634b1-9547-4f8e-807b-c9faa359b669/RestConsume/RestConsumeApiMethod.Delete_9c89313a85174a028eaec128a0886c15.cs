using System;
using OutSystems.Application.RestConsume.Definitions;
using HttpMethod = OutSystems.Application.RestConsume.Definitions.HttpMethod;

namespace ssRuntimeDestroyer;

public class Delete_9c89313a85174a028eaec128a0886c15 : IRestConsumeApiMethod {
    public Guid Key { get; } = Guid.Parse("9c89313a-8517-4a02-8eae-c128a0886c15");
    public string Name => "Delete";
    public IRestConsumeApi RestConsumeApi { get; }
    public HttpMethod HttpMethod => HttpMethod.Delete;
    public string UrlPath => "RuntimeDestroyer/rest/Test/HttpMethod?HttpRequestIdentifier={HttpRequestIdentifier}&Port={Port}";
    public RequestFormat RequestFormat => OutSystems.Application.RestConsume.Definitions.RequestFormat.None;
    public ResponseFormat ResponseFormat => OutSystems.Application.RestConsume.Definitions.ResponseFormat.None;
    public IReadOnlyList<IRestConsumeApiMethodInputParameter> InputParameters { get; }
    public IReadOnlyList<IRestConsumeApiMethodOutputParameter> OutputParameters { get; }
    public TimeSpan? Timeout { get; } = null;

    public Delete_9c89313a85174a028eaec128a0886c15(TestClient_a07c5d9788164016ac17c28c58cf19ad restConsumeApi) {
        RestConsumeApi = restConsumeApi;
        InputParameters = [
            new RestConsumeApiMethodInputParameter(Guid.Parse("dbecb014-a480-497d-9cc0-b902d15a2f91"), "HttpRequestIdentifier", this, false, ParameterType.Text, "",  false, ParameterSendIn.Url,null, false),
new RestConsumeApiMethodInputParameter(Guid.Parse("b0e4162a-cbf7-4a8c-9db4-b4de20574623"), "ContentType", this, false, ParameterType.Text, "",  true, ParameterSendIn.Header,"Content-Type", true),
new RestConsumeApiMethodInputParameter(Guid.Parse("17fe98de-998f-4921-8725-0c5a9bb5514d"), "Port", this, false, ParameterType.Text, "",  false, ParameterSendIn.Url,null, false),

        ];

        OutputParameters = [
            
        ];
    }
}