using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// StartUpdateEmailFailureReason
public class JSONST_265373b7ea713cad761986e9aec6548dStructure : AbstractRESTStructure<ST_265373b7ea713cad761986e9aec6548dStructure> {
[JsonProperty("InvalidEmail")]
[JsonPropertyName("InvalidEmail")]
public bool? AttrInvalidEmail;

public JSONST_265373b7ea713cad761986e9aec6548dStructure() { }

public JSONST_265373b7ea713cad761986e9aec6548dStructure (ST_265373b7ea713cad761986e9aec6548dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvalidEmail = ConvertToRestWithoutDefaults(s.ssInvalidEmail, false);
  } else {
AttrInvalidEmail = (bool?) s.ssInvalidEmail;
  }
}

public static Func<ssSystem_.RestRecords.JSONST_265373b7ea713cad761986e9aec6548dStructure, ST_265373b7ea713cad761986e9aec6548dStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONST_265373b7ea713cad761986e9aec6548dStructure s) => ToStructure(s, config);
}
public static ST_265373b7ea713cad761986e9aec6548dStructure ToStructure(ssSystem_.RestRecords.JSONST_265373b7ea713cad761986e9aec6548dStructure obj, IBehaviorsConfiguration config) { 
  ST_265373b7ea713cad761986e9aec6548dStructure s = new ST_265373b7ea713cad761986e9aec6548dStructure();
  if(obj != null) {
  s.ssInvalidEmail = obj.AttrInvalidEmail == null ? false : obj.AttrInvalidEmail.Value;
  }
  return s;
}

public static Func<ST_265373b7ea713cad761986e9aec6548dStructure, ssSystem_.RestRecords.JSONST_265373b7ea713cad761986e9aec6548dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_265373b7ea713cad761986e9aec6548dStructure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONST_265373b7ea713cad761986e9aec6548dStructure FromStructure(ST_265373b7ea713cad761986e9aec6548dStructure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONST_265373b7ea713cad761986e9aec6548dStructure(s, config);
}

}


