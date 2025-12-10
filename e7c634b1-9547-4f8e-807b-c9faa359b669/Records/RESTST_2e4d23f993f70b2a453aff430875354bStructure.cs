using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// HTTPRequest2
public class RESTST_2e4d23f993f70b2a453aff430875354bStructure : AbstractRESTStructure<ST_2e4d23f993f70b2a453aff430875354bStructure> {
[JsonProperty("BaseURL")]
public string AttrBaseURL;

[JsonProperty("URLPath")]
public string AttrURLPath;

[JsonProperty("URLQueryParameters")]
public RestList<ssRuntimeDestroyer.RestRecords.RESTST_67c9532b700300cd02996c0d658856f8Structure> AttrURLQueryParameters;

[JsonProperty("HTTPMethod")]
public string AttrHTTPMethod;

[JsonProperty("Headers")]
public RestList<ssRuntimeDestroyer.RestRecords.RESTST_b6163e36a4b633b09c820fee73ba221eStructure> AttrHeaders;

[JsonProperty("RequestText")]
public string AttrRequestText;

[JsonProperty("RequestBinary")]
public byte[] AttrRequestBinary;

public RESTST_2e4d23f993f70b2a453aff430875354bStructure() { }

public RESTST_2e4d23f993f70b2a453aff430875354bStructure (ST_2e4d23f993f70b2a453aff430875354bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBaseURL = ConvertToRestWithoutDefaults(s.ssBaseURL, "");
AttrURLPath = ConvertToRestWithoutDefaults(s.ssURLPath, "");
AttrURLQueryParameters = s.ssURLQueryParameters.Length == 0 ? null : s.ssURLQueryParameters.ToRestList<ssRuntimeDestroyer.RestRecords.RESTST_67c9532b700300cd02996c0d658856f8Structure>(ssRuntimeDestroyer.RestRecords.RESTST_67c9532b700300cd02996c0d658856f8Structure.FromStructureDelegate(config));
AttrHTTPMethod = ConvertToRestWithoutDefaults(s.ssHTTPMethod, "");
AttrHeaders = s.ssHeaders.Length == 0 ? null : s.ssHeaders.ToRestList<ssRuntimeDestroyer.RestRecords.RESTST_b6163e36a4b633b09c820fee73ba221eStructure>(ssRuntimeDestroyer.RestRecords.RESTST_b6163e36a4b633b09c820fee73ba221eStructure.FromStructureDelegate(config));
AttrRequestText = ConvertToRestWithoutDefaults(s.ssRequestText, "");
AttrRequestBinary = ConvertToRestWithoutDefaults(s.ssRequestBinary);
  } else {
AttrBaseURL = s.ssBaseURL;
AttrURLPath = s.ssURLPath;
AttrURLQueryParameters = s.ssURLQueryParameters.ToRestList<ssRuntimeDestroyer.RestRecords.RESTST_67c9532b700300cd02996c0d658856f8Structure>(ssRuntimeDestroyer.RestRecords.RESTST_67c9532b700300cd02996c0d658856f8Structure.FromStructureDelegate(config));
AttrHTTPMethod = s.ssHTTPMethod;
AttrHeaders = s.ssHeaders.ToRestList<ssRuntimeDestroyer.RestRecords.RESTST_b6163e36a4b633b09c820fee73ba221eStructure>(ssRuntimeDestroyer.RestRecords.RESTST_b6163e36a4b633b09c820fee73ba221eStructure.FromStructureDelegate(config));
AttrRequestText = s.ssRequestText;
AttrRequestBinary = s.ssRequestBinary;
  }
}

public static ST_2e4d23f993f70b2a453aff430875354bStructure ToStructure(ssRuntimeDestroyer.RestRecords.RESTST_2e4d23f993f70b2a453aff430875354bStructure obj) { 
  ST_2e4d23f993f70b2a453aff430875354bStructure s = new ST_2e4d23f993f70b2a453aff430875354bStructure();
  if(obj != null) {
  s.ssBaseURL = obj.AttrBaseURL == null ? "" : obj.AttrBaseURL;
  s.ssURLPath = obj.AttrURLPath == null ? "" : obj.AttrURLPath;
  s.ssURLQueryParameters = RL_f12ccf0a92533f516726b4232e2b352e.FromRestList(obj.AttrURLQueryParameters, ssRuntimeDestroyer.RestRecords.RESTST_67c9532b700300cd02996c0d658856f8Structure.ToStructure);
  s.ssHTTPMethod = obj.AttrHTTPMethod == null ? "" : obj.AttrHTTPMethod;
  s.ssHeaders = RL_435011a192ffc5b6f97bc0a73c8501c1.FromRestList(obj.AttrHeaders, ssRuntimeDestroyer.RestRecords.RESTST_b6163e36a4b633b09c820fee73ba221eStructure.ToStructure);
  s.ssRequestText = obj.AttrRequestText == null ? "" : obj.AttrRequestText;
  s.ssRequestBinary = obj.AttrRequestBinary == null ? new byte[] {} : obj.AttrRequestBinary;
  }
  return s;
}

public static Func<ST_2e4d23f993f70b2a453aff430875354bStructure, ssRuntimeDestroyer.RestRecords.RESTST_2e4d23f993f70b2a453aff430875354bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_2e4d23f993f70b2a453aff430875354bStructure s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTST_2e4d23f993f70b2a453aff430875354bStructure FromStructure(ST_2e4d23f993f70b2a453aff430875354bStructure s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTST_2e4d23f993f70b2a453aff430875354bStructure(s, config);
}

}


