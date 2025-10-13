using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] ActivityInstance (hg460+gk0UGzMRTFlEBTOQ) <code>ENActivityInstanceEntityRecord</code> that
///  represents <code>ActivityInstance</code> <p>Description: Entity that stores a record for eac
/// h activity that occurs while a process instance is active.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("ActivityInstance","hg460+gk0UGzMRTFlEBTOQ","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: ActivityInstance
public partial struct ENActivityInstanceEntityRecord : ITypedRecord<ENActivityInstanceEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*FB00tltBSUq9d_RJEYJfjA");
internal static readonly GlobalObjectKey IdActivityDefinitionId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*RKo1AcZ++GdjB8TdQ_XVmw");
internal static readonly GlobalObjectKey IdProcessInstanceId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*eCSPjcu_zomzRt24PBY_IA");
internal static readonly GlobalObjectKey IdProcessDefinitionId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*XrE5x97wqE25uhOaAC8eYw");
internal static readonly GlobalObjectKey IdStatus = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*r+14whd7qhMDhw_o0hntvQ");
internal static readonly GlobalObjectKey IdStartedOn = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*tllITD87aUKydcWeF6kLHg");
internal static readonly GlobalObjectKey IdLastModifiedOn = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*9WTleHO+bk+9Dwr5GrMoFg");
internal static readonly GlobalObjectKey IdHasExpired = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*j9F+59tqD0uNVEE2D1VKXQ");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID",0,true,true,false,true)]
[System.Xml.Serialization.XmlElement("Id")]
private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(8,true);
          _ssId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ACTIVITYDEFINITIONID",0,false,false,true,true)]
[System.Xml.Serialization.XmlElement("ActivityDefinitionId")]
private int _ssActivityDefinitionId;
public int ssActivityDefinitionId{
  get{
      return _ssActivityDefinitionId;
  }
  set{
      if((_ssActivityDefinitionId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssActivityDefinitionId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("PROCESSINSTANCEID",0,false,false,true,true)]
[System.Xml.Serialization.XmlElement("ProcessInstanceId")]
private long _ssProcessInstanceId;
public long ssProcessInstanceId{
  get{
      return _ssProcessInstanceId;
  }
  set{
      if((_ssProcessInstanceId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssProcessInstanceId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("PROCESSDEFINITIONID",0,false,false,true,false)]
[System.Xml.Serialization.XmlElement("ProcessDefinitionId")]
private int _ssProcessDefinitionId;
public int ssProcessDefinitionId{
  get{
      return _ssProcessDefinitionId;
  }
  set{
      if((_ssProcessDefinitionId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssProcessDefinitionId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("STATUS",0,false,false,true,true)]
[System.Xml.Serialization.XmlElement("Status")]
private long _ssStatus;
public long ssStatus{
  get{
      return _ssStatus;
  }
  set{
      if((_ssStatus!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssStatus = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("STARTEDON",0,false,false,false,false)]
[System.Xml.Serialization.XmlElement("StartedOn")]
private DateTime _ssStartedOn;
public DateTime ssStartedOn{
  get{
      return _ssStartedOn;
  }
  set{
      if((_ssStartedOn!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssStartedOn = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("LASTMODIFIEDON",0,false,false,false,false)]
[System.Xml.Serialization.XmlElement("LastModifiedOn")]
private DateTime _ssLastModifiedOn;
public DateTime ssLastModifiedOn{
  get{
      return _ssLastModifiedOn;
  }
  set{
      if((_ssLastModifiedOn!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssLastModifiedOn = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("HASEXPIRED",0,false,false,false,false)]
[System.Xml.Serialization.XmlElement("HasExpired")]
private bool _ssHasExpired;
public bool ssHasExpired{
  get{
      return _ssHasExpired;
  }
  set{
      if((_ssHasExpired!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssHasExpired = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENActivityInstanceEntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssActivityDefinitionId = 0;
_ssProcessInstanceId = 0L;
_ssProcessDefinitionId = 0;
_ssStatus = 0L;
_ssStartedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssLastModifiedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssHasExpired = false;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssId = r.ReadLongInteger(index++, "ActivityInstance.Id", 0L);
ssActivityDefinitionId = r.ReadEntityReference(index++, "ActivityInstance.ActivityDefinitionId", 0);
ssProcessInstanceId = r.ReadEntityReferenceLongInteger(index++, "ActivityInstance.ProcessInstanceId", 0L);
ssProcessDefinitionId = r.ReadEntityReference(index++, "ActivityInstance.ProcessDefinitionId", 0);
ssStatus = r.ReadEntityReferenceLongInteger(index++, "ActivityInstance.Status", 0L);
ssStartedOn = r.ReadDateTime(index++, "ActivityInstance.StartedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssLastModifiedOn = r.ReadDateTime(index++, "ActivityInstance.LastModifiedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssHasExpired = r.ReadBoolean(index++, "ActivityInstance.HasExpired", false);
ChangedAttributes = new BitArray(8,false);
OptimizedAttributes = new BitArray(8,false);
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ENActivityInstanceEntityRecord r) {
this = r;
}


public static bool operator == (ENActivityInstanceEntityRecord a, ENActivityInstanceEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssActivityDefinitionId != b.ssActivityDefinitionId) return false;
if (a.ssProcessInstanceId != b.ssProcessInstanceId) return false;
if (a.ssProcessDefinitionId != b.ssProcessDefinitionId) return false;
if (a.ssStatus != b.ssStatus) return false;
if (a.ssStartedOn != b.ssStartedOn) return false;
if (a.ssLastModifiedOn != b.ssLastModifiedOn) return false;
if (a.ssHasExpired != b.ssHasExpired) return false;
return true;
}

public static bool operator != (ENActivityInstanceEntityRecord a, ENActivityInstanceEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENActivityInstanceEntityRecord)) return false;
return (this == (ENActivityInstanceEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssActivityDefinitionId.GetHashCode()
 ^ ssProcessInstanceId.GetHashCode()
 ^ ssProcessDefinitionId.GetHashCode()
 ^ ssStatus.GetHashCode()
 ^ ssStartedOn.GetHashCode()
 ^ ssLastModifiedOn.GetHashCode()
 ^ ssHasExpired.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ENActivityInstanceEntityRecord Duplicate() {
ENActivityInstanceEntityRecord t;
t._ssId = this._ssId;
t._ssActivityDefinitionId = this._ssActivityDefinitionId;
t._ssProcessInstanceId = this._ssProcessInstanceId;
t._ssProcessDefinitionId = this._ssProcessDefinitionId;
t._ssStatus = this._ssStatus;
t._ssStartedOn = this._ssStartedOn;
t._ssLastModifiedOn = this._ssLastModifiedOn;
t._ssHasExpired = this._ssHasExpired;
t.ChangedAttributes = new BitArray(8);
t.OptimizedAttributes = new BitArray(8);
for(int i = 0; i < 8; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "activitydefinitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActivityDefinitionId")) variable.Value = ssActivityDefinitionId; else variable.Optimized = true;
} else if (head == "processinstanceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessInstanceId")) variable.Value = ssProcessInstanceId; else variable.Optimized = true;
} else if (head == "processdefinitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessDefinitionId")) variable.Value = ssProcessDefinitionId; else variable.Optimized = true;
} else if (head == "status") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Status")) variable.Value = ssStatus; else variable.Optimized = true;
} else if (head == "startedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartedOn")) variable.Value = ssStartedOn; else variable.Optimized = true;
} else if (head == "lastmodifiedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LastModifiedOn")) variable.Value = ssLastModifiedOn; else variable.Optimized = true;
} else if (head == "hasexpired") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasExpired")) variable.Value = ssHasExpired; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdActivityDefinitionId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdProcessInstanceId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdProcessDefinitionId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdStatus)) {
return ChangedAttributes[4];
}
if (key.Equals(IdStartedOn)) {
return ChangedAttributes[5];
}
if (key.Equals(IdLastModifiedOn)) {
return ChangedAttributes[6];
}
if (key.Equals(IdHasExpired)) {
return ChangedAttributes[7];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdActivityDefinitionId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdProcessInstanceId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdProcessDefinitionId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdStatus)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdStartedOn)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdLastModifiedOn)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdHasExpired)) {
return OptimizedAttributes[7];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdActivityDefinitionId) {
return ssActivityDefinitionId;
}
if (key == IdProcessInstanceId) {
return ssProcessInstanceId;
}
if (key == IdProcessDefinitionId) {
return ssProcessDefinitionId;
}
if (key == IdStatus) {
return ssStatus;
}
if (key == IdStartedOn) {
return ssStartedOn;
}
if (key == IdLastModifiedOn) {
return ssLastModifiedOn;
}
if (key == IdHasExpired) {
return ssHasExpired;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdActivityDefinitionId.Key.AsGuid) {
return ssActivityDefinitionId;
}
if (attributeKey == IdProcessInstanceId.Key.AsGuid) {
return ssProcessInstanceId;
}
if (attributeKey == IdProcessDefinitionId.Key.AsGuid) {
return ssProcessDefinitionId;
}
if (attributeKey == IdStatus.Key.AsGuid) {
return ssStatus;
}
if (attributeKey == IdStartedOn.Key.AsGuid) {
return ssStartedOn;
}
if (attributeKey == IdLastModifiedOn.Key.AsGuid) {
return ssLastModifiedOn;
}
if (attributeKey == IdHasExpired.Key.AsGuid) {
return ssHasExpired;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(8);
OptimizedAttributes = new BitArray(8);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssActivityDefinitionId = (int) other.AttributeGet(IdActivityDefinitionId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdActivityDefinitionId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdActivityDefinitionId);
ssProcessInstanceId = (long) other.AttributeGet(IdProcessInstanceId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdProcessInstanceId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdProcessInstanceId);
ssProcessDefinitionId = (int) other.AttributeGet(IdProcessDefinitionId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdProcessDefinitionId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdProcessDefinitionId);
ssStatus = (long) other.AttributeGet(IdStatus);
ChangedAttributes[4] = other.ChangedAttributeGet(IdStatus);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdStatus);
ssStartedOn = (DateTime) other.AttributeGet(IdStartedOn);
ChangedAttributes[5] = other.ChangedAttributeGet(IdStartedOn);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdStartedOn);
ssLastModifiedOn = (DateTime) other.AttributeGet(IdLastModifiedOn);
ChangedAttributes[6] = other.ChangedAttributeGet(IdLastModifiedOn);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdLastModifiedOn);
ssHasExpired = (bool) other.AttributeGet(IdHasExpired);
ChangedAttributes[7] = other.ChangedAttributeGet(IdHasExpired);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdHasExpired);
}
} // ENActivityInstanceEntityRecord

/// <summary>
/// RecordList type <code>ActivityInstanceList</code> that represents a record list of
///  <code>ActivityInstance</code>
/// </summary>
public partial class RLActivityInstanceList : GenericRecordList<ENActivityInstanceEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENActivityInstanceEntityRecord GetElementDefaultValue() {
return new ENActivityInstanceEntityRecord();
}

public T[] ToArray<T>(Func<ENActivityInstanceEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLActivityInstanceList recordList, Func<ENActivityInstanceEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLActivityInstanceList(ENActivityInstanceEntityRecord[] array) {
  RLActivityInstanceList result = new RLActivityInstanceList();
result.InnerFromArray(array);
    return result;
}

public static RLActivityInstanceList ToList<T>(T[] array, Func <T, ENActivityInstanceEntityRecord> converter) {
  RLActivityInstanceList result = new RLActivityInstanceList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLActivityInstanceList FromRestList<T>(RestList<T> restList, Func <T, ENActivityInstanceEntityRecord> converter) {
  RLActivityInstanceList result = new RLActivityInstanceList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLActivityInstanceList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENActivityInstanceEntityRecord> NewList() {
return new RLActivityInstanceList();
}


} // RLActivityInstanceList
}
