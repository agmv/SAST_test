using System.Diagnostics;
namespace ssRuntimeDestroyer.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] Weekday (JJMPZTDIlEqEvhwOtdPndQ)
///  <code>EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord</code> that represents <code>Weekday</code
/// > <p>Description: </p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("Weekday","2F8yZnwOU020QZqhoKm9Kw","OtPSJNbDJ0+zmss8DirdpA", 0,"weekd_2jhmh9kn2941g92kugwqdvh4", null, false)]
// Name: Weekday
public partial struct EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord : ITypedRecord<EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("OtPSJNbDJ0+zmss8DirdpA*EwRwaAX1R0yo4UNoBgIKYg");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("OtPSJNbDJ0+zmss8DirdpA*hqDXkdmzrUqRJzSLQIuxwg");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("OtPSJNbDJ0+zmss8DirdpA*FTZkUTumqkKfkdBxxibP4w");
internal static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("OtPSJNbDJ0+zmss8DirdpA*mK_xO1prdEesljctxJfuow");

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

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("LABEL",50,false,false,false,true)]
[System.Xml.Serialization.XmlElement("Label")]
private string _ssLabel;
public string ssLabel{
  get{
      return _ssLabel;
  }
  set{
      if((_ssLabel!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssLabel = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ORDER",0,false,false,false,true)]
[System.Xml.Serialization.XmlElement("Order")]
private int _ssOrder;
public int ssOrder{
  get{
      return _ssOrder;
  }
  set{
      if((_ssOrder!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssOrder = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("IS_ACTIVE",0,false,false,false,true)]
[System.Xml.Serialization.XmlElement("Is_Active")]
private bool _ssIs_Active;
public bool ssIs_Active{
  get{
      return _ssIs_Active;
  }
  set{
      if((_ssIs_Active!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssIs_Active = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord() {
ChangedAttributes = new BitArray(4,true);
OptimizedAttributes = new BitArray(4,false);
_ssId = 0;
_ssLabel = "";
_ssOrder = 0;
_ssIs_Active = false;
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
ssId = r.ReadInteger(index++, "Weekday.Id", 0);
ssLabel = r.ReadText(index++, "Weekday.Label", "");
ssOrder = r.ReadInteger(index++, "Weekday.Order", 0);
ssIs_Active = r.ReadBoolean(index++, "Weekday.Is_Active", false);
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
public void ReadIM(EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord r) {
this = r;
}


public static bool operator == (EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord a, EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssOrder != b.ssOrder) return false;
if (a.ssIs_Active != b.ssIs_Active) return false;
return true;
}

public static bool operator != (EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord a, EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord)) return false;
return (this == (EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssOrder.GetHashCode()
 ^ ssIs_Active.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord Duplicate() {
EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord t;
t._ssId = this._ssId;
t._ssLabel = this._ssLabel;
t._ssOrder = this._ssOrder;
t._ssIs_Active = this._ssIs_Active;
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
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
} else if (head == "is_active") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Is_Active")) variable.Value = ssIs_Active; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdLabel)) {
return ChangedAttributes[1];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[2];
}
if (key.Equals(IdIs_Active)) {
return ChangedAttributes[3];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdLabel)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdIs_Active)) {
return OptimizedAttributes[3];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdLabel) {
return ssLabel;
}
if (key == IdOrder) {
return ssOrder;
}
if (key == IdIs_Active) {
return ssIs_Active;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
if (attributeKey == IdOrder.Key.AsGuid) {
return ssOrder;
}
if (attributeKey == IdIs_Active.Key.AsGuid) {
return ssIs_Active;
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
ssLabel = (string) other.AttributeGet(IdLabel);
ChangedAttributes[1] = other.ChangedAttributeGet(IdLabel);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdLabel);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[2] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdOrder);
ssIs_Active = (bool) other.AttributeGet(IdIs_Active);
ChangedAttributes[3] = other.ChangedAttributeGet(IdIs_Active);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIs_Active);
}
} // EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord

/// <summary>
/// RecordList type <code>WeekdayList</code> that represents a record list of <code>Weekday</code>
/// </summary>
public partial class RL_82ee6fc450c183600f2cb3b2a9c6bf50 : GenericRecordList<EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord>, IEnumerable, IEnumerator {

protected override EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord GetElementDefaultValue() {
return new EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord();
}

public T[] ToArray<T>(Func<EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_82ee6fc450c183600f2cb3b2a9c6bf50 recordList, Func<EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_82ee6fc450c183600f2cb3b2a9c6bf50(EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord[] array) {
  RL_82ee6fc450c183600f2cb3b2a9c6bf50 result = new RL_82ee6fc450c183600f2cb3b2a9c6bf50();
result.InnerFromArray(array);
    return result;
}

public static RL_82ee6fc450c183600f2cb3b2a9c6bf50 ToList<T>(T[] array, Func <T, EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord> converter) {
  RL_82ee6fc450c183600f2cb3b2a9c6bf50 result = new RL_82ee6fc450c183600f2cb3b2a9c6bf50();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_82ee6fc450c183600f2cb3b2a9c6bf50 FromRestList<T>(RestList<T> restList, Func <T, EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord> converter) {
  RL_82ee6fc450c183600f2cb3b2a9c6bf50 result = new RL_82ee6fc450c183600f2cb3b2a9c6bf50();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_82ee6fc450c183600f2cb3b2a9c6bf50() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord> NewList() {
return new RL_82ee6fc450c183600f2cb3b2a9c6bf50();
}


} // RL_82ee6fc450c183600f2cb3b2a9c6bf50
}
