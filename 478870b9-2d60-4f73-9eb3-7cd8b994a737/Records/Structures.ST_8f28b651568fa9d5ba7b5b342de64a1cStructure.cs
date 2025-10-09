namespace ssSystem_ {
/// <summary>
/// [Structure] StartUserRegistrationFailureReason (pT1OqexG2kuob61ZFcgEAw)
///  <code>ST_8f28b651568fa9d5ba7b5b342de64a1cStructure</code> that represent
/// s <code>StartUserRegistrationFailureReason</code> <p>Description: Failure reason structure.
///  Contains the reason for failure if the action isn't successful.</p>
/// </summary>
// Name: StartUserRegistrationFailureReason
public partial struct ST_8f28b651568fa9d5ba7b5b342de64a1cStructure : ITypedRecord<ST_8f28b651568fa9d5ba7b5b342de64a1cStructure> {
internal static readonly GlobalObjectKey IdInvalidEmail = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*u92VfJjiBEe0aMAENlqxkQ");
internal static readonly GlobalObjectKey IdInvalidName = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*4P6oj5xZh02faEy8Aq4sVg");
internal static readonly GlobalObjectKey IdUserAlreadyRegistered = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*RBRuAsYkskWuO9kuiVQdcw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("InvalidEmail")]
public bool ssInvalidEmail;

[System.Xml.Serialization.XmlElement("InvalidName")]
public bool ssInvalidName;

[System.Xml.Serialization.XmlElement("UserAlreadyRegistered")]
public bool ssUserAlreadyRegistered;


public BitArray OptimizedAttributes;

public ST_8f28b651568fa9d5ba7b5b342de64a1cStructure() {
OptimizedAttributes = null;
ssInvalidEmail = false;
ssInvalidName = false;
ssUserAlreadyRegistered = false;
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
ssInvalidEmail = r.ReadBoolean(index++, "StartUserRegistrationFailureReason.InvalidEmail", false);
ssInvalidName = r.ReadBoolean(index++, "StartUserRegistrationFailureReason.InvalidName", false);
ssUserAlreadyRegistered = r.ReadBoolean(index++, "StartUserRegistrationFailureReason.UserAlreadyRegistered", false);
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
public void ReadIM(ST_8f28b651568fa9d5ba7b5b342de64a1cStructure r) {
this = r;
}


public static bool operator == (ST_8f28b651568fa9d5ba7b5b342de64a1cStructure a, ST_8f28b651568fa9d5ba7b5b342de64a1cStructure b) {
if (a.ssInvalidEmail != b.ssInvalidEmail) return false;
if (a.ssInvalidName != b.ssInvalidName) return false;
if (a.ssUserAlreadyRegistered != b.ssUserAlreadyRegistered) return false;
return true;
}

public static bool operator != (ST_8f28b651568fa9d5ba7b5b342de64a1cStructure a, ST_8f28b651568fa9d5ba7b5b342de64a1cStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_8f28b651568fa9d5ba7b5b342de64a1cStructure)) return false;
return (this == (ST_8f28b651568fa9d5ba7b5b342de64a1cStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvalidEmail.GetHashCode()
 ^ ssInvalidName.GetHashCode()
 ^ ssUserAlreadyRegistered.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_8f28b651568fa9d5ba7b5b342de64a1cStructure Duplicate() {
ST_8f28b651568fa9d5ba7b5b342de64a1cStructure t;
t.ssInvalidEmail = this.ssInvalidEmail;
t.ssInvalidName = this.ssInvalidName;
t.ssUserAlreadyRegistered = this.ssUserAlreadyRegistered;
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
if (head == "invalidemail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvalidEmail")) variable.Value = ssInvalidEmail; else variable.Optimized = true;
} else if (head == "invalidname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvalidName")) variable.Value = ssInvalidName; else variable.Optimized = true;
} else if (head == "useralreadyregistered") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserAlreadyRegistered")) variable.Value = ssUserAlreadyRegistered; else variable.Optimized = true;
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
if (key == IdInvalidEmail) {
return ssInvalidEmail;
}
if (key == IdInvalidName) {
return ssInvalidName;
}
if (key == IdUserAlreadyRegistered) {
return ssUserAlreadyRegistered;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvalidEmail.Key.AsGuid) {
return ssInvalidEmail;
}
if (attributeKey == IdInvalidName.Key.AsGuid) {
return ssInvalidName;
}
if (attributeKey == IdUserAlreadyRegistered.Key.AsGuid) {
return ssUserAlreadyRegistered;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInvalidEmail = (bool) other.AttributeGet(IdInvalidEmail);
ssInvalidName = (bool) other.AttributeGet(IdInvalidName);
ssUserAlreadyRegistered = (bool) other.AttributeGet(IdUserAlreadyRegistered);
}
} // ST_8f28b651568fa9d5ba7b5b342de64a1cStructure
/// <summary>
/// RecordList type <code>StartUserRegistrationFailureReasonList</code> that represents a record list
///  of <code>StartUserRegistrationFailureReason</code>
/// </summary>
public partial class RL_aad032b1e33509d2ba60156a32583c0e : GenericRecordList<ST_8f28b651568fa9d5ba7b5b342de64a1cStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_8f28b651568fa9d5ba7b5b342de64a1cStructure GetElementDefaultValue() {
return new ST_8f28b651568fa9d5ba7b5b342de64a1cStructure();
}

public T[] ToArray<T>(Func<ST_8f28b651568fa9d5ba7b5b342de64a1cStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_aad032b1e33509d2ba60156a32583c0e recordList, Func<ST_8f28b651568fa9d5ba7b5b342de64a1cStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_aad032b1e33509d2ba60156a32583c0e(ST_8f28b651568fa9d5ba7b5b342de64a1cStructure[] array) {
  RL_aad032b1e33509d2ba60156a32583c0e result = new RL_aad032b1e33509d2ba60156a32583c0e();
result.InnerFromArray(array);
    return result;
}

public static RL_aad032b1e33509d2ba60156a32583c0e ToList<T>(T[] array, Func <T, ST_8f28b651568fa9d5ba7b5b342de64a1cStructure> converter) {
  RL_aad032b1e33509d2ba60156a32583c0e result = new RL_aad032b1e33509d2ba60156a32583c0e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_aad032b1e33509d2ba60156a32583c0e FromRestList<T>(RestList<T> restList, Func <T, ST_8f28b651568fa9d5ba7b5b342de64a1cStructure> converter) {
  RL_aad032b1e33509d2ba60156a32583c0e result = new RL_aad032b1e33509d2ba60156a32583c0e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_aad032b1e33509d2ba60156a32583c0e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_8f28b651568fa9d5ba7b5b342de64a1cStructure> NewList() {
return new RL_aad032b1e33509d2ba60156a32583c0e();
}


} // RL_aad032b1e33509d2ba60156a32583c0e
}

