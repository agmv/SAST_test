using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AIContentTypeRecord
public class RESTRC_331ddee75740189a809db62f762472bd : AbstractRESTStructure<RC_331ddee75740189a809db62f762472bd> {
[JsonProperty("AIContentType")]
public ssRuntimeDestroyer.RestRecords.RESTENAIContentTypeEntityRecord AttrAIContentType;

public RESTRC_331ddee75740189a809db62f762472bd() { }

public RESTRC_331ddee75740189a809db62f762472bd (RC_331ddee75740189a809db62f762472bd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIContentType = ConvertToRestWithoutDefaults(s.ssENAIContentType, new ENAIContentTypeEntityRecord(), ssRuntimeDestroyer.RestRecords.RESTENAIContentTypeEntityRecord.FromStructureDelegate(config));
  } else {
AttrAIContentType = ssRuntimeDestroyer.RestRecords.RESTENAIContentTypeEntityRecord.FromStructure(s.ssENAIContentType, config);
  }
}

public static RC_331ddee75740189a809db62f762472bd ToStructure(ssRuntimeDestroyer.RestRecords.RESTRC_331ddee75740189a809db62f762472bd obj) { 
  RC_331ddee75740189a809db62f762472bd s = new RC_331ddee75740189a809db62f762472bd();
  if(obj != null) {
  s.ssENAIContentType = ssRuntimeDestroyer.RestRecords.RESTENAIContentTypeEntityRecord.ToStructure(obj.AttrAIContentType);
  }
  return s;
}

public static Func<RC_331ddee75740189a809db62f762472bd, ssRuntimeDestroyer.RestRecords.RESTRC_331ddee75740189a809db62f762472bd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_331ddee75740189a809db62f762472bd s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTRC_331ddee75740189a809db62f762472bd FromStructure(RC_331ddee75740189a809db62f762472bd s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTRC_331ddee75740189a809db62f762472bd(s, config);
}

}


