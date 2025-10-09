using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] ProcessInstance (rk1aJNDvckKT91HxgCaO6w) <code>ENProcessInstanceEntityRecord</code> that
///  represents <code>ProcessInstance</code> <p>Description: Entity that stores a record for each activ
/// e process instance.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("ProcessInstance","rk1aJNDvckKT91HxgCaO6w","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: ProcessInstance
public partial struct ENProcessInstanceEntityRecord : ITypedRecord<ENProcessInstanceEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*GL4JreOXZk+Xzi2nGBOF7A");
internal static readonly GlobalObjectKey IdProcessDefinitionId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*Qn7GFbSaU7ptL6qCsgmTsw");
internal static readonly GlobalObjectKey IdStatus = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*3AugLvR88yK5iKJEXvKQSw");
internal static readonly GlobalObjectKey IdStartedOn = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*DdBVFghchkqshT5uRZd8dg");
internal static readonly GlobalObjectKey IdLastModifiedOn = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*Oj9fyHZeZUaFHQpteWJRYQ");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*E+GW4rHIGU60hdED9q8QAA");

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
          ChangedAttributes = new BitArray(6,true);
          _ssId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("PROCESSDEFINITIONID",0,false,false,true,true)]
[System.Xml.Serialization.XmlElement("ProcessDefinitionId")]
private int _ssProcessDefinitionId;
public int ssProcessDefinitionId{
  get{
      return _ssProcessDefinitionId;
  }
  set{
      if((_ssProcessDefinitionId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
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
      if((_ssStatus!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
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
      if((_ssStartedOn!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
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
      if((_ssLastModifiedOn!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssLastModifiedOn = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("LABEL",100,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Label")]
private string _ssLabel;
public string ssLabel{
  get{
      return _ssLabel;
  }
  set{
      if((_ssLabel!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssLabel = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENProcessInstanceEntityRecord() {
ChangedAttributes = new BitArray(6,true);
OptimizedAttributes = new BitArray(6,false);
_ssId = 0L;
_ssProcessDefinitionId = 0;
_ssStatus = 0L;
_ssStartedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssLastModifiedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssLabel = "";
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
ssId = r.ReadLongInteger(index++, "ProcessInstance.Id", 0L);
ssProcessDefinitionId = r.ReadEntityReference(index++, "ProcessInstance.ProcessDefinitionId", 0);
ssStatus = r.ReadEntityReferenceLongInteger(index++, "ProcessInstance.Status", 0L);
ssStartedOn = r.ReadDateTime(index++, "ProcessInstance.StartedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssLastModifiedOn = r.ReadDateTime(index++, "ProcessInstance.LastModifiedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssLabel = r.ReadText(index++, "ProcessInstance.Label", "");
ChangedAttributes = new BitArray(6,false);
OptimizedAttributes = new BitArray(6,false);
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
public void ReadIM(ENProcessInstanceEntityRecord r) {
this = r;
}


public static bool operator == (ENProcessInstanceEntityRecord a, ENProcessInstanceEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssProcessDefinitionId != b.ssProcessDefinitionId) return false;
if (a.ssStatus != b.ssStatus) return false;
if (a.ssStartedOn != b.ssStartedOn) return false;
if (a.ssLastModifiedOn != b.ssLastModifiedOn) return false;
if (a.ssLabel != b.ssLabel) return false;
return true;
}

public static bool operator != (ENProcessInstanceEntityRecord a, ENProcessInstanceEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENProcessInstanceEntityRecord)) return false;
return (this == (ENProcessInstanceEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssProcessDefinitionId.GetHashCode()
 ^ ssStatus.GetHashCode()
 ^ ssStartedOn.GetHashCode()
 ^ ssLastModifiedOn.GetHashCode()
 ^ ssLabel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ENProcessInstanceEntityRecord Duplicate() {
ENProcessInstanceEntityRecord t;
t._ssId = this._ssId;
t._ssProcessDefinitionId = this._ssProcessDefinitionId;
t._ssStatus = this._ssStatus;
t._ssStartedOn = this._ssStartedOn;
t._ssLastModifiedOn = this._ssLastModifiedOn;
t._ssLabel = this._ssLabel;
t.ChangedAttributes = new BitArray(6);
t.OptimizedAttributes = new BitArray(6);
for(int i = 0; i < 6; i++){
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
} else if (head == "processdefinitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessDefinitionId")) variable.Value = ssProcessDefinitionId; else variable.Optimized = true;
} else if (head == "status") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Status")) variable.Value = ssStatus; else variable.Optimized = true;
} else if (head == "startedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartedOn")) variable.Value = ssStartedOn; else variable.Optimized = true;
} else if (head == "lastmodifiedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LastModifiedOn")) variable.Value = ssLastModifiedOn; else variable.Optimized = true;
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdProcessDefinitionId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdStatus)) {
return ChangedAttributes[2];
}
if (key.Equals(IdStartedOn)) {
return ChangedAttributes[3];
}
if (key.Equals(IdLastModifiedOn)) {
return ChangedAttributes[4];
}
if (key.Equals(IdLabel)) {
return ChangedAttributes[5];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdProcessDefinitionId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdStatus)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdStartedOn)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdLastModifiedOn)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdLabel)) {
return OptimizedAttributes[5];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
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
if (key == IdLabel) {
return ssLabel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
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
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(6);
OptimizedAttributes = new BitArray(6);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssProcessDefinitionId = (int) other.AttributeGet(IdProcessDefinitionId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdProcessDefinitionId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdProcessDefinitionId);
ssStatus = (long) other.AttributeGet(IdStatus);
ChangedAttributes[2] = other.ChangedAttributeGet(IdStatus);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdStatus);
ssStartedOn = (DateTime) other.AttributeGet(IdStartedOn);
ChangedAttributes[3] = other.ChangedAttributeGet(IdStartedOn);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdStartedOn);
ssLastModifiedOn = (DateTime) other.AttributeGet(IdLastModifiedOn);
ChangedAttributes[4] = other.ChangedAttributeGet(IdLastModifiedOn);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdLastModifiedOn);
ssLabel = (string) other.AttributeGet(IdLabel);
ChangedAttributes[5] = other.ChangedAttributeGet(IdLabel);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdLabel);
}
} // ENProcessInstanceEntityRecord

/// <summary>
/// RecordList type <code>ProcessInstanceList</code> that represents a record list of
///  <code>ProcessInstance</code>
/// </summary>
public partial class RLProcessInstanceList : GenericRecordList<ENProcessInstanceEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENProcessInstanceEntityRecord GetElementDefaultValue() {
return new ENProcessInstanceEntityRecord();
}

public T[] ToArray<T>(Func<ENProcessInstanceEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLProcessInstanceList recordList, Func<ENProcessInstanceEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLProcessInstanceList(ENProcessInstanceEntityRecord[] array) {
  RLProcessInstanceList result = new RLProcessInstanceList();
result.InnerFromArray(array);
    return result;
}

public static RLProcessInstanceList ToList<T>(T[] array, Func <T, ENProcessInstanceEntityRecord> converter) {
  RLProcessInstanceList result = new RLProcessInstanceList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLProcessInstanceList FromRestList<T>(RestList<T> restList, Func <T, ENProcessInstanceEntityRecord> converter) {
  RLProcessInstanceList result = new RLProcessInstanceList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLProcessInstanceList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENProcessInstanceEntityRecord> NewList() {
return new RLProcessInstanceList();
}


} // RLProcessInstanceList
}
