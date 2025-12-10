using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// SampleListStruct
public class JSONST_00ba72a41660161c6373af90c87d0979Structure : AbstractRESTStructure<ST_00ba72a41660161c6373af90c87d0979Structure> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONST_00ba72a41660161c6373af90c87d0979Structure() { }

public JSONST_00ba72a41660161c6373af90c87d0979Structure (ST_00ba72a41660161c6373af90c87d0979Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = ConvertToRestWithoutDefaults(s.ssId, "");
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONST_00ba72a41660161c6373af90c87d0979Structure, ST_00ba72a41660161c6373af90c87d0979Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONST_00ba72a41660161c6373af90c87d0979Structure s) => ToStructure(s, config);
}
public static ST_00ba72a41660161c6373af90c87d0979Structure ToStructure(ssRuntimeDestroyer.RestRecords.JSONST_00ba72a41660161c6373af90c87d0979Structure obj, IBehaviorsConfiguration config) { 
  ST_00ba72a41660161c6373af90c87d0979Structure s = new ST_00ba72a41660161c6373af90c87d0979Structure();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<ST_00ba72a41660161c6373af90c87d0979Structure, ssRuntimeDestroyer.RestRecords.JSONST_00ba72a41660161c6373af90c87d0979Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_00ba72a41660161c6373af90c87d0979Structure s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONST_00ba72a41660161c6373af90c87d0979Structure FromStructure(ST_00ba72a41660161c6373af90c87d0979Structure s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONST_00ba72a41660161c6373af90c87d0979Structure(s, config);
}

}


