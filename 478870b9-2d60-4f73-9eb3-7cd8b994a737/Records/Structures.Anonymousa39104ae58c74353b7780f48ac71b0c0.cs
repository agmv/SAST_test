namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (rgSRo8dYU0O3eA9IrHGwwA)
///  <code>RC_9808e19d66784f7acd0d80b7d130df17</code> that represent
/// s <code>FinishUpdateEmailFailureReasonRecord</code> <p>Description: </p>
/// </summary>
// Name: FinishUpdateEmailFailureReasonRecord
public partial struct RC_9808e19d66784f7acd0d80b7d130df17 : ITypedRecord<RC_9808e19d66784f7acd0d80b7d130df17> {
internal static readonly GlobalObjectKey IdFinishUpdateEmailFailureReason = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*neEImHhmek_NDYC30TDfFw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("FinishUpdateEmailFailureReason")]
public ST_23034956e06e8e0a2169e5e731331735Structure ssSTFinishUpdateEmailFailureReason;


public static implicit operator ST_23034956e06e8e0a2169e5e731331735Structure( RC_9808e19d66784f7acd0d80b7d130df17 r) {
return r.ssSTFinishUpdateEmailFailureReason;
}

public static implicit operator RC_9808e19d66784f7acd0d80b7d130df17 (ST_23034956e06e8e0a2169e5e731331735Structure r) {
RC_9808e19d66784f7acd0d80b7d130df17 res = new RC_9808e19d66784f7acd0d80b7d130df17 ();
res.ssSTFinishUpdateEmailFailureReason = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_9808e19d66784f7acd0d80b7d130df17() {
OptimizedAttributes = null;
ssSTFinishUpdateEmailFailureReason = new ST_23034956e06e8e0a2169e5e731331735Structure();
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
    ssSTFinishUpdateEmailFailureReason.OptimizedAttributes = value[0];
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
ssSTFinishUpdateEmailFailureReason.Read( r, ref index);
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
public void ReadIM(RC_9808e19d66784f7acd0d80b7d130df17 r) {
this = r;
}


public static bool operator == (RC_9808e19d66784f7acd0d80b7d130df17 a, RC_9808e19d66784f7acd0d80b7d130df17 b) {
if (a.ssSTFinishUpdateEmailFailureReason != b.ssSTFinishUpdateEmailFailureReason) return false;
return true;
}

public static bool operator != (RC_9808e19d66784f7acd0d80b7d130df17 a, RC_9808e19d66784f7acd0d80b7d130df17 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9808e19d66784f7acd0d80b7d130df17)) return false;
return (this == (RC_9808e19d66784f7acd0d80b7d130df17)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFinishUpdateEmailFailureReason.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFinishUpdateEmailFailureReason.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFinishUpdateEmailFailureReason.InternalRecursiveSave();
}


public RC_9808e19d66784f7acd0d80b7d130df17 Duplicate() {
RC_9808e19d66784f7acd0d80b7d130df17 t;
t.ssSTFinishUpdateEmailFailureReason = (ST_23034956e06e8e0a2169e5e731331735Structure)this.ssSTFinishUpdateEmailFailureReason.Duplicate();
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
if (head == "finishupdateemailfailurereason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FinishUpdateEmailFailureReason")) variable.Value = ssSTFinishUpdateEmailFailureReason; else variable.Optimized = true;
variable.SetFieldName("finishupdateemailfailurereason");
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
if (key == IdFinishUpdateEmailFailureReason) {
return ssSTFinishUpdateEmailFailureReason;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFinishUpdateEmailFailureReason.Key.AsGuid) {
return ssSTFinishUpdateEmailFailureReason;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFinishUpdateEmailFailureReason.FillFromOther((IRecord) other.AttributeGet(IdFinishUpdateEmailFailureReason));
}
} // RC_9808e19d66784f7acd0d80b7d130df17
/// <summary>
/// RecordList type <code>FinishUpdateEmailFailureReasonRecordList</code> that represents a record list
///  of <code>FinishUpdateEmailFailureReason</code>
/// </summary>
public partial class RL_3d8ec8875be5c4be53b16383052cc65f : GenericRecordList<RC_9808e19d66784f7acd0d80b7d130df17>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_9808e19d66784f7acd0d80b7d130df17 GetElementDefaultValue() {
return new RC_9808e19d66784f7acd0d80b7d130df17();
}

public T[] ToArray<T>(Func<RC_9808e19d66784f7acd0d80b7d130df17, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3d8ec8875be5c4be53b16383052cc65f recordList, Func<RC_9808e19d66784f7acd0d80b7d130df17, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3d8ec8875be5c4be53b16383052cc65f(RC_9808e19d66784f7acd0d80b7d130df17[] array) {
  RL_3d8ec8875be5c4be53b16383052cc65f result = new RL_3d8ec8875be5c4be53b16383052cc65f();
result.InnerFromArray(array);
    return result;
}

public static RL_3d8ec8875be5c4be53b16383052cc65f ToList<T>(T[] array, Func <T, RC_9808e19d66784f7acd0d80b7d130df17> converter) {
  RL_3d8ec8875be5c4be53b16383052cc65f result = new RL_3d8ec8875be5c4be53b16383052cc65f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3d8ec8875be5c4be53b16383052cc65f FromRestList<T>(RestList<T> restList, Func <T, RC_9808e19d66784f7acd0d80b7d130df17> converter) {
  RL_3d8ec8875be5c4be53b16383052cc65f result = new RL_3d8ec8875be5c4be53b16383052cc65f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3d8ec8875be5c4be53b16383052cc65f() : base() {
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
protected override OSList<RC_9808e19d66784f7acd0d80b7d130df17> NewList() {
return new RL_3d8ec8875be5c4be53b16383052cc65f();
}


} // RL_3d8ec8875be5c4be53b16383052cc65f
}

