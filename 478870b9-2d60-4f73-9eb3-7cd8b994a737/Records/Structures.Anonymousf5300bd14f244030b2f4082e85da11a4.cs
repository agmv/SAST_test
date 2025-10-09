namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (0Qsw9SRPMECy9AguhdoRpA)
///  <code>RC_9817a5747e4b09aa3a6a7eb35ce9f66e</code> that represent
/// s <code>FinishResetPasswordResultRecord</code> <p>Description: </p>
/// </summary>
// Name: FinishResetPasswordResultRecord
public partial struct RC_9817a5747e4b09aa3a6a7eb35ce9f66e : ITypedRecord<RC_9817a5747e4b09aa3a6a7eb35ce9f66e> {
internal static readonly GlobalObjectKey IdFinishResetPasswordResult = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dKUXmEt+qgk6an6zXOn2bg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("FinishResetPasswordResult")]
public ST_f49ebf7a28f80c1411af81f260f72632Structure ssSTFinishResetPasswordResult;


public static implicit operator ST_f49ebf7a28f80c1411af81f260f72632Structure( RC_9817a5747e4b09aa3a6a7eb35ce9f66e r) {
return r.ssSTFinishResetPasswordResult;
}

public static implicit operator RC_9817a5747e4b09aa3a6a7eb35ce9f66e (ST_f49ebf7a28f80c1411af81f260f72632Structure r) {
RC_9817a5747e4b09aa3a6a7eb35ce9f66e res = new RC_9817a5747e4b09aa3a6a7eb35ce9f66e ();
res.ssSTFinishResetPasswordResult = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_9817a5747e4b09aa3a6a7eb35ce9f66e() {
OptimizedAttributes = null;
ssSTFinishResetPasswordResult = new ST_f49ebf7a28f80c1411af81f260f72632Structure();
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
    ssSTFinishResetPasswordResult.OptimizedAttributes = value[0];
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
ssSTFinishResetPasswordResult.Read( r, ref index);
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
public void ReadIM(RC_9817a5747e4b09aa3a6a7eb35ce9f66e r) {
this = r;
}


public static bool operator == (RC_9817a5747e4b09aa3a6a7eb35ce9f66e a, RC_9817a5747e4b09aa3a6a7eb35ce9f66e b) {
if (a.ssSTFinishResetPasswordResult != b.ssSTFinishResetPasswordResult) return false;
return true;
}

public static bool operator != (RC_9817a5747e4b09aa3a6a7eb35ce9f66e a, RC_9817a5747e4b09aa3a6a7eb35ce9f66e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9817a5747e4b09aa3a6a7eb35ce9f66e)) return false;
return (this == (RC_9817a5747e4b09aa3a6a7eb35ce9f66e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFinishResetPasswordResult.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFinishResetPasswordResult.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFinishResetPasswordResult.InternalRecursiveSave();
}


public RC_9817a5747e4b09aa3a6a7eb35ce9f66e Duplicate() {
RC_9817a5747e4b09aa3a6a7eb35ce9f66e t;
t.ssSTFinishResetPasswordResult = (ST_f49ebf7a28f80c1411af81f260f72632Structure)this.ssSTFinishResetPasswordResult.Duplicate();
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
if (head == "finishresetpasswordresult") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FinishResetPasswordResult")) variable.Value = ssSTFinishResetPasswordResult; else variable.Optimized = true;
variable.SetFieldName("finishresetpasswordresult");
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
if (key == IdFinishResetPasswordResult) {
return ssSTFinishResetPasswordResult;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFinishResetPasswordResult.Key.AsGuid) {
return ssSTFinishResetPasswordResult;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFinishResetPasswordResult.FillFromOther((IRecord) other.AttributeGet(IdFinishResetPasswordResult));
}
} // RC_9817a5747e4b09aa3a6a7eb35ce9f66e
/// <summary>
/// RecordList type <code>FinishResetPasswordResultRecordList</code> that represents a record list of
///  <code>FinishResetPasswordResult</code>
/// </summary>
public partial class RL_3f7b36d8bbcf12054b7e2f49497f214f : GenericRecordList<RC_9817a5747e4b09aa3a6a7eb35ce9f66e>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_9817a5747e4b09aa3a6a7eb35ce9f66e GetElementDefaultValue() {
return new RC_9817a5747e4b09aa3a6a7eb35ce9f66e();
}

public T[] ToArray<T>(Func<RC_9817a5747e4b09aa3a6a7eb35ce9f66e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3f7b36d8bbcf12054b7e2f49497f214f recordList, Func<RC_9817a5747e4b09aa3a6a7eb35ce9f66e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3f7b36d8bbcf12054b7e2f49497f214f(RC_9817a5747e4b09aa3a6a7eb35ce9f66e[] array) {
  RL_3f7b36d8bbcf12054b7e2f49497f214f result = new RL_3f7b36d8bbcf12054b7e2f49497f214f();
result.InnerFromArray(array);
    return result;
}

public static RL_3f7b36d8bbcf12054b7e2f49497f214f ToList<T>(T[] array, Func <T, RC_9817a5747e4b09aa3a6a7eb35ce9f66e> converter) {
  RL_3f7b36d8bbcf12054b7e2f49497f214f result = new RL_3f7b36d8bbcf12054b7e2f49497f214f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3f7b36d8bbcf12054b7e2f49497f214f FromRestList<T>(RestList<T> restList, Func <T, RC_9817a5747e4b09aa3a6a7eb35ce9f66e> converter) {
  RL_3f7b36d8bbcf12054b7e2f49497f214f result = new RL_3f7b36d8bbcf12054b7e2f49497f214f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3f7b36d8bbcf12054b7e2f49497f214f() : base() {
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
protected override OSList<RC_9817a5747e4b09aa3a6a7eb35ce9f66e> NewList() {
return new RL_3f7b36d8bbcf12054b7e2f49497f214f();
}


} // RL_3f7b36d8bbcf12054b7e2f49497f214f
}

