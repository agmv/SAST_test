using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AIItem
public class JSONSTAIItemStructure : AbstractRESTStructure<STAIItemStructure> {
[JsonProperty("ContentType")]
[JsonPropertyName("ContentType")]
public long? AttrContentType;

[JsonProperty("ContentText")]
[JsonPropertyName("ContentText")]
public string AttrContentText;

[JsonProperty("ContentUrl")]
[JsonPropertyName("ContentUrl")]
public string AttrContentUrl;

[JsonProperty("ContentBinaryData")]
[JsonPropertyName("ContentBinaryData")]
public byte[] AttrContentBinaryData;

[JsonProperty("FileFormat")]
[JsonPropertyName("FileFormat")]
public string AttrFileFormat;

public JSONSTAIItemStructure() { }

public JSONSTAIItemStructure (STAIItemStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrContentType = ConvertToRestWithoutDefaults(s.ssContentType, 0L);
AttrContentText = ConvertToRestWithoutDefaults(s.ssContentText, "");
AttrContentUrl = ConvertToRestWithoutDefaults(s.ssContentUrl, "");
AttrContentBinaryData = ConvertToRestWithoutDefaults(s.ssContentBinaryData);
AttrFileFormat = ConvertToRestWithoutDefaults(s.ssFileFormat, "");
  } else {
AttrContentType = (long?) s.ssContentType;
AttrContentText = s.ssContentText;
AttrContentUrl = s.ssContentUrl;
AttrContentBinaryData = s.ssContentBinaryData;
AttrFileFormat = s.ssFileFormat;
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONSTAIItemStructure, STAIItemStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONSTAIItemStructure s) => ToStructure(s, config);
}
public static STAIItemStructure ToStructure(ssRuntimeDestroyer.RestRecords.JSONSTAIItemStructure obj, IBehaviorsConfiguration config) { 
  STAIItemStructure s = new STAIItemStructure();
  if(obj != null) {
  s.ssContentType = obj.AttrContentType == null ? 0L : obj.AttrContentType.Value;
  s.ssContentText = obj.AttrContentText == null ? "" : obj.AttrContentText;
  s.ssContentUrl = obj.AttrContentUrl == null ? "" : obj.AttrContentUrl;
  s.ssContentBinaryData = obj.AttrContentBinaryData == null ? new byte[] {} : obj.AttrContentBinaryData;
  s.ssFileFormat = obj.AttrFileFormat == null ? "" : obj.AttrFileFormat;
  }
  return s;
}

public static Func<STAIItemStructure, ssRuntimeDestroyer.RestRecords.JSONSTAIItemStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (STAIItemStructure s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONSTAIItemStructure FromStructure(STAIItemStructure s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONSTAIItemStructure(s, config);
}

}


