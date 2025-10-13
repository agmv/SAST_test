namespace ssSystem_ {
/// <summary>
/// [Structure] ChangePasswordFailureReason (i0ymthvi6EePTbzQGTrg3g)
///  <code>ST_896e066bc5a2d27c8f6a276746e82800Structure</code> that represent
/// s <code>ChangePasswordFailureReason</code> <p>Description: </p>
/// </summary>
// Name: ChangePasswordFailureReason
public partial struct ST_896e066bc5a2d27c8f6a276746e82800Structure : ITypedRecord<ST_896e066bc5a2d27c8f6a276746e82800Structure> {
internal static readonly GlobalObjectKey IdPasswordComplexityPolicyFailed = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*LZGI5i3dv0yPkzgHbNoZyg");
internal static readonly GlobalObjectKey IdInvalidCredentials = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*IVeCRKs7k0u3dlgwlue3Vg");
internal static readonly GlobalObjectKey IdTooManyFailedAttempts = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*D8shWBSbD0aF28fPMZS_ww");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("PasswordComplexityPolicyFailed")]
public bool ssPasswordComplexityPolicyFailed;

[System.Xml.Serialization.XmlElement("InvalidCredentials")]
public bool ssInvalidCredentials;

[System.Xml.Serialization.XmlElement("TooManyFailedAttempts")]
public bool ssTooManyFailedAttempts;


public BitArray OptimizedAttributes;

public ST_896e066bc5a2d27c8f6a276746e82800Structure() {
OptimizedAttributes = null;
ssPasswordComplexityPolicyFailed = false;
ssInvalidCredentials = false;
ssTooManyFailedAttempts = false;
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
ssPasswordComplexityPolicyFailed = r.ReadBoolean(index++, "ChangePasswordFailureReason.PasswordComplexityPolicyFailed", false);
ssInvalidCredentials = r.ReadBoolean(index++, "ChangePasswordFailureReason.InvalidCredentials", false);
ssTooManyFailedAttempts = r.ReadBoolean(index++, "ChangePasswordFailureReason.TooManyFailedAttempts", false);
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
public void ReadIM(ST_896e066bc5a2d27c8f6a276746e82800Structure r) {
this = r;
}


public static bool operator == (ST_896e066bc5a2d27c8f6a276746e82800Structure a, ST_896e066bc5a2d27c8f6a276746e82800Structure b) {
if (a.ssPasswordComplexityPolicyFailed != b.ssPasswordComplexityPolicyFailed) return false;
if (a.ssInvalidCredentials != b.ssInvalidCredentials) return false;
if (a.ssTooManyFailedAttempts != b.ssTooManyFailedAttempts) return false;
return true;
}

public static bool operator != (ST_896e066bc5a2d27c8f6a276746e82800Structure a, ST_896e066bc5a2d27c8f6a276746e82800Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_896e066bc5a2d27c8f6a276746e82800Structure)) return false;
return (this == (ST_896e066bc5a2d27c8f6a276746e82800Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPasswordComplexityPolicyFailed.GetHashCode()
 ^ ssInvalidCredentials.GetHashCode()
 ^ ssTooManyFailedAttempts.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_896e066bc5a2d27c8f6a276746e82800Structure Duplicate() {
ST_896e066bc5a2d27c8f6a276746e82800Structure t;
t.ssPasswordComplexityPolicyFailed = this.ssPasswordComplexityPolicyFailed;
t.ssInvalidCredentials = this.ssInvalidCredentials;
t.ssTooManyFailedAttempts = this.ssTooManyFailedAttempts;
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
} else if (head == "invalidcredentials") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvalidCredentials")) variable.Value = ssInvalidCredentials; else variable.Optimized = true;
} else if (head == "toomanyfailedattempts") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TooManyFailedAttempts")) variable.Value = ssTooManyFailedAttempts; else variable.Optimized = true;
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
if (key == IdInvalidCredentials) {
return ssInvalidCredentials;
}
if (key == IdTooManyFailedAttempts) {
return ssTooManyFailedAttempts;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPasswordComplexityPolicyFailed.Key.AsGuid) {
return ssPasswordComplexityPolicyFailed;
}
if (attributeKey == IdInvalidCredentials.Key.AsGuid) {
return ssInvalidCredentials;
}
if (attributeKey == IdTooManyFailedAttempts.Key.AsGuid) {
return ssTooManyFailedAttempts;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPasswordComplexityPolicyFailed = (bool) other.AttributeGet(IdPasswordComplexityPolicyFailed);
ssInvalidCredentials = (bool) other.AttributeGet(IdInvalidCredentials);
ssTooManyFailedAttempts = (bool) other.AttributeGet(IdTooManyFailedAttempts);
}
} // ST_896e066bc5a2d27c8f6a276746e82800Structure
/// <summary>
/// RecordList type <code>ChangePasswordFailureReasonList</code> that represents a record list of
///  <code>ChangePasswordFailureReason</code>
/// </summary>
public partial class RL_a60626c1780bfe250dcef75d5dfa5fd1 : GenericRecordList<ST_896e066bc5a2d27c8f6a276746e82800Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_896e066bc5a2d27c8f6a276746e82800Structure GetElementDefaultValue() {
return new ST_896e066bc5a2d27c8f6a276746e82800Structure();
}

public T[] ToArray<T>(Func<ST_896e066bc5a2d27c8f6a276746e82800Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a60626c1780bfe250dcef75d5dfa5fd1 recordList, Func<ST_896e066bc5a2d27c8f6a276746e82800Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a60626c1780bfe250dcef75d5dfa5fd1(ST_896e066bc5a2d27c8f6a276746e82800Structure[] array) {
  RL_a60626c1780bfe250dcef75d5dfa5fd1 result = new RL_a60626c1780bfe250dcef75d5dfa5fd1();
result.InnerFromArray(array);
    return result;
}

public static RL_a60626c1780bfe250dcef75d5dfa5fd1 ToList<T>(T[] array, Func <T, ST_896e066bc5a2d27c8f6a276746e82800Structure> converter) {
  RL_a60626c1780bfe250dcef75d5dfa5fd1 result = new RL_a60626c1780bfe250dcef75d5dfa5fd1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a60626c1780bfe250dcef75d5dfa5fd1 FromRestList<T>(RestList<T> restList, Func <T, ST_896e066bc5a2d27c8f6a276746e82800Structure> converter) {
  RL_a60626c1780bfe250dcef75d5dfa5fd1 result = new RL_a60626c1780bfe250dcef75d5dfa5fd1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a60626c1780bfe250dcef75d5dfa5fd1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_896e066bc5a2d27c8f6a276746e82800Structure> NewList() {
return new RL_a60626c1780bfe250dcef75d5dfa5fd1();
}


} // RL_a60626c1780bfe250dcef75d5dfa5fd1
}

