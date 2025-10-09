using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] ActivityDefinition (78eBMjWzI64yf+It5tGLUw) <code>ENActivityDefinitionEntityRecord</code>
///  that represents <code>ActivityDefinition</code> <p>Description: Entity that holds the definition o
/// f each activity as specified in the workflow editor.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("ActivityDefinition","78eBMjWzI64yf+It5tGLUw","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: ActivityDefinition
public partial struct ENActivityDefinitionEntityRecord : ITypedRecord<ENActivityDefinitionEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*kqC+9_ftJ0pCMV2lj6cf9w");
internal static readonly GlobalObjectKey IdKey = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*asc4hX6l5k+RIPaa6VoqCQ");
internal static readonly GlobalObjectKey IdProcessDefinitionId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*r+9sMpNl8v7+KFVRmwF0_w");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*6fUisFISKvm4DZayt_k4GQ");
internal static readonly GlobalObjectKey IdKind = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*g49JVlFc_NKS9BIruK329g");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID",0,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Id")]
private int _ssId;
public int ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(5,true);
          _ssId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("KEY",36,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Key")]
private string _ssKey;
public string ssKey{
  get{
      return _ssKey;
  }
  set{
      if((_ssKey!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssKey = value;
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
      if((_ssProcessDefinitionId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssProcessDefinitionId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("NAME",50,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Name")]
private string _ssName;
public string ssName{
  get{
      return _ssName;
  }
  set{
      if((_ssName!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssName = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("KIND",0,false,false,true,true)]
[System.Xml.Serialization.XmlElement("Kind")]
private long _ssKind;
public long ssKind{
  get{
      return _ssKind;
  }
  set{
      if((_ssKind!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssKind = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENActivityDefinitionEntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = 0;
_ssKey = "";
_ssProcessDefinitionId = 0;
_ssName = "";
_ssKind = 0L;
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
ssId = r.ReadInteger(index++, "ActivityDefinition.Id", 0);
ssKey = r.ReadText(index++, "ActivityDefinition.Key", "");
ssProcessDefinitionId = r.ReadEntityReference(index++, "ActivityDefinition.ProcessDefinitionId", 0);
ssName = r.ReadText(index++, "ActivityDefinition.Name", "");
ssKind = r.ReadEntityReferenceLongInteger(index++, "ActivityDefinition.Kind", 0L);
ChangedAttributes = new BitArray(5,false);
OptimizedAttributes = new BitArray(5,false);
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
public void ReadIM(ENActivityDefinitionEntityRecord r) {
this = r;
}


public static bool operator == (ENActivityDefinitionEntityRecord a, ENActivityDefinitionEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssKey != b.ssKey) return false;
if (a.ssProcessDefinitionId != b.ssProcessDefinitionId) return false;
if (a.ssName != b.ssName) return false;
if (a.ssKind != b.ssKind) return false;
return true;
}

public static bool operator != (ENActivityDefinitionEntityRecord a, ENActivityDefinitionEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENActivityDefinitionEntityRecord)) return false;
return (this == (ENActivityDefinitionEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssKey.GetHashCode()
 ^ ssProcessDefinitionId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssKind.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ENActivityDefinitionEntityRecord Duplicate() {
ENActivityDefinitionEntityRecord t;
t._ssId = this._ssId;
t._ssKey = this._ssKey;
t._ssProcessDefinitionId = this._ssProcessDefinitionId;
t._ssName = this._ssName;
t._ssKind = this._ssKind;
t.ChangedAttributes = new BitArray(5);
t.OptimizedAttributes = new BitArray(5);
for(int i = 0; i < 5; i++){
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
} else if (head == "key") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Key")) variable.Value = ssKey; else variable.Optimized = true;
} else if (head == "processdefinitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessDefinitionId")) variable.Value = ssProcessDefinitionId; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "kind") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Kind")) variable.Value = ssKind; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdKey)) {
return ChangedAttributes[1];
}
if (key.Equals(IdProcessDefinitionId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdName)) {
return ChangedAttributes[3];
}
if (key.Equals(IdKind)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdKey)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdProcessDefinitionId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdName)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdKind)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdKey) {
return ssKey;
}
if (key == IdProcessDefinitionId) {
return ssProcessDefinitionId;
}
if (key == IdName) {
return ssName;
}
if (key == IdKind) {
return ssKind;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdKey.Key.AsGuid) {
return ssKey;
}
if (attributeKey == IdProcessDefinitionId.Key.AsGuid) {
return ssProcessDefinitionId;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdKind.Key.AsGuid) {
return ssKind;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(5);
OptimizedAttributes = new BitArray(5);
if (other == null) return;
ssId = (int) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssKey = (string) other.AttributeGet(IdKey);
ChangedAttributes[1] = other.ChangedAttributeGet(IdKey);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdKey);
ssProcessDefinitionId = (int) other.AttributeGet(IdProcessDefinitionId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdProcessDefinitionId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdProcessDefinitionId);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[3] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdName);
ssKind = (long) other.AttributeGet(IdKind);
ChangedAttributes[4] = other.ChangedAttributeGet(IdKind);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdKind);
}
} // ENActivityDefinitionEntityRecord

/// <summary>
/// RecordList type <code>ActivityDefinitionList</code> that represents a record list of
///  <code>ActivityDefinition</code>
/// </summary>
public partial class RLActivityDefinitionList : GenericRecordList<ENActivityDefinitionEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENActivityDefinitionEntityRecord GetElementDefaultValue() {
return new ENActivityDefinitionEntityRecord();
}

public T[] ToArray<T>(Func<ENActivityDefinitionEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLActivityDefinitionList recordList, Func<ENActivityDefinitionEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLActivityDefinitionList(ENActivityDefinitionEntityRecord[] array) {
  RLActivityDefinitionList result = new RLActivityDefinitionList();
result.InnerFromArray(array);
    return result;
}

public static RLActivityDefinitionList ToList<T>(T[] array, Func <T, ENActivityDefinitionEntityRecord> converter) {
  RLActivityDefinitionList result = new RLActivityDefinitionList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLActivityDefinitionList FromRestList<T>(RestList<T> restList, Func <T, ENActivityDefinitionEntityRecord> converter) {
  RLActivityDefinitionList result = new RLActivityDefinitionList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLActivityDefinitionList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENActivityDefinitionEntityRecord> NewList() {
return new RLActivityDefinitionList();
}


} // RLActivityDefinitionList
}
