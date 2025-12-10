using System.Diagnostics;
namespace ssRuntimeDestroyer {

/// <summary>
/// [Entity] SampleListGet (y0lPFd5uxE2GnQ_b9AAJEQ)
///  <code>EN_80054628bf73dfa0a64914948a216302EntityRecord</code> that represent
/// s <code>SampleListGet</code> <p>Description: </p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("SampleListGet","y0lPFd5uxE2GnQ_b9AAJEQ","sTTG50eVjk+Ae8n6o1m2aQ", 0,"sampl_jf1oovmiqpmwd80zqtwtprb0", null, false)]
// Name: SampleListGet
public partial struct EN_80054628bf73dfa0a64914948a216302EntityRecord : ITypedRecord<EN_80054628bf73dfa0a64914948a216302EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*nnQt_Ica9k+ZxFUh5zaI5A");

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
          ChangedAttributes = new BitArray(1,true);
          _ssId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_80054628bf73dfa0a64914948a216302EntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssId = 0;
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
ssId = r.ReadInteger(index++, "SampleListGet.Id", 0);
ChangedAttributes = new BitArray(1,false);
OptimizedAttributes = new BitArray(1,false);
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
public void ReadIM(EN_80054628bf73dfa0a64914948a216302EntityRecord r) {
this = r;
}


public static bool operator == (EN_80054628bf73dfa0a64914948a216302EntityRecord a, EN_80054628bf73dfa0a64914948a216302EntityRecord b) {
if (a.ssId != b.ssId) return false;
return true;
}

public static bool operator != (EN_80054628bf73dfa0a64914948a216302EntityRecord a, EN_80054628bf73dfa0a64914948a216302EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_80054628bf73dfa0a64914948a216302EntityRecord)) return false;
return (this == (EN_80054628bf73dfa0a64914948a216302EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_80054628bf73dfa0a64914948a216302EntityRecord Duplicate() {
EN_80054628bf73dfa0a64914948a216302EntityRecord t;
t._ssId = this._ssId;
t.ChangedAttributes = new BitArray(1);
t.OptimizedAttributes = new BitArray(1);
for(int i = 0; i < 1; i++){
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
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssId = (int) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
}
} // EN_80054628bf73dfa0a64914948a216302EntityRecord

/// <summary>
/// RecordList type <code>SampleListGetList</code> that represents a record list of
///  <code>SampleListGet</code>
/// </summary>
public partial class RL_c0d9dc2f7e8a67587b92f7e34e9dd57a : GenericRecordList<EN_80054628bf73dfa0a64914948a216302EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_80054628bf73dfa0a64914948a216302EntityRecord GetElementDefaultValue() {
return new EN_80054628bf73dfa0a64914948a216302EntityRecord();
}

public T[] ToArray<T>(Func<EN_80054628bf73dfa0a64914948a216302EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c0d9dc2f7e8a67587b92f7e34e9dd57a recordList, Func<EN_80054628bf73dfa0a64914948a216302EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c0d9dc2f7e8a67587b92f7e34e9dd57a(EN_80054628bf73dfa0a64914948a216302EntityRecord[] array) {
  RL_c0d9dc2f7e8a67587b92f7e34e9dd57a result = new RL_c0d9dc2f7e8a67587b92f7e34e9dd57a();
result.InnerFromArray(array);
    return result;
}

public static RL_c0d9dc2f7e8a67587b92f7e34e9dd57a ToList<T>(T[] array, Func <T, EN_80054628bf73dfa0a64914948a216302EntityRecord> converter) {
  RL_c0d9dc2f7e8a67587b92f7e34e9dd57a result = new RL_c0d9dc2f7e8a67587b92f7e34e9dd57a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c0d9dc2f7e8a67587b92f7e34e9dd57a FromRestList<T>(RestList<T> restList, Func <T, EN_80054628bf73dfa0a64914948a216302EntityRecord> converter) {
  RL_c0d9dc2f7e8a67587b92f7e34e9dd57a result = new RL_c0d9dc2f7e8a67587b92f7e34e9dd57a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c0d9dc2f7e8a67587b92f7e34e9dd57a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_80054628bf73dfa0a64914948a216302EntityRecord> NewList() {
return new RL_c0d9dc2f7e8a67587b92f7e34e9dd57a();
}


} // RL_c0d9dc2f7e8a67587b92f7e34e9dd57a
}
