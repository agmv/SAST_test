using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// PasswordValidationResult
public class JSONST_b9e6959231369ae517164f0fb8e8606dStructure : AbstractRESTStructure<ST_b9e6959231369ae517164f0fb8e8606dStructure> {
[JsonProperty("IsValid")]
[JsonPropertyName("IsValid")]
public bool? AttrIsValid;

[JsonProperty("MissingLowerCaseLetter")]
[JsonPropertyName("MissingLowerCaseLetter")]
public bool? AttrMissingLowerCaseLetter;

[JsonProperty("MissingMinimumLength")]
[JsonPropertyName("MissingMinimumLength")]
public bool? AttrMissingMinimumLength;

[JsonProperty("MissingUpperCaseLetter")]
[JsonPropertyName("MissingUpperCaseLetter")]
public bool? AttrMissingUpperCaseLetter;

[JsonProperty("MissingNumber")]
[JsonPropertyName("MissingNumber")]
public bool? AttrMissingNumber;

[JsonProperty("MissingSpecialCharacter")]
[JsonPropertyName("MissingSpecialCharacter")]
public bool? AttrMissingSpecialCharacter;

public JSONST_b9e6959231369ae517164f0fb8e8606dStructure() { }

public JSONST_b9e6959231369ae517164f0fb8e8606dStructure (ST_b9e6959231369ae517164f0fb8e8606dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsValid = ConvertToRestWithoutDefaults(s.ssIsValid, false);
AttrMissingLowerCaseLetter = ConvertToRestWithoutDefaults(s.ssMissingLowerCaseLetter, false);
AttrMissingMinimumLength = ConvertToRestWithoutDefaults(s.ssMissingMinimumLength, false);
AttrMissingUpperCaseLetter = ConvertToRestWithoutDefaults(s.ssMissingUpperCaseLetter, false);
AttrMissingNumber = ConvertToRestWithoutDefaults(s.ssMissingNumber, false);
AttrMissingSpecialCharacter = ConvertToRestWithoutDefaults(s.ssMissingSpecialCharacter, false);
  } else {
AttrIsValid = (bool?) s.ssIsValid;
AttrMissingLowerCaseLetter = (bool?) s.ssMissingLowerCaseLetter;
AttrMissingMinimumLength = (bool?) s.ssMissingMinimumLength;
AttrMissingUpperCaseLetter = (bool?) s.ssMissingUpperCaseLetter;
AttrMissingNumber = (bool?) s.ssMissingNumber;
AttrMissingSpecialCharacter = (bool?) s.ssMissingSpecialCharacter;
  }
}

public static Func<ssSystem_.RestRecords.JSONST_b9e6959231369ae517164f0fb8e8606dStructure, ST_b9e6959231369ae517164f0fb8e8606dStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONST_b9e6959231369ae517164f0fb8e8606dStructure s) => ToStructure(s, config);
}
public static ST_b9e6959231369ae517164f0fb8e8606dStructure ToStructure(ssSystem_.RestRecords.JSONST_b9e6959231369ae517164f0fb8e8606dStructure obj, IBehaviorsConfiguration config) { 
  ST_b9e6959231369ae517164f0fb8e8606dStructure s = new ST_b9e6959231369ae517164f0fb8e8606dStructure();
  if(obj != null) {
  s.ssIsValid = obj.AttrIsValid == null ? false : obj.AttrIsValid.Value;
  s.ssMissingLowerCaseLetter = obj.AttrMissingLowerCaseLetter == null ? false : obj.AttrMissingLowerCaseLetter.Value;
  s.ssMissingMinimumLength = obj.AttrMissingMinimumLength == null ? false : obj.AttrMissingMinimumLength.Value;
  s.ssMissingUpperCaseLetter = obj.AttrMissingUpperCaseLetter == null ? false : obj.AttrMissingUpperCaseLetter.Value;
  s.ssMissingNumber = obj.AttrMissingNumber == null ? false : obj.AttrMissingNumber.Value;
  s.ssMissingSpecialCharacter = obj.AttrMissingSpecialCharacter == null ? false : obj.AttrMissingSpecialCharacter.Value;
  }
  return s;
}

public static Func<ST_b9e6959231369ae517164f0fb8e8606dStructure, ssSystem_.RestRecords.JSONST_b9e6959231369ae517164f0fb8e8606dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b9e6959231369ae517164f0fb8e8606dStructure s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONST_b9e6959231369ae517164f0fb8e8606dStructure FromStructure(ST_b9e6959231369ae517164f0fb8e8606dStructure s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONST_b9e6959231369ae517164f0fb8e8606dStructure(s, config);
}

}


