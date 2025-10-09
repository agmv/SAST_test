namespace ssSystem_ {
/// <summary>
/// [Structure] StartUpdateEmailResult (h6bM9MtAEEu1ubZOOxX0Nw)
///  <code>ST_f4b6c6eeb122dfa3165aeece838fd077Structure</code> that represent
/// s <code>StartUpdateEmailResult</code> <p>Description: </p>
/// </summary>
// Name: StartUpdateEmailResult
public partial struct ST_f4b6c6eeb122dfa3165aeece838fd077Structure : ITypedRecord<ST_f4b6c6eeb122dfa3165aeece838fd077Structure> {
internal static readonly GlobalObjectKey IdSuccess = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*pTsO3CFSE0eTMejTi3TP9A");
internal static readonly GlobalObjectKey IdVerificationCode = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*q7nP+Uo9HESVESKGB5YXFw");
internal static readonly GlobalObjectKey IdStartUpdateEmailFailureReason = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*HQl0bfUaukyNu8YbJWQxTA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Success")]
public bool ssSuccess;

[System.Xml.Serialization.XmlElement("VerificationCode")]
public string ssVerificationCode;

[System.Xml.Serialization.XmlElement("StartUpdateEmailFailureReason")]
public ST_265373b7ea713cad761986e9aec6548dStructure ssStartUpdateEmailFailureReason;


public BitArray OptimizedAttributes;

public ST_f4b6c6eeb122dfa3165aeece838fd077Structure() {
OptimizedAttributes = null;
ssSuccess = false;
ssVerificationCode = "";
ssStartUpdateEmailFailureReason = new ST_265373b7ea713cad761986e9aec6548dStructure();
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
    ssStartUpdateEmailFailureReason.OptimizedAttributes = value[0];
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
ssSuccess = r.ReadBoolean(index++, "StartUpdateEmailResult.Success", false);
ssVerificationCode = r.ReadText(index++, "StartUpdateEmailResult.VerificationCode", "");
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
public void ReadIM(ST_f4b6c6eeb122dfa3165aeece838fd077Structure r) {
this = r;
}


public static bool operator == (ST_f4b6c6eeb122dfa3165aeece838fd077Structure a, ST_f4b6c6eeb122dfa3165aeece838fd077Structure b) {
if (a.ssSuccess != b.ssSuccess) return false;
if (a.ssVerificationCode != b.ssVerificationCode) return false;
if (a.ssStartUpdateEmailFailureReason != b.ssStartUpdateEmailFailureReason) return false;
return true;
}

public static bool operator != (ST_f4b6c6eeb122dfa3165aeece838fd077Structure a, ST_f4b6c6eeb122dfa3165aeece838fd077Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f4b6c6eeb122dfa3165aeece838fd077Structure)) return false;
return (this == (ST_f4b6c6eeb122dfa3165aeece838fd077Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSuccess.GetHashCode()
 ^ ssVerificationCode.GetHashCode()
 ^ ssStartUpdateEmailFailureReason.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssStartUpdateEmailFailureReason.RecursiveReset();
}

public void InternalRecursiveSave() {
ssStartUpdateEmailFailureReason.InternalRecursiveSave();
}


public ST_f4b6c6eeb122dfa3165aeece838fd077Structure Duplicate() {
ST_f4b6c6eeb122dfa3165aeece838fd077Structure t;
t.ssSuccess = this.ssSuccess;
t.ssVerificationCode = this.ssVerificationCode;
t.ssStartUpdateEmailFailureReason = (ST_265373b7ea713cad761986e9aec6548dStructure)this.ssStartUpdateEmailFailureReason.Duplicate();
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
} else if (head == "verificationcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VerificationCode")) variable.Value = ssVerificationCode; else variable.Optimized = true;
} else if (head == "startupdateemailfailurereason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartUpdateEmailFailureReason")) variable.Value = ssStartUpdateEmailFailureReason; else variable.Optimized = true;
variable.SetFieldName("startupdateemailfailurereason");
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
if (key == IdVerificationCode) {
return ssVerificationCode;
}
if (key == IdStartUpdateEmailFailureReason) {
return ssStartUpdateEmailFailureReason;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSuccess.Key.AsGuid) {
return ssSuccess;
}
if (attributeKey == IdVerificationCode.Key.AsGuid) {
return ssVerificationCode;
}
if (attributeKey == IdStartUpdateEmailFailureReason.Key.AsGuid) {
return ssStartUpdateEmailFailureReason;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSuccess = (bool) other.AttributeGet(IdSuccess);
ssVerificationCode = (string) other.AttributeGet(IdVerificationCode);
ssStartUpdateEmailFailureReason.FillFromOther((IRecord) other.AttributeGet(IdStartUpdateEmailFailureReason));
}
} // ST_f4b6c6eeb122dfa3165aeece838fd077Structure
/// <summary>
/// RecordList type <code>StartUpdateEmailResultList</code> that represents a record list of
///  <code>StartUpdateEmailResult</code>
/// </summary>
public partial class RL_95969e56f8e0952b240be2078c44eef9 : GenericRecordList<ST_f4b6c6eeb122dfa3165aeece838fd077Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_f4b6c6eeb122dfa3165aeece838fd077Structure GetElementDefaultValue() {
return new ST_f4b6c6eeb122dfa3165aeece838fd077Structure();
}

public T[] ToArray<T>(Func<ST_f4b6c6eeb122dfa3165aeece838fd077Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_95969e56f8e0952b240be2078c44eef9 recordList, Func<ST_f4b6c6eeb122dfa3165aeece838fd077Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_95969e56f8e0952b240be2078c44eef9(ST_f4b6c6eeb122dfa3165aeece838fd077Structure[] array) {
  RL_95969e56f8e0952b240be2078c44eef9 result = new RL_95969e56f8e0952b240be2078c44eef9();
result.InnerFromArray(array);
    return result;
}

public static RL_95969e56f8e0952b240be2078c44eef9 ToList<T>(T[] array, Func <T, ST_f4b6c6eeb122dfa3165aeece838fd077Structure> converter) {
  RL_95969e56f8e0952b240be2078c44eef9 result = new RL_95969e56f8e0952b240be2078c44eef9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_95969e56f8e0952b240be2078c44eef9 FromRestList<T>(RestList<T> restList, Func <T, ST_f4b6c6eeb122dfa3165aeece838fd077Structure> converter) {
  RL_95969e56f8e0952b240be2078c44eef9 result = new RL_95969e56f8e0952b240be2078c44eef9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_95969e56f8e0952b240be2078c44eef9() : base() {
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
protected override OSList<ST_f4b6c6eeb122dfa3165aeece838fd077Structure> NewList() {
return new RL_95969e56f8e0952b240be2078c44eef9();
}


} // RL_95969e56f8e0952b240be2078c44eef9
}

