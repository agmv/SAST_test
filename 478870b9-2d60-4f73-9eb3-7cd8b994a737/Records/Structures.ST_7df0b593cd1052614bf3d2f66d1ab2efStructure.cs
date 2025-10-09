namespace ssSystem_ {
/// <summary>
/// [Structure] StartResetPasswordResult (bjslq40EukmmYv3KL_5xOQ)
///  <code>ST_7df0b593cd1052614bf3d2f66d1ab2efStructure</code> that represent
/// s <code>StartResetPasswordResult</code> <p>Description: </p>
/// </summary>
// Name: StartResetPasswordResult
public partial struct ST_7df0b593cd1052614bf3d2f66d1ab2efStructure : ITypedRecord<ST_7df0b593cd1052614bf3d2f66d1ab2efStructure> {
internal static readonly GlobalObjectKey IdSuccess = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*23IvLHMpwU6MEbLDCb1+dA");
internal static readonly GlobalObjectKey IdVerificationCode = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*nCDaM9tHKkme1SKMBnXtmw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Success")]
public bool ssSuccess;

[System.Xml.Serialization.XmlElement("VerificationCode")]
public string ssVerificationCode;


public BitArray OptimizedAttributes;

public ST_7df0b593cd1052614bf3d2f66d1ab2efStructure() {
OptimizedAttributes = null;
ssSuccess = false;
ssVerificationCode = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSuccess = r.ReadBoolean(index++, "StartResetPasswordResult.Success", false);
ssVerificationCode = r.ReadText(index++, "StartResetPasswordResult.VerificationCode", "");
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
public void ReadIM(ST_7df0b593cd1052614bf3d2f66d1ab2efStructure r) {
this = r;
}


public static bool operator == (ST_7df0b593cd1052614bf3d2f66d1ab2efStructure a, ST_7df0b593cd1052614bf3d2f66d1ab2efStructure b) {
if (a.ssSuccess != b.ssSuccess) return false;
if (a.ssVerificationCode != b.ssVerificationCode) return false;
return true;
}

public static bool operator != (ST_7df0b593cd1052614bf3d2f66d1ab2efStructure a, ST_7df0b593cd1052614bf3d2f66d1ab2efStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_7df0b593cd1052614bf3d2f66d1ab2efStructure)) return false;
return (this == (ST_7df0b593cd1052614bf3d2f66d1ab2efStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSuccess.GetHashCode()
 ^ ssVerificationCode.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_7df0b593cd1052614bf3d2f66d1ab2efStructure Duplicate() {
ST_7df0b593cd1052614bf3d2f66d1ab2efStructure t;
t.ssSuccess = this.ssSuccess;
t.ssVerificationCode = this.ssVerificationCode;
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSuccess.Key.AsGuid) {
return ssSuccess;
}
if (attributeKey == IdVerificationCode.Key.AsGuid) {
return ssVerificationCode;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSuccess = (bool) other.AttributeGet(IdSuccess);
ssVerificationCode = (string) other.AttributeGet(IdVerificationCode);
}
} // ST_7df0b593cd1052614bf3d2f66d1ab2efStructure
/// <summary>
/// RecordList type <code>StartResetPasswordResultList</code> that represents a record list of
///  <code>StartResetPasswordResult</code>
/// </summary>
public partial class RL_4e4931d865c8789e9e6ef1d8540ae228 : GenericRecordList<ST_7df0b593cd1052614bf3d2f66d1ab2efStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_7df0b593cd1052614bf3d2f66d1ab2efStructure GetElementDefaultValue() {
return new ST_7df0b593cd1052614bf3d2f66d1ab2efStructure();
}

public T[] ToArray<T>(Func<ST_7df0b593cd1052614bf3d2f66d1ab2efStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4e4931d865c8789e9e6ef1d8540ae228 recordList, Func<ST_7df0b593cd1052614bf3d2f66d1ab2efStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4e4931d865c8789e9e6ef1d8540ae228(ST_7df0b593cd1052614bf3d2f66d1ab2efStructure[] array) {
  RL_4e4931d865c8789e9e6ef1d8540ae228 result = new RL_4e4931d865c8789e9e6ef1d8540ae228();
result.InnerFromArray(array);
    return result;
}

public static RL_4e4931d865c8789e9e6ef1d8540ae228 ToList<T>(T[] array, Func <T, ST_7df0b593cd1052614bf3d2f66d1ab2efStructure> converter) {
  RL_4e4931d865c8789e9e6ef1d8540ae228 result = new RL_4e4931d865c8789e9e6ef1d8540ae228();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4e4931d865c8789e9e6ef1d8540ae228 FromRestList<T>(RestList<T> restList, Func <T, ST_7df0b593cd1052614bf3d2f66d1ab2efStructure> converter) {
  RL_4e4931d865c8789e9e6ef1d8540ae228 result = new RL_4e4931d865c8789e9e6ef1d8540ae228();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4e4931d865c8789e9e6ef1d8540ae228() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_7df0b593cd1052614bf3d2f66d1ab2efStructure> NewList() {
return new RL_4e4931d865c8789e9e6ef1d8540ae228();
}


} // RL_4e4931d865c8789e9e6ef1d8540ae228
}

