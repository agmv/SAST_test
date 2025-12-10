using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// URLQueryParameterRecord
public class RESTRC_390a8f0cc1a357081cd0fa77862d946e : AbstractRESTStructure<RC_390a8f0cc1a357081cd0fa77862d946e> {
[JsonProperty("URLQueryParameter")]
public ssRuntimeDestroyer.RestRecords.RESTST_67c9532b700300cd02996c0d658856f8Structure AttrURLQueryParameter;

public RESTRC_390a8f0cc1a357081cd0fa77862d946e() { }

public RESTRC_390a8f0cc1a357081cd0fa77862d946e (RC_390a8f0cc1a357081cd0fa77862d946e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrURLQueryParameter = ConvertToRestWithoutDefaults(s.ssSTURLQueryParameter, new ST_67c9532b700300cd02996c0d658856f8Structure(), ssRuntimeDestroyer.RestRecords.RESTST_67c9532b700300cd02996c0d658856f8Structure.FromStructureDelegate(config));
  } else {
AttrURLQueryParameter = ssRuntimeDestroyer.RestRecords.RESTST_67c9532b700300cd02996c0d658856f8Structure.FromStructure(s.ssSTURLQueryParameter, config);
  }
}

public static RC_390a8f0cc1a357081cd0fa77862d946e ToStructure(ssRuntimeDestroyer.RestRecords.RESTRC_390a8f0cc1a357081cd0fa77862d946e obj) { 
  RC_390a8f0cc1a357081cd0fa77862d946e s = new RC_390a8f0cc1a357081cd0fa77862d946e();
  if(obj != null) {
  s.ssSTURLQueryParameter = ssRuntimeDestroyer.RestRecords.RESTST_67c9532b700300cd02996c0d658856f8Structure.ToStructure(obj.AttrURLQueryParameter);
  }
  return s;
}

public static Func<RC_390a8f0cc1a357081cd0fa77862d946e, ssRuntimeDestroyer.RestRecords.RESTRC_390a8f0cc1a357081cd0fa77862d946e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_390a8f0cc1a357081cd0fa77862d946e s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTRC_390a8f0cc1a357081cd0fa77862d946e FromStructure(RC_390a8f0cc1a357081cd0fa77862d946e s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTRC_390a8f0cc1a357081cd0fa77862d946e(s, config);
}

}


