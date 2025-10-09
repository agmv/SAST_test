using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// ProcessInstanceRecord
public class RESTRC_c2c51a49c601586c1a143904ac6893f9 : AbstractRESTStructure<RC_c2c51a49c601586c1a143904ac6893f9> {
[JsonProperty("ProcessInstance")]
public ssSystem_.RestRecords.RESTENProcessInstanceEntityRecord AttrProcessInstance;

public RESTRC_c2c51a49c601586c1a143904ac6893f9() { }

public RESTRC_c2c51a49c601586c1a143904ac6893f9 (RC_c2c51a49c601586c1a143904ac6893f9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProcessInstance = ConvertToRestWithoutDefaults(s.ssENProcessInstance, new ENProcessInstanceEntityRecord(), ssSystem_.RestRecords.RESTENProcessInstanceEntityRecord.FromStructureDelegate(config));
  } else {
AttrProcessInstance = ssSystem_.RestRecords.RESTENProcessInstanceEntityRecord.FromStructure(s.ssENProcessInstance, config);
  }
}

public static RC_c2c51a49c601586c1a143904ac6893f9 ToStructure(ssSystem_.RestRecords.RESTRC_c2c51a49c601586c1a143904ac6893f9 obj) { 
  RC_c2c51a49c601586c1a143904ac6893f9 s = new RC_c2c51a49c601586c1a143904ac6893f9();
  if(obj != null) {
  s.ssENProcessInstance = ssSystem_.RestRecords.RESTENProcessInstanceEntityRecord.ToStructure(obj.AttrProcessInstance);
  }
  return s;
}

public static Func<RC_c2c51a49c601586c1a143904ac6893f9, ssSystem_.RestRecords.RESTRC_c2c51a49c601586c1a143904ac6893f9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c2c51a49c601586c1a143904ac6893f9 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_c2c51a49c601586c1a143904ac6893f9 FromStructure(RC_c2c51a49c601586c1a143904ac6893f9 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_c2c51a49c601586c1a143904ac6893f9(s, config);
}

}


