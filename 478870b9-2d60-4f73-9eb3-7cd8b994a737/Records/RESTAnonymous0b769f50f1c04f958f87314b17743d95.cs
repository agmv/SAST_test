using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// FinishUpdateEmailResultRecord
public class RESTRC_679ae82d2c7d05b47c7411f8ce9aeb62 : AbstractRESTStructure<RC_679ae82d2c7d05b47c7411f8ce9aeb62> {
[JsonProperty("FinishUpdateEmailResult")]
public ssSystem_.RestRecords.RESTST_992b6b077ef933bd10f0df6cf0ce4be3Structure AttrFinishUpdateEmailResult;

public RESTRC_679ae82d2c7d05b47c7411f8ce9aeb62() { }

public RESTRC_679ae82d2c7d05b47c7411f8ce9aeb62 (RC_679ae82d2c7d05b47c7411f8ce9aeb62 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFinishUpdateEmailResult = ConvertToRestWithoutDefaults(s.ssSTFinishUpdateEmailResult, new ST_992b6b077ef933bd10f0df6cf0ce4be3Structure(), ssSystem_.RestRecords.RESTST_992b6b077ef933bd10f0df6cf0ce4be3Structure.FromStructureDelegate(config));
  } else {
AttrFinishUpdateEmailResult = ssSystem_.RestRecords.RESTST_992b6b077ef933bd10f0df6cf0ce4be3Structure.FromStructure(s.ssSTFinishUpdateEmailResult, config);
  }
}

public static RC_679ae82d2c7d05b47c7411f8ce9aeb62 ToStructure(ssSystem_.RestRecords.RESTRC_679ae82d2c7d05b47c7411f8ce9aeb62 obj) { 
  RC_679ae82d2c7d05b47c7411f8ce9aeb62 s = new RC_679ae82d2c7d05b47c7411f8ce9aeb62();
  if(obj != null) {
  s.ssSTFinishUpdateEmailResult = ssSystem_.RestRecords.RESTST_992b6b077ef933bd10f0df6cf0ce4be3Structure.ToStructure(obj.AttrFinishUpdateEmailResult);
  }
  return s;
}

public static Func<RC_679ae82d2c7d05b47c7411f8ce9aeb62, ssSystem_.RestRecords.RESTRC_679ae82d2c7d05b47c7411f8ce9aeb62> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_679ae82d2c7d05b47c7411f8ce9aeb62 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_679ae82d2c7d05b47c7411f8ce9aeb62 FromStructure(RC_679ae82d2c7d05b47c7411f8ce9aeb62 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_679ae82d2c7d05b47c7411f8ce9aeb62(s, config);
}

}


