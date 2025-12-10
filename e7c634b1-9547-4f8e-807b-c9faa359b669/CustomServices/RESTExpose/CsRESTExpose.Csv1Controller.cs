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


namespace ssRuntimeDestroyer.CsRESTExpose.Csv1;

[EnableCors("RestExposeCorsPolicy")]
[TypeFilter(typeof(OnRestExposeRequestFilter), Arguments = new object[] { typeof(Csv1Controller.OnFilter), "5ea5c532-52b0-46a6-8c6a-aca1742ab164", new string[] { "rest/v1/swagger.json" } })]
[TypeFilter(typeof(OnRestExposeResponseFilter), Arguments = new object[] { typeof(Csv1Controller.OnFilter) })]
[Route("rest/v1")]
[RestServiceControllerConfiguration(DefaultValuesBehavior=DefaultValuesBehavior.DontSend, HTTPSecurity=HTTPSecurity.SSL)]
public class Csv1Controller : RestExposeApiController {
public class OnFilter : AbstractFilter {
  public override bool SkipOnRequestImplementation => true;
  public override bool SkipOnResponseImplementation => true;
}

public Csv1Controller(IAppInfo appInfo, IApplicationLogger applicationLogger, ISettingsProvider settingsProvider, IHttpContextAccessor httpContextAccessor, IRequestContext requestContext) : base(appInfo, applicationLogger, settingsProvider, httpContextAccessor, requestContext) { }
public override bool IsSwaggerRequest(string currentRoute) {
    return currentRoute == "rest/v1/swagger.json";
}
[HttpGet]
[Route("swagger.json")]
[Produces(typeof(string))]
public IActionResult FlowSwagger() {
    return base.SwaggerJson("v1");
}

[HttpGet]
[Route("")]
[Produces(typeof(string))]
[RESTExposeActionProperties("RunTests", false, false)]
public async Task<IActionResult> Flowv1ActionRunTests([FromQuery(Name= "Port"), ModelBinder(typeof(AbstractParamBinder))] string auxinParamPort = null,CancellationToken cancellationToken = default) {
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
string inParamPort = "";
try {
if (auxinParamPort == null) {
  validationErrors.Add("The 'Port' URL parameter is missing in the request.");
} else {
inParamPort = auxinParamPort;
}
} catch {
  validationErrors.Add("Failed to parse. 'Text' compatible data type is required for parameter 'Port'.");
}
if (validationErrors.Any()) {
    throw RestExposeErrorsHelper.InvalidRequest(new Dictionary<string, string[]>() { { "ValidationErrors", validationErrors.ToArray() } });
}

string outParamBody;
cancellationToken.ThrowIfCancellationRequested();
outParamBody = await ssRuntimeDestroyer.CsRESTExpose.Csv1.Csv1ControllerFlows.Flowv1ActionRunTests(requestContext,inParamPort,cancellationToken);

await DatabaseAccess.FreeUpResourcesAsync(true);
return this.GetResponseResult(outParamBody);
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

