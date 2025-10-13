using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] ProcessDefinition (9_tPM2r+CdVqIl8lCtR79w) <code>ENProcessDefinitionEntityRecord</code>
///  that represents <code>ProcessDefinition</code> <p>Description: Entity that holds the definition o
/// f each process as specified in the workflow editor.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("ProcessDefinition","9_tPM2r+CdVqIl8lCtR79w","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: ProcessDefinition
public partial struct ENProcessDefinitionEntityRecord : ITypedRecord<ENProcessDefinitionEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*yk6iG9NJOiQSLWJYOyeZHg");
internal static readonly GlobalObjectKey IdKey = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*qkiZZbKvWkqBA7f4uclIEw");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*fl_4pYCpZXTW8Xm_MMdq_w");
internal static readonly GlobalObjectKey IdRevision = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*8FiGgpw2JUGeiU+XINJFaA");

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
          ChangedAttributes = new BitArray(4,true);
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

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("NAME",50,false,false,false,true)]
[System.Xml.Serialization.XmlElement("Name")]
private string _ssName;
public string ssName{
  get{
      return _ssName;
  }
  set{
      if((_ssName!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssName = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("REVISION",0,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Revision")]
private int _ssRevision;
public int ssRevision{
  get{
      return _ssRevision;
  }
  set{
      if((_ssRevision!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssRevision = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENProcessDefinitionEntityRecord() {
ChangedAttributes = new BitArray(4,true);
OptimizedAttributes = new BitArray(4,false);
_ssId = 0;
_ssKey = "";
_ssName = "";
_ssRevision = 0;
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
ssId = r.ReadInteger(index++, "ProcessDefinition.Id", 0);
ssKey = r.ReadText(index++, "ProcessDefinition.Key", "");
ssName = r.ReadText(index++, "ProcessDefinition.Name", "");
ssRevision = r.ReadInteger(index++, "ProcessDefinition.Revision", 0);
ChangedAttributes = new BitArray(4,false);
OptimizedAttributes = new BitArray(4,false);
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
public void ReadIM(ENProcessDefinitionEntityRecord r) {
this = r;
}


public static bool operator == (ENProcessDefinitionEntityRecord a, ENProcessDefinitionEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssKey != b.ssKey) return false;
if (a.ssName != b.ssName) return false;
if (a.ssRevision != b.ssRevision) return false;
return true;
}

public static bool operator != (ENProcessDefinitionEntityRecord a, ENProcessDefinitionEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENProcessDefinitionEntityRecord)) return false;
return (this == (ENProcessDefinitionEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssKey.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssRevision.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ENProcessDefinitionEntityRecord Duplicate() {
ENProcessDefinitionEntityRecord t;
t._ssId = this._ssId;
t._ssKey = this._ssKey;
t._ssName = this._ssName;
t._ssRevision = this._ssRevision;
t.ChangedAttributes = new BitArray(4);
t.OptimizedAttributes = new BitArray(4);
for(int i = 0; i < 4; i++){
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
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "revision") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Revision")) variable.Value = ssRevision; else variable.Optimized = true;
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
if (key.Equals(IdName)) {
return ChangedAttributes[2];
}
if (key.Equals(IdRevision)) {
return ChangedAttributes[3];
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
if (key.Equals(IdName)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdRevision)) {
return OptimizedAttributes[3];
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
if (key == IdName) {
return ssName;
}
if (key == IdRevision) {
return ssRevision;
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
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdRevision.Key.AsGuid) {
return ssRevision;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(4);
OptimizedAttributes = new BitArray(4);
if (other == null) return;
ssId = (int) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssKey = (string) other.AttributeGet(IdKey);
ChangedAttributes[1] = other.ChangedAttributeGet(IdKey);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdKey);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[2] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdName);
ssRevision = (int) other.AttributeGet(IdRevision);
ChangedAttributes[3] = other.ChangedAttributeGet(IdRevision);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdRevision);
}
} // ENProcessDefinitionEntityRecord

/// <summary>
/// RecordList type <code>ProcessDefinitionList</code> that represents a record list of
///  <code>ProcessDefinition</code>
/// </summary>
public partial class RLProcessDefinitionList : GenericRecordList<ENProcessDefinitionEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENProcessDefinitionEntityRecord GetElementDefaultValue() {
return new ENProcessDefinitionEntityRecord();
}

public T[] ToArray<T>(Func<ENProcessDefinitionEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLProcessDefinitionList recordList, Func<ENProcessDefinitionEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLProcessDefinitionList(ENProcessDefinitionEntityRecord[] array) {
  RLProcessDefinitionList result = new RLProcessDefinitionList();
result.InnerFromArray(array);
    return result;
}

public static RLProcessDefinitionList ToList<T>(T[] array, Func <T, ENProcessDefinitionEntityRecord> converter) {
  RLProcessDefinitionList result = new RLProcessDefinitionList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLProcessDefinitionList FromRestList<T>(RestList<T> restList, Func <T, ENProcessDefinitionEntityRecord> converter) {
  RLProcessDefinitionList result = new RLProcessDefinitionList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLProcessDefinitionList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENProcessDefinitionEntityRecord> NewList() {
return new RLProcessDefinitionList();
}


} // RLProcessDefinitionList
}
