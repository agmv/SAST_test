namespace ssSystem_ {
/// <summary>
/// [Structure] FinishUpdateEmailResult (9+FhqxF81EyS+KbFZlV54w)
///  <code>ST_992b6b077ef933bd10f0df6cf0ce4be3Structure</code> that represent
/// s <code>FinishUpdateEmailResult</code> <p>Description: </p>
/// </summary>
// Name: FinishUpdateEmailResult
public partial struct ST_992b6b077ef933bd10f0df6cf0ce4be3Structure : ITypedRecord<ST_992b6b077ef933bd10f0df6cf0ce4be3Structure> {
internal static readonly GlobalObjectKey IdSuccess = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*NBhe5wek_k295GgF+P_OwA");
internal static readonly GlobalObjectKey IdFinishUpdateEmailFailureReason = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*Uk0u+EBmqUe6av8WOL4ZlA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Success")]
public bool ssSuccess;

[System.Xml.Serialization.XmlElement("FinishUpdateEmailFailureReason")]
public ST_23034956e06e8e0a2169e5e731331735Structure ssFinishUpdateEmailFailureReason;


public BitArray OptimizedAttributes;

public ST_992b6b077ef933bd10f0df6cf0ce4be3Structure() {
OptimizedAttributes = null;
ssSuccess = false;
ssFinishUpdateEmailFailureReason = new ST_23034956e06e8e0a2169e5e731331735Structure();
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
    ssFinishUpdateEmailFailureReason.OptimizedAttributes = value[0];
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
ssSuccess = r.ReadBoolean(index++, "FinishUpdateEmailResult.Success", false);
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
public void ReadIM(ST_992b6b077ef933bd10f0df6cf0ce4be3Structure r) {
this = r;
}


public static bool operator == (ST_992b6b077ef933bd10f0df6cf0ce4be3Structure a, ST_992b6b077ef933bd10f0df6cf0ce4be3Structure b) {
if (a.ssSuccess != b.ssSuccess) return false;
if (a.ssFinishUpdateEmailFailureReason != b.ssFinishUpdateEmailFailureReason) return false;
return true;
}

public static bool operator != (ST_992b6b077ef933bd10f0df6cf0ce4be3Structure a, ST_992b6b077ef933bd10f0df6cf0ce4be3Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_992b6b077ef933bd10f0df6cf0ce4be3Structure)) return false;
return (this == (ST_992b6b077ef933bd10f0df6cf0ce4be3Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSuccess.GetHashCode()
 ^ ssFinishUpdateEmailFailureReason.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssFinishUpdateEmailFailureReason.RecursiveReset();
}

public void InternalRecursiveSave() {
ssFinishUpdateEmailFailureReason.InternalRecursiveSave();
}


public ST_992b6b077ef933bd10f0df6cf0ce4be3Structure Duplicate() {
ST_992b6b077ef933bd10f0df6cf0ce4be3Structure t;
t.ssSuccess = this.ssSuccess;
t.ssFinishUpdateEmailFailureReason = (ST_23034956e06e8e0a2169e5e731331735Structure)this.ssFinishUpdateEmailFailureReason.Duplicate();
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
if (head == "success") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Success")) variable.Value = ssSuccess; else variable.Optimized = true;
} else if (head == "finishupdateemailfailurereason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FinishUpdateEmailFailureReason")) variable.Value = ssFinishUpdateEmailFailureReason; else variable.Optimized = true;
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
if (key == IdSuccess) {
return ssSuccess;
}
if (key == IdFinishUpdateEmailFailureReason) {
return ssFinishUpdateEmailFailureReason;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSuccess.Key.AsGuid) {
return ssSuccess;
}
if (attributeKey == IdFinishUpdateEmailFailureReason.Key.AsGuid) {
return ssFinishUpdateEmailFailureReason;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSuccess = (bool) other.AttributeGet(IdSuccess);
ssFinishUpdateEmailFailureReason.FillFromOther((IRecord) other.AttributeGet(IdFinishUpdateEmailFailureReason));
}
} // ST_992b6b077ef933bd10f0df6cf0ce4be3Structure
/// <summary>
/// RecordList type <code>FinishUpdateEmailResultList</code> that represents a record list of
///  <code>FinishUpdateEmailResult</code>
/// </summary>
public partial class RL_4f31e5cc195a653ef45cd5ab3bd16daf : GenericRecordList<ST_992b6b077ef933bd10f0df6cf0ce4be3Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_992b6b077ef933bd10f0df6cf0ce4be3Structure GetElementDefaultValue() {
return new ST_992b6b077ef933bd10f0df6cf0ce4be3Structure();
}

public T[] ToArray<T>(Func<ST_992b6b077ef933bd10f0df6cf0ce4be3Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4f31e5cc195a653ef45cd5ab3bd16daf recordList, Func<ST_992b6b077ef933bd10f0df6cf0ce4be3Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4f31e5cc195a653ef45cd5ab3bd16daf(ST_992b6b077ef933bd10f0df6cf0ce4be3Structure[] array) {
  RL_4f31e5cc195a653ef45cd5ab3bd16daf result = new RL_4f31e5cc195a653ef45cd5ab3bd16daf();
result.InnerFromArray(array);
    return result;
}

public static RL_4f31e5cc195a653ef45cd5ab3bd16daf ToList<T>(T[] array, Func <T, ST_992b6b077ef933bd10f0df6cf0ce4be3Structure> converter) {
  RL_4f31e5cc195a653ef45cd5ab3bd16daf result = new RL_4f31e5cc195a653ef45cd5ab3bd16daf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4f31e5cc195a653ef45cd5ab3bd16daf FromRestList<T>(RestList<T> restList, Func <T, ST_992b6b077ef933bd10f0df6cf0ce4be3Structure> converter) {
  RL_4f31e5cc195a653ef45cd5ab3bd16daf result = new RL_4f31e5cc195a653ef45cd5ab3bd16daf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4f31e5cc195a653ef45cd5ab3bd16daf() : base() {
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
protected override OSList<ST_992b6b077ef933bd10f0df6cf0ce4be3Structure> NewList() {
return new RL_4f31e5cc195a653ef45cd5ab3bd16daf();
}


} // RL_4f31e5cc195a653ef45cd5ab3bd16daf
}

