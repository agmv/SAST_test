using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// HTTPRequest2
public class JSONST_2e4d23f993f70b2a453aff430875354bStructure : AbstractRESTStructure<ST_2e4d23f993f70b2a453aff430875354bStructure> {
[JsonProperty("BaseURL")]
[JsonPropertyName("BaseURL")]
public string AttrBaseURL;

[JsonProperty("URLPath")]
[JsonPropertyName("URLPath")]
public string AttrURLPath;

[JsonProperty("URLQueryParameters")]
[JsonPropertyName("URLQueryParameters")]
public ssRuntimeDestroyer.RestRecords.JSONST_67c9532b700300cd02996c0d658856f8Structure[] AttrURLQueryParameters;

[JsonProperty("HTTPMethod")]
[JsonPropertyName("HTTPMethod")]
public string AttrHTTPMethod;

[JsonProperty("Headers")]
[JsonPropertyName("Headers")]
public ssRuntimeDestroyer.RestRecords.JSONST_b6163e36a4b633b09c820fee73ba221eStructure[] AttrHeaders;

[JsonProperty("RequestText")]
[JsonPropertyName("RequestText")]
public string AttrRequestText;

[JsonProperty("RequestBinary")]
[JsonPropertyName("RequestBinary")]
public byte[] AttrRequestBinary;

public JSONST_2e4d23f993f70b2a453aff430875354bStructure() { }

public JSONST_2e4d23f993f70b2a453aff430875354bStructure (ST_2e4d23f993f70b2a453aff430875354bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBaseURL = ConvertToRestWithoutDefaults(s.ssBaseURL, "");
AttrURLPath = ConvertToRestWithoutDefaults(s.ssURLPath, "");
AttrURLQueryParameters = s.ssURLQueryParameters.Length == 0 ? null : s.ssURLQueryParameters.ToArray<ssRuntimeDestroyer.RestRecords.JSONST_67c9532b700300cd02996c0d658856f8Structure>(ssRuntimeDestroyer.RestRecords.JSONST_67c9532b700300cd02996c0d658856f8Structure.FromStructureDelegate(config));
AttrHTTPMethod = ConvertToRestWithoutDefaults(s.ssHTTPMethod, "");
AttrHeaders = s.ssHeaders.Length == 0 ? null : s.ssHeaders.ToArray<ssRuntimeDestroyer.RestRecords.JSONST_b6163e36a4b633b09c820fee73ba221eStructure>(ssRuntimeDestroyer.RestRecords.JSONST_b6163e36a4b633b09c820fee73ba221eStructure.FromStructureDelegate(config));
AttrRequestText = ConvertToRestWithoutDefaults(s.ssRequestText, "");
AttrRequestBinary = ConvertToRestWithoutDefaults(s.ssRequestBinary);
  } else {
AttrBaseURL = s.ssBaseURL;
AttrURLPath = s.ssURLPath;
AttrURLQueryParameters = s.ssURLQueryParameters.ToArray<ssRuntimeDestroyer.RestRecords.JSONST_67c9532b700300cd02996c0d658856f8Structure>(ssRuntimeDestroyer.RestRecords.JSONST_67c9532b700300cd02996c0d658856f8Structure.FromStructureDelegate(config));
AttrHTTPMethod = s.ssHTTPMethod;
AttrHeaders = s.ssHeaders.ToArray<ssRuntimeDestroyer.RestRecords.JSONST_b6163e36a4b633b09c820fee73ba221eStructure>(ssRuntimeDestroyer.RestRecords.JSONST_b6163e36a4b633b09c820fee73ba221eStructure.FromStructureDelegate(config));
AttrRequestText = s.ssRequestText;
AttrRequestBinary = s.ssRequestBinary;
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONST_2e4d23f993f70b2a453aff430875354bStructure, ST_2e4d23f993f70b2a453aff430875354bStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONST_2e4d23f993f70b2a453aff430875354bStructure s) => ToStructure(s, config);
}
public static ST_2e4d23f993f70b2a453aff430875354bStructure ToStructure(ssRuntimeDestroyer.RestRecords.JSONST_2e4d23f993f70b2a453aff430875354bStructure obj, IBehaviorsConfiguration config) { 
  ST_2e4d23f993f70b2a453aff430875354bStructure s = new ST_2e4d23f993f70b2a453aff430875354bStructure();
  if(obj != null) {
  s.ssBaseURL = obj.AttrBaseURL == null ? "" : obj.AttrBaseURL;
  s.ssURLPath = obj.AttrURLPath == null ? "" : obj.AttrURLPath;
  s.ssURLQueryParameters = RL_f12ccf0a92533f516726b4232e2b352e.ToList(obj.AttrURLQueryParameters, ssRuntimeDestroyer.RestRecords.JSONST_67c9532b700300cd02996c0d658856f8Structure.ToStructureDelegate(config));
  s.ssHTTPMethod = obj.AttrHTTPMethod == null ? "" : obj.AttrHTTPMethod;
  s.ssHeaders = RL_435011a192ffc5b6f97bc0a73c8501c1.ToList(obj.AttrHeaders, ssRuntimeDestroyer.RestRecords.JSONST_b6163e36a4b633b09c820fee73ba221eStructure.ToStructureDelegate(config));
  s.ssRequestText = obj.AttrRequestText == null ? "" : obj.AttrRequestText;
  s.ssRequestBinary = obj.AttrRequestBinary == null ? new byte[] {} : obj.AttrRequestBinary;
  }
  return s;
}

public static Func<ST_2e4d23f993f70b2a453aff430875354bStructure, ssRuntimeDestroyer.RestRecords.JSONST_2e4d23f993f70b2a453aff430875354bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_2e4d23f993f70b2a453aff430875354bStructure s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONST_2e4d23f993f70b2a453aff430875354bStructure FromStructure(ST_2e4d23f993f70b2a453aff430875354bStructure s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONST_2e4d23f993f70b2a453aff430875354bStructure(s, config);
}

}


