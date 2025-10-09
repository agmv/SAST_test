namespace ssSystem_ {
/// <summary>
/// [Structure] FinishUserRegistrationResult (8nSXHUk6Z0OZ2lSldnuNyQ)
///  <code>ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure</code> that represent
/// s <code>FinishUserRegistrationResult</code> <p>Description: Result of the finish user registration
///  action. Returns a user identifier if the user was successfully registered. Returns a failure reaso
/// n if unsuccessful.</p>
/// </summary>
// Name: FinishUserRegistrationResult
public partial struct ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure : ITypedRecord<ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure> {
internal static readonly GlobalObjectKey IdSuccess = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*8lHZ61z1tk2QfvsvOgltyw");
internal static readonly GlobalObjectKey IdUserId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*0aD7jP7ZZUaf1wbUVgN+8w");
internal static readonly GlobalObjectKey IdFinishUserRegistrationFailureReason = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*zWOcD4ISl0OW7ZZgdyXD+g");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Success")]
public bool ssSuccess;

[System.Xml.Serialization.XmlElement("UserId")]
public string ssUserId;

[System.Xml.Serialization.XmlElement("FinishUserRegistrationFailureReason")]
public ST_6512d51a2c447fea2b8340c839f73d57Structure ssFinishUserRegistrationFailureReason;


public BitArray OptimizedAttributes;

public ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure() {
OptimizedAttributes = null;
ssSuccess = false;
ssUserId = "";
ssFinishUserRegistrationFailureReason = new ST_6512d51a2c447fea2b8340c839f73d57Structure();
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
    ssFinishUserRegistrationFailureReason.OptimizedAttributes = value[0];
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
ssSuccess = r.ReadBoolean(index++, "FinishUserRegistrationResult.Success", false);
ssUserId = r.ReadEntityReferenceText(index++, "FinishUserRegistrationResult.UserId", "");
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
public void ReadIM(ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure r) {
this = r;
}


public static bool operator == (ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure a, ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure b) {
if (a.ssSuccess != b.ssSuccess) return false;
if (a.ssUserId != b.ssUserId) return false;
if (a.ssFinishUserRegistrationFailureReason != b.ssFinishUserRegistrationFailureReason) return false;
return true;
}

public static bool operator != (ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure a, ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure)) return false;
return (this == (ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSuccess.GetHashCode()
 ^ ssUserId.GetHashCode()
 ^ ssFinishUserRegistrationFailureReason.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssFinishUserRegistrationFailureReason.RecursiveReset();
}

public void InternalRecursiveSave() {
ssFinishUserRegistrationFailureReason.InternalRecursiveSave();
}


public ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure Duplicate() {
ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure t;
t.ssSuccess = this.ssSuccess;
t.ssUserId = this.ssUserId;
t.ssFinishUserRegistrationFailureReason = (ST_6512d51a2c447fea2b8340c839f73d57Structure)this.ssFinishUserRegistrationFailureReason.Duplicate();
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
} else if (head == "userid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserId")) variable.Value = ssUserId; else variable.Optimized = true;
} else if (head == "finishuserregistrationfailurereason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FinishUserRegistrationFailureReason")) variable.Value = ssFinishUserRegistrationFailureReason; else variable.Optimized = true;
variable.SetFieldName("finishuserregistrationfailurereason");
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
if (key == IdUserId) {
return ssUserId;
}
if (key == IdFinishUserRegistrationFailureReason) {
return ssFinishUserRegistrationFailureReason;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSuccess.Key.AsGuid) {
return ssSuccess;
}
if (attributeKey == IdUserId.Key.AsGuid) {
return ssUserId;
}
if (attributeKey == IdFinishUserRegistrationFailureReason.Key.AsGuid) {
return ssFinishUserRegistrationFailureReason;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSuccess = (bool) other.AttributeGet(IdSuccess);
ssUserId = (string) other.AttributeGet(IdUserId);
ssFinishUserRegistrationFailureReason.FillFromOther((IRecord) other.AttributeGet(IdFinishUserRegistrationFailureReason));
}
} // ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure
/// <summary>
/// RecordList type <code>FinishUserRegistrationResultList</code> that represents a record list of
///  <code>FinishUserRegistrationResult</code>
/// </summary>
public partial class RL_9eba70ecf7dd38d3ed1fcfec91b187a8 : GenericRecordList<ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure GetElementDefaultValue() {
return new ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure();
}

public T[] ToArray<T>(Func<ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9eba70ecf7dd38d3ed1fcfec91b187a8 recordList, Func<ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9eba70ecf7dd38d3ed1fcfec91b187a8(ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure[] array) {
  RL_9eba70ecf7dd38d3ed1fcfec91b187a8 result = new RL_9eba70ecf7dd38d3ed1fcfec91b187a8();
result.InnerFromArray(array);
    return result;
}

public static RL_9eba70ecf7dd38d3ed1fcfec91b187a8 ToList<T>(T[] array, Func <T, ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure> converter) {
  RL_9eba70ecf7dd38d3ed1fcfec91b187a8 result = new RL_9eba70ecf7dd38d3ed1fcfec91b187a8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9eba70ecf7dd38d3ed1fcfec91b187a8 FromRestList<T>(RestList<T> restList, Func <T, ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure> converter) {
  RL_9eba70ecf7dd38d3ed1fcfec91b187a8 result = new RL_9eba70ecf7dd38d3ed1fcfec91b187a8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9eba70ecf7dd38d3ed1fcfec91b187a8() : base() {
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
protected override OSList<ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure> NewList() {
return new RL_9eba70ecf7dd38d3ed1fcfec91b187a8();
}


} // RL_9eba70ecf7dd38d3ed1fcfec91b187a8
}

