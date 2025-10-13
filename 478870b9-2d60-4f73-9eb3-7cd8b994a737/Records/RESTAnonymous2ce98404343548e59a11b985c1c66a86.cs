using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// RuntimeTypeRecord
public class RESTRC_3251af6c799b185d408b7cad31be3454 : AbstractRESTStructure<RC_3251af6c799b185d408b7cad31be3454> {
[JsonProperty("RuntimeType")]
public ssSystem_.RestRecords.RESTENRuntimeTypeEntityRecord AttrRuntimeType;

public RESTRC_3251af6c799b185d408b7cad31be3454() { }

public RESTRC_3251af6c799b185d408b7cad31be3454 (RC_3251af6c799b185d408b7cad31be3454 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRuntimeType = ssSystem_.RestRecords.RESTENRuntimeTypeEntityRecord.FromStructure(s.ssENRuntimeType, config);
  } else {
AttrRuntimeType = ssSystem_.RestRecords.RESTENRuntimeTypeEntityRecord.FromStructure(s.ssENRuntimeType, config);
  }
}

public static RC_3251af6c799b185d408b7cad31be3454 ToStructure(ssSystem_.RestRecords.RESTRC_3251af6c799b185d408b7cad31be3454 obj) { 
  RC_3251af6c799b185d408b7cad31be3454 s = new RC_3251af6c799b185d408b7cad31be3454();
  if(obj != null) {
  s.ssENRuntimeType = ssSystem_.RestRecords.RESTENRuntimeTypeEntityRecord.ToStructure(obj.AttrRuntimeType);
  }
  return s;
}

public static Func<RC_3251af6c799b185d408b7cad31be3454, ssSystem_.RestRecords.RESTRC_3251af6c799b185d408b7cad31be3454> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3251af6c799b185d408b7cad31be3454 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.RESTRC_3251af6c799b185d408b7cad31be3454 FromStructure(RC_3251af6c799b185d408b7cad31be3454 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.RESTRC_3251af6c799b185d408b7cad31be3454(s, config);
}

}


