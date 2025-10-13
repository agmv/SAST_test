using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssSystem_.RestRecords;

// RuntimeTypeRecord
public class JSONRC_3251af6c799b185d408b7cad31be3454 : AbstractRESTStructure<RC_3251af6c799b185d408b7cad31be3454> {
[JsonProperty("RuntimeType")]
[JsonPropertyName("RuntimeType")]
public ssSystem_.RestRecords.JSONENRuntimeTypeEntityRecord AttrRuntimeType;

public JSONRC_3251af6c799b185d408b7cad31be3454() { }

public JSONRC_3251af6c799b185d408b7cad31be3454 (RC_3251af6c799b185d408b7cad31be3454 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRuntimeType = ssSystem_.RestRecords.JSONENRuntimeTypeEntityRecord.FromStructure(s.ssENRuntimeType, config);
  } else {
AttrRuntimeType = ssSystem_.RestRecords.JSONENRuntimeTypeEntityRecord.FromStructure(s.ssENRuntimeType, config);
  }
}

public static Func<ssSystem_.RestRecords.JSONRC_3251af6c799b185d408b7cad31be3454, RC_3251af6c799b185d408b7cad31be3454> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssSystem_.RestRecords.JSONRC_3251af6c799b185d408b7cad31be3454 s) => ToStructure(s, config);
}
public static RC_3251af6c799b185d408b7cad31be3454 ToStructure(ssSystem_.RestRecords.JSONRC_3251af6c799b185d408b7cad31be3454 obj, IBehaviorsConfiguration config) { 
  RC_3251af6c799b185d408b7cad31be3454 s = new RC_3251af6c799b185d408b7cad31be3454();
  if(obj != null) {
  s.ssENRuntimeType = ssSystem_.RestRecords.JSONENRuntimeTypeEntityRecord.ToStructure(obj.AttrRuntimeType, config);
  }
  return s;
}

public static Func<RC_3251af6c799b185d408b7cad31be3454, ssSystem_.RestRecords.JSONRC_3251af6c799b185d408b7cad31be3454> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3251af6c799b185d408b7cad31be3454 s) => FromStructure(s, config);
}
public static ssSystem_.RestRecords.JSONRC_3251af6c799b185d408b7cad31be3454 FromStructure(RC_3251af6c799b185d408b7cad31be3454 s, IBehaviorsConfiguration config) { 
  return new ssSystem_.RestRecords.JSONRC_3251af6c799b185d408b7cad31be3454(s, config);
}

}


