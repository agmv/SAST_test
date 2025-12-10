using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// SampleListStruct
public class RESTST_00ba72a41660161c6373af90c87d0979Structure : AbstractRESTStructure<ST_00ba72a41660161c6373af90c87d0979Structure> {
[JsonProperty("Id")]
public string AttrId;

public RESTST_00ba72a41660161c6373af90c87d0979Structure() { }

public RESTST_00ba72a41660161c6373af90c87d0979Structure (ST_00ba72a41660161c6373af90c87d0979Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = ConvertToRestWithoutDefaults(s.ssId, "");
  } else {
AttrId = s.ssId;
  }
}

public static ST_00ba72a41660161c6373af90c87d0979Structure ToStructure(ssRuntimeDestroyer.RestRecords.RESTST_00ba72a41660161c6373af90c87d0979Structure obj) { 
  ST_00ba72a41660161c6373af90c87d0979Structure s = new ST_00ba72a41660161c6373af90c87d0979Structure();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<ST_00ba72a41660161c6373af90c87d0979Structure, ssRuntimeDestroyer.RestRecords.RESTST_00ba72a41660161c6373af90c87d0979Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_00ba72a41660161c6373af90c87d0979Structure s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTST_00ba72a41660161c6373af90c87d0979Structure FromStructure(ST_00ba72a41660161c6373af90c87d0979Structure s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTST_00ba72a41660161c6373af90c87d0979Structure(s, config);
}

}


