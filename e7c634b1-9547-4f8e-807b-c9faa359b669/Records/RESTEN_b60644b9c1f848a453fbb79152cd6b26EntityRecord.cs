using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// Enum_color
public class RESTEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord : AbstractRESTStructure<EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord> {
[JsonProperty("Value")]
public string AttrValue;

[JsonProperty("Order")]
public int? AttrOrder;

public RESTEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord() { }

public RESTEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord (EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValue = s.ssValue;
AttrOrder = ConvertToRestWithoutDefaults(s.ssOrder, 0);
  } else {
AttrValue = s.ssValue;
AttrOrder = (int?) s.ssOrder;
  }
}

public static EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord ToStructure(ssRuntimeDestroyer.RestRecords.RESTEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord obj) { 
  EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord s = new EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  }
  return s;
}

public static Func<EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord, ssRuntimeDestroyer.RestRecords.RESTEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord FromStructure(EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTEN_b60644b9c1f848a453fbb79152cd6b26EntityRecord(s, config);
}

}


