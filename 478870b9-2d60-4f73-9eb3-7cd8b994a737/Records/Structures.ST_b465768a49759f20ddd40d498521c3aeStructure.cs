namespace ssSystem_ {
/// <summary>
/// [Structure] StartUserRegistrationResult (qhzDBItK1UeBLpyzsjvtjA)
///  <code>ST_b465768a49759f20ddd40d498521c3aeStructure</code> that represent
/// s <code>StartUserRegistrationResult</code> <p>Description: Result of the user registration action. 
///  Returns a user identifier and a temporary password if the user was successfully registered.
///   Returns a failure reason if unsuccessful.</p>
/// </summary>
// Name: StartUserRegistrationResult
public partial struct ST_b465768a49759f20ddd40d498521c3aeStructure : ITypedRecord<ST_b465768a49759f20ddd40d498521c3aeStructure> {
internal static readonly GlobalObjectKey IdSuccess = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*ljprUDMaNkWOn8ieghH30g");
internal static readonly GlobalObjectKey IdStartUserRegistrationFailureReason = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*J5neM2ny40OUV6J10ylfUw");
internal static readonly GlobalObjectKey IdVerificationCode = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*jXOSIti_wkeOaVym4Y4l6w");
internal static readonly GlobalObjectKey IdUserId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*SG0dOupmkkaNXiY5lIjI2w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Success")]
public bool ssSuccess;

[System.Xml.Serialization.XmlElement("StartUserRegistrationFailureReason")]
public ST_8f28b651568fa9d5ba7b5b342de64a1cStructure ssStartUserRegistrationFailureReason;

[System.Xml.Serialization.XmlElement("VerificationCode")]
public string ssVerificationCode;

[System.Xml.Serialization.XmlElement("UserId")]
public string ssUserId;


public BitArray OptimizedAttributes;

public ST_b465768a49759f20ddd40d498521c3aeStructure() {
OptimizedAttributes = null;
ssSuccess = false;
ssStartUserRegistrationFailureReason = new ST_8f28b651568fa9d5ba7b5b342de64a1cStructure();
ssVerificationCode = "";
ssUserId = "";
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
    ssStartUserRegistrationFailureReason.OptimizedAttributes = value[0];
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
ssSuccess = r.ReadBoolean(index++, "StartUserRegistrationResult.Success", false);
ssVerificationCode = r.ReadText(index++, "StartUserRegistrationResult.VerificationCode", "");
ssUserId = r.ReadEntityReferenceText(index++, "StartUserRegistrationResult.UserId", "");
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
public void ReadIM(ST_b465768a49759f20ddd40d498521c3aeStructure r) {
this = r;
}


public static bool operator == (ST_b465768a49759f20ddd40d498521c3aeStructure a, ST_b465768a49759f20ddd40d498521c3aeStructure b) {
if (a.ssSuccess != b.ssSuccess) return false;
if (a.ssStartUserRegistrationFailureReason != b.ssStartUserRegistrationFailureReason) return false;
if (a.ssVerificationCode != b.ssVerificationCode) return false;
if (a.ssUserId != b.ssUserId) return false;
return true;
}

public static bool operator != (ST_b465768a49759f20ddd40d498521c3aeStructure a, ST_b465768a49759f20ddd40d498521c3aeStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b465768a49759f20ddd40d498521c3aeStructure)) return false;
return (this == (ST_b465768a49759f20ddd40d498521c3aeStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSuccess.GetHashCode()
 ^ ssStartUserRegistrationFailureReason.GetHashCode()
 ^ ssVerificationCode.GetHashCode()
 ^ ssUserId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssStartUserRegistrationFailureReason.RecursiveReset();
}

public void InternalRecursiveSave() {
ssStartUserRegistrationFailureReason.InternalRecursiveSave();
}


public ST_b465768a49759f20ddd40d498521c3aeStructure Duplicate() {
ST_b465768a49759f20ddd40d498521c3aeStructure t;
t.ssSuccess = this.ssSuccess;
t.ssStartUserRegistrationFailureReason = (ST_8f28b651568fa9d5ba7b5b342de64a1cStructure)this.ssStartUserRegistrationFailureReason.Duplicate();
t.ssVerificationCode = this.ssVerificationCode;
t.ssUserId = this.ssUserId;
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
} else if (head == "startuserregistrationfailurereason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartUserRegistrationFailureReason")) variable.Value = ssStartUserRegistrationFailureReason; else variable.Optimized = true;
variable.SetFieldName("startuserregistrationfailurereason");
} else if (head == "verificationcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VerificationCode")) variable.Value = ssVerificationCode; else variable.Optimized = true;
} else if (head == "userid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserId")) variable.Value = ssUserId; else variable.Optimized = true;
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
if (key == IdStartUserRegistrationFailureReason) {
return ssStartUserRegistrationFailureReason;
}
if (key == IdVerificationCode) {
return ssVerificationCode;
}
if (key == IdUserId) {
return ssUserId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSuccess.Key.AsGuid) {
return ssSuccess;
}
if (attributeKey == IdStartUserRegistrationFailureReason.Key.AsGuid) {
return ssStartUserRegistrationFailureReason;
}
if (attributeKey == IdVerificationCode.Key.AsGuid) {
return ssVerificationCode;
}
if (attributeKey == IdUserId.Key.AsGuid) {
return ssUserId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSuccess = (bool) other.AttributeGet(IdSuccess);
ssStartUserRegistrationFailureReason.FillFromOther((IRecord) other.AttributeGet(IdStartUserRegistrationFailureReason));
ssVerificationCode = (string) other.AttributeGet(IdVerificationCode);
ssUserId = (string) other.AttributeGet(IdUserId);
}
} // ST_b465768a49759f20ddd40d498521c3aeStructure
/// <summary>
/// RecordList type <code>StartUserRegistrationResultList</code> that represents a record list of
///  <code>StartUserRegistrationResult</code>
/// </summary>
public partial class RL_e03caeb3051b63201fbde73f1c69f75b : GenericRecordList<ST_b465768a49759f20ddd40d498521c3aeStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_b465768a49759f20ddd40d498521c3aeStructure GetElementDefaultValue() {
return new ST_b465768a49759f20ddd40d498521c3aeStructure();
}

public T[] ToArray<T>(Func<ST_b465768a49759f20ddd40d498521c3aeStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e03caeb3051b63201fbde73f1c69f75b recordList, Func<ST_b465768a49759f20ddd40d498521c3aeStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e03caeb3051b63201fbde73f1c69f75b(ST_b465768a49759f20ddd40d498521c3aeStructure[] array) {
  RL_e03caeb3051b63201fbde73f1c69f75b result = new RL_e03caeb3051b63201fbde73f1c69f75b();
result.InnerFromArray(array);
    return result;
}

public static RL_e03caeb3051b63201fbde73f1c69f75b ToList<T>(T[] array, Func <T, ST_b465768a49759f20ddd40d498521c3aeStructure> converter) {
  RL_e03caeb3051b63201fbde73f1c69f75b result = new RL_e03caeb3051b63201fbde73f1c69f75b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e03caeb3051b63201fbde73f1c69f75b FromRestList<T>(RestList<T> restList, Func <T, ST_b465768a49759f20ddd40d498521c3aeStructure> converter) {
  RL_e03caeb3051b63201fbde73f1c69f75b result = new RL_e03caeb3051b63201fbde73f1c69f75b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e03caeb3051b63201fbde73f1c69f75b() : base() {
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
protected override OSList<ST_b465768a49759f20ddd40d498521c3aeStructure> NewList() {
return new RL_e03caeb3051b63201fbde73f1c69f75b();
}


} // RL_e03caeb3051b63201fbde73f1c69f75b
}

