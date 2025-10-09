namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (OSku3fpRpv+iR1IU2i9nGg)
///  <code>RC_a7be5795c4af08fa8098110e55d36aff</code> that represents <code>ProcessStatusRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ProcessStatusRecord
public partial struct RC_a7be5795c4af08fa8098110e55d36aff : ITypedRecord<RC_a7be5795c4af08fa8098110e55d36aff> {
internal static readonly GlobalObjectKey IdProcessStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*lVe+p6_E+giAmBEOVdNq_w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ProcessStatus")]
public ENProcessStatusEntityRecord ssENProcessStatus;


public static implicit operator ENProcessStatusEntityRecord( RC_a7be5795c4af08fa8098110e55d36aff r) {
return r.ssENProcessStatus;
}

public static implicit operator RC_a7be5795c4af08fa8098110e55d36aff (ENProcessStatusEntityRecord r) {
RC_a7be5795c4af08fa8098110e55d36aff res = new RC_a7be5795c4af08fa8098110e55d36aff ();
res.ssENProcessStatus = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProcessStatus.ChangedAttributes = value;
}
get {
    return ssENProcessStatus.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_a7be5795c4af08fa8098110e55d36aff() {
OptimizedAttributes = null;
ssENProcessStatus = new ENProcessStatusEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProcessStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProcessStatus.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProcessStatus.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProcessStatus.Read( r, ref index);
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
public void ReadIM(RC_a7be5795c4af08fa8098110e55d36aff r) {
this = r;
}


public static bool operator == (RC_a7be5795c4af08fa8098110e55d36aff a, RC_a7be5795c4af08fa8098110e55d36aff b) {
if (a.ssENProcessStatus != b.ssENProcessStatus) return false;
return true;
}

public static bool operator != (RC_a7be5795c4af08fa8098110e55d36aff a, RC_a7be5795c4af08fa8098110e55d36aff b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a7be5795c4af08fa8098110e55d36aff)) return false;
return (this == (RC_a7be5795c4af08fa8098110e55d36aff)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProcessStatus.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProcessStatus.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProcessStatus.InternalRecursiveSave();
}


public RC_a7be5795c4af08fa8098110e55d36aff Duplicate() {
RC_a7be5795c4af08fa8098110e55d36aff t;
t.ssENProcessStatus = (ENProcessStatusEntityRecord)this.ssENProcessStatus.Duplicate();
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
if (head == "processstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessStatus")) variable.Value = ssENProcessStatus; else variable.Optimized = true;
variable.SetFieldName("processstatus");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProcessStatus.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProcessStatus.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProcessStatus) {
return ssENProcessStatus;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProcessStatus.Key.AsGuid) {
return ssENProcessStatus;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProcessStatus.FillFromOther((IRecord) other.AttributeGet(IdProcessStatus));
}
} // RC_a7be5795c4af08fa8098110e55d36aff
/// <summary>
/// RecordList type <code>ProcessStatusRecordList</code> that represents a record list of
///  <code>ProcessStatus</code>
/// </summary>
public partial class RL_fdf787b37ceb8d49d68d7ae5649f3b09 : GenericRecordList<RC_a7be5795c4af08fa8098110e55d36aff>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_a7be5795c4af08fa8098110e55d36aff GetElementDefaultValue() {
return new RC_a7be5795c4af08fa8098110e55d36aff();
}

public T[] ToArray<T>(Func<RC_a7be5795c4af08fa8098110e55d36aff, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fdf787b37ceb8d49d68d7ae5649f3b09 recordList, Func<RC_a7be5795c4af08fa8098110e55d36aff, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fdf787b37ceb8d49d68d7ae5649f3b09(RC_a7be5795c4af08fa8098110e55d36aff[] array) {
  RL_fdf787b37ceb8d49d68d7ae5649f3b09 result = new RL_fdf787b37ceb8d49d68d7ae5649f3b09();
result.InnerFromArray(array);
    return result;
}

public static RL_fdf787b37ceb8d49d68d7ae5649f3b09 ToList<T>(T[] array, Func <T, RC_a7be5795c4af08fa8098110e55d36aff> converter) {
  RL_fdf787b37ceb8d49d68d7ae5649f3b09 result = new RL_fdf787b37ceb8d49d68d7ae5649f3b09();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fdf787b37ceb8d49d68d7ae5649f3b09 FromRestList<T>(RestList<T> restList, Func <T, RC_a7be5795c4af08fa8098110e55d36aff> converter) {
  RL_fdf787b37ceb8d49d68d7ae5649f3b09 result = new RL_fdf787b37ceb8d49d68d7ae5649f3b09();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fdf787b37ceb8d49d68d7ae5649f3b09() : base() {
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
protected override OSList<RC_a7be5795c4af08fa8098110e55d36aff> NewList() {
return new RL_fdf787b37ceb8d49d68d7ae5649f3b09();
}


} // RL_fdf787b37ceb8d49d68d7ae5649f3b09
}

