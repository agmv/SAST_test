using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;
using OutSystems.RESTService.Runtime.Core;
using OutSystems.RESTService.Runtime.Core.Binders;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.ErrorHandling;
using OutSystems.RESTService.Runtime.Core.Filters;
using ssRuntimeDestroyer.CsRESTExpose;


namespace ssRuntimeDestroyer.CsRESTExpose.CsTest;

[EnableCors("RestExposeCorsPolicy")]
[TypeFilter(typeof(OnRestExposeRequestFilter), Arguments = new object[] { typeof(CsTestController.OnFilter), "06c0448e-5759-41f3-a374-91678ce171e4", new string[] { "rest/Test/swagger.json","rest/Test" } })]
[TypeFilter(typeof(OnRestExposeResponseFilter), Arguments = new object[] { typeof(CsTestController.OnFilter) })]
[Route("rest/Test")]
[RestServiceControllerConfiguration(DefaultValuesBehavior=DefaultValuesBehavior.DontSend, HTTPSecurity=HTTPSecurity.SSL)]
public class CsTestController : RestExposeApiController {
public class OnFilter : AbstractFilter {
  public override bool SkipOnRequestImplementation => true;
  public override bool SkipOnResponseImplementation => true;
}

public CsTestController(IAppInfo appInfo, IApplicationLogger applicationLogger, ISettingsProvider settingsProvider, IHttpContextAccessor httpContextAccessor, IRequestContext requestContext) : base(appInfo, applicationLogger, settingsProvider, httpContextAccessor, requestContext) { }
public override bool IsSwaggerRequest(string currentRoute) {
    return currentRoute == "rest/Test" || currentRoute == "rest/Test/swagger.json";
}
[HttpGet]
[Route("swagger.json")]
[Produces(typeof(string))]
public IActionResult FlowSwagger() {
    return base.SwaggerJson("Test");
}

[HttpGet]
[Route("")]
[Produces(typeof(string))]
public IActionResult FlowSwaggerDoc() {
  return base.SwaggerDoc("Test");
}

[HttpPost]
[Route("HttpMethod")]
[Produces(typeof(void))]
[RESTExposeActionProperties("HttpMethodPOST", false, false)]
public async Task<IActionResult> FlowTestActionHttpMethodPOST([FromBody]ssRuntimeDestroyer.RestRecords.JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord auxinParamHttpRequest,CancellationToken cancellationToken = default) {
var appInfo = AppInfo.GetAppInfo();
var requestContext = appInfo.RequestContext;
appInfo.CheckIsApplicationEnabled();
DateTime startExecution = DateTime.UtcNow;
string errorLogId = "";
try {
cancellationToken.ThrowIfCancellationRequested();
AppInfo.GetAppInfo().RequestContext.IsServiceAction = true;

this.ValidateRequestSecurity();
var validationErrors = new List<String>();
EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord inParamHttpRequest = new EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord();
try {
if (auxinParamHttpRequest == null) {
  validationErrors.Add("The request body is missing.");
} else {
inParamHttpRequest = ssRuntimeDestroyer.RestRecords.JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord.ToStructure(auxinParamHttpRequest, this.BehaviorsConfiguration);
}
} catch {
  validationErrors.Add("Failed to parse JSON request content.");
}
if (validationErrors.Any()) {
    throw RestExposeErrorsHelper.InvalidRequest(new Dictionary<string, string[]>() { { "ValidationErrors", validationErrors.ToArray() } });
}

cancellationToken.ThrowIfCancellationRequested();
await ssRuntimeDestroyer.CsRESTExpose.CsTest.CsTestControllerFlows.FlowTestActionHttpMethodPOST(requestContext,inParamHttpRequest,cancellationToken);

await DatabaseAccess.FreeUpResourcesAsync(true);
return this.GetResponseResult();
} catch (Exception ex) {
  await DatabaseAccess.FreeUpResourcesAsync(false);
  if (ex is RestExposeException) {
    throw;
  }
  throw new RestExposeException(ex, RestServiceHttpUtils.GetCurrentStatusCode(httpContextAccessor.Context.Response));
} finally {
AppInfo.GetAppInfo().RequestContext.IsServiceAction = false;

}
}


[HttpGet]
[Route("HttpMethodExcelEntity")]
[Produces(typeof(ssRuntimeDestroyer.RestRecords.JSONEN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord[]))]
[RESTExposeActionProperties("HttpMethodExcelEntityGET", false, false)]
public async Task<IActionResult> FlowTestActionHttpMethodExcelEntityGET(CancellationToken cancellationToken = default) {
var appInfo = AppInfo.GetAppInfo();
var requestContext = appInfo.RequestContext;
appInfo.CheckIsApplicationEnabled();
DateTime startExecution = DateTime.UtcNow;
string errorLogId = "";
try {
cancellationToken.ThrowIfCancellationRequested();
AppInfo.GetAppInfo().RequestContext.IsServiceAction = true;

this.ValidateRequestSecurity();
var validationErrors = new List<String>();
if (validationErrors.Any()) {
    throw RestExposeErrorsHelper.InvalidRequest(new Dictionary<string, string[]>() { { "ValidationErrors", validationErrors.ToArray() } });
}

RL_1e7b3d2125f39aa37d81e604b3a0a4fb outParamSampleList;
cancellationToken.ThrowIfCancellationRequested();
outParamSampleList = await ssRuntimeDestroyer.CsRESTExpose.CsTest.CsTestControllerFlows.FlowTestActionHttpMethodExcelEntityGET(requestContext,cancellationToken);

await DatabaseAccess.FreeUpResourcesAsync(true);
return this.GetResponseResult(typeof(ssRuntimeDestroyer.RestRecords.JSONEN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord[]), outParamSampleList.ToArray<ssRuntimeDestroyer.RestRecords.JSONEN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord>(ssRuntimeDestroyer.RestRecords.JSONEN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord.FromStructureDelegate(this.BehaviorsConfiguration)));
} catch (Exception ex) {
  await DatabaseAccess.FreeUpResourcesAsync(false);
  if (ex is RestExposeException) {
    throw;
  }
  throw new RestExposeException(ex, RestServiceHttpUtils.GetCurrentStatusCode(httpContextAccessor.Context.Response));
} finally {
AppInfo.GetAppInfo().RequestContext.IsServiceAction = false;

}
}


[HttpPost]
[Route("HttpMethodExcel")]
[Produces(typeof(void))]
[RESTExposeActionProperties("HttpMethodExcelPOST", true, false)]
public async Task<IActionResult> FlowTestActionHttpMethodExcelPOST([FromBody]byte[] auxinParamHttpRequest,CancellationToken cancellationToken = default) {
var appInfo = AppInfo.GetAppInfo();
var requestContext = appInfo.RequestContext;
appInfo.CheckIsApplicationEnabled();
DateTime startExecution = DateTime.UtcNow;
string errorLogId = "";
try {
cancellationToken.ThrowIfCancellationRequested();
AppInfo.GetAppInfo().RequestContext.IsServiceAction = true;

this.ValidateRequestSecurity();
var validationErrors = new List<String>();
byte[] inParamHttpRequest = new byte[] {};
try {
if (auxinParamHttpRequest == null || auxinParamHttpRequest.Length == 0) {
  validationErrors.Add("The request body is missing.");
} else {
inParamHttpRequest = auxinParamHttpRequest;
}
} catch {
  validationErrors.Add("Failed to parse. 'BinaryData' compatible data type is required for parameter 'HttpRequest'.");
}
if (validationErrors.Any()) {
    throw RestExposeErrorsHelper.InvalidRequest(new Dictionary<string, string[]>() { { "ValidationErrors", validationErrors.ToArray() } });
}

cancellationToken.ThrowIfCancellationRequested();
await ssRuntimeDestroyer.CsRESTExpose.CsTest.CsTestControllerFlows.FlowTestActionHttpMethodExcelPOST(requestContext,inParamHttpRequest,cancellationToken);

await DatabaseAccess.FreeUpResourcesAsync(true);
return this.GetResponseResult();
} catch (Exception ex) {
  await DatabaseAccess.FreeUpResourcesAsync(false);
  if (ex is RestExposeException) {
    throw;
  }
  throw new RestExposeException(ex, RestServiceHttpUtils.GetCurrentStatusCode(httpContextAccessor.Context.Response));
} finally {
AppInfo.GetAppInfo().RequestContext.IsServiceAction = false;

}
}


[HttpDelete]
[Route("HttpMethod")]
[Produces(typeof(void))]
[RESTExposeActionProperties("HttpMethodDELETE", false, false)]
public async Task<IActionResult> FlowTestActionHttpMethodDELETE([FromQuery(Name= "HttpRequestIdentifier"), ModelBinder(typeof(LongIntegerParamBinder))] long? auxinParamHttpRequestIdentifier = null,CancellationToken cancellationToken = default) {
var appInfo = AppInfo.GetAppInfo();
var requestContext = appInfo.RequestContext;
appInfo.CheckIsApplicationEnabled();
DateTime startExecution = DateTime.UtcNow;
string errorLogId = "";
try {
cancellationToken.ThrowIfCancellationRequested();
AppInfo.GetAppInfo().RequestContext.IsServiceAction = true;

this.ValidateRequestSecurity();
var validationErrors = new List<String>();
long inParamHttpRequestIdentifier = 0L;
try {
if (auxinParamHttpRequestIdentifier == null) {
  validationErrors.Add("The 'HttpRequestIdentifier' URL parameter is missing in the request.");
} else {
inParamHttpRequestIdentifier = auxinParamHttpRequestIdentifier.Value;
}
} catch {
  validationErrors.Add("Failed to parse. 'HttpRequestIdentifier' compatible data type is required for parameter 'HttpRequestIdentifier'.");
}
if (validationErrors.Any()) {
    throw RestExposeErrorsHelper.InvalidRequest(new Dictionary<string, string[]>() { { "ValidationErrors", validationErrors.ToArray() } });
}

cancellationToken.ThrowIfCancellationRequested();
await ssRuntimeDestroyer.CsRESTExpose.CsTest.CsTestControllerFlows.FlowTestActionHttpMethodDELETE(requestContext,inParamHttpRequestIdentifier,cancellationToken);

await DatabaseAccess.FreeUpResourcesAsync(true);
return this.GetResponseResult();
} catch (Exception ex) {
  await DatabaseAccess.FreeUpResourcesAsync(false);
  if (ex is RestExposeException) {
    throw;
  }
  throw new RestExposeException(ex, RestServiceHttpUtils.GetCurrentStatusCode(httpContextAccessor.Context.Response));
} finally {
AppInfo.GetAppInfo().RequestContext.IsServiceAction = false;

}
}


[HttpPut]
[Route("HttpMethod")]
[Produces(typeof(void))]
[RESTExposeActionProperties("HttpMethodPUT", false, false)]
public async Task<IActionResult> FlowTestActionHttpMethodPUT([FromBody]ssRuntimeDestroyer.RestRecords.JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord auxinParamHttpRequest,CancellationToken cancellationToken = default) {
var appInfo = AppInfo.GetAppInfo();
var requestContext = appInfo.RequestContext;
appInfo.CheckIsApplicationEnabled();
DateTime startExecution = DateTime.UtcNow;
string errorLogId = "";
try {
cancellationToken.ThrowIfCancellationRequested();
AppInfo.GetAppInfo().RequestContext.IsServiceAction = true;

this.ValidateRequestSecurity();
var validationErrors = new List<String>();
EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord inParamHttpRequest = new EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord();
try {
if (auxinParamHttpRequest == null) {
  validationErrors.Add("The request body is missing.");
} else {
inParamHttpRequest = ssRuntimeDestroyer.RestRecords.JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord.ToStructure(auxinParamHttpRequest, this.BehaviorsConfiguration);
}
} catch {
  validationErrors.Add("Failed to parse JSON request content.");
}
if (validationErrors.Any()) {
    throw RestExposeErrorsHelper.InvalidRequest(new Dictionary<string, string[]>() { { "ValidationErrors", validationErrors.ToArray() } });
}

cancellationToken.ThrowIfCancellationRequested();
await ssRuntimeDestroyer.CsRESTExpose.CsTest.CsTestControllerFlows.FlowTestActionHttpMethodPUT(requestContext,inParamHttpRequest,cancellationToken);

await DatabaseAccess.FreeUpResourcesAsync(true);
return this.GetResponseResult();
} catch (Exception ex) {
  await DatabaseAccess.FreeUpResourcesAsync(false);
  if (ex is RestExposeException) {
    throw;
  }
  throw new RestExposeException(ex, RestServiceHttpUtils.GetCurrentStatusCode(httpContextAccessor.Context.Response));
} finally {
AppInfo.GetAppInfo().RequestContext.IsServiceAction = false;

}
}


[HttpGet]
[Route("HttpMethod")]
[Produces(typeof(ssRuntimeDestroyer.RestRecords.JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord[]))]
[RESTExposeActionProperties("HttpMethodGET", false, false)]
public async Task<IActionResult> FlowTestActionHttpMethodGET(CancellationToken cancellationToken = default) {
var appInfo = AppInfo.GetAppInfo();
var requestContext = appInfo.RequestContext;
appInfo.CheckIsApplicationEnabled();
DateTime startExecution = DateTime.UtcNow;
string errorLogId = "";
try {
cancellationToken.ThrowIfCancellationRequested();
AppInfo.GetAppInfo().RequestContext.IsServiceAction = true;

this.ValidateRequestSecurity();
var validationErrors = new List<String>();
if (validationErrors.Any()) {
    throw RestExposeErrorsHelper.InvalidRequest(new Dictionary<string, string[]>() { { "ValidationErrors", validationErrors.ToArray() } });
}

RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5 outParamHttpRequestList;
cancellationToken.ThrowIfCancellationRequested();
outParamHttpRequestList = await ssRuntimeDestroyer.CsRESTExpose.CsTest.CsTestControllerFlows.FlowTestActionHttpMethodGET(requestContext,cancellationToken);

await DatabaseAccess.FreeUpResourcesAsync(true);
return this.GetResponseResult(typeof(ssRuntimeDestroyer.RestRecords.JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord[]), outParamHttpRequestList.ToArray<ssRuntimeDestroyer.RestRecords.JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord>(ssRuntimeDestroyer.RestRecords.JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord.FromStructureDelegate(this.BehaviorsConfiguration)));
} catch (Exception ex) {
  await DatabaseAccess.FreeUpResourcesAsync(false);
  if (ex is RestExposeException) {
    throw;
  }
  throw new RestExposeException(ex, RestServiceHttpUtils.GetCurrentStatusCode(httpContextAccessor.Context.Response));
} finally {
AppInfo.GetAppInfo().RequestContext.IsServiceAction = false;

}
}


[HttpGet]
[Route("HttpMethodExcelStatic")]
[Produces(typeof(byte[]))]
[RESTExposeActionProperties("HttpMethodExcelStaticGET", false, true)]
public async Task<IActionResult> FlowTestActionHttpMethodExcelStaticGET(CancellationToken cancellationToken = default) {
var appInfo = AppInfo.GetAppInfo();
var requestContext = appInfo.RequestContext;
appInfo.CheckIsApplicationEnabled();
DateTime startExecution = DateTime.UtcNow;
string errorLogId = "";
try {
cancellationToken.ThrowIfCancellationRequested();
AppInfo.GetAppInfo().RequestContext.IsServiceAction = true;

this.ValidateRequestSecurity();
var validationErrors = new List<String>();
if (validationErrors.Any()) {
    throw RestExposeErrorsHelper.InvalidRequest(new Dictionary<string, string[]>() { { "ValidationErrors", validationErrors.ToArray() } });
}

byte[] outParamBinaryData;
cancellationToken.ThrowIfCancellationRequested();
outParamBinaryData = await ssRuntimeDestroyer.CsRESTExpose.CsTest.CsTestControllerFlows.FlowTestActionHttpMethodExcelStaticGET(requestContext,cancellationToken);

await DatabaseAccess.FreeUpResourcesAsync(true);
return this.GetResponseResult(outParamBinaryData);
} catch (Exception ex) {
  await DatabaseAccess.FreeUpResourcesAsync(false);
  if (ex is RestExposeException) {
    throw;
  }
  throw new RestExposeException(ex, RestServiceHttpUtils.GetCurrentStatusCode(httpContextAccessor.Context.Response));
} finally {
AppInfo.GetAppInfo().RequestContext.IsServiceAction = false;

}
}

}

