using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// FinishUserRegistrationResult
public class RESTST_6ae840a01e1abcf21a5dce7b68bc4d92Structure : AbstractRESTStructure<ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure> {
[JsonProperty("Success")]
public bool? AttrSuccess;

[JsonProperty("UserId")]
public string AttrUserId;

[JsonProperty("FinishUserRegistrationFailureReason")]
public ssSystem_.RestRecords.RESTST_6512d51a2c447fea2b8340c839f73d57Structure AttrFinishUserRegistrationFailureReason;

public RESTST_6ae840a01e1abcf21a5dce7b68bc4d92Structure() { }

public RESTST_6ae840a01e1abcf21a5dce7b68bc4d92Structure (ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSuccess = ConvertToRestWithoutDefaults(s.ssSuccess, false);
AttrUserId = ConvertToRestWithoutDefaults(s.ssUserId, "");
AttrFinishUserRegistrationFailureReason = ConvertToRestWithoutDefaults(s.ssFinishUserRegistrationFailureReason, new ST_6512d51a2c447fea2b8340c839f73d57Structure(), ssSystem_.RestRecords.RESTST_6512d51a2c447fea2b8340c839f73d57Structure.FromStructureDelegate(config));
  } else {
AttrSuccess = (bool?) s.ssSuccess;
AttrUserId = s.ssUserId;
AttrFinishUserRegistrationFailureReason = ssSystem_.RestRecords.RESTST_6512d51a2c447fea2b8340c839f73d57Structure.FromStructure(s.ssFinishUserRegistrationFailureReason, config);
  }
}

public static ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure ToStructure(ssSystem_.RestRecords.RESTST_6ae840a01e1abcf21a5dce7b68bc4d92Structure obj) { 
  ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure s = new ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure();
  if(obj != null) {
  s.ssSuccess = obj.AttrSuccess == null ? false : obj.AttrSuccess.Value;
  s.ssUserId = obj.AttrUserId == null ? "" : obj.AttrUserId;
  s.ssFinishUserRegistrationFailureReason = ssSystem_.RestRecords.RESTST_6512d51a2c447fea2b8340c839f73d57Structure.ToStructure(obj.AttrFinishUserRegistrationFailureReason);
  }
  return s;
}

public static Func<ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure, ssSystem_.RestRecords.RESTST_6ae840a01e1abcf21a5dce7b68bc4d92Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTST_6ae840a01e1abcf21a5dce7b68bc4d92Structure FromStructure(ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTST_6ae840a01e1abcf21a5dce7b68bc4d92Structure(s, config);
}

}


