using Microsoft.AspNetCore.Mvc;
using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Abstractions.Controllers;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;
using OutSystems.RESTService.Runtime.Core;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;
using OutSystems.RESTService.Runtime.Core.ErrorHandling;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Core.ClientSettings;

namespace ssRuntimeDestroyer.ScreenServices;

[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[Route("screenservices/RuntimeDestroyer/MainFlow/ScreenAggregate")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class RuntimeDestroyer_MainFlow_ScreenAggregate_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return RuntimeDestroyer_MainFlow_ScreenAggregate_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return RuntimeDestroyer_MainFlow_ScreenAggregate_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(RuntimeDestroyer_MainFlow_ScreenAggregate_Controller); }
        public override void EnsureInitialized() { RuntimeDestroyer_MainFlow_ScreenAggregate_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return RuntimeDestroyer_MainFlow_ScreenAggregate_Controller.GetDbBinaryConfigs(); }
    }

    public static readonly CheckPermissionsIndex Permissions;

    private static readonly HashSet<IScreenControllerProxy> childControllers = new();
    public static IEnumerable<IScreenControllerProxy> GetChildControllers() {
        return childControllers;
    }

    private static volatile bool initialized = false;
    public static void EnsureInitialized() {
        // Only a single thread can do initializations at the time. Allows the CheckPermissionsIndex class non-threadsafe.
        // This should always be done only once at ApplicationStart
        lock (ScreenServicesApiController.GlobalScreenServicesInitializationLock) {
            if (!initialized) {
                initialized = true; // InitPermissionIndexes propagates to new parents as well so we can set it as initialized here before going into recursion

                SafeAddChildController(RuntimeDestroyer_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("MainFlow.ScreenAggregate"), RuntimeDestroyer_MainFlow_ScreenAggregate_Controller.CheckPermissionsAsync);
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }


    public static async Task CheckPermissionsAsync(IRequestContext requestContext, CancellationToken cancellationToken) {
        return;

    }


    static RuntimeDestroyer_MainFlow_ScreenAggregate_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*Employee.CreateOrUpdateEmployee*/"sTTG50eVjk+Ae8n6o1m2aQ*vveL5Hud5k6hByqjemU1GA.#CreateOrUpdateEntity", 
/*Employee.DeleteAllEmployee*/"sTTG50eVjk+Ae8n6o1m2aQ*vveL5Hud5k6hByqjemU1GA.#DeleteAllEntity"});

    }

    public RuntimeDestroyer_MainFlow_ScreenAggregate_Controller(
        IAppInfo appInfo,
        IApplicationLogger applicationLogger,
        ISettingsProvider settingsProvider,
        IHttpContextAccessor httpContextAccessor,
        IRequestContext requestContext,
        IClientSettingsService clientSettingsService
    ) : base(
        appInfo,
        applicationLogger,
        settingsProvider,
        httpContextAccessor,
        requestContext,
        clientSettingsService
    ) {
    }

[HttpPost]
[Route("ScreenDataSetGetEmployees")]
[RESTScreenServicesActionProperties(Name="GetEmployees",Screen="ScreenAggregate",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetEmployees(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "2A6dfi5SGfsQboyiA6ktqw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        RuntimeDestroyer_MainFlow_ScreenAggregate_ScreenModel model = null;
AggregateInputsRecord inputs = null;
CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {model = RESTRuntimeDestroyer_MainFlow_ScreenAggregate_ScreenModel.FromJSON(screenModel, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetEmployees_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetEmployees_maxRecords = model.varLcMaxRecords;
} else {
datasetGetEmployees_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetEmployees_startIndex;
if((inputs.StartIndex == null)) {
datasetGetEmployees_startIndex = model.varLcStartIndex;
} else {
datasetGetEmployees_startIndex = inputs.StartIndex.Value;
}

if((datasetGetEmployees_maxRecords < 1)) {
datasetGetEmployees_maxRecords = 1;
}

AggregateRecord<RL_3be1495f5fc898e41acd45a19b4ddd3b> ds_output = new AggregateRecord<RL_3be1495f5fc898e41acd45a19b4ddd3b>();
long count;
(ds_output.List,count) = await RuntimeDestroyer_MainFlow_ScreenAggregate_ScreenModel.datasetGetEmployees(requestContext,datasetGetEmployees_maxRecords,datasetGetEmployees_startIndex,IterationMultiplicity.Multiple,model.varLcTableSort,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssRuntimeDestroyer.RestRecords.RESTRC_3b55179c5be20c3d1041cf4a1dcf3f76>(ssRuntimeDestroyer.RestRecords.RESTRC_3b55179c5be20c3d1041cf4a1dcf3f76.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ssCreateOrUpdateEmployee")]
[RESTScreenServicesActionProperties(Name="CreateOrUpdateEmployee",Screen="ScreenAggregate",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ssCreateOrUpdateEmployee(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "DGWwvDkWRAvoNPhH1KseZg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        RuntimeDestroyer_MainFlow_ScreenAggregate_ssCreateOrUpdateEmployee_Model inputs = null;
long res_outParamId = 0L;
CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTRuntimeDestroyer_MainFlow_ScreenAggregate_ssCreateOrUpdateEmployee_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res_outParamId = await ExtendedActions.CreateOrUpdateEmployee(requestContext,inputs.inParamSource.ChangedAttributes,inputs.inParamSource,cancellationToken);

var output = RESTRuntimeDestroyer_MainFlow_ScreenAggregate_ssCreateOrUpdateEmployee_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamId);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ssDeleteAllEmployee")]
[RESTScreenServicesActionProperties(Name="DeleteAllEmployee",Screen="ScreenAggregate",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ssDeleteAllEmployee(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "6g+6lvT1aUGpMLSpTAG69Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}


// 
await ExtendedActions.DeleteAllEmployee(requestContext,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}
}
