namespace ssSystem_ {
/// <summary>
/// [Structure] FinishUserRegistrationFailureReason (zDT1bcBv9kiG6vhdXu4Ntw)
///  <code>ST_6512d51a2c447fea2b8340c839f73d57Structure</code> that represent
/// s <code>FinishUserRegistrationFailureReason</code> <p>Description: Failure reason structure.
///  Contains the reason for failure if the action isn't successful.</p>
/// </summary>
// Name: FinishUserRegistrationFailureReason
public partial struct ST_6512d51a2c447fea2b8340c839f73d57Structure : ITypedRecord<ST_6512d51a2c447fea2b8340c839f73d57Structure> {
internal static readonly GlobalObjectKey IdInvalidVerificationCode = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*_GGNP8luYk2Jg3GxDhvbJA");
internal static readonly GlobalObjectKey IdPasswordComplexityPolicyFailed = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*c1wwHkOuDEiEPU4vj7Apeg");
internal static readonly GlobalObjectKey IdInvalidEmail = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*3PvFrqHAiUyJtNSxFJj18Q");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("InvalidVerificationCode")]
public bool ssInvalidVerificationCode;

[System.Xml.Serialization.XmlElement("PasswordComplexityPolicyFailed")]
public bool ssPasswordComplexityPolicyFailed;

[System.Xml.Serialization.XmlElement("InvalidEmail")]
public bool ssInvalidEmail;


public BitArray OptimizedAttributes;

public ST_6512d51a2c447fea2b8340c839f73d57Structure() {
OptimizedAttributes = null;
ssInvalidVerificationCode = false;
ssPasswordComplexityPolicyFailed = false;
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
ssInvalidVerificationCode = r.ReadBoolean(index++, "FinishUserRegistrationFailureReason.InvalidVerificationCode", false);
ssPasswordComplexityPolicyFailed = r.ReadBoolean(index++, "FinishUserRegistrationFailureReason.PasswordComplexityPolicyFailed", false);
ssInvalidEmail = r.ReadBoolean(index++, "FinishUserRegistrationFailureReason.InvalidEmail", false);
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
public void ReadIM(ST_6512d51a2c447fea2b8340c839f73d57Structure r) {
this = r;
}


public static bool operator == (ST_6512d51a2c447fea2b8340c839f73d57Structure a, ST_6512d51a2c447fea2b8340c839f73d57Structure b) {
if (a.ssInvalidVerificationCode != b.ssInvalidVerificationCode) return false;
if (a.ssPasswordComplexityPolicyFailed != b.ssPasswordComplexityPolicyFailed) return false;
if (a.ssInvalidEmail != b.ssInvalidEmail) return false;
return true;
}

public static bool operator != (ST_6512d51a2c447fea2b8340c839f73d57Structure a, ST_6512d51a2c447fea2b8340c839f73d57Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_6512d51a2c447fea2b8340c839f73d57Structure)) return false;
return (this == (ST_6512d51a2c447fea2b8340c839f73d57Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvalidVerificationCode.GetHashCode()
 ^ ssPasswordComplexityPolicyFailed.GetHashCode()
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


public ST_6512d51a2c447fea2b8340c839f73d57Structure Duplicate() {
ST_6512d51a2c447fea2b8340c839f73d57Structure t;
t.ssInvalidVerificationCode = this.ssInvalidVerificationCode;
t.ssPasswordComplexityPolicyFailed = this.ssPasswordComplexityPolicyFailed;
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
if (head == "invalidverificationcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvalidVerificationCode")) variable.Value = ssInvalidVerificationCode; else variable.Optimized = true;
} else if (head == "passwordcomplexitypolicyfailed") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PasswordComplexityPolicyFailed")) variable.Value = ssPasswordComplexityPolicyFailed; else variable.Optimized = true;
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
if (key == IdInvalidVerificationCode) {
return ssInvalidVerificationCode;
}
if (key == IdPasswordComplexityPolicyFailed) {
return ssPasswordComplexityPolicyFailed;
}
if (key == IdInvalidEmail) {
return ssInvalidEmail;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvalidVerificationCode.Key.AsGuid) {
return ssInvalidVerificationCode;
}
if (attributeKey == IdPasswordComplexityPolicyFailed.Key.AsGuid) {
return ssPasswordComplexityPolicyFailed;
}
if (attributeKey == IdInvalidEmail.Key.AsGuid) {
return ssInvalidEmail;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInvalidVerificationCode = (bool) other.AttributeGet(IdInvalidVerificationCode);
ssPasswordComplexityPolicyFailed = (bool) other.AttributeGet(IdPasswordComplexityPolicyFailed);
ssInvalidEmail = (bool) other.AttributeGet(IdInvalidEmail);
}
} // ST_6512d51a2c447fea2b8340c839f73d57Structure
/// <summary>
/// RecordList type <code>FinishUserRegistrationFailureReasonList</code> that represents a record list
///  of <code>FinishUserRegistrationFailureReason</code>
/// </summary>
public partial class RL_f1cba7c926c1338911619f0bbdd18e16 : GenericRecordList<ST_6512d51a2c447fea2b8340c839f73d57Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_6512d51a2c447fea2b8340c839f73d57Structure GetElementDefaultValue() {
return new ST_6512d51a2c447fea2b8340c839f73d57Structure();
}

public T[] ToArray<T>(Func<ST_6512d51a2c447fea2b8340c839f73d57Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f1cba7c926c1338911619f0bbdd18e16 recordList, Func<ST_6512d51a2c447fea2b8340c839f73d57Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f1cba7c926c1338911619f0bbdd18e16(ST_6512d51a2c447fea2b8340c839f73d57Structure[] array) {
  RL_f1cba7c926c1338911619f0bbdd18e16 result = new RL_f1cba7c926c1338911619f0bbdd18e16();
result.InnerFromArray(array);
    return result;
}

public static RL_f1cba7c926c1338911619f0bbdd18e16 ToList<T>(T[] array, Func <T, ST_6512d51a2c447fea2b8340c839f73d57Structure> converter) {
  RL_f1cba7c926c1338911619f0bbdd18e16 result = new RL_f1cba7c926c1338911619f0bbdd18e16();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f1cba7c926c1338911619f0bbdd18e16 FromRestList<T>(RestList<T> restList, Func <T, ST_6512d51a2c447fea2b8340c839f73d57Structure> converter) {
  RL_f1cba7c926c1338911619f0bbdd18e16 result = new RL_f1cba7c926c1338911619f0bbdd18e16();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f1cba7c926c1338911619f0bbdd18e16() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_6512d51a2c447fea2b8340c839f73d57Structure> NewList() {
return new RL_f1cba7c926c1338911619f0bbdd18e16();
}


} // RL_f1cba7c926c1338911619f0bbdd18e16
}

