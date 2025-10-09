using System.Collections.Immutable;
using Microsoft.Extensions.Primitives;
using OutSystems.Application.RestConsume.Definitions;
using OutSystems.Application.RestConsume.Callbacks;

namespace ssRuntimeDestroyer;

public class TestClient_a07c5d9788164016ac17c28c58cf19ad : IRestConsumeApi {
    public Guid ModuleKey { get; } = Guid.Parse("e7c634b1-9547-4f8e-807b-c9faa359b669");
    public Guid Key { get; } = Guid.Parse("a07c5d97-8816-4016-ac17-c28c58cf19ad");
    public string Name => "TestClient";
    public string ModuleName => "RuntimeDestroyer";
    public string BaseUrl => "http://localhost"; 
    public IRestConsumeApiBasicAuthentication? BasicAuthentication => null;
    public DateFormat DateFormat => DateFormat.ISO;
    public Func<IRequestContext, RestConsumeHttpRequest, CancellationToken, Task<RestConsumeHttpRequest>>? OnBeforeRequestAsync { get; } = async (requestContext, httpRequest, cancellationToken) => {
ST_2e4d23f993f70b2a453aff430875354bStructure internalHttpRequest = new ST_2e4d23f993f70b2a453aff430875354bStructure();
internalHttpRequest.ssBaseURL = httpRequest.GetBaseUrl();
internalHttpRequest.ssURLPath = httpRequest.GetUrlPath();
internalHttpRequest.ssURLQueryParameters = RL_f12ccf0a92533f516726b4232e2b352e.ToList(httpRequest.GetUrlQueryParameters(), kv => new ST_67c9532b700300cd02996c0d658856f8Structure {
ssName = kv.Key,
ssValue = kv.Value
});
internalHttpRequest.ssHTTPMethod = httpRequest.GetHttpMethod();
internalHttpRequest.ssHeaders = RL_435011a192ffc5b6f97bc0a73c8501c1.ToList(httpRequest.GetHeaders(), kv => new ST_b6163e36a4b633b09c820fee73ba221eStructure {
ssName = kv.Key,
ssValue = kv.Value
});
internalHttpRequest.ssRequestText = httpRequest.GetRequestText();
internalHttpRequest.ssRequestBinary = httpRequest.GetRequestBinary();
var outputRequest = await Callback_TestClient_a07c5d9788164016ac17c28c58cf19ad.NewInstance().FlowTestClientActionOnBeforeRequest(requestContext,internalHttpRequest,cancellationToken);
var resultRestRequest = new RestConsumeHttpRequest(
baseUrl: outputRequest.ssBaseURL,
urlPath: outputRequest.ssURLPath,
urlQueryParameters: outputRequest.ssURLQueryParameters.ToArray(st => new KeyValuePair<string, string>(st.ssName, st.ssValue)),
httpMethod: outputRequest.ssHTTPMethod,
headers: outputRequest.ssHeaders.ToArray(st => new KeyValuePair<string, string>(st.ssName, st.ssValue)),
requestText: outputRequest.ssRequestText,
requestBinary: outputRequest.ssRequestBinary);
return resultRestRequest;
};
    public Func<IRequestContext, RestConsumeHttpResponse, CancellationToken, Task<RestConsumeHttpResponse>>? OnAfterResponseAsync { get; } = null;

    public async Task<IReadOnlyDictionary<string, StringValues>> GetHeadersAsync(IRequestContext requestContext, CancellationToken cancellationToken) {
        return ImmutableDictionary<string, StringValues>.Empty;
    }
}