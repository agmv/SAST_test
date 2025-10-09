namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (IjJMAFoNZEeD5LRjalHvxQ)
///  <code>RC_1ba3db8c7175cd095b4f1a36c3a1e53d</code> that represent
/// s <code>FinishResetPasswordFailureReasonRecord</code> <p>Description: </p>
/// </summary>
// Name: FinishResetPasswordFailureReasonRecord
public partial struct RC_1ba3db8c7175cd095b4f1a36c3a1e53d : ITypedRecord<RC_1ba3db8c7175cd095b4f1a36c3a1e53d> {
internal static readonly GlobalObjectKey IdFinishResetPasswordFailureReason = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jNujG3VxCc1bTxo2w6HlPQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("FinishResetPasswordFailureReason")]
public ST_9b153b9b179efd305d9e3eb52006065fStructure ssSTFinishResetPasswordFailureReason;


public static implicit operator ST_9b153b9b179efd305d9e3eb52006065fStructure( RC_1ba3db8c7175cd095b4f1a36c3a1e53d r) {
return r.ssSTFinishResetPasswordFailureReason;
}

public static implicit operator RC_1ba3db8c7175cd095b4f1a36c3a1e53d (ST_9b153b9b179efd305d9e3eb52006065fStructure r) {
RC_1ba3db8c7175cd095b4f1a36c3a1e53d res = new RC_1ba3db8c7175cd095b4f1a36c3a1e53d ();
res.ssSTFinishResetPasswordFailureReason = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_1ba3db8c7175cd095b4f1a36c3a1e53d() {
OptimizedAttributes = null;
ssSTFinishResetPasswordFailureReason = new ST_9b153b9b179efd305d9e3eb52006065fStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTFinishResetPasswordFailureReason.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTFinishResetPasswordFailureReason.Read( r, ref index);
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
public void ReadIM(RC_1ba3db8c7175cd095b4f1a36c3a1e53d r) {
this = r;
}


public static bool operator == (RC_1ba3db8c7175cd095b4f1a36c3a1e53d a, RC_1ba3db8c7175cd095b4f1a36c3a1e53d b) {
if (a.ssSTFinishResetPasswordFailureReason != b.ssSTFinishResetPasswordFailureReason) return false;
return true;
}

public static bool operator != (RC_1ba3db8c7175cd095b4f1a36c3a1e53d a, RC_1ba3db8c7175cd095b4f1a36c3a1e53d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1ba3db8c7175cd095b4f1a36c3a1e53d)) return false;
return (this == (RC_1ba3db8c7175cd095b4f1a36c3a1e53d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFinishResetPasswordFailureReason.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFinishResetPasswordFailureReason.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFinishResetPasswordFailureReason.InternalRecursiveSave();
}


public RC_1ba3db8c7175cd095b4f1a36c3a1e53d Duplicate() {
RC_1ba3db8c7175cd095b4f1a36c3a1e53d t;
t.ssSTFinishResetPasswordFailureReason = (ST_9b153b9b179efd305d9e3eb52006065fStructure)this.ssSTFinishResetPasswordFailureReason.Duplicate();
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
if (head == "finishresetpasswordfailurereason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FinishResetPasswordFailureReason")) variable.Value = ssSTFinishResetPasswordFailureReason; else variable.Optimized = true;
variable.SetFieldName("finishresetpasswordfailurereason");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFinishResetPasswordFailureReason) {
return ssSTFinishResetPasswordFailureReason;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFinishResetPasswordFailureReason.Key.AsGuid) {
return ssSTFinishResetPasswordFailureReason;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFinishResetPasswordFailureReason.FillFromOther((IRecord) other.AttributeGet(IdFinishResetPasswordFailureReason));
}
} // RC_1ba3db8c7175cd095b4f1a36c3a1e53d
/// <summary>
/// RecordList type <code>FinishResetPasswordFailureReasonRecordList</code> that represents a record
///  list of <code>FinishResetPasswordFailureReason</code>
/// </summary>
public partial class RL_47595c6744be14d2bd677fd05324180f : GenericRecordList<RC_1ba3db8c7175cd095b4f1a36c3a1e53d>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_1ba3db8c7175cd095b4f1a36c3a1e53d GetElementDefaultValue() {
return new RC_1ba3db8c7175cd095b4f1a36c3a1e53d();
}

public T[] ToArray<T>(Func<RC_1ba3db8c7175cd095b4f1a36c3a1e53d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_47595c6744be14d2bd677fd05324180f recordList, Func<RC_1ba3db8c7175cd095b4f1a36c3a1e53d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_47595c6744be14d2bd677fd05324180f(RC_1ba3db8c7175cd095b4f1a36c3a1e53d[] array) {
  RL_47595c6744be14d2bd677fd05324180f result = new RL_47595c6744be14d2bd677fd05324180f();
result.InnerFromArray(array);
    return result;
}

public static RL_47595c6744be14d2bd677fd05324180f ToList<T>(T[] array, Func <T, RC_1ba3db8c7175cd095b4f1a36c3a1e53d> converter) {
  RL_47595c6744be14d2bd677fd05324180f result = new RL_47595c6744be14d2bd677fd05324180f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_47595c6744be14d2bd677fd05324180f FromRestList<T>(RestList<T> restList, Func <T, RC_1ba3db8c7175cd095b4f1a36c3a1e53d> converter) {
  RL_47595c6744be14d2bd677fd05324180f result = new RL_47595c6744be14d2bd677fd05324180f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_47595c6744be14d2bd677fd05324180f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1ba3db8c7175cd095b4f1a36c3a1e53d> NewList() {
return new RL_47595c6744be14d2bd677fd05324180f();
}


} // RL_47595c6744be14d2bd677fd05324180f
}

