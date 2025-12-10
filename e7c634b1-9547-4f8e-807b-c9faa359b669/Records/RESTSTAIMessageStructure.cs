using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AIMessage
public class RESTSTAIMessageStructure : AbstractRESTStructure<STAIMessageStructure> {
[JsonProperty("Content")]
public RestList<ssRuntimeDestroyer.RestRecords.RESTSTAIItemStructure> AttrContent;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("Role")]
public long? AttrRole;

[JsonProperty("ActionName")]
public string AttrActionName;

[JsonProperty("ActionParameters")]
public string AttrActionParameters;

[JsonProperty("ActionId")]
public string AttrActionId;

public RESTSTAIMessageStructure() { }

public RESTSTAIMessageStructure (STAIMessageStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrContent = s.ssContent.Length == 0 ? null : s.ssContent.ToRestList<ssRuntimeDestroyer.RestRecords.RESTSTAIItemStructure>(ssRuntimeDestroyer.RestRecords.RESTSTAIItemStructure.FromStructureDelegate(config));
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrRole = ConvertToRestWithoutDefaults(s.ssRole, 0L);
AttrActionName = ConvertToRestWithoutDefaults(s.ssActionName, "");
AttrActionParameters = ConvertToRestWithoutDefaults(s.ssActionParameters, "");
AttrActionId = ConvertToRestWithoutDefaults(s.ssActionId, "");
  } else {
AttrContent = s.ssContent.ToRestList<ssRuntimeDestroyer.RestRecords.RESTSTAIItemStructure>(ssRuntimeDestroyer.RestRecords.RESTSTAIItemStructure.FromStructureDelegate(config));
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrRole = (long?) s.ssRole;
AttrActionName = s.ssActionName;
AttrActionParameters = s.ssActionParameters;
AttrActionId = s.ssActionId;
  }
}

public static STAIMessageStructure ToStructure(ssRuntimeDestroyer.RestRecords.RESTSTAIMessageStructure obj) { 
  STAIMessageStructure s = new STAIMessageStructure();
  if(obj != null) {
  s.ssContent = RLAIItemList.FromRestList(obj.AttrContent, ssRuntimeDestroyer.RestRecords.RESTSTAIItemStructure.ToStructure);
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssRole = obj.AttrRole == null ? 0L : obj.AttrRole.Value;
  s.ssActionName = obj.AttrActionName == null ? "" : obj.AttrActionName;
  s.ssActionParameters = obj.AttrActionParameters == null ? "" : obj.AttrActionParameters;
  s.ssActionId = obj.AttrActionId == null ? "" : obj.AttrActionId;
  }
  return s;
}

public static Func<STAIMessageStructure, ssRuntimeDestroyer.RestRecords.RESTSTAIMessageStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (STAIMessageStructure s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTSTAIMessageStructure FromStructure(STAIMessageStructure s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTSTAIMessageStructure(s, config);
}

}


