using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssRuntimeDestroyer.ScreenServices;

public class RESTRuntimeDestroyer_MainFlow_FetchData_DataActionGetWeekday_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Out1")]
public string outParamOut1;


    public static RESTRuntimeDestroyer_MainFlow_FetchData_DataActionGetWeekday_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamOut1) {RESTRuntimeDestroyer_MainFlow_FetchData_DataActionGetWeekday_Outputs result = new RESTRuntimeDestroyer_MainFlow_FetchData_DataActionGetWeekday_Outputs();
result.outParamOut1 = outParamOut1;
return result;
}


    public static RuntimeDestroyer_MainFlow_FetchData_DataActionGetWeekday_Model ToModel(RESTRuntimeDestroyer_MainFlow_FetchData_DataActionGetWeekday_Outputs variables) {RuntimeDestroyer_MainFlow_FetchData_DataActionGetWeekday_Model result = new RuntimeDestroyer_MainFlow_FetchData_DataActionGetWeekday_Model();
result.outParamOut1 = variables == null || variables.outParamOut1 == null ? "" : variables.outParamOut1;
return result;
}


    public static RESTRuntimeDestroyer_MainFlow_FetchData_DataActionGetWeekday_Outputs FromModel(IBehaviorsConfiguration conf, RuntimeDestroyer_MainFlow_FetchData_DataActionGetWeekday_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTRuntimeDestroyer_MainFlow_FetchData_DataActionGetWeekday_Outputs result = new RESTRuntimeDestroyer_MainFlow_FetchData_DataActionGetWeekday_Outputs();
result.outParamOut1 = screenModel.outParamOut1;
return result;
}

}
