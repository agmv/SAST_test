using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ChangePasswordResult
public class JSONST_368bb4a94e9c212b75f0247c9d3e6e37Structure : AbstractRESTStructure<ST_368bb4a94e9c212b75f0247c9d3e6e37Structure> {
[JsonProperty("Success")]
[JsonPropertyName("Success")]
public bool? AttrSuccess;

[JsonProperty("ChangePasswordFailureReason")]
[JsonPropertyName("ChangePasswordFailureReason")]
public ssSystem_.RestRecords.JSONST_896e066bc5a2d27c8f6a276746e82800Structure AttrChangePasswordFailureReason;

public JSONST_368bb4a94e9c212b75f0247c9d3e6e37Structure() { }

public JSONST_368bb4a94e9c212b75f0247c9d3e6e37Structure (ST_368bb4a94e9c212b75f0247c9d3e6e37Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSuccess = ConvertToRestWithoutDefaults(s.ssSuccess, false);
AttrChangePasswordFailureReason = ConvertToRestWithoutDefaults(s.ssChangePasswordFailureReason, new ST_896e066bc5a2d27c8f6a276746e82800Structure(), ssSystem_.RestRecords.JSONST_896e066bc5a2d27c8f6a276746e82800Structure.FromStructureDelegate(config));
  } else {
AttrSuccess = (bool?) s.ssSuccess;
AttrChangePasswordFailureReason = ssSystem_.RestRecords.JSONST_896e066bc5a2d27c8f6a276746e82800Structure.FromStructure(s.ssChangePasswordFailureReason, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONST_368bb4a94e9c212b75f0247c9d3e6e37Structure, ST_368bb4a94e9c212b75f0247c9d3e6e37Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONST_368bb4a94e9c212b75f0247c9d3e6e37Structure s) => ToStructure(s, config);
}
public static ST_368bb4a94e9c212b75f0247c9d3e6e37Structure ToStructure(ssSystem_.RestRecords.JSONST_368bb4a94e9c212b75f0247c9d3e6e37Structure obj, IBehaviorsConfiguration config) { 
  ST_368bb4a94e9c212b75f0247c9d3e6e37Structure s = new ST_368bb4a94e9c212b75f0247c9d3e6e37Structure();
  if(obj != null) {
  s.ssSuccess = obj.AttrSuccess == null ? false : obj.AttrSuccess.Value;
  s.ssChangePasswordFailureReason = ssSystem_.RestRecords.JSONST_896e066bc5a2d27c8f6a276746e82800Structure.ToStructure(obj.AttrChangePasswordFailureReason, config);
  }
  return s;
}

public static Func<ST_368bb4a94e9c212b75f0247c9d3e6e37Structure, ssSystem_.RestRecords.JSONST_368bb4a94e9c212b75f0247c9d3e6e37Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_368bb4a94e9c212b75f0247c9d3e6e37Structure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONST_368bb4a94e9c212b75f0247c9d3e6e37Structure FromStructure(ST_368bb4a94e9c212b75f0247c9d3e6e37Structure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONST_368bb4a94e9c212b75f0247c9d3e6e37Structure(s, config);
}

}


