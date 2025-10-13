using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// FinishUpdateEmailResult
public class JSONST_992b6b077ef933bd10f0df6cf0ce4be3Structure : AbstractRESTStructure<ST_992b6b077ef933bd10f0df6cf0ce4be3Structure> {
[JsonProperty("Success")]
[JsonPropertyName("Success")]
public bool? AttrSuccess;

[JsonProperty("FinishUpdateEmailFailureReason")]
[JsonPropertyName("FinishUpdateEmailFailureReason")]
public ssSystem_.RestRecords.JSONST_23034956e06e8e0a2169e5e731331735Structure AttrFinishUpdateEmailFailureReason;

public JSONST_992b6b077ef933bd10f0df6cf0ce4be3Structure() { }

public JSONST_992b6b077ef933bd10f0df6cf0ce4be3Structure (ST_992b6b077ef933bd10f0df6cf0ce4be3Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSuccess = ConvertToRestWithoutDefaults(s.ssSuccess, false);
AttrFinishUpdateEmailFailureReason = ConvertToRestWithoutDefaults(s.ssFinishUpdateEmailFailureReason, new ST_23034956e06e8e0a2169e5e731331735Structure(), ssSystem_.RestRecords.JSONST_23034956e06e8e0a2169e5e731331735Structure.FromStructureDelegate(config));
  } else {
AttrSuccess = (bool?) s.ssSuccess;
AttrFinishUpdateEmailFailureReason = ssSystem_.RestRecords.JSONST_23034956e06e8e0a2169e5e731331735Structure.FromStructure(s.ssFinishUpdateEmailFailureReason, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONST_992b6b077ef933bd10f0df6cf0ce4be3Structure, ST_992b6b077ef933bd10f0df6cf0ce4be3Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONST_992b6b077ef933bd10f0df6cf0ce4be3Structure s) => ToStructure(s, config);
}
public static ST_992b6b077ef933bd10f0df6cf0ce4be3Structure ToStructure(ssSystem_.RestRecords.JSONST_992b6b077ef933bd10f0df6cf0ce4be3Structure obj, IBehaviorsConfiguration config) { 
  ST_992b6b077ef933bd10f0df6cf0ce4be3Structure s = new ST_992b6b077ef933bd10f0df6cf0ce4be3Structure();
  if(obj != null) {
  s.ssSuccess = obj.AttrSuccess == null ? false : obj.AttrSuccess.Value;
  s.ssFinishUpdateEmailFailureReason = ssSystem_.RestRecords.JSONST_23034956e06e8e0a2169e5e731331735Structure.ToStructure(obj.AttrFinishUpdateEmailFailureReason, config);
  }
  return s;
}

public static Func<ST_992b6b077ef933bd10f0df6cf0ce4be3Structure, ssSystem_.RestRecords.JSONST_992b6b077ef933bd10f0df6cf0ce4be3Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_992b6b077ef933bd10f0df6cf0ce4be3Structure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONST_992b6b077ef933bd10f0df6cf0ce4be3Structure FromStructure(ST_992b6b077ef933bd10f0df6cf0ce4be3Structure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONST_992b6b077ef933bd10f0df6cf0ce4be3Structure(s, config);
}

}


