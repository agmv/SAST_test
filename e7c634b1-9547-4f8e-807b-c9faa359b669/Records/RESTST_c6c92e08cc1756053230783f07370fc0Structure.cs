using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// Employee2
public class RESTST_c6c92e08cc1756053230783f07370fc0Structure : AbstractRESTStructure<ST_c6c92e08cc1756053230783f07370fc0Structure> {
[JsonProperty("id")]
public string Attrid;

[JsonProperty("name")]
public string Attrname;

[JsonProperty("color")]
public string Attrcolor;

public RESTST_c6c92e08cc1756053230783f07370fc0Structure() { }

public RESTST_c6c92e08cc1756053230783f07370fc0Structure (ST_c6c92e08cc1756053230783f07370fc0Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrid = ConvertToRestWithoutDefaults(s.ssid, "");
Attrname = ConvertToRestWithoutDefaults(s.ssname, "");
Attrcolor = ConvertToRestWithoutDefaults(s.sscolor, (ENEnum_colorEntity.GetRecordByKey(ObjectKey.Parse("S_YdImXjJECSohfJCzEYMw"))).ssValue);
  } else {
Attrid = s.ssid;
Attrname = s.ssname;
Attrcolor = s.sscolor;
  }
}

public static ST_c6c92e08cc1756053230783f07370fc0Structure ToStructure(ssRuntimeDestroyer.RestRecords.RESTST_c6c92e08cc1756053230783f07370fc0Structure obj) { 
  ST_c6c92e08cc1756053230783f07370fc0Structure s = new ST_c6c92e08cc1756053230783f07370fc0Structure();
  if(obj != null) {
  s.ssid = obj.Attrid == null ? "" : obj.Attrid;
  s.ssname = obj.Attrname == null ? "" : obj.Attrname;
  s.sscolor = obj.Attrcolor == null ? (ENEnum_colorEntity.GetRecordByKey(ObjectKey.Parse("S_YdImXjJECSohfJCzEYMw"))).ssValue : obj.Attrcolor;
  }
  return s;
}

public static Func<ST_c6c92e08cc1756053230783f07370fc0Structure, ssRuntimeDestroyer.RestRecords.RESTST_c6c92e08cc1756053230783f07370fc0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_c6c92e08cc1756053230783f07370fc0Structure s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTST_c6c92e08cc1756053230783f07370fc0Structure FromStructure(ST_c6c92e08cc1756053230783f07370fc0Structure s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTST_c6c92e08cc1756053230783f07370fc0Structure(s, config);
}

}


