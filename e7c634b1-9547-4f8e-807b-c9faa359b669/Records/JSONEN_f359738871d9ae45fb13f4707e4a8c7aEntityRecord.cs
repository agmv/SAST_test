using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// HttpRequest
public class JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord : AbstractRESTStructure<EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("HttpMethod")]
[JsonPropertyName("HttpMethod")]
public string AttrHttpMethod;

[JsonProperty("Body")]
[JsonPropertyName("Body")]
public string AttrBody;

public JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord() { }

public JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord (EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrHttpMethod = s.ssHttpMethod;
AttrBody = ConvertToRestWithoutDefaults(s.ssBody, "");
  } else {
AttrId = (long?) s.ssId;
AttrHttpMethod = s.ssHttpMethod;
AttrBody = s.ssBody;
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord, EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord s) => ToStructure(s, config);
}
public static EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord ToStructure(ssRuntimeDestroyer.RestRecords.JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord s = new EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssHttpMethod = obj.AttrHttpMethod == null ? "" : obj.AttrHttpMethod;
  s.ssBody = obj.AttrBody == null ? "" : obj.AttrBody;
  }
  return s;
}

public static Func<EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord, ssRuntimeDestroyer.RestRecords.JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord FromStructure(EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord(s, config);
}

}


