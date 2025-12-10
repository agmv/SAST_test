namespace ssRuntimeDestroyer.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (ZGelhAnXCUG5Biqpy8kYWQ)
///  <code>RC_37793b7d6834fb46c2d504f9d8c91d4a</code> that represents <code>WeekdayRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: WeekdayRecord
public partial struct RC_37793b7d6834fb46c2d504f9d8c91d4a : ITypedRecord<RC_37793b7d6834fb46c2d504f9d8c91d4a> {
internal static readonly GlobalObjectKey IdWeekday = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fTt5NzRoRvvC1QT52MkdSg");

[System.Xml.Serialization.XmlElement("Weekday")]
public EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord ssENWeekday;


public static implicit operator EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord( RC_37793b7d6834fb46c2d504f9d8c91d4a r) {
return r.ssENWeekday;
}

public static implicit operator RC_37793b7d6834fb46c2d504f9d8c91d4a (EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord r) {
RC_37793b7d6834fb46c2d504f9d8c91d4a res = new RC_37793b7d6834fb46c2d504f9d8c91d4a ();
res.ssENWeekday = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENWeekday.ChangedAttributes = value;
}
get {
    return ssENWeekday.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_37793b7d6834fb46c2d504f9d8c91d4a() {
OptimizedAttributes = null;
ssENWeekday = new EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENWeekday.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENWeekday.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENWeekday.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENWeekday.Read( r, ref index);
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
public void ReadIM(RC_37793b7d6834fb46c2d504f9d8c91d4a r) {
this = r;
}


public static bool operator == (RC_37793b7d6834fb46c2d504f9d8c91d4a a, RC_37793b7d6834fb46c2d504f9d8c91d4a b) {
if (a.ssENWeekday != b.ssENWeekday) return false;
return true;
}

public static bool operator != (RC_37793b7d6834fb46c2d504f9d8c91d4a a, RC_37793b7d6834fb46c2d504f9d8c91d4a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_37793b7d6834fb46c2d504f9d8c91d4a)) return false;
return (this == (RC_37793b7d6834fb46c2d504f9d8c91d4a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENWeekday.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENWeekday.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENWeekday.InternalRecursiveSave();
}


public RC_37793b7d6834fb46c2d504f9d8c91d4a Duplicate() {
RC_37793b7d6834fb46c2d504f9d8c91d4a t;
t.ssENWeekday = (EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord)this.ssENWeekday.Duplicate();
t.OptimizedAttributes = null;
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
if (head == "weekday") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Weekday")) variable.Value = ssENWeekday; else variable.Optimized = true;
variable.SetFieldName("weekday");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENWeekday.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENWeekday.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdWeekday) {
return ssENWeekday;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdWeekday.Key.AsGuid) {
return ssENWeekday;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENWeekday.FillFromOther((IRecord) other.AttributeGet(IdWeekday));
}
} // RC_37793b7d6834fb46c2d504f9d8c91d4a
/// <summary>
/// RecordList type <code>WeekdayRecordList</code> that represents a record list of
///  <code>Weekday</code>
/// </summary>
public partial class RL_ae79e5863abde88cf07babd0361db7a4 : GenericRecordList<RC_37793b7d6834fb46c2d504f9d8c91d4a>, IEnumerable, IEnumerator {

protected override RC_37793b7d6834fb46c2d504f9d8c91d4a GetElementDefaultValue() {
return new RC_37793b7d6834fb46c2d504f9d8c91d4a();
}

public T[] ToArray<T>(Func<RC_37793b7d6834fb46c2d504f9d8c91d4a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ae79e5863abde88cf07babd0361db7a4 recordList, Func<RC_37793b7d6834fb46c2d504f9d8c91d4a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ae79e5863abde88cf07babd0361db7a4(RC_37793b7d6834fb46c2d504f9d8c91d4a[] array) {
  RL_ae79e5863abde88cf07babd0361db7a4 result = new RL_ae79e5863abde88cf07babd0361db7a4();
result.InnerFromArray(array);
    return result;
}

public static RL_ae79e5863abde88cf07babd0361db7a4 ToList<T>(T[] array, Func <T, RC_37793b7d6834fb46c2d504f9d8c91d4a> converter) {
  RL_ae79e5863abde88cf07babd0361db7a4 result = new RL_ae79e5863abde88cf07babd0361db7a4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ae79e5863abde88cf07babd0361db7a4 FromRestList<T>(RestList<T> restList, Func <T, RC_37793b7d6834fb46c2d504f9d8c91d4a> converter) {
  RL_ae79e5863abde88cf07babd0361db7a4 result = new RL_ae79e5863abde88cf07babd0361db7a4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ae79e5863abde88cf07babd0361db7a4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_37793b7d6834fb46c2d504f9d8c91d4a> NewList() {
return new RL_ae79e5863abde88cf07babd0361db7a4();
}


} // RL_ae79e5863abde88cf07babd0361db7a4
}

