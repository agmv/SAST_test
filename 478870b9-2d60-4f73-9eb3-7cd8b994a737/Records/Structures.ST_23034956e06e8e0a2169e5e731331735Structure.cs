namespace ssSystem_ {
/// <summary>
/// [Structure] FinishUpdateEmailFailureReason (b5mSd4ZSaU2PNoITAB0b1A)
///  <code>ST_23034956e06e8e0a2169e5e731331735Structure</code> that represent
/// s <code>FinishUpdateEmailFailureReason</code> <p>Description: Failure reason structure. Contains
///  the reason for failure if the action is not successful.</p>
/// </summary>
// Name: FinishUpdateEmailFailureReason
public partial struct ST_23034956e06e8e0a2169e5e731331735Structure : ITypedRecord<ST_23034956e06e8e0a2169e5e731331735Structure> {
internal static readonly GlobalObjectKey IdInvalidVerificationCode = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*upK9FpY8UESbg2eaDVawAg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("InvalidVerificationCode")]
public bool ssInvalidVerificationCode;


public BitArray OptimizedAttributes;

public ST_23034956e06e8e0a2169e5e731331735Structure() {
OptimizedAttributes = null;
ssInvalidVerificationCode = false;
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
ssInvalidVerificationCode = r.ReadBoolean(index++, "FinishUpdateEmailFailureReason.InvalidVerificationCode", false);
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
public void ReadIM(ST_23034956e06e8e0a2169e5e731331735Structure r) {
this = r;
}


public static bool operator == (ST_23034956e06e8e0a2169e5e731331735Structure a, ST_23034956e06e8e0a2169e5e731331735Structure b) {
if (a.ssInvalidVerificationCode != b.ssInvalidVerificationCode) return false;
return true;
}

public static bool operator != (ST_23034956e06e8e0a2169e5e731331735Structure a, ST_23034956e06e8e0a2169e5e731331735Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_23034956e06e8e0a2169e5e731331735Structure)) return false;
return (this == (ST_23034956e06e8e0a2169e5e731331735Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvalidVerificationCode.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_23034956e06e8e0a2169e5e731331735Structure Duplicate() {
ST_23034956e06e8e0a2169e5e731331735Structure t;
t.ssInvalidVerificationCode = this.ssInvalidVerificationCode;
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvalidVerificationCode.Key.AsGuid) {
return ssInvalidVerificationCode;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInvalidVerificationCode = (bool) other.AttributeGet(IdInvalidVerificationCode);
}
} // ST_23034956e06e8e0a2169e5e731331735Structure
/// <summary>
/// RecordList type <code>FinishUpdateEmailFailureReasonList</code> that represents a record list of
///  <code>FinishUpdateEmailFailureReason</code>
/// </summary>
public partial class RL_7fc4b41472273e30810db8605733082c : GenericRecordList<ST_23034956e06e8e0a2169e5e731331735Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_23034956e06e8e0a2169e5e731331735Structure GetElementDefaultValue() {
return new ST_23034956e06e8e0a2169e5e731331735Structure();
}

public T[] ToArray<T>(Func<ST_23034956e06e8e0a2169e5e731331735Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7fc4b41472273e30810db8605733082c recordList, Func<ST_23034956e06e8e0a2169e5e731331735Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7fc4b41472273e30810db8605733082c(ST_23034956e06e8e0a2169e5e731331735Structure[] array) {
  RL_7fc4b41472273e30810db8605733082c result = new RL_7fc4b41472273e30810db8605733082c();
result.InnerFromArray(array);
    return result;
}

public static RL_7fc4b41472273e30810db8605733082c ToList<T>(T[] array, Func <T, ST_23034956e06e8e0a2169e5e731331735Structure> converter) {
  RL_7fc4b41472273e30810db8605733082c result = new RL_7fc4b41472273e30810db8605733082c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7fc4b41472273e30810db8605733082c FromRestList<T>(RestList<T> restList, Func <T, ST_23034956e06e8e0a2169e5e731331735Structure> converter) {
  RL_7fc4b41472273e30810db8605733082c result = new RL_7fc4b41472273e30810db8605733082c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7fc4b41472273e30810db8605733082c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_23034956e06e8e0a2169e5e731331735Structure> NewList() {
return new RL_7fc4b41472273e30810db8605733082c();
}


} // RL_7fc4b41472273e30810db8605733082c
}

