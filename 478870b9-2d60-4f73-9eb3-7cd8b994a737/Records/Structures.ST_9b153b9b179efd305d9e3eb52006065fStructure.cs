namespace ssSystem_ {
/// <summary>
/// [Structure] FinishResetPasswordFailureReason (gf_L1ayGokuRXEbQRH0x5w)
///  <code>ST_9b153b9b179efd305d9e3eb52006065fStructure</code> that represent
/// s <code>FinishResetPasswordFailureReason</code> <p>Description: </p>
/// </summary>
// Name: FinishResetPasswordFailureReason
public partial struct ST_9b153b9b179efd305d9e3eb52006065fStructure : ITypedRecord<ST_9b153b9b179efd305d9e3eb52006065fStructure> {
internal static readonly GlobalObjectKey IdPasswordComplexityPolicyFailed = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*0WcpEf5G2kyYldEhFJs3xA");
internal static readonly GlobalObjectKey IdInvalidVerificationCode = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*B2saAoAFO0ulCpDw+gkaRQ");
internal static readonly GlobalObjectKey IdInvalidEmail = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*6ZPT9s7CFUizE51uVPWgxg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("PasswordComplexityPolicyFailed")]
public bool ssPasswordComplexityPolicyFailed;

[System.Xml.Serialization.XmlElement("InvalidVerificationCode")]
public bool ssInvalidVerificationCode;

[System.Xml.Serialization.XmlElement("InvalidEmail")]
public bool ssInvalidEmail;


public BitArray OptimizedAttributes;

public ST_9b153b9b179efd305d9e3eb52006065fStructure() {
OptimizedAttributes = null;
ssPasswordComplexityPolicyFailed = false;
ssInvalidVerificationCode = false;
ssInvalidEmail = false;
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
ssPasswordComplexityPolicyFailed = r.ReadBoolean(index++, "FinishResetPasswordFailureReason.PasswordComplexityPolicyFailed", false);
ssInvalidVerificationCode = r.ReadBoolean(index++, "FinishResetPasswordFailureReason.InvalidVerificationCode", false);
ssInvalidEmail = r.ReadBoolean(index++, "FinishResetPasswordFailureReason.InvalidEmail", false);
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
public void ReadIM(ST_9b153b9b179efd305d9e3eb52006065fStructure r) {
this = r;
}


public static bool operator == (ST_9b153b9b179efd305d9e3eb52006065fStructure a, ST_9b153b9b179efd305d9e3eb52006065fStructure b) {
if (a.ssPasswordComplexityPolicyFailed != b.ssPasswordComplexityPolicyFailed) return false;
if (a.ssInvalidVerificationCode != b.ssInvalidVerificationCode) return false;
if (a.ssInvalidEmail != b.ssInvalidEmail) return false;
return true;
}

public static bool operator != (ST_9b153b9b179efd305d9e3eb52006065fStructure a, ST_9b153b9b179efd305d9e3eb52006065fStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_9b153b9b179efd305d9e3eb52006065fStructure)) return false;
return (this == (ST_9b153b9b179efd305d9e3eb52006065fStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPasswordComplexityPolicyFailed.GetHashCode()
 ^ ssInvalidVerificationCode.GetHashCode()
 ^ ssInvalidEmail.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_9b153b9b179efd305d9e3eb52006065fStructure Duplicate() {
ST_9b153b9b179efd305d9e3eb52006065fStructure t;
t.ssPasswordComplexityPolicyFailed = this.ssPasswordComplexityPolicyFailed;
t.ssInvalidVerificationCode = this.ssInvalidVerificationCode;
t.ssInvalidEmail = this.ssInvalidEmail;
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
if (head == "passwordcomplexitypolicyfailed") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PasswordComplexityPolicyFailed")) variable.Value = ssPasswordComplexityPolicyFailed; else variable.Optimized = true;
} else if (head == "invalidverificationcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvalidVerificationCode")) variable.Value = ssInvalidVerificationCode; else variable.Optimized = true;
} else if (head == "invalidemail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvalidEmail")) variable.Value = ssInvalidEmail; else variable.Optimized = true;
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
if (key == IdPasswordComplexityPolicyFailed) {
return ssPasswordComplexityPolicyFailed;
}
if (key == IdInvalidVerificationCode) {
return ssInvalidVerificationCode;
}
if (key == IdInvalidEmail) {
return ssInvalidEmail;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPasswordComplexityPolicyFailed.Key.AsGuid) {
return ssPasswordComplexityPolicyFailed;
}
if (attributeKey == IdInvalidVerificationCode.Key.AsGuid) {
return ssInvalidVerificationCode;
}
if (attributeKey == IdInvalidEmail.Key.AsGuid) {
return ssInvalidEmail;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPasswordComplexityPolicyFailed = (bool) other.AttributeGet(IdPasswordComplexityPolicyFailed);
ssInvalidVerificationCode = (bool) other.AttributeGet(IdInvalidVerificationCode);
ssInvalidEmail = (bool) other.AttributeGet(IdInvalidEmail);
}
} // ST_9b153b9b179efd305d9e3eb52006065fStructure
/// <summary>
/// RecordList type <code>FinishResetPasswordFailureReasonList</code> that represents a record list of
///  <code>FinishResetPasswordFailureReason</code>
/// </summary>
public partial class RL_31d7615454c0155a64f826d4e0cf4cb5 : GenericRecordList<ST_9b153b9b179efd305d9e3eb52006065fStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_9b153b9b179efd305d9e3eb52006065fStructure GetElementDefaultValue() {
return new ST_9b153b9b179efd305d9e3eb52006065fStructure();
}

public T[] ToArray<T>(Func<ST_9b153b9b179efd305d9e3eb52006065fStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_31d7615454c0155a64f826d4e0cf4cb5 recordList, Func<ST_9b153b9b179efd305d9e3eb52006065fStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_31d7615454c0155a64f826d4e0cf4cb5(ST_9b153b9b179efd305d9e3eb52006065fStructure[] array) {
  RL_31d7615454c0155a64f826d4e0cf4cb5 result = new RL_31d7615454c0155a64f826d4e0cf4cb5();
result.InnerFromArray(array);
    return result;
}

public static RL_31d7615454c0155a64f826d4e0cf4cb5 ToList<T>(T[] array, Func <T, ST_9b153b9b179efd305d9e3eb52006065fStructure> converter) {
  RL_31d7615454c0155a64f826d4e0cf4cb5 result = new RL_31d7615454c0155a64f826d4e0cf4cb5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_31d7615454c0155a64f826d4e0cf4cb5 FromRestList<T>(RestList<T> restList, Func <T, ST_9b153b9b179efd305d9e3eb52006065fStructure> converter) {
  RL_31d7615454c0155a64f826d4e0cf4cb5 result = new RL_31d7615454c0155a64f826d4e0cf4cb5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_31d7615454c0155a64f826d4e0cf4cb5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_9b153b9b179efd305d9e3eb52006065fStructure> NewList() {
return new RL_31d7615454c0155a64f826d4e0cf4cb5();
}


} // RL_31d7615454c0155a64f826d4e0cf4cb5
}

