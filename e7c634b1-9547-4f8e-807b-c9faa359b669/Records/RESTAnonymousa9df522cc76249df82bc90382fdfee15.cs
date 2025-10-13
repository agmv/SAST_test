using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// Employee2Record
public class RESTRC_cb713964cdef6257549c9c600e5dce68 : AbstractRESTStructure<RC_cb713964cdef6257549c9c600e5dce68> {
[JsonProperty("Employee2")]
public ssRuntimeDestroyer.RestRecords.RESTST_c6c92e08cc1756053230783f07370fc0Structure AttrEmployee2;

public RESTRC_cb713964cdef6257549c9c600e5dce68() { }

public RESTRC_cb713964cdef6257549c9c600e5dce68 (RC_cb713964cdef6257549c9c600e5dce68 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEmployee2 = ConvertToRestWithoutDefaults(s.ssSTEmployee2, new ST_c6c92e08cc1756053230783f07370fc0Structure(), ssRuntimeDestroyer.RestRecords.RESTST_c6c92e08cc1756053230783f07370fc0Structure.FromStructureDelegate(config));
  } else {
AttrEmployee2 = ssRuntimeDestroyer.RestRecords.RESTST_c6c92e08cc1756053230783f07370fc0Structure.FromStructure(s.ssSTEmployee2, config);
  }
}

public static RC_cb713964cdef6257549c9c600e5dce68 ToStructure(ssRuntimeDestroyer.RestRecords.RESTRC_cb713964cdef6257549c9c600e5dce68 obj) { 
  RC_cb713964cdef6257549c9c600e5dce68 s = new RC_cb713964cdef6257549c9c600e5dce68();
  if(obj != null) {
  s.ssSTEmployee2 = ssRuntimeDestroyer.RestRecords.RESTST_c6c92e08cc1756053230783f07370fc0Structure.ToStructure(obj.AttrEmployee2);
  }
  return s;
}

public static Func<RC_cb713964cdef6257549c9c600e5dce68, ssRuntimeDestroyer.RestRecords.RESTRC_cb713964cdef6257549c9c600e5dce68> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cb713964cdef6257549c9c600e5dce68 s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTRC_cb713964cdef6257549c9c600e5dce68 FromStructure(RC_cb713964cdef6257549c9c600e5dce68 s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTRC_cb713964cdef6257549c9c600e5dce68(s, config);
}

}


