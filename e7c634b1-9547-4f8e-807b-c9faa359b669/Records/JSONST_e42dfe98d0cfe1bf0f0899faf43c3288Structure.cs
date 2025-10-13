using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// EmployeeName
public class JSONST_e42dfe98d0cfe1bf0f0899faf43c3288Structure : AbstractRESTStructure<ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure> {
[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

public JSONST_e42dfe98d0cfe1bf0f0899faf43c3288Structure() { }

public JSONST_e42dfe98d0cfe1bf0f0899faf43c3288Structure (ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
  } else {
AttrName = s.ssName;
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONST_e42dfe98d0cfe1bf0f0899faf43c3288Structure, ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONST_e42dfe98d0cfe1bf0f0899faf43c3288Structure s) => ToStructure(s, config);
}
public static ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure ToStructure(ssRuntimeDestroyer.RestRecords.JSONST_e42dfe98d0cfe1bf0f0899faf43c3288Structure obj, IBehaviorsConfiguration config) { 
  ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure s = new ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure();
  if(obj != null) {
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure, ssRuntimeDestroyer.RestRecords.JSONST_e42dfe98d0cfe1bf0f0899faf43c3288Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONST_e42dfe98d0cfe1bf0f0899faf43c3288Structure FromStructure(ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONST_e42dfe98d0cfe1bf0f0899faf43c3288Structure(s, config);
}

}


