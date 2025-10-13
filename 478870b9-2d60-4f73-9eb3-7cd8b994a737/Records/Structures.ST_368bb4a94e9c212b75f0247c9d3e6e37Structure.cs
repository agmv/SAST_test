namespace ssSystem_ {
/// <summary>
/// [Structure] ChangePasswordResult (uApviDVMrkqrCX13BzCaCA)
///  <code>ST_368bb4a94e9c212b75f0247c9d3e6e37Structure</code> that represent
/// s <code>ChangePasswordResult</code> <p>Description: </p>
/// </summary>
// Name: ChangePasswordResult
public partial struct ST_368bb4a94e9c212b75f0247c9d3e6e37Structure : ITypedRecord<ST_368bb4a94e9c212b75f0247c9d3e6e37Structure> {
internal static readonly GlobalObjectKey IdSuccess = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*g1sY44Uw806w9coLBNh_Kw");
internal static readonly GlobalObjectKey IdChangePasswordFailureReason = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*Q+kRRKyB5UCatqFM6j8JNA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Success")]
public bool ssSuccess;

[System.Xml.Serialization.XmlElement("ChangePasswordFailureReason")]
public ST_896e066bc5a2d27c8f6a276746e82800Structure ssChangePasswordFailureReason;


public BitArray OptimizedAttributes;

public ST_368bb4a94e9c212b75f0247c9d3e6e37Structure() {
OptimizedAttributes = null;
ssSuccess = false;
ssChangePasswordFailureReason = new ST_896e066bc5a2d27c8f6a276746e82800Structure();
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
    ssChangePasswordFailureReason.OptimizedAttributes = value[0];
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
ssSuccess = r.ReadBoolean(index++, "ChangePasswordResult.Success", false);
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
public void ReadIM(ST_368bb4a94e9c212b75f0247c9d3e6e37Structure r) {
this = r;
}


public static bool operator == (ST_368bb4a94e9c212b75f0247c9d3e6e37Structure a, ST_368bb4a94e9c212b75f0247c9d3e6e37Structure b) {
if (a.ssSuccess != b.ssSuccess) return false;
if (a.ssChangePasswordFailureReason != b.ssChangePasswordFailureReason) return false;
return true;
}

public static bool operator != (ST_368bb4a94e9c212b75f0247c9d3e6e37Structure a, ST_368bb4a94e9c212b75f0247c9d3e6e37Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_368bb4a94e9c212b75f0247c9d3e6e37Structure)) return false;
return (this == (ST_368bb4a94e9c212b75f0247c9d3e6e37Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSuccess.GetHashCode()
 ^ ssChangePasswordFailureReason.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssChangePasswordFailureReason.RecursiveReset();
}

public void InternalRecursiveSave() {
ssChangePasswordFailureReason.InternalRecursiveSave();
}


public ST_368bb4a94e9c212b75f0247c9d3e6e37Structure Duplicate() {
ST_368bb4a94e9c212b75f0247c9d3e6e37Structure t;
t.ssSuccess = this.ssSuccess;
t.ssChangePasswordFailureReason = (ST_896e066bc5a2d27c8f6a276746e82800Structure)this.ssChangePasswordFailureReason.Duplicate();
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
} else if (head == "changepasswordfailurereason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ChangePasswordFailureReason")) variable.Value = ssChangePasswordFailureReason; else variable.Optimized = true;
variable.SetFieldName("changepasswordfailurereason");
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
if (key == IdChangePasswordFailureReason) {
return ssChangePasswordFailureReason;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSuccess.Key.AsGuid) {
return ssSuccess;
}
if (attributeKey == IdChangePasswordFailureReason.Key.AsGuid) {
return ssChangePasswordFailureReason;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSuccess = (bool) other.AttributeGet(IdSuccess);
ssChangePasswordFailureReason.FillFromOther((IRecord) other.AttributeGet(IdChangePasswordFailureReason));
}
} // ST_368bb4a94e9c212b75f0247c9d3e6e37Structure
/// <summary>
/// RecordList type <code>ChangePasswordResultList</code> that represents a record list of
///  <code>ChangePasswordResult</code>
/// </summary>
public partial class RL_fc9a0541e530960ed38d7662d5b2141b : GenericRecordList<ST_368bb4a94e9c212b75f0247c9d3e6e37Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_368bb4a94e9c212b75f0247c9d3e6e37Structure GetElementDefaultValue() {
return new ST_368bb4a94e9c212b75f0247c9d3e6e37Structure();
}

public T[] ToArray<T>(Func<ST_368bb4a94e9c212b75f0247c9d3e6e37Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fc9a0541e530960ed38d7662d5b2141b recordList, Func<ST_368bb4a94e9c212b75f0247c9d3e6e37Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fc9a0541e530960ed38d7662d5b2141b(ST_368bb4a94e9c212b75f0247c9d3e6e37Structure[] array) {
  RL_fc9a0541e530960ed38d7662d5b2141b result = new RL_fc9a0541e530960ed38d7662d5b2141b();
result.InnerFromArray(array);
    return result;
}

public static RL_fc9a0541e530960ed38d7662d5b2141b ToList<T>(T[] array, Func <T, ST_368bb4a94e9c212b75f0247c9d3e6e37Structure> converter) {
  RL_fc9a0541e530960ed38d7662d5b2141b result = new RL_fc9a0541e530960ed38d7662d5b2141b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fc9a0541e530960ed38d7662d5b2141b FromRestList<T>(RestList<T> restList, Func <T, ST_368bb4a94e9c212b75f0247c9d3e6e37Structure> converter) {
  RL_fc9a0541e530960ed38d7662d5b2141b result = new RL_fc9a0541e530960ed38d7662d5b2141b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fc9a0541e530960ed38d7662d5b2141b() : base() {
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
protected override OSList<ST_368bb4a94e9c212b75f0247c9d3e6e37Structure> NewList() {
return new RL_fc9a0541e530960ed38d7662d5b2141b();
}


} // RL_fc9a0541e530960ed38d7662d5b2141b
}

