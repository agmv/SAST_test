using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AIContentTypeRecord
public class JSONRC_331ddee75740189a809db62f762472bd : AbstractRESTStructure<RC_331ddee75740189a809db62f762472bd> {
[JsonProperty("AIContentType")]
[JsonPropertyName("AIContentType")]
public ssRuntimeDestroyer.RestRecords.JSONENAIContentTypeEntityRecord AttrAIContentType;

public JSONRC_331ddee75740189a809db62f762472bd() { }

public JSONRC_331ddee75740189a809db62f762472bd (RC_331ddee75740189a809db62f762472bd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIContentType = ConvertToRestWithoutDefaults(s.ssENAIContentType, new ENAIContentTypeEntityRecord(), ssRuntimeDestroyer.RestRecords.JSONENAIContentTypeEntityRecord.FromStructureDelegate(config));
  } else {
AttrAIContentType = ssRuntimeDestroyer.RestRecords.JSONENAIContentTypeEntityRecord.FromStructure(s.ssENAIContentType, config);
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONRC_331ddee75740189a809db62f762472bd, RC_331ddee75740189a809db62f762472bd> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONRC_331ddee75740189a809db62f762472bd s) => ToStructure(s, config);
}
public static RC_331ddee75740189a809db62f762472bd ToStructure(ssRuntimeDestroyer.RestRecords.JSONRC_331ddee75740189a809db62f762472bd obj, IBehaviorsConfiguration config) { 
  RC_331ddee75740189a809db62f762472bd s = new RC_331ddee75740189a809db62f762472bd();
  if(obj != null) {
  s.ssENAIContentType = ssRuntimeDestroyer.RestRecords.JSONENAIContentTypeEntityRecord.ToStructure(obj.AttrAIContentType, config);
  }
  return s;
}

public static Func<RC_331ddee75740189a809db62f762472bd, ssRuntimeDestroyer.RestRecords.JSONRC_331ddee75740189a809db62f762472bd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_331ddee75740189a809db62f762472bd s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONRC_331ddee75740189a809db62f762472bd FromStructure(RC_331ddee75740189a809db62f762472bd s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONRC_331ddee75740189a809db62f762472bd(s, config);
}

}


