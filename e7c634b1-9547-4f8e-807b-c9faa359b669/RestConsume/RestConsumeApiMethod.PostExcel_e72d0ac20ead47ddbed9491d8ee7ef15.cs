using System;
using OutSystems.Application.RestConsume.Definitions;
using HttpMethod = OutSystems.Application.RestConsume.Definitions.HttpMethod;

namespace ssRuntimeDestroyer;

public class PostExcel_e72d0ac20ead47ddbed9491d8ee7ef15 : IRestConsumeApiMethod {
    public Guid Key { get; } = Guid.Parse("e72d0ac2-0ead-47dd-bed9-491d8ee7ef15");
    public string Name => "PostExcel";
    public IRestConsumeApi RestConsumeApi { get; }
    public HttpMethod HttpMethod => HttpMethod.Post;
    public string UrlPath => "RuntimeDestroyer/rest/Test/HttpMethodExcel?Port={Port}";
    public RequestFormat RequestFormat => OutSystems.Application.RestConsume.Definitions.RequestFormat.Binary;
    public ResponseFormat ResponseFormat => OutSystems.Application.RestConsume.Definitions.ResponseFormat.None;
    public IReadOnlyList<IRestConsumeApiMethodInputParameter> InputParameters { get; }
    public IReadOnlyList<IRestConsumeApiMethodOutputParameter> OutputParameters { get; }
    public TimeSpan? Timeout { get; } = null;

    public PostExcel_e72d0ac20ead47ddbed9491d8ee7ef15(TestClient_a07c5d9788164016ac17c28c58cf19ad restConsumeApi) {
        RestConsumeApi = restConsumeApi;
        InputParameters = [
            new RestConsumeApiMethodInputParameter(Guid.Parse("4cae9874-ca69-4b68-8ab0-b5d058efe413"), "ContentType", this, false, ParameterType.Text, "",  true, ParameterSendIn.Header,"Content-Type", true),
new RestConsumeApiMethodInputParameter(Guid.Parse("804d38be-6b93-4836-b663-b771bed5eafe"), "Request", this, false, ParameterType.BinaryData, new byte[] {},  true, ParameterSendIn.Body,null, true),
new RestConsumeApiMethodInputParameter(Guid.Parse("10b6634b-55af-479d-ae42-8b4edc6f10be"), "Port", this, false, ParameterType.Text, "",  false, ParameterSendIn.Url,null, false),

        ];

        OutputParameters = [
            
        ];
    }
}