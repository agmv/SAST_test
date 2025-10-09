using System.Diagnostics;
namespace ssRuntimeDestroyer {

/// <summary>
/// [Entity] SampleListEntity (FVkyWoyVgk260UUpR6bQ0A)
///  <code>EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord</code> that represent
/// s <code>SampleListEntity</code> <p>Description: </p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("SampleListEntity","FVkyWoyVgk260UUpR6bQ0A","sTTG50eVjk+Ae8n6o1m2aQ", 0,"sampl_jf1oovmiqpmts9oi7sezxyk3", null, false)]
// Name: SampleListEntity
public partial struct EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord : ITypedRecord<EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*epXMXzFx1k6HxMW5twqyug");

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
          ChangedAttributes = new BitArray(1,true);
          _ssId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssId = 0L;
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
ssId = r.ReadLongInteger(index++, "SampleListEntity.Id", 0L);
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
public void ReadIM(EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord r) {
this = r;
}


public static bool operator == (EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord a, EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord b) {
if (a.ssId != b.ssId) return false;
return true;
}

public static bool operator != (EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord a, EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord)) return false;
return (this == (EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord)o);
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


public EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord Duplicate() {
EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord t;
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
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
}
} // EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord

/// <summary>
/// RecordList type <code>SampleListEntityList</code> that represents a record list of
///  <code>SampleListEntity</code>
/// </summary>
public partial class RL_1e7b3d2125f39aa37d81e604b3a0a4fb : GenericRecordList<EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord GetElementDefaultValue() {
return new EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord();
}

public T[] ToArray<T>(Func<EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1e7b3d2125f39aa37d81e604b3a0a4fb recordList, Func<EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1e7b3d2125f39aa37d81e604b3a0a4fb(EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord[] array) {
  RL_1e7b3d2125f39aa37d81e604b3a0a4fb result = new RL_1e7b3d2125f39aa37d81e604b3a0a4fb();
result.InnerFromArray(array);
    return result;
}

public static RL_1e7b3d2125f39aa37d81e604b3a0a4fb ToList<T>(T[] array, Func <T, EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord> converter) {
  RL_1e7b3d2125f39aa37d81e604b3a0a4fb result = new RL_1e7b3d2125f39aa37d81e604b3a0a4fb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1e7b3d2125f39aa37d81e604b3a0a4fb FromRestList<T>(RestList<T> restList, Func <T, EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord> converter) {
  RL_1e7b3d2125f39aa37d81e604b3a0a4fb result = new RL_1e7b3d2125f39aa37d81e604b3a0a4fb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1e7b3d2125f39aa37d81e604b3a0a4fb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord> NewList() {
return new RL_1e7b3d2125f39aa37d81e604b3a0a4fb();
}


} // RL_1e7b3d2125f39aa37d81e604b3a0a4fb
}
