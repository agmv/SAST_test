namespace ssSystem_ {
/// <summary>
/// [Structure] UpdateUserResult (Xavb1l+gbkSh78PH1asAYg)
///  <code>ST_c57cc6bedbdc9e62046393fa735672cfStructure</code> that represent
/// s <code>UpdateUserResult</code> <p>Description: Result of the update user action. Returns the
///  failure reason if unsuccessful.</p>
/// </summary>
// Name: UpdateUserResult
public partial struct ST_c57cc6bedbdc9e62046393fa735672cfStructure : ITypedRecord<ST_c57cc6bedbdc9e62046393fa735672cfStructure> {
internal static readonly GlobalObjectKey IdSuccess = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*Mce_L2t3D0iCnh_v9m6wUA");
internal static readonly GlobalObjectKey IdUserPhotoURL = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*vIUgPPeSSEKoxIopbU1icQ");
internal static readonly GlobalObjectKey IdUpdateUserFailureReason = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*bOg3Aj8lwkmU87GJHH5WHg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Success")]
public bool ssSuccess;

[System.Xml.Serialization.XmlElement("UserPhotoURL")]
public string ssUserPhotoURL;

[System.Xml.Serialization.XmlElement("UpdateUserFailureReason")]
public ST_6f88d6be05f2234ba151435ee8bf2cd4Structure ssUpdateUserFailureReason;


public BitArray OptimizedAttributes;

public ST_c57cc6bedbdc9e62046393fa735672cfStructure() {
OptimizedAttributes = null;
ssSuccess = false;
ssUserPhotoURL = "";
ssUpdateUserFailureReason = new ST_6f88d6be05f2234ba151435ee8bf2cd4Structure();
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
    ssUpdateUserFailureReason.OptimizedAttributes = value[0];
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
ssSuccess = r.ReadBoolean(index++, "UpdateUserResult.Success", false);
ssUserPhotoURL = r.ReadText(index++, "UpdateUserResult.UserPhotoURL", "");
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
public void ReadIM(ST_c57cc6bedbdc9e62046393fa735672cfStructure r) {
this = r;
}


public static bool operator == (ST_c57cc6bedbdc9e62046393fa735672cfStructure a, ST_c57cc6bedbdc9e62046393fa735672cfStructure b) {
if (a.ssSuccess != b.ssSuccess) return false;
if (a.ssUserPhotoURL != b.ssUserPhotoURL) return false;
if (a.ssUpdateUserFailureReason != b.ssUpdateUserFailureReason) return false;
return true;
}

public static bool operator != (ST_c57cc6bedbdc9e62046393fa735672cfStructure a, ST_c57cc6bedbdc9e62046393fa735672cfStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_c57cc6bedbdc9e62046393fa735672cfStructure)) return false;
return (this == (ST_c57cc6bedbdc9e62046393fa735672cfStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSuccess.GetHashCode()
 ^ ssUserPhotoURL.GetHashCode()
 ^ ssUpdateUserFailureReason.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssUpdateUserFailureReason.RecursiveReset();
}

public void InternalRecursiveSave() {
ssUpdateUserFailureReason.InternalRecursiveSave();
}


public ST_c57cc6bedbdc9e62046393fa735672cfStructure Duplicate() {
ST_c57cc6bedbdc9e62046393fa735672cfStructure t;
t.ssSuccess = this.ssSuccess;
t.ssUserPhotoURL = this.ssUserPhotoURL;
t.ssUpdateUserFailureReason = (ST_6f88d6be05f2234ba151435ee8bf2cd4Structure)this.ssUpdateUserFailureReason.Duplicate();
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
} else if (head == "userphotourl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserPhotoURL")) variable.Value = ssUserPhotoURL; else variable.Optimized = true;
} else if (head == "updateuserfailurereason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateUserFailureReason")) variable.Value = ssUpdateUserFailureReason; else variable.Optimized = true;
variable.SetFieldName("updateuserfailurereason");
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
if (key == IdUserPhotoURL) {
return ssUserPhotoURL;
}
if (key == IdUpdateUserFailureReason) {
return ssUpdateUserFailureReason;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSuccess.Key.AsGuid) {
return ssSuccess;
}
if (attributeKey == IdUserPhotoURL.Key.AsGuid) {
return ssUserPhotoURL;
}
if (attributeKey == IdUpdateUserFailureReason.Key.AsGuid) {
return ssUpdateUserFailureReason;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSuccess = (bool) other.AttributeGet(IdSuccess);
ssUserPhotoURL = (string) other.AttributeGet(IdUserPhotoURL);
ssUpdateUserFailureReason.FillFromOther((IRecord) other.AttributeGet(IdUpdateUserFailureReason));
}
} // ST_c57cc6bedbdc9e62046393fa735672cfStructure
/// <summary>
/// RecordList type <code>UpdateUserResultList</code> that represents a record list of
///  <code>UpdateUserResult</code>
/// </summary>
public partial class RL_36d4d7e2109bafadf398450826580bed : GenericRecordList<ST_c57cc6bedbdc9e62046393fa735672cfStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_c57cc6bedbdc9e62046393fa735672cfStructure GetElementDefaultValue() {
return new ST_c57cc6bedbdc9e62046393fa735672cfStructure();
}

public T[] ToArray<T>(Func<ST_c57cc6bedbdc9e62046393fa735672cfStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_36d4d7e2109bafadf398450826580bed recordList, Func<ST_c57cc6bedbdc9e62046393fa735672cfStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_36d4d7e2109bafadf398450826580bed(ST_c57cc6bedbdc9e62046393fa735672cfStructure[] array) {
  RL_36d4d7e2109bafadf398450826580bed result = new RL_36d4d7e2109bafadf398450826580bed();
result.InnerFromArray(array);
    return result;
}

public static RL_36d4d7e2109bafadf398450826580bed ToList<T>(T[] array, Func <T, ST_c57cc6bedbdc9e62046393fa735672cfStructure> converter) {
  RL_36d4d7e2109bafadf398450826580bed result = new RL_36d4d7e2109bafadf398450826580bed();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_36d4d7e2109bafadf398450826580bed FromRestList<T>(RestList<T> restList, Func <T, ST_c57cc6bedbdc9e62046393fa735672cfStructure> converter) {
  RL_36d4d7e2109bafadf398450826580bed result = new RL_36d4d7e2109bafadf398450826580bed();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_36d4d7e2109bafadf398450826580bed() : base() {
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
protected override OSList<ST_c57cc6bedbdc9e62046393fa735672cfStructure> NewList() {
return new RL_36d4d7e2109bafadf398450826580bed();
}


} // RL_36d4d7e2109bafadf398450826580bed
}

