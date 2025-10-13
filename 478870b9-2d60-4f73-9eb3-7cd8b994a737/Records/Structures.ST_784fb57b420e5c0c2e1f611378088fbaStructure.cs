namespace ssSystem_ {
/// <summary>
/// [Structure] UserLoginResult (m+QTu624jEKHFldxwv4zIQ)
///  <code>ST_784fb57b420e5c0c2e1f611378088fbaStructure</code> that represent
/// s <code>UserLoginResult</code> <p>Description: </p>
/// </summary>
// Name: UserLoginResult
public partial struct ST_784fb57b420e5c0c2e1f611378088fbaStructure : ITypedRecord<ST_784fb57b420e5c0c2e1f611378088fbaStructure> {
internal static readonly GlobalObjectKey IdRetryAfterSeconds = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*yCnS70dQi0ene9m7gInItA");
internal static readonly GlobalObjectKey IdSuccess = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*gA_uzV3zjkC42HgHAoi9Mg");
internal static readonly GlobalObjectKey IdUserId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*1GuAKWbS0kGApNwYqAvk8w");
internal static readonly GlobalObjectKey IdUserLoginFailureReason = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*FG0_9q4l_06tG23M9YHlaA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("RetryAfterSeconds")]
public int ssRetryAfterSeconds;

[System.Xml.Serialization.XmlElement("Success")]
public bool ssSuccess;

[System.Xml.Serialization.XmlElement("UserId")]
public string ssUserId;

[System.Xml.Serialization.XmlElement("UserLoginFailureReason")]
public ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure ssUserLoginFailureReason;


public BitArray OptimizedAttributes;

public ST_784fb57b420e5c0c2e1f611378088fbaStructure() {
OptimizedAttributes = null;
ssRetryAfterSeconds = 0;
ssSuccess = false;
ssUserId = "";
ssUserLoginFailureReason = new ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure();
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
    ssUserLoginFailureReason.OptimizedAttributes = value[0];
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
ssRetryAfterSeconds = r.ReadInteger(index++, "UserLoginResult.RetryAfterSeconds", 0);
ssSuccess = r.ReadBoolean(index++, "UserLoginResult.Success", false);
ssUserId = r.ReadEntityReferenceText(index++, "UserLoginResult.UserId", "");
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
public void ReadIM(ST_784fb57b420e5c0c2e1f611378088fbaStructure r) {
this = r;
}


public static bool operator == (ST_784fb57b420e5c0c2e1f611378088fbaStructure a, ST_784fb57b420e5c0c2e1f611378088fbaStructure b) {
if (a.ssRetryAfterSeconds != b.ssRetryAfterSeconds) return false;
if (a.ssSuccess != b.ssSuccess) return false;
if (a.ssUserId != b.ssUserId) return false;
if (a.ssUserLoginFailureReason != b.ssUserLoginFailureReason) return false;
return true;
}

public static bool operator != (ST_784fb57b420e5c0c2e1f611378088fbaStructure a, ST_784fb57b420e5c0c2e1f611378088fbaStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_784fb57b420e5c0c2e1f611378088fbaStructure)) return false;
return (this == (ST_784fb57b420e5c0c2e1f611378088fbaStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssRetryAfterSeconds.GetHashCode()
 ^ ssSuccess.GetHashCode()
 ^ ssUserId.GetHashCode()
 ^ ssUserLoginFailureReason.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssUserLoginFailureReason.RecursiveReset();
}

public void InternalRecursiveSave() {
ssUserLoginFailureReason.InternalRecursiveSave();
}


public ST_784fb57b420e5c0c2e1f611378088fbaStructure Duplicate() {
ST_784fb57b420e5c0c2e1f611378088fbaStructure t;
t.ssRetryAfterSeconds = this.ssRetryAfterSeconds;
t.ssSuccess = this.ssSuccess;
t.ssUserId = this.ssUserId;
t.ssUserLoginFailureReason = (ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure)this.ssUserLoginFailureReason.Duplicate();
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
if (head == "retryafterseconds") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RetryAfterSeconds")) variable.Value = ssRetryAfterSeconds; else variable.Optimized = true;
} else if (head == "success") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Success")) variable.Value = ssSuccess; else variable.Optimized = true;
} else if (head == "userid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserId")) variable.Value = ssUserId; else variable.Optimized = true;
} else if (head == "userloginfailurereason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserLoginFailureReason")) variable.Value = ssUserLoginFailureReason; else variable.Optimized = true;
variable.SetFieldName("userloginfailurereason");
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
if (key == IdRetryAfterSeconds) {
return ssRetryAfterSeconds;
}
if (key == IdSuccess) {
return ssSuccess;
}
if (key == IdUserId) {
return ssUserId;
}
if (key == IdUserLoginFailureReason) {
return ssUserLoginFailureReason;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRetryAfterSeconds.Key.AsGuid) {
return ssRetryAfterSeconds;
}
if (attributeKey == IdSuccess.Key.AsGuid) {
return ssSuccess;
}
if (attributeKey == IdUserId.Key.AsGuid) {
return ssUserId;
}
if (attributeKey == IdUserLoginFailureReason.Key.AsGuid) {
return ssUserLoginFailureReason;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssRetryAfterSeconds = (int) other.AttributeGet(IdRetryAfterSeconds);
ssSuccess = (bool) other.AttributeGet(IdSuccess);
ssUserId = (string) other.AttributeGet(IdUserId);
ssUserLoginFailureReason.FillFromOther((IRecord) other.AttributeGet(IdUserLoginFailureReason));
}
} // ST_784fb57b420e5c0c2e1f611378088fbaStructure
/// <summary>
/// RecordList type <code>UserLoginResultList</code> that represents a record list of
///  <code>UserLoginResult</code>
/// </summary>
public partial class RL_bfe5e088b2f6df6ae697d4a263069bca : GenericRecordList<ST_784fb57b420e5c0c2e1f611378088fbaStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_784fb57b420e5c0c2e1f611378088fbaStructure GetElementDefaultValue() {
return new ST_784fb57b420e5c0c2e1f611378088fbaStructure();
}

public T[] ToArray<T>(Func<ST_784fb57b420e5c0c2e1f611378088fbaStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bfe5e088b2f6df6ae697d4a263069bca recordList, Func<ST_784fb57b420e5c0c2e1f611378088fbaStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bfe5e088b2f6df6ae697d4a263069bca(ST_784fb57b420e5c0c2e1f611378088fbaStructure[] array) {
  RL_bfe5e088b2f6df6ae697d4a263069bca result = new RL_bfe5e088b2f6df6ae697d4a263069bca();
result.InnerFromArray(array);
    return result;
}

public static RL_bfe5e088b2f6df6ae697d4a263069bca ToList<T>(T[] array, Func <T, ST_784fb57b420e5c0c2e1f611378088fbaStructure> converter) {
  RL_bfe5e088b2f6df6ae697d4a263069bca result = new RL_bfe5e088b2f6df6ae697d4a263069bca();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bfe5e088b2f6df6ae697d4a263069bca FromRestList<T>(RestList<T> restList, Func <T, ST_784fb57b420e5c0c2e1f611378088fbaStructure> converter) {
  RL_bfe5e088b2f6df6ae697d4a263069bca result = new RL_bfe5e088b2f6df6ae697d4a263069bca();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bfe5e088b2f6df6ae697d4a263069bca() : base() {
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
protected override OSList<ST_784fb57b420e5c0c2e1f611378088fbaStructure> NewList() {
return new RL_bfe5e088b2f6df6ae697d4a263069bca();
}


} // RL_bfe5e088b2f6df6ae697d4a263069bca
}

