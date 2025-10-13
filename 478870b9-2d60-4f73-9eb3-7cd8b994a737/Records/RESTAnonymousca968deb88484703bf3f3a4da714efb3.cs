using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// FinishUserRegistrationFailureReasonRecord
public class RESTRC_78fc3f34c3c68c7b3604ba4da3920682 : AbstractRESTStructure<RC_78fc3f34c3c68c7b3604ba4da3920682> {
[JsonProperty("FinishUserRegistrationFailureReason")]
public ssSystem_.RestRecords.RESTST_6512d51a2c447fea2b8340c839f73d57Structure AttrFinishUserRegistrationFailureReason;

public RESTRC_78fc3f34c3c68c7b3604ba4da3920682() { }

public RESTRC_78fc3f34c3c68c7b3604ba4da3920682 (RC_78fc3f34c3c68c7b3604ba4da3920682 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFinishUserRegistrationFailureReason = ConvertToRestWithoutDefaults(s.ssSTFinishUserRegistrationFailureReason, new ST_6512d51a2c447fea2b8340c839f73d57Structure(), ssSystem_.RestRecords.RESTST_6512d51a2c447fea2b8340c839f73d57Structure.FromStructureDelegate(config));
  } else {
AttrFinishUserRegistrationFailureReason = ssSystem_.RestRecords.RESTST_6512d51a2c447fea2b8340c839f73d57Structure.FromStructure(s.ssSTFinishUserRegistrationFailureReason, config);
  }
}

public static RC_78fc3f34c3c68c7b3604ba4da3920682 ToStructure(ssSystem_.RestRecords.RESTRC_78fc3f34c3c68c7b3604ba4da3920682 obj) { 
  RC_78fc3f34c3c68c7b3604ba4da3920682 s = new RC_78fc3f34c3c68c7b3604ba4da3920682();
  if(obj != null) {
  s.ssSTFinishUserRegistrationFailureReason = ssSystem_.RestRecords.RESTST_6512d51a2c447fea2b8340c839f73d57Structure.ToStructure(obj.AttrFinishUserRegistrationFailureReason);
  }
  return s;
}

public static Func<RC_78fc3f34c3c68c7b3604ba4da3920682, ssSystem_.RestRecords.RESTRC_78fc3f34c3c68c7b3604ba4da3920682> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_78fc3f34c3c68c7b3604ba4da3920682 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_78fc3f34c3c68c7b3604ba4da3920682 FromStructure(RC_78fc3f34c3c68c7b3604ba4da3920682 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_78fc3f34c3c68c7b3604ba4da3920682(s, config);
}

}


