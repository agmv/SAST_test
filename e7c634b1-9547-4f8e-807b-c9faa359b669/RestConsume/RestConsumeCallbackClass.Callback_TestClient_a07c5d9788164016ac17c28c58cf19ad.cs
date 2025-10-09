using System.Diagnostics;

namespace ssRuntimeDestroyer;

public class Callback_TestClient_a07c5d9788164016ac17c28c58cf19ad : ICallback_TestClient_a07c5d9788164016ac17c28c58cf19ad {
    private static readonly ActivitySource activitySource = new(typeof(Callback_TestClient_a07c5d9788164016ac17c28c58cf19ad).FullName!);

    public static Callback_TestClient_a07c5d9788164016ac17c28c58cf19ad NewInstance() {
        return new Callback_TestClient_a07c5d9788164016ac17c28c58cf19ad();
    }

    public class lcvOnBeforeRequest : VarsBag {
public ST_2e4d23f993f70b2a453aff430875354bStructure inParamRequest;
/// <summary>
/// Variable <code>HttpHeader</code> that represents the Service Studio HTTPHeader
///  <code>HttpHeader</code> <p>Description: </p>
/// </summary>
public ST_b6163e36a4b633b09c820fee73ba221eStructure varLcHttpHeader = new ST_b6163e36a4b633b09c820fee73ba221eStructure();

public lcvOnBeforeRequest(ST_2e4d23f993f70b2a453aff430875354bStructure inParamRequest) {
this.inParamRequest = inParamRequest;
}
}
public class lcoOnBeforeRequest : VarsBag {
public ST_2e4d23f993f70b2a453aff430875354bStructure outParamCustomizedRequest = new ST_2e4d23f993f70b2a453aff430875354bStructure();

public lcoOnBeforeRequest() {
}
}
/// <summary>
/// Action <code>OnBeforeRequest</code> that represents the Service Studio action
///  <code>OnBeforeRequest</code> <p> Description: </p>
/// </summary>
public async Task<ST_2e4d23f993f70b2a453aff430875354bStructure> FlowTestClientActionOnBeforeRequest(IRequestContext requestContext,ST_2e4d23f993f70b2a453aff430875354bStructure inParamRequest,CancellationToken cancellationToken) {
ST_2e4d23f993f70b2a453aff430875354bStructure outParamCustomizedRequest = default;
lcoOnBeforeRequest result = new lcoOnBeforeRequest();
lcvOnBeforeRequest localVars = new lcvOnBeforeRequest(inParamRequest);
try {
cancellationToken.ThrowIfCancellationRequested();
using (activitySource.CreateCustomActionActivity("REST (Consume)", "OnBeforeRequest", "3c1e11ee-4458-4a0b-a3da-72c991827b2b", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669")){
// HttpHeader
// HttpHeader.Name = "Content-Type"
localVars.varLcHttpHeader.ssName = "Content-Type";

// HttpHeader.Value = "application/json"
localVars.varLcHttpHeader.ssValue = "application/json";
// CustomizedRequest = Request
// CustomizedRequest = Request
result.outParamCustomizedRequest=localVars.inParamRequest;
// CustomizedRequest.Headers.Current = HttpHeader
result.outParamCustomizedRequest.ssHeaders.CurrentRec = localVars.varLcHttpHeader;
// CustomizedRequest.BaseURL = Request.BaseURL + Request.URLQueryParameters
// CustomizedRequest.BaseURL = Request.BaseURL + ":" + Request.URLQueryParameters[Request.URLQueryParameters.Length - 1].Value
result.outParamCustomizedRequest.ssBaseURL = ((localVars.inParamRequest.ssBaseURL+":")+localVars.inParamRequest.ssURLQueryParameters[(localVars.inParamRequest.ssURLQueryParameters.Length-1)].ssValue);
} //close CreateActionActivity using block
} //try

finally {
outParamCustomizedRequest = result.outParamCustomizedRequest;
}
RETURN_STATEMENT:
return outParamCustomizedRequest;
}

public static class FuncFlowTestClientActionOnBeforeRequest {



}


}