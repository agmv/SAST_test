using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssRuntimeDestroyer.RestRecords;

// AttachmentRecord
public class RESTRCAttachmentRecord : AbstractRESTStructure<RCAttachmentRecord> {
[JsonProperty("Attachment")]
public ssRuntimeDestroyer.RestRecords.RESTSTAttachmentStructure AttrAttachment;

public RESTRCAttachmentRecord() { }

public RESTRCAttachmentRecord (RCAttachmentRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAttachment = ConvertToRestWithoutDefaults(s.ssSTAttachment, new STAttachmentStructure(), ssRuntimeDestroyer.RestRecords.RESTSTAttachmentStructure.FromStructureDelegate(config));
  } else {
AttrAttachment = ssRuntimeDestroyer.RestRecords.RESTSTAttachmentStructure.FromStructure(s.ssSTAttachment, config);
  }
}

public static RCAttachmentRecord ToStructure(ssRuntimeDestroyer.RestRecords.RESTRCAttachmentRecord obj) { 
  RCAttachmentRecord s = new RCAttachmentRecord();
  if(obj != null) {
  s.ssSTAttachment = ssRuntimeDestroyer.RestRecords.RESTSTAttachmentStructure.ToStructure(obj.AttrAttachment);
  }
  return s;
}

public static Func<RCAttachmentRecord, ssRuntimeDestroyer.RestRecords.RESTRCAttachmentRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAttachmentRecord s) => FromStructure(s, config);
}
public static ssRuntimeDestroyer.RestRecords.RESTRCAttachmentRecord FromStructure(RCAttachmentRecord s, IBehaviorsConfiguration config) { 
  return new ssRuntimeDestroyer.RestRecords.RESTRCAttachmentRecord(s, config);
}

}


