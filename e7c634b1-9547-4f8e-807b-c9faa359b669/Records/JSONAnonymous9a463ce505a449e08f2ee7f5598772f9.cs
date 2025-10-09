using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// HttpRequestRecord
public class JSONRC_1ba5183fe935decff47a51e639a147ac : AbstractRESTStructure<RC_1ba5183fe935decff47a51e639a147ac> {
[JsonProperty("HttpRequest")]
[JsonPropertyName("HttpRequest")]
public ssRuntimeDestroyer.RestRecords.JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord AttrHttpRequest;

public JSONRC_1ba5183fe935decff47a51e639a147ac() { }

public JSONRC_1ba5183fe935decff47a51e639a147ac (RC_1ba5183fe935decff47a51e639a147ac s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHttpRequest = ConvertToRestWithoutDefaults(s.ssENHttpRequest, new EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord(), ssRuntimeDestroyer.RestRecords.JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord.FromStructureDelegate(config));
  } else {
AttrHttpRequest = ssRuntimeDestroyer.RestRecords.JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord.FromStructure(s.ssENHttpRequest, config);
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONRC_1ba5183fe935decff47a51e639a147ac, RC_1ba5183fe935decff47a51e639a147ac> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONRC_1ba5183fe935decff47a51e639a147ac s) => ToStructure(s, config);
}
public static RC_1ba5183fe935decff47a51e639a147ac ToStructure(ssRuntimeDestroyer.RestRecords.JSONRC_1ba5183fe935decff47a51e639a147ac obj, IBehaviorsConfiguration config) { 
  RC_1ba5183fe935decff47a51e639a147ac s = new RC_1ba5183fe935decff47a51e639a147ac();
  if(obj != null) {
  s.ssENHttpRequest = ssRuntimeDestroyer.RestRecords.JSONEN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord.ToStructure(obj.AttrHttpRequest, config);
  }
  return s;
}

public static Func<RC_1ba5183fe935decff47a51e639a147ac, ssRuntimeDestroyer.RestRecords.JSONRC_1ba5183fe935decff47a51e639a147ac> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1ba5183fe935decff47a51e639a147ac s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONRC_1ba5183fe935decff47a51e639a147ac FromStructure(RC_1ba5183fe935decff47a51e639a147ac s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONRC_1ba5183fe935decff47a51e639a147ac(s, config);
}

}


