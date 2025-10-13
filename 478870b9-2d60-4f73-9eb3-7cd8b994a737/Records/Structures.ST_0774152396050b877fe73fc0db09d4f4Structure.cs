namespace ssSystem_ {
/// <summary>
/// [Structure] PasswordComplexityPolicy (Nvd_KYklcE2F6m+uP7jlsg)
///  <code>ST_0774152396050b877fe73fc0db09d4f4Structure</code> that represent
/// s <code>PasswordComplexityPolicy</code> <p>Description: </p>
/// </summary>
// Name: PasswordComplexityPolicy
public partial struct ST_0774152396050b877fe73fc0db09d4f4Structure : ITypedRecord<ST_0774152396050b877fe73fc0db09d4f4Structure> {
internal static readonly GlobalObjectKey IdMinimumLength = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*UMs7PILoeUGaJkQMhxWlVQ");
internal static readonly GlobalObjectKey IdUpperCaseLetterRequired = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*28YtGmOD5USVH_TbGEbbiQ");
internal static readonly GlobalObjectKey IdLowerCaseLetterRequired = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*T5Kxr9XhjU+ieo5tIKUH+g");
internal static readonly GlobalObjectKey IdNumberRequired = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*mQjGQ3zbLU+9TDy1d2cSJg");
internal static readonly GlobalObjectKey IdSpecialCharacterRequired = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*j1pA3RMA9UmMRYkLLoZ2XQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("MinimumLength")]
public int ssMinimumLength;

[System.Xml.Serialization.XmlElement("UpperCaseLetterRequired")]
public bool ssUpperCaseLetterRequired;

[System.Xml.Serialization.XmlElement("LowerCaseLetterRequired")]
public bool ssLowerCaseLetterRequired;

[System.Xml.Serialization.XmlElement("NumberRequired")]
public bool ssNumberRequired;

[System.Xml.Serialization.XmlElement("SpecialCharacterRequired")]
public bool ssSpecialCharacterRequired;


public BitArray OptimizedAttributes;

public ST_0774152396050b877fe73fc0db09d4f4Structure() {
OptimizedAttributes = null;
ssMinimumLength = 0;
ssUpperCaseLetterRequired = false;
ssLowerCaseLetterRequired = false;
ssNumberRequired = false;
ssSpecialCharacterRequired = false;
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
ssMinimumLength = r.ReadInteger(index++, "PasswordComplexityPolicy.MinimumLength", 0);
ssUpperCaseLetterRequired = r.ReadBoolean(index++, "PasswordComplexityPolicy.UpperCaseLetterRequired", false);
ssLowerCaseLetterRequired = r.ReadBoolean(index++, "PasswordComplexityPolicy.LowerCaseLetterRequired", false);
ssNumberRequired = r.ReadBoolean(index++, "PasswordComplexityPolicy.NumberRequired", false);
ssSpecialCharacterRequired = r.ReadBoolean(index++, "PasswordComplexityPolicy.SpecialCharacterRequired", false);
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
public void ReadIM(ST_0774152396050b877fe73fc0db09d4f4Structure r) {
this = r;
}


public static bool operator == (ST_0774152396050b877fe73fc0db09d4f4Structure a, ST_0774152396050b877fe73fc0db09d4f4Structure b) {
if (a.ssMinimumLength != b.ssMinimumLength) return false;
if (a.ssUpperCaseLetterRequired != b.ssUpperCaseLetterRequired) return false;
if (a.ssLowerCaseLetterRequired != b.ssLowerCaseLetterRequired) return false;
if (a.ssNumberRequired != b.ssNumberRequired) return false;
if (a.ssSpecialCharacterRequired != b.ssSpecialCharacterRequired) return false;
return true;
}

public static bool operator != (ST_0774152396050b877fe73fc0db09d4f4Structure a, ST_0774152396050b877fe73fc0db09d4f4Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_0774152396050b877fe73fc0db09d4f4Structure)) return false;
return (this == (ST_0774152396050b877fe73fc0db09d4f4Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssMinimumLength.GetHashCode()
 ^ ssUpperCaseLetterRequired.GetHashCode()
 ^ ssLowerCaseLetterRequired.GetHashCode()
 ^ ssNumberRequired.GetHashCode()
 ^ ssSpecialCharacterRequired.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_0774152396050b877fe73fc0db09d4f4Structure Duplicate() {
ST_0774152396050b877fe73fc0db09d4f4Structure t;
t.ssMinimumLength = this.ssMinimumLength;
t.ssUpperCaseLetterRequired = this.ssUpperCaseLetterRequired;
t.ssLowerCaseLetterRequired = this.ssLowerCaseLetterRequired;
t.ssNumberRequired = this.ssNumberRequired;
t.ssSpecialCharacterRequired = this.ssSpecialCharacterRequired;
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
if (head == "minimumlength") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MinimumLength")) variable.Value = ssMinimumLength; else variable.Optimized = true;
} else if (head == "uppercaseletterrequired") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpperCaseLetterRequired")) variable.Value = ssUpperCaseLetterRequired; else variable.Optimized = true;
} else if (head == "lowercaseletterrequired") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LowerCaseLetterRequired")) variable.Value = ssLowerCaseLetterRequired; else variable.Optimized = true;
} else if (head == "numberrequired") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NumberRequired")) variable.Value = ssNumberRequired; else variable.Optimized = true;
} else if (head == "specialcharacterrequired") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SpecialCharacterRequired")) variable.Value = ssSpecialCharacterRequired; else variable.Optimized = true;
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
if (key == IdMinimumLength) {
return ssMinimumLength;
}
if (key == IdUpperCaseLetterRequired) {
return ssUpperCaseLetterRequired;
}
if (key == IdLowerCaseLetterRequired) {
return ssLowerCaseLetterRequired;
}
if (key == IdNumberRequired) {
return ssNumberRequired;
}
if (key == IdSpecialCharacterRequired) {
return ssSpecialCharacterRequired;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMinimumLength.Key.AsGuid) {
return ssMinimumLength;
}
if (attributeKey == IdUpperCaseLetterRequired.Key.AsGuid) {
return ssUpperCaseLetterRequired;
}
if (attributeKey == IdLowerCaseLetterRequired.Key.AsGuid) {
return ssLowerCaseLetterRequired;
}
if (attributeKey == IdNumberRequired.Key.AsGuid) {
return ssNumberRequired;
}
if (attributeKey == IdSpecialCharacterRequired.Key.AsGuid) {
return ssSpecialCharacterRequired;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssMinimumLength = (int) other.AttributeGet(IdMinimumLength);
ssUpperCaseLetterRequired = (bool) other.AttributeGet(IdUpperCaseLetterRequired);
ssLowerCaseLetterRequired = (bool) other.AttributeGet(IdLowerCaseLetterRequired);
ssNumberRequired = (bool) other.AttributeGet(IdNumberRequired);
ssSpecialCharacterRequired = (bool) other.AttributeGet(IdSpecialCharacterRequired);
}
} // ST_0774152396050b877fe73fc0db09d4f4Structure
/// <summary>
/// RecordList type <code>PasswordComplexityPolicyList</code> that represents a record list of
///  <code>PasswordComplexityPolicy</code>
/// </summary>
public partial class RL_f50879d0da007880fcd304f3378f0a9e : GenericRecordList<ST_0774152396050b877fe73fc0db09d4f4Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_0774152396050b877fe73fc0db09d4f4Structure GetElementDefaultValue() {
return new ST_0774152396050b877fe73fc0db09d4f4Structure();
}

public T[] ToArray<T>(Func<ST_0774152396050b877fe73fc0db09d4f4Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f50879d0da007880fcd304f3378f0a9e recordList, Func<ST_0774152396050b877fe73fc0db09d4f4Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f50879d0da007880fcd304f3378f0a9e(ST_0774152396050b877fe73fc0db09d4f4Structure[] array) {
  RL_f50879d0da007880fcd304f3378f0a9e result = new RL_f50879d0da007880fcd304f3378f0a9e();
result.InnerFromArray(array);
    return result;
}

public static RL_f50879d0da007880fcd304f3378f0a9e ToList<T>(T[] array, Func <T, ST_0774152396050b877fe73fc0db09d4f4Structure> converter) {
  RL_f50879d0da007880fcd304f3378f0a9e result = new RL_f50879d0da007880fcd304f3378f0a9e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f50879d0da007880fcd304f3378f0a9e FromRestList<T>(RestList<T> restList, Func <T, ST_0774152396050b877fe73fc0db09d4f4Structure> converter) {
  RL_f50879d0da007880fcd304f3378f0a9e result = new RL_f50879d0da007880fcd304f3378f0a9e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f50879d0da007880fcd304f3378f0a9e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_0774152396050b877fe73fc0db09d4f4Structure> NewList() {
return new RL_f50879d0da007880fcd304f3378f0a9e();
}


} // RL_f50879d0da007880fcd304f3378f0a9e
}

