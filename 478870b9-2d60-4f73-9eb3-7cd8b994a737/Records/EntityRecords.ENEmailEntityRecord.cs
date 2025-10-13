using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] Email (CWv+3dcKHk6ctXgJ81F2tg) <code>ENEmailEntityRecord</code> that represents
///  <code>Email</code> <p>Description: [Internal] Emails pending and sent by the platform.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("Email","CWv+3dcKHk6ctXgJ81F2tg","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: Email
public partial struct ENEmailEntityRecord : ITypedRecord<ENEmailEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*FM6wPJyywkmU9WUNQ7EOpw");
internal static readonly GlobalObjectKey IdSize = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*MH7sUZGrw0WTSW0F9xSPog");

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
          ChangedAttributes = new BitArray(2,true);
          _ssId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("SIZE",0,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Size")]
private int _ssSize;
public int ssSize{
  get{
      return _ssSize;
  }
  set{
      if((_ssSize!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssSize = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENEmailEntityRecord() {
ChangedAttributes = new BitArray(2,true);
OptimizedAttributes = new BitArray(2,false);
_ssId = 0L;
_ssSize = 0;
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
ssId = r.ReadLongInteger(index++, "Email.Id", 0L);
ssSize = r.ReadInteger(index++, "Email.Size", 0);
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
public void ReadIM(ENEmailEntityRecord r) {
this = r;
}


public static bool operator == (ENEmailEntityRecord a, ENEmailEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssSize != b.ssSize) return false;
return true;
}

public static bool operator != (ENEmailEntityRecord a, ENEmailEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENEmailEntityRecord)) return false;
return (this == (ENEmailEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssSize.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ENEmailEntityRecord Duplicate() {
ENEmailEntityRecord t;
t._ssId = this._ssId;
t._ssSize = this._ssSize;
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
} else if (head == "size") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Size")) variable.Value = ssSize; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdSize)) {
return ChangedAttributes[1];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdSize)) {
return OptimizedAttributes[1];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdSize) {
return ssSize;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdSize.Key.AsGuid) {
return ssSize;
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
ssSize = (int) other.AttributeGet(IdSize);
ChangedAttributes[1] = other.ChangedAttributeGet(IdSize);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdSize);
}
} // ENEmailEntityRecord

/// <summary>
/// RecordList type <code>EmailList</code> that represents a record list of <code>Email</code>
/// </summary>
public partial class RLEmailList : GenericRecordList<ENEmailEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENEmailEntityRecord GetElementDefaultValue() {
return new ENEmailEntityRecord();
}

public T[] ToArray<T>(Func<ENEmailEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLEmailList recordList, Func<ENEmailEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLEmailList(ENEmailEntityRecord[] array) {
  RLEmailList result = new RLEmailList();
result.InnerFromArray(array);
    return result;
}

public static RLEmailList ToList<T>(T[] array, Func <T, ENEmailEntityRecord> converter) {
  RLEmailList result = new RLEmailList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLEmailList FromRestList<T>(RestList<T> restList, Func <T, ENEmailEntityRecord> converter) {
  RLEmailList result = new RLEmailList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLEmailList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENEmailEntityRecord> NewList() {
return new RLEmailList();
}


} // RLEmailList
}
