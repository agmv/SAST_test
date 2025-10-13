namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (OY2dp4HTlRRK7QPY1GgomA)
///  <code>RC_36a7d48575a55c39ace8b7f6b0cd3ac4</code> that represents <code>ActivityStatusRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ActivityStatusRecord
public partial struct RC_36a7d48575a55c39ace8b7f6b0cd3ac4 : ITypedRecord<RC_36a7d48575a55c39ace8b7f6b0cd3ac4> {
internal static readonly GlobalObjectKey IdActivityStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*hdSnNqV1OVys6Lf2sM06xA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ActivityStatus")]
public ENActivityStatusEntityRecord ssENActivityStatus;


public static implicit operator ENActivityStatusEntityRecord( RC_36a7d48575a55c39ace8b7f6b0cd3ac4 r) {
return r.ssENActivityStatus;
}

public static implicit operator RC_36a7d48575a55c39ace8b7f6b0cd3ac4 (ENActivityStatusEntityRecord r) {
RC_36a7d48575a55c39ace8b7f6b0cd3ac4 res = new RC_36a7d48575a55c39ace8b7f6b0cd3ac4 ();
res.ssENActivityStatus = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENActivityStatus.ChangedAttributes = value;
}
get {
    return ssENActivityStatus.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_36a7d48575a55c39ace8b7f6b0cd3ac4() {
OptimizedAttributes = null;
ssENActivityStatus = new ENActivityStatusEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENActivityStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENActivityStatus.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENActivityStatus.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENActivityStatus.Read( r, ref index);
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
public void ReadIM(RC_36a7d48575a55c39ace8b7f6b0cd3ac4 r) {
this = r;
}


public static bool operator == (RC_36a7d48575a55c39ace8b7f6b0cd3ac4 a, RC_36a7d48575a55c39ace8b7f6b0cd3ac4 b) {
if (a.ssENActivityStatus != b.ssENActivityStatus) return false;
return true;
}

public static bool operator != (RC_36a7d48575a55c39ace8b7f6b0cd3ac4 a, RC_36a7d48575a55c39ace8b7f6b0cd3ac4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_36a7d48575a55c39ace8b7f6b0cd3ac4)) return false;
return (this == (RC_36a7d48575a55c39ace8b7f6b0cd3ac4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENActivityStatus.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENActivityStatus.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENActivityStatus.InternalRecursiveSave();
}


public RC_36a7d48575a55c39ace8b7f6b0cd3ac4 Duplicate() {
RC_36a7d48575a55c39ace8b7f6b0cd3ac4 t;
t.ssENActivityStatus = (ENActivityStatusEntityRecord)this.ssENActivityStatus.Duplicate();
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
if (head == "activitystatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActivityStatus")) variable.Value = ssENActivityStatus; else variable.Optimized = true;
variable.SetFieldName("activitystatus");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENActivityStatus.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENActivityStatus.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdActivityStatus) {
return ssENActivityStatus;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdActivityStatus.Key.AsGuid) {
return ssENActivityStatus;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENActivityStatus.FillFromOther((IRecord) other.AttributeGet(IdActivityStatus));
}
} // RC_36a7d48575a55c39ace8b7f6b0cd3ac4
/// <summary>
/// RecordList type <code>ActivityStatusRecordList</code> that represents a record list of
///  <code>ActivityStatus</code>
/// </summary>
public partial class RL_20bf822013f9723d57d50b23f1a33f26 : GenericRecordList<RC_36a7d48575a55c39ace8b7f6b0cd3ac4>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_36a7d48575a55c39ace8b7f6b0cd3ac4 GetElementDefaultValue() {
return new RC_36a7d48575a55c39ace8b7f6b0cd3ac4();
}

public T[] ToArray<T>(Func<RC_36a7d48575a55c39ace8b7f6b0cd3ac4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_20bf822013f9723d57d50b23f1a33f26 recordList, Func<RC_36a7d48575a55c39ace8b7f6b0cd3ac4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_20bf822013f9723d57d50b23f1a33f26(RC_36a7d48575a55c39ace8b7f6b0cd3ac4[] array) {
  RL_20bf822013f9723d57d50b23f1a33f26 result = new RL_20bf822013f9723d57d50b23f1a33f26();
result.InnerFromArray(array);
    return result;
}

public static RL_20bf822013f9723d57d50b23f1a33f26 ToList<T>(T[] array, Func <T, RC_36a7d48575a55c39ace8b7f6b0cd3ac4> converter) {
  RL_20bf822013f9723d57d50b23f1a33f26 result = new RL_20bf822013f9723d57d50b23f1a33f26();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_20bf822013f9723d57d50b23f1a33f26 FromRestList<T>(RestList<T> restList, Func <T, RC_36a7d48575a55c39ace8b7f6b0cd3ac4> converter) {
  RL_20bf822013f9723d57d50b23f1a33f26 result = new RL_20bf822013f9723d57d50b23f1a33f26();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_20bf822013f9723d57d50b23f1a33f26() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(2,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_36a7d48575a55c39ace8b7f6b0cd3ac4> NewList() {
return new RL_20bf822013f9723d57d50b23f1a33f26();
}


} // RL_20bf822013f9723d57d50b23f1a33f26
}

