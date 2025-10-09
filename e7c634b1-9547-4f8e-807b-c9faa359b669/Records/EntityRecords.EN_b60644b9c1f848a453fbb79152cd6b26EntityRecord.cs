using System.Diagnostics;
namespace ssRuntimeDestroyer {

/// <summary>
/// [CustomEntity] Enum_color (KVKON+MYzEqMKPyIYEqX9w)
///  <code>EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord</code> that represent
/// s <code>Enum_color</code> <p>Description: </p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("Enum_color","KVKON+MYzEqMKPyIYEqX9w","sTTG50eVjk+Ae8n6o1m2aQ", 0,"", null, false)]
// Name: Enum_color
public partial struct EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord : ITypedRecord<EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord> {
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*+lhZUN53KEqiVgtj9ICBSA");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*OPf4bSkcGUevuEQFnh_v1w");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("VALUE",52,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Value")]
private string _ssValue;
public string ssValue{
  get{
      return _ssValue;
  }
  set{
      if((_ssValue!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(2,true);
          _ssValue = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ORDER",0,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Order")]
private int _ssOrder;
public int ssOrder{
  get{
      return _ssOrder;
  }
  set{
      if((_ssOrder!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssOrder = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord() {
ChangedAttributes = new BitArray(2,true);
OptimizedAttributes = new BitArray(2,false);
_ssValue = "";
_ssOrder = 0;
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
ssValue = r.ReadText(index++, "Enum_color.Value", "");
ssOrder = r.ReadInteger(index++, "Enum_color.Order", 0);
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
public void ReadIM(EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord r) {
this = r;
}


public static bool operator == (EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord a, EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord b) {
if (a.ssValue != b.ssValue) return false;
if (a.ssOrder != b.ssOrder) return false;
return true;
}

public static bool operator != (EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord a, EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord)) return false;
return (this == (EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssValue.GetHashCode()
 ^ ssOrder.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord Duplicate() {
EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord t;
t._ssValue = this._ssValue;
t._ssOrder = this._ssOrder;
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
if (head == "value") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Value")) variable.Value = ssValue; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdValue)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[1];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdValue)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[1];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdValue) {
return ssValue;
}
if (key == IdOrder) {
return ssOrder;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdValue.Key.AsGuid) {
return ssValue;
}
if (attributeKey == IdOrder.Key.AsGuid) {
return ssOrder;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(2);
OptimizedAttributes = new BitArray(2);
if (other == null) return;
ssValue = (string) other.AttributeGet(IdValue);
ChangedAttributes[0] = other.ChangedAttributeGet(IdValue);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdValue);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrder);
}
} // EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord

/// <summary>
/// RecordList type <code>Enum_colorList</code> that represents a record list of
///  <code>Enum_color</code>
/// </summary>
public partial class RL_ef029f0dff70d984c57a782a56ea06a9 : GenericRecordList<EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord GetElementDefaultValue() {
return new EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord();
}

public T[] ToArray<T>(Func<EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ef029f0dff70d984c57a782a56ea06a9 recordList, Func<EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ef029f0dff70d984c57a782a56ea06a9(EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord[] array) {
  RL_ef029f0dff70d984c57a782a56ea06a9 result = new RL_ef029f0dff70d984c57a782a56ea06a9();
result.InnerFromArray(array);
    return result;
}

public static RL_ef029f0dff70d984c57a782a56ea06a9 ToList<T>(T[] array, Func <T, EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord> converter) {
  RL_ef029f0dff70d984c57a782a56ea06a9 result = new RL_ef029f0dff70d984c57a782a56ea06a9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ef029f0dff70d984c57a782a56ea06a9 FromRestList<T>(RestList<T> restList, Func <T, EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord> converter) {
  RL_ef029f0dff70d984c57a782a56ea06a9 result = new RL_ef029f0dff70d984c57a782a56ea06a9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ef029f0dff70d984c57a782a56ea06a9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord> NewList() {
return new RL_ef029f0dff70d984c57a782a56ea06a9();
}


} // RL_ef029f0dff70d984c57a782a56ea06a9
}
