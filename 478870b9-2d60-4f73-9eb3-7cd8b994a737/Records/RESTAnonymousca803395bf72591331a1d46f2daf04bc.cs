using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ActivityOutputRecord
public class RESTRC_24e87e1f1de297ca8a691099e40c22ed : AbstractRESTStructure<RC_24e87e1f1de297ca8a691099e40c22ed> {
[JsonProperty("ActivityOutput")]
public ssSystem_.RestRecords.RESTENActivityOutputEntityRecord AttrActivityOutput;

public RESTRC_24e87e1f1de297ca8a691099e40c22ed() { }

public RESTRC_24e87e1f1de297ca8a691099e40c22ed (RC_24e87e1f1de297ca8a691099e40c22ed s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityOutput = ConvertToRestWithoutDefaults(s.ssENActivityOutput, new ENActivityOutputEntityRecord(), ssSystem_.RestRecords.RESTENActivityOutputEntityRecord.FromStructureDelegate(config));
  } else {
AttrActivityOutput = ssSystem_.RestRecords.RESTENActivityOutputEntityRecord.FromStructure(s.ssENActivityOutput, config);
  }
}

public static RC_24e87e1f1de297ca8a691099e40c22ed ToStructure(ssSystem_.RestRecords.RESTRC_24e87e1f1de297ca8a691099e40c22ed obj) { 
  RC_24e87e1f1de297ca8a691099e40c22ed s = new RC_24e87e1f1de297ca8a691099e40c22ed();
  if(obj != null) {
  s.ssENActivityOutput = ssSystem_.RestRecords.RESTENActivityOutputEntityRecord.ToStructure(obj.AttrActivityOutput);
  }
  return s;
}

public static Func<RC_24e87e1f1de297ca8a691099e40c22ed, ssSystem_.RestRecords.RESTRC_24e87e1f1de297ca8a691099e40c22ed> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_24e87e1f1de297ca8a691099e40c22ed s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_24e87e1f1de297ca8a691099e40c22ed FromStructure(RC_24e87e1f1de297ca8a691099e40c22ed s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_24e87e1f1de297ca8a691099e40c22ed(s, config);
}

}


