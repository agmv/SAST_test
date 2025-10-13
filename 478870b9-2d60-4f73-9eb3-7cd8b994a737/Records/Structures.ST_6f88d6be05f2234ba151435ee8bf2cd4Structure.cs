namespace ssSystem_ {
/// <summary>
/// [Structure] UpdateUserFailureReason (L7Pogbpibku1boNBREfFxQ)
///  <code>ST_6f88d6be05f2234ba151435ee8bf2cd4Structure</code> that represent
/// s <code>UpdateUserFailureReason</code> <p>Description: Failure reason structure. Contains the
///  reason for failure if the action isn't successful.</p>
/// </summary>
// Name: UpdateUserFailureReason
public partial struct ST_6f88d6be05f2234ba151435ee8bf2cd4Structure : ITypedRecord<ST_6f88d6be05f2234ba151435ee8bf2cd4Structure> {
internal static readonly GlobalObjectKey IdInvalidCredentials = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*uwyusrhbcEGVeU6UFG96VA");
internal static readonly GlobalObjectKey IdInvalidName = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*Bzhdf4Dy20akXgY7L6GcPg");
internal static readonly GlobalObjectKey IdInvalidPhotoURL = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*XUZxZp8HG02I6HSC0Wx1eA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("InvalidCredentials")]
public bool ssInvalidCredentials;

[System.Xml.Serialization.XmlElement("InvalidName")]
public bool ssInvalidName;

[System.Xml.Serialization.XmlElement("InvalidPhotoURL")]
public bool ssInvalidPhotoURL;


public BitArray OptimizedAttributes;

public ST_6f88d6be05f2234ba151435ee8bf2cd4Structure() {
OptimizedAttributes = null;
ssInvalidCredentials = false;
ssInvalidName = false;
ssInvalidPhotoURL = false;
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
ssInvalidCredentials = r.ReadBoolean(index++, "UpdateUserFailureReason.InvalidCredentials", false);
ssInvalidName = r.ReadBoolean(index++, "UpdateUserFailureReason.InvalidName", false);
ssInvalidPhotoURL = r.ReadBoolean(index++, "UpdateUserFailureReason.InvalidPhotoURL", false);
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
public void ReadIM(ST_6f88d6be05f2234ba151435ee8bf2cd4Structure r) {
this = r;
}


public static bool operator == (ST_6f88d6be05f2234ba151435ee8bf2cd4Structure a, ST_6f88d6be05f2234ba151435ee8bf2cd4Structure b) {
if (a.ssInvalidCredentials != b.ssInvalidCredentials) return false;
if (a.ssInvalidName != b.ssInvalidName) return false;
if (a.ssInvalidPhotoURL != b.ssInvalidPhotoURL) return false;
return true;
}

public static bool operator != (ST_6f88d6be05f2234ba151435ee8bf2cd4Structure a, ST_6f88d6be05f2234ba151435ee8bf2cd4Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_6f88d6be05f2234ba151435ee8bf2cd4Structure)) return false;
return (this == (ST_6f88d6be05f2234ba151435ee8bf2cd4Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvalidCredentials.GetHashCode()
 ^ ssInvalidName.GetHashCode()
 ^ ssInvalidPhotoURL.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_6f88d6be05f2234ba151435ee8bf2cd4Structure Duplicate() {
ST_6f88d6be05f2234ba151435ee8bf2cd4Structure t;
t.ssInvalidCredentials = this.ssInvalidCredentials;
t.ssInvalidName = this.ssInvalidName;
t.ssInvalidPhotoURL = this.ssInvalidPhotoURL;
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
if (head == "invalidcredentials") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvalidCredentials")) variable.Value = ssInvalidCredentials; else variable.Optimized = true;
} else if (head == "invalidname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvalidName")) variable.Value = ssInvalidName; else variable.Optimized = true;
} else if (head == "invalidphotourl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvalidPhotoURL")) variable.Value = ssInvalidPhotoURL; else variable.Optimized = true;
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
if (key == IdInvalidCredentials) {
return ssInvalidCredentials;
}
if (key == IdInvalidName) {
return ssInvalidName;
}
if (key == IdInvalidPhotoURL) {
return ssInvalidPhotoURL;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvalidCredentials.Key.AsGuid) {
return ssInvalidCredentials;
}
if (attributeKey == IdInvalidName.Key.AsGuid) {
return ssInvalidName;
}
if (attributeKey == IdInvalidPhotoURL.Key.AsGuid) {
return ssInvalidPhotoURL;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInvalidCredentials = (bool) other.AttributeGet(IdInvalidCredentials);
ssInvalidName = (bool) other.AttributeGet(IdInvalidName);
ssInvalidPhotoURL = (bool) other.AttributeGet(IdInvalidPhotoURL);
}
} // ST_6f88d6be05f2234ba151435ee8bf2cd4Structure
/// <summary>
/// RecordList type <code>UpdateUserFailureReasonList</code> that represents a record list of
///  <code>UpdateUserFailureReason</code>
/// </summary>
public partial class RL_8b34cec2d3a4e3170e329009c7e2bef8 : GenericRecordList<ST_6f88d6be05f2234ba151435ee8bf2cd4Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_6f88d6be05f2234ba151435ee8bf2cd4Structure GetElementDefaultValue() {
return new ST_6f88d6be05f2234ba151435ee8bf2cd4Structure();
}

public T[] ToArray<T>(Func<ST_6f88d6be05f2234ba151435ee8bf2cd4Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8b34cec2d3a4e3170e329009c7e2bef8 recordList, Func<ST_6f88d6be05f2234ba151435ee8bf2cd4Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8b34cec2d3a4e3170e329009c7e2bef8(ST_6f88d6be05f2234ba151435ee8bf2cd4Structure[] array) {
  RL_8b34cec2d3a4e3170e329009c7e2bef8 result = new RL_8b34cec2d3a4e3170e329009c7e2bef8();
result.InnerFromArray(array);
    return result;
}

public static RL_8b34cec2d3a4e3170e329009c7e2bef8 ToList<T>(T[] array, Func <T, ST_6f88d6be05f2234ba151435ee8bf2cd4Structure> converter) {
  RL_8b34cec2d3a4e3170e329009c7e2bef8 result = new RL_8b34cec2d3a4e3170e329009c7e2bef8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8b34cec2d3a4e3170e329009c7e2bef8 FromRestList<T>(RestList<T> restList, Func <T, ST_6f88d6be05f2234ba151435ee8bf2cd4Structure> converter) {
  RL_8b34cec2d3a4e3170e329009c7e2bef8 result = new RL_8b34cec2d3a4e3170e329009c7e2bef8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8b34cec2d3a4e3170e329009c7e2bef8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_6f88d6be05f2234ba151435ee8bf2cd4Structure> NewList() {
return new RL_8b34cec2d3a4e3170e329009c7e2bef8();
}


} // RL_8b34cec2d3a4e3170e329009c7e2bef8
}

