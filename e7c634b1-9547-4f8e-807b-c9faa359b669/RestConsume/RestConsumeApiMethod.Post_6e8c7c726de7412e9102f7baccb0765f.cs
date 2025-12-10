using System;
using OutSystems.Application.RestConsume.Definitions;
using HttpMethod = OutSystems.Application.RestConsume.Definitions.HttpMethod;

namespace ssRuntimeDestroyer;

public class Post_6e8c7c726de7412e9102f7baccb0765f : IRestConsumeApiMethod {
    public Guid Key { get; } = Guid.Parse("6e8c7c72-6de7-412e-9102-f7baccb0765f");
    public string Name => "Post";
    public IRestConsumeApi RestConsumeApi { get; }
    public HttpMethod HttpMethod => HttpMethod.Post;
    public string UrlPath => "RuntimeDestroyer/rest/Test/HttpMethod?Port={Port}";
    public RequestFormat RequestFormat => OutSystems.Application.RestConsume.Definitions.RequestFormat.Json;
    public ResponseFormat ResponseFormat => OutSystems.Application.RestConsume.Definitions.ResponseFormat.None;
    public IReadOnlyList<IRestConsumeApiMethodInputParameter> InputParameters { get; }
    public IReadOnlyList<IRestConsumeApiMethodOutputParameter> OutputParameters { get; }
    public TimeSpan? Timeout { get; } = null;

    public Post_6e8c7c726de7412e9102f7baccb0765f(TestClient_a07c5d9788164016ac17c28c58cf19ad restConsumeApi) {
        RestConsumeApi = restConsumeApi;
        InputParameters = [
            new RestConsumeApiMethodInputParameter(Guid.Parse("7f4831ba-3971-40f5-95ac-17cc26441846"), "ContentType", this, false, ParameterType.Text, "",  true, ParameterSendIn.Header,"Content-Type", true),
new RestConsumeApiMethodInputParameter(Guid.Parse("3bae4474-e3d1-4506-84f8-5e305bc93a9f"), "Request", this, false, ParameterType.Structure, new RestConsumeStructure_HttpRequestStruct_34ce93e9f60ca0d98b2e231b96135f86(),  true, ParameterSendIn.Body,null, true),
new RestConsumeApiMethodInputParameter(Guid.Parse("a076abf8-c731-4124-aca4-fc78cb9d9db2"), "Port", this, false, ParameterType.Text, "",  false, ParameterSendIn.Url,null, false),

        ];

        OutputParameters = [
            
        ];
    }
}