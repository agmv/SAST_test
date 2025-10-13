namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (EFKocJwYn0qMuFOorwnICg)
///  <code>RC_4d77cfdd567b208680377834fc8205a2</code> that represent
/// s <code>PasswordComplexityPolicyRecord</code> <p>Description: </p>
/// </summary>
// Name: PasswordComplexityPolicyRecord
public partial struct RC_4d77cfdd567b208680377834fc8205a2 : ITypedRecord<RC_4d77cfdd567b208680377834fc8205a2> {
internal static readonly GlobalObjectKey IdPasswordComplexityPolicy = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3c93TXtWhiCAN3g0_IIFog");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("PasswordComplexityPolicy")]
public ST_0774152396050b877fe73fc0db09d4f4Structure ssSTPasswordComplexityPolicy;


public static implicit operator ST_0774152396050b877fe73fc0db09d4f4Structure( RC_4d77cfdd567b208680377834fc8205a2 r) {
return r.ssSTPasswordComplexityPolicy;
}

public static implicit operator RC_4d77cfdd567b208680377834fc8205a2 (ST_0774152396050b877fe73fc0db09d4f4Structure r) {
RC_4d77cfdd567b208680377834fc8205a2 res = new RC_4d77cfdd567b208680377834fc8205a2 ();
res.ssSTPasswordComplexityPolicy = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_4d77cfdd567b208680377834fc8205a2() {
OptimizedAttributes = null;
ssSTPasswordComplexityPolicy = new ST_0774152396050b877fe73fc0db09d4f4Structure();
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
    ssSTPasswordComplexityPolicy.OptimizedAttributes = value[0];
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
ssSTPasswordComplexityPolicy.Read( r, ref index);
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
public void ReadIM(RC_4d77cfdd567b208680377834fc8205a2 r) {
this = r;
}


public static bool operator == (RC_4d77cfdd567b208680377834fc8205a2 a, RC_4d77cfdd567b208680377834fc8205a2 b) {
if (a.ssSTPasswordComplexityPolicy != b.ssSTPasswordComplexityPolicy) return false;
return true;
}

public static bool operator != (RC_4d77cfdd567b208680377834fc8205a2 a, RC_4d77cfdd567b208680377834fc8205a2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4d77cfdd567b208680377834fc8205a2)) return false;
return (this == (RC_4d77cfdd567b208680377834fc8205a2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPasswordComplexityPolicy.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPasswordComplexityPolicy.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPasswordComplexityPolicy.InternalRecursiveSave();
}


public RC_4d77cfdd567b208680377834fc8205a2 Duplicate() {
RC_4d77cfdd567b208680377834fc8205a2 t;
t.ssSTPasswordComplexityPolicy = (ST_0774152396050b877fe73fc0db09d4f4Structure)this.ssSTPasswordComplexityPolicy.Duplicate();
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
if (head == "passwordcomplexitypolicy") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PasswordComplexityPolicy")) variable.Value = ssSTPasswordComplexityPolicy; else variable.Optimized = true;
variable.SetFieldName("passwordcomplexitypolicy");
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
if (key == IdPasswordComplexityPolicy) {
return ssSTPasswordComplexityPolicy;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPasswordComplexityPolicy.Key.AsGuid) {
return ssSTPasswordComplexityPolicy;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPasswordComplexityPolicy.FillFromOther((IRecord) other.AttributeGet(IdPasswordComplexityPolicy));
}
} // RC_4d77cfdd567b208680377834fc8205a2
/// <summary>
/// RecordList type <code>PasswordComplexityPolicyRecordList</code> that represents a record list of
///  <code>PasswordComplexityPolicy</code>
/// </summary>
public partial class RL_919d8bc896529858c8cc8f0f3e5cb019 : GenericRecordList<RC_4d77cfdd567b208680377834fc8205a2>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_4d77cfdd567b208680377834fc8205a2 GetElementDefaultValue() {
return new RC_4d77cfdd567b208680377834fc8205a2();
}

public T[] ToArray<T>(Func<RC_4d77cfdd567b208680377834fc8205a2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_919d8bc896529858c8cc8f0f3e5cb019 recordList, Func<RC_4d77cfdd567b208680377834fc8205a2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_919d8bc896529858c8cc8f0f3e5cb019(RC_4d77cfdd567b208680377834fc8205a2[] array) {
  RL_919d8bc896529858c8cc8f0f3e5cb019 result = new RL_919d8bc896529858c8cc8f0f3e5cb019();
result.InnerFromArray(array);
    return result;
}

public static RL_919d8bc896529858c8cc8f0f3e5cb019 ToList<T>(T[] array, Func <T, RC_4d77cfdd567b208680377834fc8205a2> converter) {
  RL_919d8bc896529858c8cc8f0f3e5cb019 result = new RL_919d8bc896529858c8cc8f0f3e5cb019();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_919d8bc896529858c8cc8f0f3e5cb019 FromRestList<T>(RestList<T> restList, Func <T, RC_4d77cfdd567b208680377834fc8205a2> converter) {
  RL_919d8bc896529858c8cc8f0f3e5cb019 result = new RL_919d8bc896529858c8cc8f0f3e5cb019();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_919d8bc896529858c8cc8f0f3e5cb019() : base() {
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
protected override OSList<RC_4d77cfdd567b208680377834fc8205a2> NewList() {
return new RL_919d8bc896529858c8cc8f0f3e5cb019();
}


} // RL_919d8bc896529858c8cc8f0f3e5cb019
}

