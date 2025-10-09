using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssRuntimeDestroyer.ScreenServices;

public class RESTRuntimeDestroyer_MainFlow_ScreenAggregate_ssCreateOrUpdateEmployee_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Id")]
public long? outParamId;


    public static RESTRuntimeDestroyer_MainFlow_ScreenAggregate_ssCreateOrUpdateEmployee_Outputs FromOutputs(IBehaviorsConfiguration conf, long outParamId) {RESTRuntimeDestroyer_MainFlow_ScreenAggregate_ssCreateOrUpdateEmployee_Outputs result = new RESTRuntimeDestroyer_MainFlow_ScreenAggregate_ssCreateOrUpdateEmployee_Outputs();
conf.IncludeBinariesURL = false;
// Write optimized result.outParamId
result.outParamId = (long?) 0L;
return result;
}


    

    
}
