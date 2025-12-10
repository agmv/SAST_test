using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AIMessage
public class JSONSTAIMessageStructure : AbstractRESTStructure<STAIMessageStructure> {
[JsonProperty("Content")]
[JsonPropertyName("Content")]
public ssRuntimeDestroyer.RestRecords.JSONSTAIItemStructure[] AttrContent;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("Role")]
[JsonPropertyName("Role")]
public long? AttrRole;

[JsonProperty("ActionName")]
[JsonPropertyName("ActionName")]
public string AttrActionName;

[JsonProperty("ActionParameters")]
[JsonPropertyName("ActionParameters")]
public string AttrActionParameters;

[JsonProperty("ActionId")]
[JsonPropertyName("ActionId")]
public string AttrActionId;

public JSONSTAIMessageStructure() { }

public JSONSTAIMessageStructure (STAIMessageStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrContent = s.ssContent.Length == 0 ? null : s.ssContent.ToArray<ssRuntimeDestroyer.RestRecords.JSONSTAIItemStructure>(ssRuntimeDestroyer.RestRecords.JSONSTAIItemStructure.FromStructureDelegate(config));
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrRole = ConvertToRestWithoutDefaults(s.ssRole, 0L);
AttrActionName = ConvertToRestWithoutDefaults(s.ssActionName, "");
AttrActionParameters = ConvertToRestWithoutDefaults(s.ssActionParameters, "");
AttrActionId = ConvertToRestWithoutDefaults(s.ssActionId, "");
  } else {
AttrContent = s.ssContent.ToArray<ssRuntimeDestroyer.RestRecords.JSONSTAIItemStructure>(ssRuntimeDestroyer.RestRecords.JSONSTAIItemStructure.FromStructureDelegate(config));
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrRole = (long?) s.ssRole;
AttrActionName = s.ssActionName;
AttrActionParameters = s.ssActionParameters;
AttrActionId = s.ssActionId;
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONSTAIMessageStructure, STAIMessageStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONSTAIMessageStructure s) => ToStructure(s, config);
}
public static STAIMessageStructure ToStructure(ssRuntimeDestroyer.RestRecords.JSONSTAIMessageStructure obj, IBehaviorsConfiguration config) { 
  STAIMessageStructure s = new STAIMessageStructure();
  if(obj != null) {
  s.ssContent = RLAIItemList.ToList(obj.AttrContent, ssRuntimeDestroyer.RestRecords.JSONSTAIItemStructure.ToStructureDelegate(config));
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssRole = obj.AttrRole == null ? 0L : obj.AttrRole.Value;
  s.ssActionName = obj.AttrActionName == null ? "" : obj.AttrActionName;
  s.ssActionParameters = obj.AttrActionParameters == null ? "" : obj.AttrActionParameters;
  s.ssActionId = obj.AttrActionId == null ? "" : obj.AttrActionId;
  }
  return s;
}

public static Func<STAIMessageStructure, ssRuntimeDestroyer.RestRecords.JSONSTAIMessageStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (STAIMessageStructure s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONSTAIMessageStructure FromStructure(STAIMessageStructure s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONSTAIMessageStructure(s, config);
}

}


