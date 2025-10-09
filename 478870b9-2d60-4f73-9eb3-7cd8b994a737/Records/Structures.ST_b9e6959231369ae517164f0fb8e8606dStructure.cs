namespace ssSystem_ {
/// <summary>
/// [Structure] PasswordValidationResult (A9EPP8zYdEi2owUr_VpQ+Q)
///  <code>ST_b9e6959231369ae517164f0fb8e8606dStructure</code> that represent
/// s <code>PasswordValidationResult</code> <p>Description: </p>
/// </summary>
// Name: PasswordValidationResult
public partial struct ST_b9e6959231369ae517164f0fb8e8606dStructure : ITypedRecord<ST_b9e6959231369ae517164f0fb8e8606dStructure> {
internal static readonly GlobalObjectKey IdIsValid = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*zrqhEFeNJEq28qn+4AOnBQ");
internal static readonly GlobalObjectKey IdMissingLowerCaseLetter = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*1kmmwVQpzEeTfdcx+LXBHA");
internal static readonly GlobalObjectKey IdMissingMinimumLength = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*bC6pfd2M3EKKqAPOFIEDLA");
internal static readonly GlobalObjectKey IdMissingUpperCaseLetter = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*Vy_B_4Mf4EOG2q9TqttE7Q");
internal static readonly GlobalObjectKey IdMissingNumber = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*6t3h6lhXbky5ejSeZQ41pA");
internal static readonly GlobalObjectKey IdMissingSpecialCharacter = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*t51jGv1oBkKNt9ecsXoeIw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("IsValid")]
public bool ssIsValid;

[System.Xml.Serialization.XmlElement("MissingLowerCaseLetter")]
public bool ssMissingLowerCaseLetter;

[System.Xml.Serialization.XmlElement("MissingMinimumLength")]
public bool ssMissingMinimumLength;

[System.Xml.Serialization.XmlElement("MissingUpperCaseLetter")]
public bool ssMissingUpperCaseLetter;

[System.Xml.Serialization.XmlElement("MissingNumber")]
public bool ssMissingNumber;

[System.Xml.Serialization.XmlElement("MissingSpecialCharacter")]
public bool ssMissingSpecialCharacter;


public BitArray OptimizedAttributes;

public ST_b9e6959231369ae517164f0fb8e8606dStructure() {
OptimizedAttributes = null;
ssIsValid = false;
ssMissingLowerCaseLetter = false;
ssMissingMinimumLength = false;
ssMissingUpperCaseLetter = false;
ssMissingNumber = false;
ssMissingSpecialCharacter = false;
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
ssIsValid = r.ReadBoolean(index++, "PasswordValidationResult.IsValid", false);
ssMissingLowerCaseLetter = r.ReadBoolean(index++, "PasswordValidationResult.MissingLowerCaseLetter", false);
ssMissingMinimumLength = r.ReadBoolean(index++, "PasswordValidationResult.MissingMinimumLength", false);
ssMissingUpperCaseLetter = r.ReadBoolean(index++, "PasswordValidationResult.MissingUpperCaseLetter", false);
ssMissingNumber = r.ReadBoolean(index++, "PasswordValidationResult.MissingNumber", false);
ssMissingSpecialCharacter = r.ReadBoolean(index++, "PasswordValidationResult.MissingSpecialCharacter", false);
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
public void ReadIM(ST_b9e6959231369ae517164f0fb8e8606dStructure r) {
this = r;
}


public static bool operator == (ST_b9e6959231369ae517164f0fb8e8606dStructure a, ST_b9e6959231369ae517164f0fb8e8606dStructure b) {
if (a.ssIsValid != b.ssIsValid) return false;
if (a.ssMissingLowerCaseLetter != b.ssMissingLowerCaseLetter) return false;
if (a.ssMissingMinimumLength != b.ssMissingMinimumLength) return false;
if (a.ssMissingUpperCaseLetter != b.ssMissingUpperCaseLetter) return false;
if (a.ssMissingNumber != b.ssMissingNumber) return false;
if (a.ssMissingSpecialCharacter != b.ssMissingSpecialCharacter) return false;
return true;
}

public static bool operator != (ST_b9e6959231369ae517164f0fb8e8606dStructure a, ST_b9e6959231369ae517164f0fb8e8606dStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b9e6959231369ae517164f0fb8e8606dStructure)) return false;
return (this == (ST_b9e6959231369ae517164f0fb8e8606dStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssIsValid.GetHashCode()
 ^ ssMissingLowerCaseLetter.GetHashCode()
 ^ ssMissingMinimumLength.GetHashCode()
 ^ ssMissingUpperCaseLetter.GetHashCode()
 ^ ssMissingNumber.GetHashCode()
 ^ ssMissingSpecialCharacter.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_b9e6959231369ae517164f0fb8e8606dStructure Duplicate() {
ST_b9e6959231369ae517164f0fb8e8606dStructure t;
t.ssIsValid = this.ssIsValid;
t.ssMissingLowerCaseLetter = this.ssMissingLowerCaseLetter;
t.ssMissingMinimumLength = this.ssMissingMinimumLength;
t.ssMissingUpperCaseLetter = this.ssMissingUpperCaseLetter;
t.ssMissingNumber = this.ssMissingNumber;
t.ssMissingSpecialCharacter = this.ssMissingSpecialCharacter;
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
if (head == "isvalid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsValid")) variable.Value = ssIsValid; else variable.Optimized = true;
} else if (head == "missinglowercaseletter") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MissingLowerCaseLetter")) variable.Value = ssMissingLowerCaseLetter; else variable.Optimized = true;
} else if (head == "missingminimumlength") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MissingMinimumLength")) variable.Value = ssMissingMinimumLength; else variable.Optimized = true;
} else if (head == "missinguppercaseletter") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MissingUpperCaseLetter")) variable.Value = ssMissingUpperCaseLetter; else variable.Optimized = true;
} else if (head == "missingnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MissingNumber")) variable.Value = ssMissingNumber; else variable.Optimized = true;
} else if (head == "missingspecialcharacter") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MissingSpecialCharacter")) variable.Value = ssMissingSpecialCharacter; else variable.Optimized = true;
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
if (key == IdIsValid) {
return ssIsValid;
}
if (key == IdMissingLowerCaseLetter) {
return ssMissingLowerCaseLetter;
}
if (key == IdMissingMinimumLength) {
return ssMissingMinimumLength;
}
if (key == IdMissingUpperCaseLetter) {
return ssMissingUpperCaseLetter;
}
if (key == IdMissingNumber) {
return ssMissingNumber;
}
if (key == IdMissingSpecialCharacter) {
return ssMissingSpecialCharacter;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIsValid.Key.AsGuid) {
return ssIsValid;
}
if (attributeKey == IdMissingLowerCaseLetter.Key.AsGuid) {
return ssMissingLowerCaseLetter;
}
if (attributeKey == IdMissingMinimumLength.Key.AsGuid) {
return ssMissingMinimumLength;
}
if (attributeKey == IdMissingUpperCaseLetter.Key.AsGuid) {
return ssMissingUpperCaseLetter;
}
if (attributeKey == IdMissingNumber.Key.AsGuid) {
return ssMissingNumber;
}
if (attributeKey == IdMissingSpecialCharacter.Key.AsGuid) {
return ssMissingSpecialCharacter;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssIsValid = (bool) other.AttributeGet(IdIsValid);
ssMissingLowerCaseLetter = (bool) other.AttributeGet(IdMissingLowerCaseLetter);
ssMissingMinimumLength = (bool) other.AttributeGet(IdMissingMinimumLength);
ssMissingUpperCaseLetter = (bool) other.AttributeGet(IdMissingUpperCaseLetter);
ssMissingNumber = (bool) other.AttributeGet(IdMissingNumber);
ssMissingSpecialCharacter = (bool) other.AttributeGet(IdMissingSpecialCharacter);
}
} // ST_b9e6959231369ae517164f0fb8e8606dStructure
/// <summary>
/// RecordList type <code>PasswordValidationResultList</code> that represents a record list of
///  <code>PasswordValidationResult</code>
/// </summary>
public partial class RL_e57523dcca7e6d3766c4721a0ef109ee : GenericRecordList<ST_b9e6959231369ae517164f0fb8e8606dStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_b9e6959231369ae517164f0fb8e8606dStructure GetElementDefaultValue() {
return new ST_b9e6959231369ae517164f0fb8e8606dStructure();
}

public T[] ToArray<T>(Func<ST_b9e6959231369ae517164f0fb8e8606dStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e57523dcca7e6d3766c4721a0ef109ee recordList, Func<ST_b9e6959231369ae517164f0fb8e8606dStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e57523dcca7e6d3766c4721a0ef109ee(ST_b9e6959231369ae517164f0fb8e8606dStructure[] array) {
  RL_e57523dcca7e6d3766c4721a0ef109ee result = new RL_e57523dcca7e6d3766c4721a0ef109ee();
result.InnerFromArray(array);
    return result;
}

public static RL_e57523dcca7e6d3766c4721a0ef109ee ToList<T>(T[] array, Func <T, ST_b9e6959231369ae517164f0fb8e8606dStructure> converter) {
  RL_e57523dcca7e6d3766c4721a0ef109ee result = new RL_e57523dcca7e6d3766c4721a0ef109ee();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e57523dcca7e6d3766c4721a0ef109ee FromRestList<T>(RestList<T> restList, Func <T, ST_b9e6959231369ae517164f0fb8e8606dStructure> converter) {
  RL_e57523dcca7e6d3766c4721a0ef109ee result = new RL_e57523dcca7e6d3766c4721a0ef109ee();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e57523dcca7e6d3766c4721a0ef109ee() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b9e6959231369ae517164f0fb8e8606dStructure> NewList() {
return new RL_e57523dcca7e6d3766c4721a0ef109ee();
}


} // RL_e57523dcca7e6d3766c4721a0ef109ee
}

