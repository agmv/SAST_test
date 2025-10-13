namespace ssSystem_ {
/// <summary>
/// [Structure] FinishResetPasswordResult (3kSp9a4y2EKBSkovQlwEBg)
///  <code>ST_f49ebf7a28f80c1411af81f260f72632Structure</code> that represent
/// s <code>FinishResetPasswordResult</code> <p>Description: </p>
/// </summary>
// Name: FinishResetPasswordResult
public partial struct ST_f49ebf7a28f80c1411af81f260f72632Structure : ITypedRecord<ST_f49ebf7a28f80c1411af81f260f72632Structure> {
internal static readonly GlobalObjectKey IdSuccess = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*qTOSyMCI306iXozkSI+xug");
internal static readonly GlobalObjectKey IdFinishResetPasswordFailureReason = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*UKP3dB5iBU6qc6E+PUHw4A");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Success")]
public bool ssSuccess;

[System.Xml.Serialization.XmlElement("FinishResetPasswordFailureReason")]
public ST_9b153b9b179efd305d9e3eb52006065fStructure ssFinishResetPasswordFailureReason;


public BitArray OptimizedAttributes;

public ST_f49ebf7a28f80c1411af81f260f72632Structure() {
OptimizedAttributes = null;
ssSuccess = false;
ssFinishResetPasswordFailureReason = new ST_9b153b9b179efd305d9e3eb52006065fStructure();
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
    ssFinishResetPasswordFailureReason.OptimizedAttributes = value[0];
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
ssSuccess = r.ReadBoolean(index++, "FinishResetPasswordResult.Success", false);
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
public void ReadIM(ST_f49ebf7a28f80c1411af81f260f72632Structure r) {
this = r;
}


public static bool operator == (ST_f49ebf7a28f80c1411af81f260f72632Structure a, ST_f49ebf7a28f80c1411af81f260f72632Structure b) {
if (a.ssSuccess != b.ssSuccess) return false;
if (a.ssFinishResetPasswordFailureReason != b.ssFinishResetPasswordFailureReason) return false;
return true;
}

public static bool operator != (ST_f49ebf7a28f80c1411af81f260f72632Structure a, ST_f49ebf7a28f80c1411af81f260f72632Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f49ebf7a28f80c1411af81f260f72632Structure)) return false;
return (this == (ST_f49ebf7a28f80c1411af81f260f72632Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSuccess.GetHashCode()
 ^ ssFinishResetPasswordFailureReason.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssFinishResetPasswordFailureReason.RecursiveReset();
}

public void InternalRecursiveSave() {
ssFinishResetPasswordFailureReason.InternalRecursiveSave();
}


public ST_f49ebf7a28f80c1411af81f260f72632Structure Duplicate() {
ST_f49ebf7a28f80c1411af81f260f72632Structure t;
t.ssSuccess = this.ssSuccess;
t.ssFinishResetPasswordFailureReason = (ST_9b153b9b179efd305d9e3eb52006065fStructure)this.ssFinishResetPasswordFailureReason.Duplicate();
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
} else if (head == "finishresetpasswordfailurereason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FinishResetPasswordFailureReason")) variable.Value = ssFinishResetPasswordFailureReason; else variable.Optimized = true;
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
if (key == IdSuccess) {
return ssSuccess;
}
if (key == IdFinishResetPasswordFailureReason) {
return ssFinishResetPasswordFailureReason;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSuccess.Key.AsGuid) {
return ssSuccess;
}
if (attributeKey == IdFinishResetPasswordFailureReason.Key.AsGuid) {
return ssFinishResetPasswordFailureReason;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSuccess = (bool) other.AttributeGet(IdSuccess);
ssFinishResetPasswordFailureReason.FillFromOther((IRecord) other.AttributeGet(IdFinishResetPasswordFailureReason));
}
} // ST_f49ebf7a28f80c1411af81f260f72632Structure
/// <summary>
/// RecordList type <code>FinishResetPasswordResultList</code> that represents a record list of
///  <code>FinishResetPasswordResult</code>
/// </summary>
public partial class RL_68be9dd68c0e161ac2c65c1092c999e6 : GenericRecordList<ST_f49ebf7a28f80c1411af81f260f72632Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_f49ebf7a28f80c1411af81f260f72632Structure GetElementDefaultValue() {
return new ST_f49ebf7a28f80c1411af81f260f72632Structure();
}

public T[] ToArray<T>(Func<ST_f49ebf7a28f80c1411af81f260f72632Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_68be9dd68c0e161ac2c65c1092c999e6 recordList, Func<ST_f49ebf7a28f80c1411af81f260f72632Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_68be9dd68c0e161ac2c65c1092c999e6(ST_f49ebf7a28f80c1411af81f260f72632Structure[] array) {
  RL_68be9dd68c0e161ac2c65c1092c999e6 result = new RL_68be9dd68c0e161ac2c65c1092c999e6();
result.InnerFromArray(array);
    return result;
}

public static RL_68be9dd68c0e161ac2c65c1092c999e6 ToList<T>(T[] array, Func <T, ST_f49ebf7a28f80c1411af81f260f72632Structure> converter) {
  RL_68be9dd68c0e161ac2c65c1092c999e6 result = new RL_68be9dd68c0e161ac2c65c1092c999e6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_68be9dd68c0e161ac2c65c1092c999e6 FromRestList<T>(RestList<T> restList, Func <T, ST_f49ebf7a28f80c1411af81f260f72632Structure> converter) {
  RL_68be9dd68c0e161ac2c65c1092c999e6 result = new RL_68be9dd68c0e161ac2c65c1092c999e6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_68be9dd68c0e161ac2c65c1092c999e6() : base() {
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
protected override OSList<ST_f49ebf7a28f80c1411af81f260f72632Structure> NewList() {
return new RL_68be9dd68c0e161ac2c65c1092c999e6();
}


} // RL_68be9dd68c0e161ac2c65c1092c999e6
}

