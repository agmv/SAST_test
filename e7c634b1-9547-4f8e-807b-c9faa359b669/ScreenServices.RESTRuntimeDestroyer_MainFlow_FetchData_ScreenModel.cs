using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssRuntimeDestroyer.ScreenServices;

public class RESTRuntimeDestroyer_MainFlow_FetchData_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetWeekday")]
public RESTRuntimeDestroyer_MainFlow_FetchData_DataActionGetWeekday_Outputs varLcGetWeekday;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();


    public static RESTRuntimeDestroyer_MainFlow_FetchData_ScreenModel FromJSON(JObject screenModel, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTRuntimeDestroyer_MainFlow_FetchData_ScreenModel result = screenModel.ToObject<RESTRuntimeDestroyer_MainFlow_FetchData_ScreenModel>(settings);
return result;
}


    public RuntimeDestroyer_MainFlow_FetchData_ScreenModel ToModel() {RuntimeDestroyer_MainFlow_FetchData_DataActionGetWeekday_Model _varLcGetWeekday = (variables.varLcGetWeekday != null) ? RESTRuntimeDestroyer_MainFlow_FetchData_DataActionGetWeekday_Outputs.ToModel(variables.varLcGetWeekday) : null;
RuntimeDestroyer_MainFlow_FetchData_ScreenModel screenModel = new RuntimeDestroyer_MainFlow_FetchData_ScreenModel(_varLcGetWeekday);
return screenModel;
}

}
