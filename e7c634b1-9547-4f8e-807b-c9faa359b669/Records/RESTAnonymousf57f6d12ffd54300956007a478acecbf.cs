using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// HTTPRequest2Record
public class RESTRC_e49ec0d2ad1794ad18666b7d4da994e4 : AbstractRESTStructure<RC_e49ec0d2ad1794ad18666b7d4da994e4> {
[JsonProperty("HTTPRequest2")]
public ssRuntimeDestroyer.RestRecords.RESTST_2e4d23f993f70b2a453aff430875354bStructure AttrHTTPRequest2;

public RESTRC_e49ec0d2ad1794ad18666b7d4da994e4() { }

public RESTRC_e49ec0d2ad1794ad18666b7d4da994e4 (RC_e49ec0d2ad1794ad18666b7d4da994e4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHTTPRequest2 = ConvertToRestWithoutDefaults(s.ssSTHTTPRequest2, new ST_2e4d23f993f70b2a453aff430875354bStructure(), ssRuntimeDestroyer.RestRecords.RESTST_2e4d23f993f70b2a453aff430875354bStructure.FromStructureDelegate(config));
  } else {
AttrHTTPRequest2 = ssRuntimeDestroyer.RestRecords.RESTST_2e4d23f993f70b2a453aff430875354bStructure.FromStructure(s.ssSTHTTPRequest2, config);
  }
}

public static RC_e49ec0d2ad1794ad18666b7d4da994e4 ToStructure(ssRuntimeDestroyer.RestRecords.RESTRC_e49ec0d2ad1794ad18666b7d4da994e4 obj) { 
  RC_e49ec0d2ad1794ad18666b7d4da994e4 s = new RC_e49ec0d2ad1794ad18666b7d4da994e4();
  if(obj != null) {
  s.ssSTHTTPRequest2 = ssRuntimeDestroyer.RestRecords.RESTST_2e4d23f993f70b2a453aff430875354bStructure.ToStructure(obj.AttrHTTPRequest2);
  }
  return s;
}

public static Func<RC_e49ec0d2ad1794ad18666b7d4da994e4, ssRuntimeDestroyer.RestRecords.RESTRC_e49ec0d2ad1794ad18666b7d4da994e4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e49ec0d2ad1794ad18666b7d4da994e4 s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTRC_e49ec0d2ad1794ad18666b7d4da994e4 FromStructure(RC_e49ec0d2ad1794ad18666b7d4da994e4 s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTRC_e49ec0d2ad1794ad18666b7d4da994e4(s, config);
}

}


