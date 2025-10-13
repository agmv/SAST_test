using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// PasswordComplexityPolicy
public class JSONST_0774152396050b877fe73fc0db09d4f4Structure : AbstractRESTStructure<ST_0774152396050b877fe73fc0db09d4f4Structure> {
[JsonProperty("MinimumLength")]
[JsonPropertyName("MinimumLength")]
public int? AttrMinimumLength;

[JsonProperty("UpperCaseLetterRequired")]
[JsonPropertyName("UpperCaseLetterRequired")]
public bool? AttrUpperCaseLetterRequired;

[JsonProperty("LowerCaseLetterRequired")]
[JsonPropertyName("LowerCaseLetterRequired")]
public bool? AttrLowerCaseLetterRequired;

[JsonProperty("NumberRequired")]
[JsonPropertyName("NumberRequired")]
public bool? AttrNumberRequired;

[JsonProperty("SpecialCharacterRequired")]
[JsonPropertyName("SpecialCharacterRequired")]
public bool? AttrSpecialCharacterRequired;

public JSONST_0774152396050b877fe73fc0db09d4f4Structure() { }

public JSONST_0774152396050b877fe73fc0db09d4f4Structure (ST_0774152396050b877fe73fc0db09d4f4Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMinimumLength = ConvertToRestWithoutDefaults(s.ssMinimumLength, 0);
AttrUpperCaseLetterRequired = ConvertToRestWithoutDefaults(s.ssUpperCaseLetterRequired, false);
AttrLowerCaseLetterRequired = ConvertToRestWithoutDefaults(s.ssLowerCaseLetterRequired, false);
AttrNumberRequired = ConvertToRestWithoutDefaults(s.ssNumberRequired, false);
AttrSpecialCharacterRequired = ConvertToRestWithoutDefaults(s.ssSpecialCharacterRequired, false);
  } else {
AttrMinimumLength = (int?) s.ssMinimumLength;
AttrUpperCaseLetterRequired = (bool?) s.ssUpperCaseLetterRequired;
AttrLowerCaseLetterRequired = (bool?) s.ssLowerCaseLetterRequired;
AttrNumberRequired = (bool?) s.ssNumberRequired;
AttrSpecialCharacterRequired = (bool?) s.ssSpecialCharacterRequired;
  }
}

public static Func<ssSystem_.RestRecords.JSONST_0774152396050b877fe73fc0db09d4f4Structure, ST_0774152396050b877fe73fc0db09d4f4Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONST_0774152396050b877fe73fc0db09d4f4Structure s) => ToStructure(s, config);
}
public static ST_0774152396050b877fe73fc0db09d4f4Structure ToStructure(ssSystem_.RestRecords.JSONST_0774152396050b877fe73fc0db09d4f4Structure obj, IBehaviorsConfiguration config) { 
  ST_0774152396050b877fe73fc0db09d4f4Structure s = new ST_0774152396050b877fe73fc0db09d4f4Structure();
  if(obj != null) {
  s.ssMinimumLength = obj.AttrMinimumLength == null ? 0 : obj.AttrMinimumLength.Value;
  s.ssUpperCaseLetterRequired = obj.AttrUpperCaseLetterRequired == null ? false : obj.AttrUpperCaseLetterRequired.Value;
  s.ssLowerCaseLetterRequired = obj.AttrLowerCaseLetterRequired == null ? false : obj.AttrLowerCaseLetterRequired.Value;
  s.ssNumberRequired = obj.AttrNumberRequired == null ? false : obj.AttrNumberRequired.Value;
  s.ssSpecialCharacterRequired = obj.AttrSpecialCharacterRequired == null ? false : obj.AttrSpecialCharacterRequired.Value;
  }
  return s;
}

public static Func<ST_0774152396050b877fe73fc0db09d4f4Structure, ssSystem_.RestRecords.JSONST_0774152396050b877fe73fc0db09d4f4Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_0774152396050b877fe73fc0db09d4f4Structure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONST_0774152396050b877fe73fc0db09d4f4Structure FromStructure(ST_0774152396050b877fe73fc0db09d4f4Structure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONST_0774152396050b877fe73fc0db09d4f4Structure(s, config);
}

}


