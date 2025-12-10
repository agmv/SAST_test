using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssRuntimeDestroyer.ScreenServices;

public class RESTRuntimeDestroyer_MainFlow_ScreenAggregate_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetEmployees")]
public RESTAggregateRecord<ssRuntimeDestroyer.RestRecords.RESTRC_3b55179c5be20c3d1041cf4a1dcf3f76> ScreenDataSetGetEmployees;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("MaxRecords")]
public int? varLcMaxRecords;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();


    public static RESTRuntimeDestroyer_MainFlow_ScreenAggregate_ScreenModel FromJSON(JObject screenModel, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTRuntimeDestroyer_MainFlow_ScreenAggregate_ScreenModel result = screenModel.ToObject<RESTRuntimeDestroyer_MainFlow_ScreenAggregate_ScreenModel>(settings);
return result;
}


    public RuntimeDestroyer_MainFlow_ScreenAggregate_ScreenModel ToModel() {string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 50 : variables.varLcMaxRecords.Value;
AggregateRecord<RL_3be1495f5fc898e41acd45a19b4ddd3b> _ScreenDataSetGetEmployees = (variables.ScreenDataSetGetEmployees != null) ? variables.ScreenDataSetGetEmployees.FromJS((array) => {
return RL_3be1495f5fc898e41acd45a19b4ddd3b.FromRestList(array, ssRuntimeDestroyer.RestRecords.RESTRC_3b55179c5be20c3d1041cf4a1dcf3f76.ToStructure);
}
) : null;
RuntimeDestroyer_MainFlow_ScreenAggregate_ScreenModel screenModel = new RuntimeDestroyer_MainFlow_ScreenAggregate_ScreenModel(varLcTableSort, varLcStartIndex, varLcMaxRecords, _ScreenDataSetGetEmployees);
return screenModel;
}

}
