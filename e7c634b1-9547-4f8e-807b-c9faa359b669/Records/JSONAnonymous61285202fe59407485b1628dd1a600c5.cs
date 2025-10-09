using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AttachmentRecord
public class JSONRCAttachmentRecord : AbstractRESTStructure<RCAttachmentRecord> {
[JsonProperty("Attachment")]
[JsonPropertyName("Attachment")]
public ssRuntimeDestroyer.RestRecords.JSONSTAttachmentStructure AttrAttachment;

public JSONRCAttachmentRecord() { }

public JSONRCAttachmentRecord (RCAttachmentRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAttachment = ConvertToRestWithoutDefaults(s.ssSTAttachment, new STAttachmentStructure(), ssRuntimeDestroyer.RestRecords.JSONSTAttachmentStructure.FromStructureDelegate(config));
  } else {
AttrAttachment = ssRuntimeDestroyer.RestRecords.JSONSTAttachmentStructure.FromStructure(s.ssSTAttachment, config);
  }
}

public static Func<ssRuntimeDestroyer.RestRecords.JSONRCAttachmentRecord, RCAttachmentRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssRuntimeDestroyer.RestRecords.JSONRCAttachmentRecord s) => ToStructure(s, config);
}
public static RCAttachmentRecord ToStructure(ssRuntimeDestroyer.RestRecords.JSONRCAttachmentRecord obj, IBehaviorsConfiguration config) { 
  RCAttachmentRecord s = new RCAttachmentRecord();
  if(obj != null) {
  s.ssSTAttachment = ssRuntimeDestroyer.RestRecords.JSONSTAttachmentStructure.ToStructure(obj.AttrAttachment, config);
  }
  return s;
}

public static Func<RCAttachmentRecord, ssRuntimeDestroyer.RestRecords.JSONRCAttachmentRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAttachmentRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.JSONRCAttachmentRecord FromStructure(RCAttachmentRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.JSONRCAttachmentRecord(s, config);
}

}


