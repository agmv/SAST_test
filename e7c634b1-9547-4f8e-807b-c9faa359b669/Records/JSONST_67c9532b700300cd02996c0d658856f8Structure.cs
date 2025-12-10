using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// URLQueryParameter
public class JSONST_67c9532b700300cd02996c0d658856f8Structure : AbstractRESTStructure<ST_67c9532b700300cd02996c0d658856f8Structure> {
[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("Value")]
[JsonPropertyName("Value")]
public string AttrValue;

public JSONST_67c9532b700300cd02996c0d658856f8Structure() { }

public JSONST_67c9532b700300cd02996c0d658856f8Structure (ST_67c9532b700300cd02996c0d658856f8Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, "");
  } else {
AttrName = s.ssName;
AttrValue = s.ssValue;
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONST_67c9532b700300cd02996c0d658856f8Structure, ST_67c9532b700300cd02996c0d658856f8Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONST_67c9532b700300cd02996c0d658856f8Structure s) => ToStructure(s, config);
}
public static ST_67c9532b700300cd02996c0d658856f8Structure ToStructure(ssRuntimeDestroyer.RestRecords.JSONST_67c9532b700300cd02996c0d658856f8Structure obj, IBehaviorsConfiguration config) { 
  ST_67c9532b700300cd02996c0d658856f8Structure s = new ST_67c9532b700300cd02996c0d658856f8Structure();
  if(obj != null) {
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  }
  return s;
}

public static Func<ST_67c9532b700300cd02996c0d658856f8Structure, ssRuntimeDestroyer.RestRecords.JSONST_67c9532b700300cd02996c0d658856f8Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_67c9532b700300cd02996c0d658856f8Structure s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONST_67c9532b700300cd02996c0d658856f8Structure FromStructure(ST_67c9532b700300cd02996c0d658856f8Structure s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONST_67c9532b700300cd02996c0d658856f8Structure(s, config);
}

}


