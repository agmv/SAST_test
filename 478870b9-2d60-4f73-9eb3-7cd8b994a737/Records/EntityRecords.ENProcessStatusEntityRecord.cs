using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] ProcessStatus (pUVVMZpibJgggsQHRFGBXA) <code>ENProcessStatusEntityRecord</code> that
///  represents <code>ProcessStatus</code> <p>Description: Available status of a process instance. Th
/// e status of a process changes according to what happens with the activities running in that process
///  instance.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("ProcessStatus","pUVVMZpibJgggsQHRFGBXA","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: ProcessStatus
public partial struct ENProcessStatusEntityRecord : ITypedRecord<ENProcessStatusEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*Oqgtza1bcOSoAnRXyWmFYA");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*at5VPus85zyvWwW+J9rrcQ");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID",0,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Id")]
private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(2,true);
          _ssId = value;
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
      if((_ssName!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssName = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENProcessStatusEntityRecord() {
ChangedAttributes = new BitArray(2,true);
OptimizedAttributes = new BitArray(2,false);
_ssId = 0L;
_ssName = "";
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
ssId = r.ReadLongInteger(index++, "ProcessStatus.Id", 0L);
ssName = r.ReadText(index++, "ProcessStatus.Name", "");
ChangedAttributes = new BitArray(2,false);
OptimizedAttributes = new BitArray(2,false);
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
public void ReadIM(ENProcessStatusEntityRecord r) {
this = r;
}


public static bool operator == (ENProcessStatusEntityRecord a, ENProcessStatusEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssName != b.ssName) return false;
return true;
}

public static bool operator != (ENProcessStatusEntityRecord a, ENProcessStatusEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENProcessStatusEntityRecord)) return false;
return (this == (ENProcessStatusEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssName.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ENProcessStatusEntityRecord Duplicate() {
ENProcessStatusEntityRecord t;
t._ssId = this._ssId;
t._ssName = this._ssName;
t.ChangedAttributes = new BitArray(2);
t.OptimizedAttributes = new BitArray(2);
for(int i = 0; i < 2; i++){
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
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdName)) {
return ChangedAttributes[1];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdName)) {
return OptimizedAttributes[1];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdName) {
return ssName;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(2);
OptimizedAttributes = new BitArray(2);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
}
} // ENProcessStatusEntityRecord

/// <summary>
/// RecordList type <code>ProcessStatusList</code> that represents a record list of
///  <code>ProcessStatus</code>
/// </summary>
public partial class RLProcessStatusList : GenericRecordList<ENProcessStatusEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENProcessStatusEntityRecord GetElementDefaultValue() {
return new ENProcessStatusEntityRecord();
}

public T[] ToArray<T>(Func<ENProcessStatusEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLProcessStatusList recordList, Func<ENProcessStatusEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLProcessStatusList(ENProcessStatusEntityRecord[] array) {
  RLProcessStatusList result = new RLProcessStatusList();
result.InnerFromArray(array);
    return result;
}

public static RLProcessStatusList ToList<T>(T[] array, Func <T, ENProcessStatusEntityRecord> converter) {
  RLProcessStatusList result = new RLProcessStatusList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLProcessStatusList FromRestList<T>(RestList<T> restList, Func <T, ENProcessStatusEntityRecord> converter) {
  RLProcessStatusList result = new RLProcessStatusList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLProcessStatusList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENProcessStatusEntityRecord> NewList() {
return new RLProcessStatusList();
}


} // RLProcessStatusList
}
