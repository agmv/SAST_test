using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// StartResetPasswordResultRecord
public class RESTRC_8f8c9b77bcc0996564febb7d38ea930a : AbstractRESTStructure<RC_8f8c9b77bcc0996564febb7d38ea930a> {
[JsonProperty("StartResetPasswordResult")]
public ssSystem_.RestRecords.RESTST_7df0b593cd1052614bf3d2f66d1ab2efStructure AttrStartResetPasswordResult;

public RESTRC_8f8c9b77bcc0996564febb7d38ea930a() { }

public RESTRC_8f8c9b77bcc0996564febb7d38ea930a (RC_8f8c9b77bcc0996564febb7d38ea930a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStartResetPasswordResult = ConvertToRestWithoutDefaults(s.ssSTStartResetPasswordResult, new ST_7df0b593cd1052614bf3d2f66d1ab2efStructure(), ssSystem_.RestRecords.RESTST_7df0b593cd1052614bf3d2f66d1ab2efStructure.FromStructureDelegate(config));
  } else {
AttrStartResetPasswordResult = ssSystem_.RestRecords.RESTST_7df0b593cd1052614bf3d2f66d1ab2efStructure.FromStructure(s.ssSTStartResetPasswordResult, config);
  }
}

public static RC_8f8c9b77bcc0996564febb7d38ea930a ToStructure(ssSystem_.RestRecords.RESTRC_8f8c9b77bcc0996564febb7d38ea930a obj) { 
  RC_8f8c9b77bcc0996564febb7d38ea930a s = new RC_8f8c9b77bcc0996564febb7d38ea930a();
  if(obj != null) {
  s.ssSTStartResetPasswordResult = ssSystem_.RestRecords.RESTST_7df0b593cd1052614bf3d2f66d1ab2efStructure.ToStructure(obj.AttrStartResetPasswordResult);
  }
  return s;
}

public static Func<RC_8f8c9b77bcc0996564febb7d38ea930a, ssSystem_.RestRecords.RESTRC_8f8c9b77bcc0996564febb7d38ea930a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8f8c9b77bcc0996564febb7d38ea930a s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_8f8c9b77bcc0996564febb7d38ea930a FromStructure(RC_8f8c9b77bcc0996564febb7d38ea930a s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_8f8c9b77bcc0996564febb7d38ea930a(s, config);
}

}


