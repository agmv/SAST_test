using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.ReferencesProxy.RestRecords;

// WeekdayRecord
public class JSONRC_37793b7d6834fb46c2d504f9d8c91d4a : AbstractRESTStructure<RC_37793b7d6834fb46c2d504f9d8c91d4a> {
[JsonProperty("Weekday")]
[JsonPropertyName("Weekday")]
public ssRuntimeDestroyer.ReferencesProxy.RestRecords.JSONEN_3b62c1d17ede66b1bf553024dad1119eEntityRecord AttrWeekday;

public JSONRC_37793b7d6834fb46c2d504f9d8c91d4a() { }

public JSONRC_37793b7d6834fb46c2d504f9d8c91d4a (RC_37793b7d6834fb46c2d504f9d8c91d4a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrWeekday = ConvertToRestWithoutDefaults(s.ssENWeekday, new EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord(), ssRuntimeDestroyer.ReferencesProxy.RestRecords.JSONEN_3b62c1d17ede66b1bf553024dad1119eEntityRecord.FromStructureDelegate(config));
  } else {
AttrWeekday = ssRuntimeDestroyer.ReferencesProxy.RestRecords.JSONEN_3b62c1d17ede66b1bf553024dad1119eEntityRecord.FromStructure(s.ssENWeekday, config);
  }
}

public static Func<ssRuntimeDestroyer.ReferencesProxy.RestRecords.JSONRC_37793b7d6834fb46c2d504f9d8c91d4a, RC_37793b7d6834fb46c2d504f9d8c91d4a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.ReferencesProxy.RestRecords.JSONRC_37793b7d6834fb46c2d504f9d8c91d4a s) => ToStructure(s, config);
}
public static RC_37793b7d6834fb46c2d504f9d8c91d4a ToStructure(ssRuntimeDestroyer.ReferencesProxy.RestRecords.JSONRC_37793b7d6834fb46c2d504f9d8c91d4a obj, IBehaviorsConfiguration config) { 
  RC_37793b7d6834fb46c2d504f9d8c91d4a s = new RC_37793b7d6834fb46c2d504f9d8c91d4a();
  if(obj != null) {
  s.ssENWeekday = ssRuntimeDestroyer.ReferencesProxy.RestRecords.JSONEN_3b62c1d17ede66b1bf553024dad1119eEntityRecord.ToStructure(obj.AttrWeekday, config);
  }
  return s;
}

public static Func<RC_37793b7d6834fb46c2d504f9d8c91d4a, ssRuntimeDestroyer.ReferencesProxy.RestRecords.JSONRC_37793b7d6834fb46c2d504f9d8c91d4a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_37793b7d6834fb46c2d504f9d8c91d4a s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.ReferencesProxy.RestRecords.JSONRC_37793b7d6834fb46c2d504f9d8c91d4a FromStructure(RC_37793b7d6834fb46c2d504f9d8c91d4a s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.ReferencesProxy.RestRecords.JSONRC_37793b7d6834fb46c2d504f9d8c91d4a(s, config);
}

}


