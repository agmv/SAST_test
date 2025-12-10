using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// WeekdayRecord
public class RESTRC_37793b7d6834fb46c2d504f9d8c91d4a : AbstractRESTStructure<RC_37793b7d6834fb46c2d504f9d8c91d4a> {
[JsonProperty("Weekday")]
public ssRuntimeDestroyer.RestRecords.RESTEN_3b62c1d17ede66b1bf553024dad1119eEntityRecord AttrWeekday;

public RESTRC_37793b7d6834fb46c2d504f9d8c91d4a() { }

public RESTRC_37793b7d6834fb46c2d504f9d8c91d4a (RC_37793b7d6834fb46c2d504f9d8c91d4a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrWeekday = ConvertToRestWithoutDefaults(s.ssENWeekday, new EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord(), ssRuntimeDestroyer.RestRecords.RESTEN_3b62c1d17ede66b1bf553024dad1119eEntityRecord.FromStructureDelegate(config));
  } else {
AttrWeekday = ssRuntimeDestroyer.RestRecords.RESTEN_3b62c1d17ede66b1bf553024dad1119eEntityRecord.FromStructure(s.ssENWeekday, config);
  }
}

public static RC_37793b7d6834fb46c2d504f9d8c91d4a ToStructure(ssRuntimeDestroyer.RestRecords.RESTRC_37793b7d6834fb46c2d504f9d8c91d4a obj) { 
  RC_37793b7d6834fb46c2d504f9d8c91d4a s = new RC_37793b7d6834fb46c2d504f9d8c91d4a();
  if(obj != null) {
  s.ssENWeekday = ssRuntimeDestroyer.RestRecords.RESTEN_3b62c1d17ede66b1bf553024dad1119eEntityRecord.ToStructure(obj.AttrWeekday);
  }
  return s;
}

public static Func<RC_37793b7d6834fb46c2d504f9d8c91d4a, ssRuntimeDestroyer.RestRecords.RESTRC_37793b7d6834fb46c2d504f9d8c91d4a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_37793b7d6834fb46c2d504f9d8c91d4a s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTRC_37793b7d6834fb46c2d504f9d8c91d4a FromStructure(RC_37793b7d6834fb46c2d504f9d8c91d4a s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTRC_37793b7d6834fb46c2d504f9d8c91d4a(s, config);
}

}


