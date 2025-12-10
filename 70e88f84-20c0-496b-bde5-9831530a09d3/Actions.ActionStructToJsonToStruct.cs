namespace ssRuntimeDestroyerLib;

public partial class Actions {
public class lcvStructToJsonToStruct : VarsBag {
/// <summary>
/// Variable <code>ExpectedHttpResponse</code> that represents the Service Studio HttpResponseStruct
///  <code>ExpectedHttpResponse</code> <p>Description: </p>
/// </summary>
public ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure varLcExpectedHttpResponse = new ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure();

public string resJSONSerialize1_outParamJSON = "";
public ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure resJSONDeserializeHttpResponse_outParamData = new ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure();
public lcvStructToJsonToStruct() {
}
}
/// <summary>
/// Action <code>StructToJsonToStruct</code> that represents the Service Studio action
///  <code>StructToJsonToStruct</code> <p> Description: </p>
/// </summary>
public static async Task ActionStructToJsonToStruct(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvStructToJsonToStruct localVars = new lcvStructToJsonToStruct();
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("StructToJsonToStruct", "46b60652-fb15-4d40-b471-190d1d9bb525", "RuntimeDestroyerLib", "70e88f84-20c0-496b-bde5-9831530a09d3") : null){
// ExpectedHttpResponse
// ExpectedHttpResponse.StatusCode = 200
localVars.varLcExpectedHttpResponse.ssStatusCode = 200;

// ExpectedHttpResponse.Body = ""
localVars.varLcExpectedHttpResponse.ssBody = "";
// JSON Serialize JsonSerializeStructToJsonToStructJSONSerialize1
FuncActionStructToJsonToStruct.JsonSerializeStructToJsonToStructJSONSerialize1(localVars.varLcExpectedHttpResponse, out localVars.resJSONSerialize1_outParamJSON);
// JSON Deserialize JsonDeserializeStructToJsonToStructJSONDeserializeHttpResponse
FuncActionStructToJsonToStruct.JsonDeserializeStructToJsonToStructJSONDeserializeHttpResponse(localVars.resJSONSerialize1_outParamJSON, out localVars.resJSONDeserializeHttpResponse_outParamData);
// AssertTrue
await Actions.ActionAssertTrue(requestContext,((localVars.varLcExpectedHttpResponse.ssStatusCode==localVars.resJSONDeserializeHttpResponse_outParamData.ssStatusCode)&&(localVars.varLcExpectedHttpResponse.ssBody==localVars.resJSONDeserializeHttpResponse_outParamData.ssBody)),"StructToJsonToStruct",cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionStructToJsonToStruct {



/// <summary>
/// JSONSerialize: JsonSerializeStructToJsonToStructJSONSerialize1 (Ku6NVYSyd_U_matxTH_vcOw)  of Action
///  "StructToJsonToStruct"
/// </summary>
public static void JsonSerializeStructToJsonToStructJSONSerialize1 (ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure inParamRecord, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = ssRuntimeDestroyerLib.RestRecords.JSONST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure.FromStructure(inParamRecord, config);
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

/// <summary>
/// JSON Deserialize : JsonDeserializeStructToJsonToStructJSONDeserializeHttpResponse
///  (K_VvxamWKDEqPlXEElShmug)  of Action "StructToJsonToStruct"
/// </summary>
public static void JsonDeserializeStructToJsonToStructJSONDeserializeHttpResponse (string inParamJson, out ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure outParamData) {
outParamData = new ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure();;
ssRuntimeDestroyerLib.RestRecords.JSONST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure holder = null;

var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
    DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var serializerSettings = config.SerializerSettings;

try {
	holder = Newtonsoft.Json.JsonConvert.DeserializeObject<ssRuntimeDestroyerLib.RestRecords.JSONST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure>(inParamJson, serializerSettings);
    outParamData = ssRuntimeDestroyerLib.RestRecords.JSONST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure.ToStructure(holder, config);
} catch (Exception e) {
    throw InvalidJsonErrorsHelper.FailedToDeserialize("HttpResponseStruct", e);
}

}

}


}
